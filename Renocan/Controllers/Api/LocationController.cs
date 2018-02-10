using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using Renocan.Dtos;
using Renocan.Models;

namespace Renocan.Controllers.Api
{
    public class LocationController : ApiController
    {

        private Renocan_DbContext context;

        public LocationController()
        {
            context = new Renocan_DbContext();
        }

        public IEnumerable<LocationDto> Get()
        {
            return context.Locations.ToList().Select(Mapper.Map<Location, LocationDto>);
        }

        public LocationDto GetLocation(int id)
        {
            var location = context.Locations.SingleOrDefault(c => c.Location_ID == id);
            if (location == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return Mapper.Map<Location, LocationDto>(location);

        }


        [HttpPost]
        public LocationDto CreateLocation(LocationDto locationDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var update = Mapper.Map<LocationDto, Location>(locationDto);
            context.Locations.Add(update);
            context.SaveChanges();
            return locationDto;
        }

        [HttpPut]
        public void UpdateActivity(int id, LocationDto locationDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var update = context.Locations.SingleOrDefault(c => c.Location_ID == id);
            if (update == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            Mapper.Map(locationDto, update);
            context.SaveChanges();

        }

    }
}
