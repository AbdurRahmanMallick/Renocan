using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Renocan.Dtos
{
    public class ScoreboardDto
    {
        public int Scoreboard_ID { get; set; }
        [Required]
        public Nullable<int> Visitor_ID { get; set; }
        [Required]
        public string Visitor_Name { get; set; }
       [Required]
        public string Leads { get; set; }
        [Required]
        public Nullable<int> Company_ID { get; set; }
        


    }
}