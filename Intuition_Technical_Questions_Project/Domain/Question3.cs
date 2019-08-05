using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Intuition.Technical.Questions.Question3
{
    public interface ICartTotal
    {
        decimal Calculate(IEnumerable<Product> products, ILocalizationInfo localInfo);
        decimal Calculate();
    }

    public interface ILocalizationInfo
    {
        string Country { get; set; }
        decimal TaxRate { get; set; }
    }

    public class Product
    {
        public Guid Id { get; set; }
        public decimal Price { get; set; }
    }

    public class CartTotal : ICartTotal
    {
        public readonly IEnumerable<Product> products;
        public readonly ILocalizationInfo localInfo;

        public CartTotal(IEnumerable<Product> products, ILocalizationInfo localInfo)
        {
            this.products = products;
            this.localInfo = localInfo;
        }


        decimal ICartTotal.Calculate(IEnumerable<Product> products, ILocalizationInfo localInfo)
        {
            decimal total = 0.0M;
            //add total of products 
            foreach (var product in products)
            {
                total += product.Price;
            }

            decimal taxRate = 0.0M;
            switch (localInfo.Country)
            {
                case "us":
                    taxRate = 0.05M;
                    break;
                case "ca":
                    taxRate = 0.15M;
                    break;
            }

            total += (total * taxRate);
            return total;
        }

        decimal ICartTotal.Calculate()
        {
           return products.Select(x => x.Price).Sum() * localInfo.TaxRate;
        }
    }
}
