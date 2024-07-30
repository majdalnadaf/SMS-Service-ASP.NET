using System.ComponentModel.DataAnnotations;

namespace SMSApiServices.DataTransferObjects
{
    public class DTOSMS
    {
        [Required]
        [Phone]
        public string PhontNumber { get; set; }
        [Required]
        [StringLength(500)]
        public string body { get; set; }
    }
}
