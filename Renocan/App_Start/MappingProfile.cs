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
            CreateMap<Client_SignupDto, Client_Signup>();
        }
    }
}