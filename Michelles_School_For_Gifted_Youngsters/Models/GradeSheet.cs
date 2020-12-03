using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Michelles_School_For_Gifted_Youngsters.Models
{
    public class GradeSheet
    {
        //Mich*
        [Key]
        public int ID { get; set; }
        public int ItemScore { get; set; }
        public int ItemTotal { get; set; }
        public float ItemGrade {get; set;}
        //*Mich
    }
}
