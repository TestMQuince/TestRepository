using MQuince.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MQuince.Services.Contracts.DTO
{
    public class FeedbackDTO
    {
        public string Comment { get; set; }
        public Guid UserId { get; set; }
        public bool Anonymous { get; set; }
        public bool Publish { get; set; }
    }
}
