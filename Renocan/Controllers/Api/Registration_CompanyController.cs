using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Renocan.Models;
using Renocan.Dtos;
using AutoMapper;

namespace Renocan.Controllers.Api
{
    public class Registration_CompanyController : ApiController
    {
        public Renocan_DbContext context;

        public Registration_CompanyController()
        {
            context = new Renocan_DbContext();
        }

        public IEnumerable<Registration_CompanyDto> GET()
        {
            return context.Registration_Company.ToList().Select(Mapper.Map<Registration_Company, Registration_CompanyDto>);
        }
    }
}
