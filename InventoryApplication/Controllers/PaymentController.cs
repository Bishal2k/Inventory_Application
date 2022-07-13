using InventoryApplication.Dto;
using InventoryApplication.Repository.RepositoryInterface;
using InventoryApplication.Services.ServicesInterface;
using InventoryApplication.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Controllers
{
    [Authorize]
    public class PaymentController : BaseController
    {
        readonly AccountRepositoryInterface _accountRepo;
        readonly PaymentServiceInterface _paymentService;
        readonly PaymentRepositoryInterface _paymentRepo;
        public PaymentController(AccountRepositoryInterface accountRepo, PaymentServiceInterface paymentService, PaymentRepositoryInterface paymentRepo)
        {
            _accountRepo = accountRepo;
            _paymentService = paymentService;
            _paymentRepo = paymentRepo;
        }
        public async Task<IActionResult> Index(PaymentIndexViewModel model)
        {
            model.Payments = await _paymentRepo.GetAllPaymentsAsync();
            return View(model);
        }
        public async Task<IActionResult> Edit(long id)
        {
            try
            {
                var payment = await _paymentRepo.GetPaymentByIdAsync(id);
                var model = new PaymentCreateViewModel();
                model.AccountId = payment.AccountId;
                model.Amount = payment.Amount;
                model.Id = payment.Id;
                model.PaymentDate = payment.PaymentDate;
                model.PaymentDescription = payment.PaymentDescription;
                model.PaymentType = payment.PaymentType;
                return View(model);
            }
            catch (Exception ex)
            {
                Notify(ex.Message, notificationType: NotificationType.error);
                return RedirectToAction(nameof(Index));
            }
            
        }
        [HttpPost]
        public async Task<IActionResult> Edit(PaymentCreateViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var account = await _accountRepo.GetByIdAsync(model.AccountId);
                var dto = new PaymentUpdateDto(model.Id, account, model.Amount, model.PaymentDescription, model.PaymentDate, model.PaymentType);
                await _paymentService.UpdateAsync(dto);
                Notify("Update Successfull", title: "Success");
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                Notify(ex.Message, notificationType: NotificationType.error);
                return View(model);
            }
        }
        
    }
}
