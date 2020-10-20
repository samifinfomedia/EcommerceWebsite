﻿using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PerfumeStore.Data.Models
{
    public class Order
    {
        [BindNever]
        public int OrderId { get; set; }
        public List<OrderDetail> OrderLines { get; set; }

        [Display(Name ="First Name")]
        [StringLength(50)]
        [Required(ErrorMessage ="Please enter your first name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [StringLength(50)]
        [Required(ErrorMessage = "Please enter your last name")]
        public string LastName { get; set; }
        
        [Display(Name = "Address Line1")]
        [StringLength(100)]
        [Required(ErrorMessage = "Please enter your address")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        
        [Display(Name = "Zip Code")]
        [StringLength(10, MinimumLength = 4)]
        [Required(ErrorMessage = "Please enter your zip code")]
        public string ZipCode { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "Please enter your city")]
        public string City { get; set; }
        
        [StringLength(50)]
        [Required(ErrorMessage = "Please enter your State name")]
        public string State { get; set; }
        
        [StringLength(50)]
        [Required(ErrorMessage = "Please enter your Country name")]
        public string Country { get; set; }
        
        [Display(Name = "Phone Number")]
        [StringLength(25)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Please enter your phone number")]
        public string PhoneNumber { get; set; }
        
        [DataType(DataType.EmailAddress)]
        [StringLength(50)]
        [Required]
        [RegularExpression(@"(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*|""(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21\x23-\x5b\x5d-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])*"")@(?:(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?|\[(?:(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(?:25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?|[a-z0-9-]*[a-z0-9]:(?:[\x01-\x08\x0b\x0c\x0e-\x1f\x21-\x5a\x53-\x7f]|\\[\x01-\x09\x0b\x0c\x0e-\x7f])+)\])",
            ErrorMessage = "The email address is not entered in a correct format")]
        public string Email { get; set; }
        
        [BindNever]
        [ScaffoldColumn(false)]
        [Column(TypeName = "decimal(18,4)")]
        public decimal OrderTotal { get; set; }
        
        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime OrderPlaced { get; set; }
    }
}

