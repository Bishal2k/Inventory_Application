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
    public class AccountController : BaseController
    {
        readonly AccountRepositoryInterface _accountRepo;
        readonly AccountServiceInterface _accountService;
        readonly PaymentServiceInterface _paymentService;
        readonly BillRepositoryInterface _billRepo;
        public AccountController(AccountRepositoryInterface accountRepo, AccountServiceInterface accountService, PaymentServiceInterface paymentService,
            BillRepositoryInterface billRepo)
        {
            _accountRepo = accountRepo;
            _accountService = accountService;
            _paymentService = paymentService;
            _billRepo = billRepo;
        }
        public async Task<IActionResult> Index(AccountIndexViewModel model)
        {
            model.Accounts = await _accountRepo.GetAllAsync();
            return View(model);
        }
        [HttpGet]
        public IActionResult MakePayment(long id, PaymentCreateViewModel model)
        {
            model.AccountId = id;
            return View("~/Views/Payment/Create.cshtml", model);
        }
        [HttpPost]
        public async Task<IActionResult> MakePayment(PaymentCreateViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View("~/Views/Payment/Create.cshtml", model);
                }
                var account = await _accountRepo.GetByIdAsync(model.AccountId);
                if (model.PaymentType == "Paid")
                {
                    var dto = new PaymentInsertDto(account, model.Amount, model.PaymentDescription, model.PaymentDate, "PaymentTypePayed");
                    await _paymentService.InsertAsync(dto);
                    return RedirectToAction(nameof(Index));
                }
                var dto2 = new PaymentInsertDto(account, model.Amount, model.PaymentDescription, model.PaymentDate, "PaymentTypeReceived");
                await _paymentService.InsertAsync(dto2);
                Notify("Transaction Successfull", title: "Success");
                return RedirectToAction(nameof(Index));

            }
            catch (Exception ex)
            {
                Notify(ex.Message, notificationType: NotificationType.error);
                return View("~/Views/Payment/Create.cshtml", model);
            }
        }
        
    }
}
