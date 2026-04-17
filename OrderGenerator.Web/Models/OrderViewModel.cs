using System.ComponentModel.DataAnnotations;

namespace OrderGenerator.Web.Models
{
    public class OrderViewModel
    {
        [Required]
        public string? Symbol { get; set; } = string.Empty;
        [Required]
        public string OperationType { get; set; } = string.Empty;
        [Range(1,99999)]
        public int Quantity { get; set; }

        [Range(typeof(decimal), "0,01", "999,99")]
        public decimal  Price { get; set; }

        public string? ResultMessage { get; set; }
    }
}
