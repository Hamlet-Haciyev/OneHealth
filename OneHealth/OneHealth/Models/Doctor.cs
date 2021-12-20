using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OneHealth.Models
{
    public class Doctor
    {
        [Key]
        public int Id { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(30)]
        public string Phone { get; set; }
        [MaxLength(50)]
        public string Whatsapp { get; set; }
        public DateTime CreatedDate { get; set; }
        [ForeignKey("HealthCategory")]
        public int HealthCategoryId { get; set; }
        public HealthCategory HealthCategory { get; set; }

    }
}
