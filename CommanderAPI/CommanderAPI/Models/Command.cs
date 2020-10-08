using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CommanderAPI.Models
{
    public class Command
    {
        [Key]
        public int id { get; set; }
        [Required]
        [MaxLength(200)]
        public string customerName { get; set; }
        [Required]
        public string address { get; set; }
        [Required]
        public string email { get; set; }
        [Required]

        public string phoneNumber { get; set; }
    }
}
