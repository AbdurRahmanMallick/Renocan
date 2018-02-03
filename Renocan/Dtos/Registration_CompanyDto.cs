using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Renocan.Dtos
{
    public class Registration_CompanyDto
    {
        public int Company_ID { get; set; }

        [Required]
        public string CompanyName { get; set; }

        [Required]
        public string PostalCode { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Email { get; set; }
        
        [Required]
        public string Password { get; set; }

        [Required]
        public string Owner_First_Name { get; set; }

        [Required]
        public string Owner_Last_Name { get; set; }

        [Required]
        public Nullable<bool> IsAggrement { get; set; }

        [Required]
        public Nullable<bool> Is_Paid { get; set; }

        [Required]
        public string Website_Add { get; set; }

        [Required]
        public string Bussiness_Description { get; set; }

        [Required]
        public string Profile_Information { get; set; }

        [Required]
        public string Products { get; set; }

        [Required]
        public string Services { get; set; }

        [Required]
        public string Brands { get; set; }

        [Required]
        public string Specialities { get; set; }

        [Required]
        public string Year_Established { get; set; }

        [Required]
        public string Return_Policy_URL { get; set; }

        [Required]
        public string Payment_Method_URL { get; set; }

        [Required]
        public string Licences_URL { get; set; }

        [Required]
        public string Insurance_URL { get; set; }

        [Required]
        public string Certificates_URL { get; set; }

        [Required]
        public string Pricing { get; set; }

        [Required]
        public string Contract_Based { get; set; }

        [Required]
        public string Warranty { get; set; }
    }
}