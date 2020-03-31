using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AngularWithCore.Models
{
    [Table("Models")]
    public class Model
    {
        public int Id {get;set;}
        [Required]
        [StringLength(255)]
        public string Name {get;set;}

//Below Make and MakeID is making a relationship, it also creates a loop relationship.
        public Make Make {get;set;}
        public int MakeId {get;set;}
    }
}