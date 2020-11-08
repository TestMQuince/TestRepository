using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MQuince.Entities;
using MQuince.Entities.Drug;
using MQuince.Repository.SQL;
using MQuince.Repository.SQL.DataProvider;
using MQuince.Services.Contracts.DTO;
using MQuince.Services.Contracts.IdentifiableDTO;
using MQuince.Services.Contracts.Interfaces;
using MQuince.Services.Implementation;

namespace MQuince.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private readonly IFeedbackService _feedbackService;

        public FeedbackController([FromServices] IFeedbackService feedbackService)
        {
            this._feedbackService = feedbackService;
        }

        [HttpPost]      
        public IActionResult Add(FeedbackDTO dto)
        {
            if (dto.Comment.Length <= 0)
            {
                return BadRequest();   
            }
            _feedbackService.Create(dto);
            return Ok(dto);
        }

        [HttpGet("GetByStatus")]
        public IEnumerable<IdentifiableDTO<FeedbackDTO>> GetByStatus(bool publish, bool approved)
        {
            return _feedbackService.GetByStatus(publish, approved);
        }

        [HttpGet("GetByParams")]
        public IEnumerable<IdentifiableDTO<FeedbackDTO>> GetByParams(bool anonymous, bool approved)
        {
            return _feedbackService.GetByParams(anonymous, approved);
        }

        [HttpPost("Update")]
        public IActionResult Update(Feedback feedback)
        {
<<<<<<< HEAD
            _feedbackService.Update(new FeedbackDTO() { Comment = feedback.Comment, UserId = feedback.UserId, Anonymous = feedback.Anonymous, Publish = feedback.Publish, Approved = feedback.Approved }, feedback.Id);
            return Ok();
=======
            return _feedbackService.GetByStatus(publish);
        }

        [HttpGet("GetByAllParams")]
        public IEnumerable<IdentifiableDTO<FeedbackDTO>> GetByAllParams(bool publish, bool anonymous, bool approved)
        {
            return _feedbackService.GetByAllParams(publish, anonymous, approved);
>>>>>>> develop
        }

    }
}