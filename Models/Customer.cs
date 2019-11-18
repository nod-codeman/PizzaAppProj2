using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VMANpizza.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [MaxLength(25, ErrorMessage = "First name can't be longer than 25 characters")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        [MaxLength(25, ErrorMessage = "Last name can't be longer than 25 characters")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Address { get; set; }

        //[Required]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        // set by default to false!!!
        public bool isMember { get; set; }
        public List<Order> Orders { get; set; }
    }
}
