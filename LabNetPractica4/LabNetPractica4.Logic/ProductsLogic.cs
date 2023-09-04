using System;
using LabNetPractica4.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica4.Logic
{
    public class ProductsLogic : BaseLogic
    {

        public List<Product> Punto2()
        {
            return context.Products.Where(product => product.UnitsInStock == 0).ToList();
        }
        public List<Product> Punto3()
        {
            var productos = from product in context.Products
                            where product.UnitsInStock > 0 && product.UnitPrice > 3
                            select product;
            return productos.ToList();
        }
        public Product Punto5()
        {
            return context.Products.Where(product => product.ProductID == 56).FirstOrDefault();
        }

    }
}
