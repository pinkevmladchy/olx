using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OLX_Course.Models
{
    public class TovarViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public string Description { get; set; }
        public string City_Name { get; set; }
        public string Category_name { get; set; }
        public string User_name { get; set; }
        public string Image { get; set; }
    }
}