using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalLibrary.Core.Model
{
    public class Password : ValueObject
    {
        public string PasswordText { get; }

        public Password(string passwordText)
        {
            if(Validate(passwordText))
            { 
                PasswordText = passwordText;
            }
            else
            {
                throw new Exception("Passed arguments are not valid!");
            }
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return PasswordText;
        }

        private bool Validate(string pText)
        {
            return pText.Length > 2;
        }
    }
}
