using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OLX_Course.Entities
{
    [Table("Tovar_Images")]

    public class Tovar_Image
    {
        [Key]
        public int Id { get; set; }
        [StringLength(500)]
        [Required]
        public string Image { get; set; }
        [ForeignKey("Tovar")]
        public int TovarId { get; set; }
        public Tovar Tovar { get; set; }
    }
}