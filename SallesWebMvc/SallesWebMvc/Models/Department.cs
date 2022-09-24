using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SallesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSalles(DateTime initial, DateTime final)
        {
            return Sellers.Select(seller => seller.TotalSales(initial, final)).Sum(sellerTotal => sellerTotal);
        }
    }
}
