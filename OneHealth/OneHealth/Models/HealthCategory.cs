using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OneHealth.Models
{
    public class HealthCategory
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(80)]
        public string Name { get; set; }

        public List<Doctor> Doctors { get; set; }
        public List<Appointment> Appointments { get; set; }

    }
}
