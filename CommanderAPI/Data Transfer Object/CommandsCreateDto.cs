using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommanderAPI.Data_Transfer_Object
{
    public class CommandsCreateDto
    {
        [Required]
        public string customerName { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string phoneNumber { get; set; }

    }
}
