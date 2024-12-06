using System.ComponentModel.DataAnnotations;

namespace Pharma.Models
{
    public class Cart
    {
        [Key]
        required
        public int prodId { get; set; }
        public string prodName { get; set; }
        public string prodDescription { get; set; } 
        public int qnty { get; set; }
        public int add {  get; set; }
    }
}
