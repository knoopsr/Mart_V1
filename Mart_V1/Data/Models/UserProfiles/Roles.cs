using Mart_V1.Data.Models.UserProfiles;
using System.ComponentModel.DataAnnotations;

namespace Mart_V1.Data.Models.UserProfiles
{
    public class Roles
    {
        [Key] 
        public int Id { get; set; }

        [Required] 
        public string Name { get; set; }

       public string Description { get; set; }
    }
}
