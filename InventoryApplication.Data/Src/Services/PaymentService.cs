using Crystal.Sms.Core.Helper;
using InventoryApplication.Dto;
using InventoryApplication.Exceptions;
using InventoryApplication.Models.Entity;
using InventoryApplication.Repository.RepositoryInterface;
using InventoryApplication.Services.ServicesInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;

namespace InventoryApplication.Services
{
    public class PaymentService : PaymentServiceInterface
    {
        readonly PaymentRepositoryInterface _paymentRepo;
        readonly AccountRepositoryInterface _accountRepo;
        public PaymentService(PaymentRepositoryInterface paymentRepo, AccountRepositoryInterface accountRepo)
        {
            _paymentRepo = paymentRepo;
            _accountRepo = accountRepo;
        }
        public async Task InsertAsync(PaymentInsertDto dto)
        {
            using TransactionScope scope = TransactionScopeHelper.GetInstance();
            var payment = new Payment(dto.Account,dto.Amount,dto.PaymentDescription,dto.PaymentDate,dto.IsPaymentReceived);
            await _paymentRepo.InsertAsync(payment);
            await DeductAmountWhileInsert(dto.IsPaymentReceived, dto.Amount, dto.Account);
            scope.Complete();
        }

        public async Task UpdateAsync(PaymentUpdateDto dto)
        {
            using TransactionScope scope = TransactionScopeHelper.GetInstance();
            var payment = await _paymentRepo.GetPaymentByIdAsync(dto.Id);
            var previouslyAddedAmount = payment.Amount;
            payment.Update(dto.Account, dto.Amount, dto.PaymentDescription, dto.PaymentDate, dto.IsPaymentReceived);
            await _paymentRepo.UpdateAsync(payment);
            await DeductAmountWhileUpdate(dto.IsPaymentReceived, dto.Amount, dto.Account, previouslyAddedAmount);
            scope.Complete();
        }
        public async Task DeductAmountWhileInsert(bool ispaymentReceived, decimal amount,Account account)
        {
            if (ispaymentReceived)
            {
                account.DeductReceiveable(amount);
                await _accountRepo.UpdateAsync(account);
                return;
            }
            account.DeductPayable(amount);
            await _accountRepo.UpdateAsync(account);
        }
        public async Task DeductAmountWhileUpdate(bool ispaymentReceived, decimal amount, Account account,decimal previouslyAddedAmount)
        {
            bool needToBeSubtracted = true;
            decimal amountToBeUpdated = 0;
            if (previouslyAddedAmount > amount)
            {
                needToBeSubtracted = false;
                amountToBeUpdated = previouslyAddedAmount - amount;
            }
            if (ispaymentReceived)
            {
                if (needToBeSubtracted)
                {
                    amountToBeUpdated = amount - previouslyAddedAmount;
                    account.AmountReceiveable -= amountToBeUpdated;
                    bool isPositive = account.AmountReceiveable >= 0;
                    if (!isPositive)
                    {
                        throw new InconsistentAmountException("रकम वास्तविक रकम तिर्नु भन्दा धेरै छ।");
                    }
                    await _accountRepo.UpdateAsync(account);
                    return;
                }               
                account.AmountReceiveable += amountToBeUpdated;
                await _accountRepo.UpdateAsync(account);
                return;
            }
            if (needToBeSubtracted)
            {
                amountToBeUpdated = amount - previouslyAddedAmount;
                account.AmountPayable -= amountToBeUpdated;
                bool isPositive = account.AmountReceiveable > 0;
                if (!isPositive)
                {
                    throw new InconsistentAmountException("रकम वास्तविक रकम तिर्नु भन्दा धेरै छ।");
                }
                await _accountRepo.UpdateAsync(account);
                return;
            }           
            account.AmountPayable += amountToBeUpdated;
            await _accountRepo.UpdateAsync(account);
        }
    }
}
