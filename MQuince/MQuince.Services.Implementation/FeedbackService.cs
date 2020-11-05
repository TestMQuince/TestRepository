﻿using MQuince.Entities;
using MQuince.Repository.Contracts;
using MQuince.Services.Contracts.DTO;
using MQuince.Services.Contracts.IdentifiableDTO;
using MQuince.Services.Contracts.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MQuince.Services.Implementation
{
    public class FeedbackService : IFeedbackService
    {
        private readonly IFeedbackRepository _feedbackRepository;
        public FeedbackService(IFeedbackRepository feedbackRepository)
        {
            _feedbackRepository = feedbackRepository;
        }
        public Guid Create(FeedbackDTO entityDTO)
        {
            Feedback feedback = CreateFeedbackFromDTO(entityDTO);

            _feedbackRepository.Create(feedback);

            return feedback.Id;
        }

        public bool Delete(Guid id) => _feedbackRepository.Delete(id);

        public IEnumerable<IdentifiableDTO<FeedbackDTO>> GetAll()
            => _feedbackRepository.GetAll().Select(c => CreateDTOFromFeedback(c));


        public IdentifiableDTO<FeedbackDTO> GetById(Guid id) => CreateDTOFromFeedback(_feedbackRepository.GetById(id));

        public void Update(FeedbackDTO entityDTO, Guid id)
        {
            _feedbackRepository.Update(CreateFeedbackFromDTO(entityDTO, id));

        }

        private Feedback CreateFeedbackFromDTO(FeedbackDTO feedback, Guid? id = null)
            => id == null ? new Feedback(feedback.Grade, feedback.Comment, feedback.UserId, feedback.Date, feedback.Anonymous)
                          : new Feedback(id.Value, feedback.Grade, feedback.Comment, feedback.UserId, feedback.Date, feedback.Anonymous);


        private IdentifiableDTO<FeedbackDTO> CreateDTOFromFeedback(Feedback feedback)
        {
            if (feedback == null) return null;

            return new IdentifiableDTO<FeedbackDTO>()
            {
                Id = feedback.Id,
                EntityDTO = new FeedbackDTO()
                {
                    Comment = feedback.Comment,
                    Grade = feedback.Grade,
                    UserId = feedback.UserId,
                    Date = feedback.Date,
                    Anonymous = feedback.Anonymous
                }

            };
        }
    }
}
