using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using AngularWithCore.Models;

namespace AngularWithCore.Controllers.Resources
{
    public class MakeResources
    {
                public int Id {get;set;}
        [Required]
        [StringLength(255)]
        public string Name {get;set;}
        public ICollection<ModelResources> Models {get;set;}

         public MakeResources()
        {
            Models = new Collection<ModelResources>();
        }
    }
}