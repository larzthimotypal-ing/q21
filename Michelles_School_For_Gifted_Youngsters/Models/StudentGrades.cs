using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Michelles_School_For_Gifted_Youngsters.Models
{
    public class StudentGrades
    {
        //Mich*
        [Key]
        public int ID { get; set; }      
        public int? Prelim { get; set; }
        public int? Midterm { get; set; }
        public int? PreFinals { get; set; }
        public int? Finals { get; set; }
        public float TotalGrade { get; set; }
        public GradesForTerm GradesForTerm { get; set; } 
        //*Mich
    }  
}
