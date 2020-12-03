using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Michelles_School_For_Gifted_Youngsters.Models
{
    public class GradesForTerm
    {
        
        [Key] //Mich*
        public int ID { get; set; }
        public int Term { get; set; }
        public int? quiz1 { get; set; }
        public int? quiz2 { get; set; }
        public int? quiz3 { get; set; }
        public int? assignment1 { get; set; }
        public int? assignment2 { get; set; }
        public int? assignment3 { get; set; }
        public GradeSheet GradeSheet { get; set; }
        //*Mich

    }
}
