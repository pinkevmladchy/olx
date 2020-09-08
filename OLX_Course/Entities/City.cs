using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OLX_Course.Entities
{
    [Table("Cities")]
    public class City
    {
        [Key]
        public int Id { get; set; }
        [StringLength(500)]
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Tovar> Tovars { get; set; }
    }
}