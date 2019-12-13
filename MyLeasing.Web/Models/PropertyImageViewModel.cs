using Microsoft.AspNetCore.Http;
using MyLeasing.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyLeasing.Web.Models
{
    public class PropertyImageViewModel : PropertyImage
    {
        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }

    }
}
