using InventoryApplication.Controllers;
using InventoryApplication.Dto;
using InventoryApplication.Repository.RepositoryInterface;
using InventoryApplication.Services.ServicesInterface;
using InventoryApplication.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryApplication.Controllers
{
    [Authorize]
    public class ProductController :BaseController
    {
        readonly ProductServiceInterface _productService;
        readonly ProductRepositoryInterface _productRepo;
        readonly ProfileRepositoryInterface _profileRepo;
        readonly ProductEntryServiceInterface _productEntryService;
        public ProductController(ProductServiceInterface productService, ProductRepositoryInterface productRepo, ProfileRepositoryInterface profileRepo, ProductEntryServiceInterface productEntryService)
        {
            _productService = productService;
            _productRepo = productRepo;
            _profileRepo = profileRepo;
            _productEntryService = productEntryService;
        }
        public async Task<IActionResult> Index(ProductIndexViewModel model)
        {
            model.Products = await _productRepo.GetAllAsync();
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ProductCreateViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var dto = new ProductDto(model.Name,model.Weight);
                await _productService.CreateAsync(dto);
                Notify("Item Created Successfully", title: "Success");
                return View();

            }
            catch (Exception ex)
            {
                Notify(ex.Message, notificationType: NotificationType.error);
                return RedirectToAction(nameof(Index));
            }


        }
        public async Task<IActionResult> Edit(long id)
        {
            var product = await _productRepo.GetByIdAsync(id);
            var model = new ProductUpdateViewModel();
            model.Id = product.Id;
            model.Name = product.Name;
            model.Weight = product.Weight;
            model.Quantity = product.Quantity;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(ProductUpdateViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(model);
                }
                var dto = new ProductUpdateDto(model.Id,model.Quantity,model.Name,model.Weight);
                await _productService.UpdateAsync(dto);
                Notify("Product Updated Successfully", title: "Success");
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                Notify(ex.Message, notificationType: NotificationType.error);
                return View(model);
            }
            
        }

        [HttpGet]
        public async Task<IActionResult> Add(long id , ProductEntryCreateViewModel model)
        {
            model.Profiles = await _profileRepo.GetAllAsync();
            model.ProductId = id;
            return View("~/Views/ProductEntry/Create.cshtml",model);
        }
        [HttpPost]
        public async Task<IActionResult> Add(ProductEntryCreateViewModel model)
        {
            try 
            {
                if (!ModelState.IsValid)
                {
                    return View("~/Views/ProductEntry/Create.cshtml", model);
                }
                
                var product = await _productRepo.GetByIdAsync(model.ProductId);
                var profile = await _profileRepo.GetByIdAsync(model.ProfileId);
                var dto = new ProductEntryInsertDto(product,profile,model.Quantity,model.Rate,model.BillNo,model.VechileNo,model.EntryDate);
                await _productEntryService.InsertAsync(dto);
                Notify("Product Added Successfully", title: "Success");
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                Notify(ex.Message, notificationType: NotificationType.error);
                return View("~/Views/ProductEntry/Create.cshtml", model);
            }


        }
    }
}
