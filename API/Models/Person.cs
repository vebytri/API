﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Models
{
    [Table("TB_M_Person")]
    public class Person
    {
        //        nik int
        //firstname string
        //lastname    string
        //phone   string
        //birthdate date
        //salary int
        //email string
        [Key]
        public int NIK { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public DateTime BirthDate { get; set; }
        public int Salary { get; set; }
        public string Email { get; set; }
    }
}
