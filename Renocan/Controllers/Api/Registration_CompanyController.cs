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

        public IEnumerable<Registration_CompanyDto> GETRegistrationCompany()
        {
            return context.Registration_Company.ToList().Select(Mapper.Map<Registration_Company, Registration_CompanyDto>);
        }


        public IHttpActionResult GetRegistrationCompany(int id)
        {
            var registrationCompany = context.Registration_Company.SingleOrDefault(c => c.Company_ID == id);

            if (registrationCompany == null)
                return NotFound();

            return Ok(Mapper.Map<Registration_Company, Registration_CompanyDto>(registrationCompany));
        }


        public IHttpActionResult POST(Registration_CompanyDto registration_CompanyDto)
        {

            if (!ModelState.IsValid)
                return BadRequest();

            var registrationCompany = Mapper.Map<Registration_CompanyDto, Registration_Company>(registration_CompanyDto);
            context.Registration_Company.Add(registrationCompany);
            context.SaveChanges();

            registration_CompanyDto.Company_ID = registrationCompany.Company_ID;
            return Created(new Uri(Request.RequestUri + "/" + registrationCompany.Company_ID), registration_CompanyDto);
        }

        [HttpPut]
        public void UpdateRegistrationCompany(int id,Registration_CompanyDto registration_CompanyDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var registrationCompanyInDb = context.Registration_Company.SingleOrDefault(c => c.Company_ID == id);

            if (registrationCompanyInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(registration_CompanyDto, registrationCompanyInDb);
            context.SaveChanges();
        }
    }
}
