using Hospital.Model.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital.Model
{
    public class Patient
    {
        [Key]
        public Guid ID { get; set; }
        public string NoKtp { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get;set;}
        [Required]
        public Sex Sex { get; set; }
        public Blood BloodType { get; set; }
        public DateTime BirthDay { get; set; }
        public string Telp { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public Marital MaritalStatus { get; set; }
        public int Occupation { get; set; }
    }
}