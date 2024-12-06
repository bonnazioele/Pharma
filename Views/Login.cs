using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Pharma.Models
{
    public class Login
    {
        [Key] public int userID {  get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }


    }
}
