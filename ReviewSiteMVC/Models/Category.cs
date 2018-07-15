using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ReviewSiteMVC.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        public string Destination { get; set; }
        public string Accommodations { get; set; }
        public string Transportation { get; set; }
        public string Activities { get; set; }

        public virtual ICollection<Review> Reviews { get; set; }
    }
}