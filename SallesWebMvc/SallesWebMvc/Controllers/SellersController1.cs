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

        public IActionResult Index()
        {
            var list = _sellerService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var departments = _departmentService.FindAll();
            SellerFormViewModel sellerFormViewModel = new SellerFormViewModel { Departments = departments };
            return View(sellerFormViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult CreateSeller(Seller seller)
        {
            _sellerService.Insert(seller);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Error), "Id not provided!");


            var obj = _sellerService.FindById(id.Value);
            if (obj == null) return RedirectToAction(nameof(Error), "Id not found!");

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _sellerService.Remove(id);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Details(int? id)
        {
            if(id == null) return RedirectToAction(nameof(Error),"Id not provided!");


            var obj = _sellerService.FindById(id.Value);
            if (obj == null) return RedirectToAction(nameof(Error), "Id not found!");

            return View(obj);
        }
        public IActionResult Edit(int? id)
        {
            if (id == null) return RedirectToAction(nameof(Error), "Id not provided!");

            var obj = _sellerService.FindById(id.Value);
            if (obj == null) return RedirectToAction(nameof(Error), "Id not found!");

            List<Department> departments = _departmentService.FindAll();
            SellerFormViewModel sellerFormViewModel = new SellerFormViewModel { Seller = obj, Departments = departments };

            return View(sellerFormViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Seller seller)
        {
            if (id != seller.Id) return BadRequest();
            try
            {
                _sellerService.Update(seller);
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
