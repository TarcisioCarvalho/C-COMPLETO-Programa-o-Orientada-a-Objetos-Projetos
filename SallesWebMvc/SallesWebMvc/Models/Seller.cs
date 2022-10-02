﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;


namespace SallesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="{0} Required")]
        [StringLength(60,MinimumLength = 3,ErrorMessage ="{0} size should be between {2} and {1}")]
        public string Name { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "{0} Required")]
        [EmailAddress(ErrorMessage = "Enter a valid email")]
        public string Email { get; set; }
        [Display(Name ="Birth Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        [Required(ErrorMessage = "{0} Required")]
        public DateTime BirthDate { get; set; }
        [Display(Name ="Base Salary")]
        [DisplayFormat(DataFormatString ="{0:F2}")]
        [Required(ErrorMessage = "{0} Required")]
        [Range(100.0, 50000.0, ErrorMessage = "{0} must be from {1} to {2}")]
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public int DepartmentId { get; set; }
        public List<SalesRecord> SalesRecords { get; set; } = new List<SalesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord salesRecord)
        {
            SalesRecords.Add(salesRecord);
        }

        public void RemoveSales(SalesRecord salesRecord)
        {
            SalesRecords.Remove(salesRecord);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            var salesInInterval = SalesRecords.Where(sale => sale.Date >= initial && sale.Date <= final);
            var total = salesInInterval.Select(sale => sale.Amount).Sum(salePrice => salePrice);
            return total;
        }
    }
}
