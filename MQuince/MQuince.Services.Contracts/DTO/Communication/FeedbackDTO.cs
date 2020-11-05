using MQuince.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MQuince.Services.Contracts.DTO
{
    public class FeedbackDTO
    {
        public Grade Grade { get; set; }
        public string Comment { get; set; }
        public Guid UserId { get; set; }
        public DateTime Date { get; set; }
        public bool Anonymous { get; set; }
    }
}
