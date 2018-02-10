using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Renocan.Dtos
{
    public class Image_TypeDto

    {
        public int Image_Type_ID { get; set; }
        [Required]
        public String Image_Type_Name { get; set; }
    }
}