using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ResourceServer.Model.Deal;
using ResourceServer.Model.Rating;
using ResourceServer.Producer;
using ResourceServer.Repositories.Interfaces;
using System;
using System.Threading.Tasks;

namespace ResourceServer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly IMessageProducer _messagePublisher;
        public RatingController( IMessageProducer messagePublisher)
        {
            _messagePublisher = messagePublisher;
        }

        [HttpPost]
        public IActionResult CreateRating(Rating _rating)
        {
            Rating rating = new()
            {
                UserId = _rating.UserId,
                DealId = _rating.DealId
            };
            _messagePublisher.SendMessage(rating);
            return Ok();
        }
    }
}
