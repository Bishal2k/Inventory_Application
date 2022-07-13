
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
    public class ProfileController : BaseController
    {
        readonly ProfileRepositoryInterface _profileRepo;
        readonly ProfileServiceInterface _profileService;
        readonly AccountServiceInterface _accountService;
        readonly ProductRepositoryInterface _prodcutRepo;
        readonly BillServiceInterface _billService;
        readonly BillRepositoryInterface _billRepo;

        public ProfileController(ProfileRepositoryInterface profileRepo, ProfileServiceInterface profileService, AccountServiceInterface accountService, 
            ProductRepositoryInterface prodcutRepo, BillServiceInterface billService, BillRepositoryInterface billRepo)
        {
            _profileRepo = profileRepo;
            _profileService = profileService;
            _accountService = accountService;
            _prodcutRepo = prodcutRepo;
            _billService = billService;
            _billRepo = billRepo;
        }
        public async Task<IActionResult> Index(ProfileIndexViewModel model)
        {
            model.Profiles = await _profileRepo.GetAllAsync();
            return View(model);
        }
        public   IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ProfileCreateViewModel model)
        {
            try 
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var dto = new ProfileCreateDto(model.Name,model.Contact,model.Address,model.CompanyName);
                await _profileService.CreateAsync(dto);
                await _accountService.CreateAccountAsync();
                Notify("Proifile Created Successfully", title: "Success");
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                Notify(ex.Message, notificationType: NotificationType.error);
                return View(model);
            }

        }
        public async Task<IActionResult> Edit(long id)
        {
            try
            {
                var profile = await _profileRepo.GetByIdAsync(id);
                var model = new ProfileUpdateViewModel();
                model.Id = profile.Id;
                model.Name = profile.Name;
                model.Contact = profile.Contact;
                model.Address = profile.Address;
                model.CompanyName = profile.CompanyName;
                return View(model);
            }
            catch (Exception ex)
            {

                Notify(ex.Message, notificationType: NotificationType.error);
                return RedirectToAction(nameof(Index));
            }
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ProfileUpdateViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var dto = new ProfileUpdateDto(model.Id,model.Name, model.Contact, model.Address, model.CompanyName);
                await _profileService.UpdateAsync(dto);
                Notify("Profile Updated Successfully", title: "Success");
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                Notify(ex.Message, notificationType: NotificationType.error);
                return View(model);
            }

        }
        public async Task<IActionResult> Sale(long id, BillCreateViewModel model)
        {
            try
            {
                model.ProductList = await _prodcutRepo.GetAllAsync();
                model.ProfileId = id;
                model.Profile = await _profileRepo.GetByIdAsync(id);
                return View(model);
            }
            catch (Exception ex)
            {
                Notify(ex.Message, notificationType: NotificationType.error);
                return RedirectToAction(nameof(Index));
            }
        }
        [HttpPost]
        public async Task<JsonResult> Sale( BillCreateViewModel model)
        {
            try
            {

                var billInsertDto = new BillInsertDto();
                var profile = await _profileRepo.GetByIdAsync(model.ProfileId);
                billInsertDto.Profile = profile;
                billInsertDto.BillDate = model.BillDate;
                billInsertDto.BillItems = model.BillItems;
                await _billService.InsertAsync(billInsertDto);
                return Json(true);
            }
            catch (Exception ex)
            {
                Notify(ex.Message, notificationType: NotificationType.error);
                return Json(false);
            }
        }
        [HttpGet]
        public async Task<IActionResult> MakeBill(BillGenerateViewModel model)
        {
            try
            {
                var bill = await _billRepo.GetLatestBillAsync();
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
