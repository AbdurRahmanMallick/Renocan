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
    public class ScoreboardController : ApiController
    {
        private Renocan_DbContext context;

        public ScoreboardController()
        {
            context = new Renocan_DbContext();
        }

        public IEnumerable<ScoreboardDto> Get()
        {
            return context.Scoreboards.ToList().Select(Mapper.Map<Scoreboard, ScoreboardDto>);
        }

        public ScoreboardDto GetScoreboard(int id)
        {
            var a = context.Scoreboards.SingleOrDefault(c => c.Scoreboard_ID == id);
            if (a == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
           
            return Mapper.Map<Scoreboard, ScoreboardDto>(a);
        

        }


        [HttpPost]
        public ScoreboardDto CreateScoreboard(ScoreboardDto a)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var Scoreboard = Mapper.Map<ScoreboardDto, Scoreboard>(a);
            context.Scoreboards.Add(Scoreboard);
            context.SaveChanges();
            return a;
        }

        [HttpPut]
        public void UpdateScoreboard(int id, ScoreboardDto ScoreboardDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var admin = context.Scoreboards.SingleOrDefault(c => c.Scoreboard_ID == id);
            if (admin == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            Mapper.Map(ScoreboardDto, admin);
            context.SaveChanges();

        }
    }
}



    

