using OLX_Course.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OLX_Course.Entities
{
    [Table("Tovars")]
    public class Tovar
    {
        [Key]
        public int Id { get; set; }
        [StringLength(500)]
        [Required]
        public string Name { get; set; }
        public int Cost { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [ForeignKey("City")]
        public int CityId { get; set; }
        public City City { get; set; }
        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [ForeignKey("ApplicationUser")]
        public string UserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}