
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
    public class ProductEntryController : BaseController
    {
        readonly ProductEntryServiceInterface _productEntryService;
        readonly ProductEntryRepositoryInterface _productEntryRepo;
        readonly ProfileRepositoryInterface _profileRepo;
        readonly ProductRepositoryInterface _productRepo;
        public ProductEntryController(ProductEntryServiceInterface productEntryService, ProductEntryRepositoryInterface productEntryRepo, ProfileRepositoryInterface profileRepo, ProductRepositoryInterface productRepo)
        {
            _productEntryRepo = productEntryRepo;
            _productEntryService = productEntryService;
            _profileRepo = profileRepo;
            _productRepo = productRepo;
        }
        public async Task<IActionResult> Index(ProductEntryIndexViewModel model)
        {
            model.ProductEntryDatas = await _productEntryRepo.GetAllAsync();
            return View(model);
        }

        public async Task<IActionResult> Edit(long id, ProductEntryUpdateViewModel model)
        {

            try
            {
                var productEntryData = await _productEntryRepo.GetByIdAsync(id);
                model.Id = productEntryData.Id;
                model.Profiles = await _profileRepo.GetAllAsync();
                model.ProductId = productEntryData.ProductId;
                model.ProfileId = productEntryData.ProfileId;
                model.Quantity = productEntryData.Quantity;
                model.Rate = productEntryData.Rate;
                model.BillNo = productEntryData.BillNo;
                model.VechileNo = productEntryData.VechileNo;
                model.EntryDate = productEntryData.EntryDate.ToString();
                return View(model);
            }
            catch (Exception ex)
            {

                Notify(ex.Message, notificationType: NotificationType.error);
                return RedirectToAction(nameof(Index));
            }

        }
        [HttpPost]
        public async Task<IActionResult> Edit(ProductEntryUpdateViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                
                var product = await _productRepo.GetByIdAsync(model.ProductId);
                var profile = await _profileRepo.GetByIdAsync(model.ProfileId);
                var dto = new ProductEntryUpdateDto(model.Id, product, profile, model.Quantity, model.Rate, model.BillNo, model.VechileNo, model.EntryDate);
                await _productEntryService.UpdateAsync(dto);
                Notify("Item Updated Successfully", title: "Success");
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
