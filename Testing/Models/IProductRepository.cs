using System;
using System.Collections.Generic;
using Testing.Models;
using System.Data;
using Dapper;

namespace Testing.Models
{
	public interface IProductRepository 
	{
		public IEnumerable<Product> GetAllProducts();
        public Product GetProduct(int id);
        





    }
}

