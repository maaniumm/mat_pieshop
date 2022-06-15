using System;
using System.Collections.Generic;
using PieShop.Models;

namespace PieShop.ViewModels
{
    public class PieListViewModel // To pass data between controller and view
    {
        public IEnumerable<Pie> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
