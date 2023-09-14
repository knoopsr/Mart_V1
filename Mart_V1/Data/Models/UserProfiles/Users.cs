using System.ComponentModel.DataAnnotations;
using Mart_V1.Data.Models.UserProfiles;

namespace Mart_V1.Data.Models.UserProfiles
{
    public class Users
    {
        [Key] public int Id { get; set; }
        [Required] public string UserName { get; set; }
        [Required] public string Password { get; set; }

        [Required] public string Email { get; set; }
        [Required] public DateTime CreatedDate { get; set; }
        public DateTime LastUpdatedDate { get; set; }
        public int Disable { get; set; } = 1;
        public string Role {  get; set; }

   
       
    }
}
