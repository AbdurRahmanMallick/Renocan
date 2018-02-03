using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Renocan.Models;
using Renocan.Dtos;

namespace Renocan.App_Start
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Client_Signup, Client_SignupDto>();
            CreateMap<Client_SignupDto, Client_Signup>().ForMember(m => m.Client_ID, opt => opt.Ignore());

            CreateMap<Registration_Company, Registration_CompanyDto>();
            CreateMap<Registration_CompanyDto, Registration_Company>().ForMember(m => m.Company_ID, opt => opt.Ignore());
        }
    }
}