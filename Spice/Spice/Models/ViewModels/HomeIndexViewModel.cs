using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Spice.Models.ViewModels
{
    public class HomeIndexViewModel
    {
        public IEnumerable<MenuItem> MenuItemsList { get; set; }
        public IEnumerable<Category> CategoryList { get; set; }
        public IEnumerable<Coupon> CouponList { get; set; }
    }
}
