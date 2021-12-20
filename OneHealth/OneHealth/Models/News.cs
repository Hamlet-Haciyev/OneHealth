using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace OneHealth.Models
{
    public class News
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(250)]
        public string Image { get; set; }
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [MaxLength(150)]

        public string Title { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<TagToNews> TagToNewss { get; set; }
        [ForeignKey("NewsCategory")]
        public int NewsCategoryId { get; set; }
        public NewsCategory NewsCategory { get; set; }
        [ForeignKey("Creator")]
        public int CreatorId { get; set; }
        public Creator Creator { get; set; }


    }
}
