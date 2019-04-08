using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CloasisWeb.Models
{
    public class EmailViewModel
    {
        public int id1 { get; set; }
        public int id2 { get; set; }

        [Required]
        public string Subject { get; set; }
        [Required]
        [MaxLength(250)]
        public string Message { get; set; }
    }
}