using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StickersWeb.Models.Team
{
    public class EditTeamModel
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Name is required field")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name length must be min 3 characters")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Description is required field")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Description length must be min 3 characters")]
        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}