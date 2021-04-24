using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Torres_SemiExercise1.Models
{
    public class ClientModel
    {
            [Key]
            public int ClientId { get; set; }
            [Required(ErrorMessage = "Name is a must")]
            public string ClientName { get; set; }
            [Required, Range(18, 59)]
            public int ClientAge { get; set; }
            [Required(ErrorMessage = "Address is a must")]
            public string ClientAddress { get; set; }
            [Required]
            public int ClientContactNo { get; set; }
            [Required]
            public string ClientEmailAdd { get; set; }
            [Required]
            public string ClientSubscription { get; set; }
    }
}
