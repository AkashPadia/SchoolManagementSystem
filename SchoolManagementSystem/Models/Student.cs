using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolManagementSystem.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }
        [Required]
        [Display(Name ="Roll Number")]
        public string RollNumber { get; set; }
        [Required]
        [Display(Name ="Father's Name")]
        public string FatherName { get; set; }
        [Required]
        [Display(Name = "Mother's Name")]
        public string MotherName { get; set; }
        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public byte Gender { get; set; }
        public string Class { get; set; }
        [Required]
        public int Contact { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Pincode { get; set; }
    }
}