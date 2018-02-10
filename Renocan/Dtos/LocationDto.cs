using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Renocan.Dtos
{
    public class LocationDto
    {
        public int Location_ID { get; set; }

        [Required]
        public string Location_Name { get; set; }

        [Required]
        public string Postal_Code { get; set; }

    }
}