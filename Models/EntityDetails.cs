using System.ComponentModel.DataAnnotations;

namespace GetEntityDetailsApi.Models
{
    public class EntityDetails
    {
           [Key]
            public int ACN { get; set; }

            [Required]
            public string EntityName { get; set; }

            [Required]
            public string Address { get; set; }

            [Required]
            public string personalEmailID { get; set; }
        
    }

}

