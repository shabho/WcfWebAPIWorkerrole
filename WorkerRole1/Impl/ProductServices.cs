using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkerRole1.Contract;

namespace WorkerRole1.Impl
{
    class ProductServices : IproductsService
    {
        public ProductData[] Getall()
        {
            return new[] { new ProductData {Name = "Item 1" , SKU = "1234"} };
        }
    }
}
