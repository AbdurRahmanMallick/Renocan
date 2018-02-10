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
    public class Image_TypeController : ApiController
    {
        private Renocan_DbContext context;

        public Image_TypeController()
        {
            context = new Renocan_DbContext();
        }
        public IEnumerable<Image_TypeDto> Get()
        {
            return context.Image_Type.ToList().Select(Mapper.Map<Image_Type, Image_TypeDto>);
        }

        public Image_TypeDto GetImage_Type(int id)
        {
            var image = context.Image_Type.SingleOrDefault(c => c.Image_Type_ID == id);
            if (image == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            return Mapper.Map<Image_Type, Image_TypeDto>(image);

        }


        [HttpPost]
        public Image_TypeDto CreateImage_Type(Image_TypeDto image_TypeDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var img= Mapper.Map<Image_TypeDto, Image_Type>(image_TypeDto);
            context.Image_Type.Add(img);
            context.SaveChanges();
            return image_TypeDto;
        }

        [HttpPut]
        public void UpdateImage_Type(int id, Image_TypeDto image_TypeDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var admin = context.Image_Type.SingleOrDefault(c => c.Image_Type_ID == id);
            if (admin == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            Mapper.Map(image_TypeDto, admin);
            context.SaveChanges();

        }
    }
}




