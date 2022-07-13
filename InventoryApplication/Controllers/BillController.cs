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
    public class BillController : BaseController
    {
        readonly BillRepositoryInterface _billRepo;
        readonly ProfileRepositoryInterface _profileRepo;
        readonly BillServiceInterface _billService;
        readonly ProductRepositoryInterface _productRepo;
        public BillController(BillRepositoryInterface billRepo, ProfileRepositoryInterface profileRepo, BillServiceInterface billService,
            ProductRepositoryInterface productRepo)
        {
            _billRepo = billRepo;
            _profileRepo = profileRepo;
            _billService = billService;
            _productRepo = productRepo;
        }
        public async Task<IActionResult> Index(BillIndexViewModel model)
        {
            
            model.Bills = await _billRepo.GetAllAsync();
            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(long id,BillCreateViewModel model)
        {
            try
            {
                var bill = await _billRepo.GetById(id);
                model.BillDate = bill.BillDate;
                model.Profile = bill.Profile;
                model.ProfileId = bill.Profile.Id;
                model.BillId = bill.Id;
                return View(model);
            }
            catch (Exception ex)
            {

                Notify(ex.Message, notificationType: NotificationType.error);
                return RedirectToAction(nameof(Index));
            }
        }
        [HttpPost]
        public async Task<IActionResult> Edit(BillCreateViewModel model)
        {

            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var profile = await _profileRepo.GetByIdAsync(model.ProfileId);
                var dto = new BillUpdateDto();
                dto.BillDate = model.BillDate;
                dto.Profile = profile;
                dto.ProfileId = profile.Id;
                dto.Id = model.BillId;
                await _billService.UpdateBillOnlyAsync(dto);
                Notify("Update Successfull", title: "Success");
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {

                Notify(ex.Message, notificationType: NotificationType.error);
                return RedirectToAction(nameof(Index));
            }
        }
        [HttpGet]
        public async Task<IActionResult> Details(long id, BillCreateViewModel model)
        {
            try
            {
                var bill = await _billRepo.GetById(id);
                model.BillItems = bill.BillItems;
                return View(model);
            }
            catch (Exception ex)
            {
                Notify(ex.Message, notificationType: NotificationType.error);
                return RedirectToAction(nameof(Index));
            }
        }
        
        public async Task<IActionResult> EditBillDetails(long billItemId, long billId, BillCreateViewModel model)
        {
            try
            {
                var bill = await _billRepo.GetById(billId);
                model.BillId = bill.Id;
                model.BillItemId = billItemId;
                var billItem = bill.BillItems.AsQueryable().Where(x => x.Id == billItemId).SingleOrDefault();
                model.ProductId = billItem.ProductId;
                model.Quantity = billItem.Quantity;
                model.Rate = billItem.Rate;
                return View(model);
            }
            catch (Exception ex)
            {

                Notify(ex.Message, notificationType: NotificationType.error);
                return RedirectToAction(nameof(Index));
            }
        }
        [HttpPost]
        public async Task<IActionResult> EditBillDetails(BillCreateViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var bill = await _billRepo.GetById(model.BillId);
                var product = await _productRepo.GetByIdAsync(model.ProductId);
                var dto = new BillItemUpdateDto();
                dto.Bill = bill;
                dto.BillItemId = model.BillItemId;
                dto.Product = product;
                dto.Quantity = model.Quantity;
                dto.Rate = model.Rate;
                await _billService.UpdateBillItems(dto);
                Notify("Update Successfull", title: "Success");
                return RedirectToAction(nameof(Details),new { bill.Id });
            }
            catch (Exception ex)
            {

                Notify(ex.Message, notificationType: NotificationType.error);
                return RedirectToAction(nameof(Index));
            }
        }
        [HttpGet]
        public async Task<IActionResult> Print(long id,BillGenerateViewModel model)
        {
            try
            {
                var bill = await _billRepo.GetById(id);
                model.BillDate = bill.BillDate;
                model.BillItems = bill.BillItems;
                model.BillNo = bill.Id;
                model.ProfileId = bill.ProfileId;
                model.ProfileName = bill.Profile.Name;
                return View("~/Views/Account/MakeBill.cshtml", model);
            }
            catch (Exception ex)
            {

                Notify(ex.Message, notificationType: NotificationType.error);
                return RedirectToAction(nameof(Index));
            }
        }

    }
}
