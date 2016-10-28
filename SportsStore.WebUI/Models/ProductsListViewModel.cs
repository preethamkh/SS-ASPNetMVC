using System.Collections.Generic;
using SportsStore.Domain.Entities;

namespace SportsStore.WebUI.Models
{
    // class to wrap all of the data to be sent from the controller to the view in a SINGLE VIEWMODEL class (this one)
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }

        // product list category information
        public string CurrentCategory { get; set; }
    }
}