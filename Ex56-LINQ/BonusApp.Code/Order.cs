using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp
{
    public class Order
    {
        private List<Product> _products = new List<Product>();

        public BonusProvider Bonus { get; set; }

        public void AddProduct(Product p)
        {
            _products.Add(p);
        }
        public double GetValueOfProducts()
        {
            //double valueOfProducts = 0.0;

            //foreach (Product p in _products)
            //{
            //    valueOfProducts += p.Value;
            //}
            double valueOfProducts = _products.Sum(p => p.Value);
            return valueOfProducts;
        }
        public double GetValueOfProducts(DateTime date)
        {
            //using .Where
            //double valueOfProducts = _products.Where(p=>p.AvailableFrom <= date && p.AvailableTo >= date).Sum(p => p.Value);

            //Ternary operator
            double valueOfProducts = _products.Sum(p=>p.AvailableFrom <= date && p.AvailableTo >= date ? p.Value : 0.0 );
            return valueOfProducts;
        }
        public double GetBonus()
        {
            return Bonus(GetValueOfProducts());
        }
        public double GetTotalPrice()
        {
            return GetValueOfProducts()-GetBonus();
        }

        public List<Product> SortProductOrderByAvailableTo()
        {
            return _products.OrderBy(p=>p.AvailableTo).ToList();
        }
    }
}
