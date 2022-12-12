using HospitalLibrary.Core.Model;
using HospitalLibrary.Core.Repository;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace HospitalTests.UserValidation_Tests
{
    public class UnitTests
    {
        [Fact]
        public void Password_Test_Low()
        {
            /*
            string passText = "12";
            Password pass = new Password(passText);
            */
        }

        [Fact]
        public void Password_Test()
        {

        }


        private static Password CreatePhysicianScheduleRepository()
        {
            Mock<Password> studRepo = new();
            studRepo.Setup(m => m.PasswordText);

            return studRepo.Object;
        }


        /*private List<Password> PasswordsText()
        {
            return new()
            {
                
            };
        }*/
    }
}
