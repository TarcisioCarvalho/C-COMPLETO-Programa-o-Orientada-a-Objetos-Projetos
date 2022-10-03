using Microsoft.AspNetCore.Mvc;
using SallesWebMvc.Models;
using SallesWebMvc.Models.ViewModels;
using SallesWebMvc.Services;
using SallesWebMvc.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SallesWebMvc.Controllers
{
    public class SellersController : Controller
    {

        private readonly SellerService _sellerService;
        private readonly DepartmentService _departmentService;

        public SellersController(SellerService sellerService, DepartmentService departmentService)
        {
            _sellerService = sellerService;
            _departmentService = departmentService;
        }

        public async Task<IActionResult> Index()
        {
            var list = await _sellerService.FindAllAsync();
            return View(list);
        }

        public async Task<IActionResult> Create()
        {
            var departments = await _departmentService.FindAllAsync();
            SellerFormViewModel sellerFormViewModel = new SellerFormViewModel { Departments = departments };
            return View(sellerFormViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateSeller(Seller seller)
        {
            if (!ModelState.IsValid)
            {
                var departments = await _departmentService.FindAllAsync();
                SellerFormViewModel sellerFormViewModel = new SellerFormViewModel { Seller = seller, Departments = departments };
                return View(sellerFormViewModel);
            }

            await _sellerService.InsertAsync(seller);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Error), "Id not provided!");


            var obj = await _sellerService.FindByIdAsync(id.Value);
            if (obj == null) return RedirectToAction(nameof(Error), "Id not found!");

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _sellerService.RemoveAsync(id);
                return RedirectToAction(nameof(Index));
            }
            catch (IntegrityException e)
            {

                return RedirectToAction(nameof(Error), e.Message);
            }
        }
        public async Task<IActionResult> Details(int? id)
        {
            if(id == null) return RedirectToAction(nameof(Error),"Id not provided!");


            var obj = await _sellerService.FindByIdAsync(id.Value);
            if (obj == null) return RedirectToAction(nameof(Error), "Id not found!");

            return View(obj);
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Error), "Id not provided!");

            var obj = await _sellerService.FindByIdAsync(id.Value);
            if (obj == null) return RedirectToAction(nameof(Error), "Id not found!");

            List<Department> departments = await _departmentService.FindAllAsync();
            SellerFormViewModel sellerFormViewModel = new SellerFormViewModel { Seller = obj, Departments = departments };

            return View(sellerFormViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Seller seller)
        {

            if (!ModelState.IsValid)
            {
                var departments = await _departmentService.FindAllAsync();
                SellerFormViewModel sellerFormViewModel = new SellerFormViewModel { Seller = seller, Departments = departments };
                return View(sellerFormViewModel);
            }

            if (id != seller.Id) return BadRequest();
            try
            {
                await _sellerService.UpdateAsync(seller);
                return RedirectToAction(nameof(Error), "Id mismatch");
            }
            catch (NotFoundException e)
            {
                return RedirectToAction(nameof(Error), e.Message);
            }
            catch (DbConcurrencyException e)
            {
                return RedirectToAction(nameof(Error), e.Message);
            }
        }

        public IActionResult Error(string message)
        {
            var viewModel = new ErrorViewModel
            {
                Message = message,
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            };
            return View(viewModel);
        }
    }
}
