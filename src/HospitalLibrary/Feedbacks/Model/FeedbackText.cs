using HospitalLibrary.Core.Model;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLibrary.Feedbacks.Model
{
    public class FeedbackText : ValueObject
    {
        public string Textt { get; set; }

        public FeedbackText() { }

        public FeedbackText(string textt)
        {
            if (Validate(textt))
            {
                Textt = textt;
            }
            else
            {
                throw new Exception("Feedback is invalid!");
            }
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Textt;
        }

        private bool Validate(string textt)
        {
            return textt.Equals("");
        }
    }
}
