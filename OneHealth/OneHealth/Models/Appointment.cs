using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OneHealth.Models
{
    public class Appointment
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(80)]
        public string FullName { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        
        [MaxLength(30)]
        public string Phone { get; set; }
        [MaxLength(2000)]
        public string Message { get; set; }
        public DateTime CreatedDate { get; set; }
        [ForeignKey("HealthCategory")]
        public int HealthCategoryId { get; set; }
        public HealthCategory HealthCategory { get; set; }
    }
}
