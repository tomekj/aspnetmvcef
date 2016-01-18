using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SystemEwidencjonowaniaAR.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [MaxLength(100)]
        public string Nazwa { get; set; }

        public virtual ICollection<Item> Item { get; set; }
    }
}