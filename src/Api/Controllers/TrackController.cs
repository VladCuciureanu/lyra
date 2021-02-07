﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Lyra.Application.Tracks;
using Lyra.Application.Tracks.Queries.GetTrack;
using Lyra.Application.Common.Security;
using Microsoft.AspNetCore.Mvc;

namespace Lyra.Api.Controllers
{
    [Authorize]
    public class TrackController : ApiControllerBase
    {
        [HttpGet("{id}")]
        public async Task<ActionResult<TrackDto>> GetTrack(int id)
        {
            var query = new GetTrackQuery()
            {
                Id = id
            };

            var result = await Mediator.Send(query);
            
            if (result == null)
                return NotFound();
            else
                return result;
        }
    }
}