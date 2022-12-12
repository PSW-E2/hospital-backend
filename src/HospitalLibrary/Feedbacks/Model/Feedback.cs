using HospitalLibrary.Core.Model;
using System;

namespace HospitalLibrary.Feedbacks.Model
{
    public class Feedback : EntityObject
    {
        //public int Id { get; set; }
        public bool Privatisation { get; set; }
        public FeedbackText Textt { get; set; }
        public string User { get; set; }
        public string Date { get; set; }
        public bool IsDisplayedPublic { get; set; }
    }
}
