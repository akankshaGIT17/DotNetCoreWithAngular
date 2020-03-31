using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using AngularWithCore.Models;

namespace AngularWithCore.Controllers.Resources
{
    public class ModelResources
    {
        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        // public Make Make { get; set; }
        // public int MakeId { get; set; }
    }
}