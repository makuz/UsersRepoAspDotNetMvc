using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UserRepoProject.Models
{
    public class UserDetails
    {

        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage = "please pass name")]
        [MaxLength(25)]
        [MinLength(2)]
        public string Name { get; set; }
        [Required(ErrorMessage = "please pass last name")]
        [MaxLength(25)]
        [MinLength(2)]
        public string lastName { get; set; }
        [Required]
        [Range(0, 150, ErrorMessage = "Please enter valid Age")]
        public int Age { get; set; }
    }
}