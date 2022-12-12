using IntegrationAPI.Controllers;
using IntegrationLibrary.Features.BloodBankNews.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit.Priority;
using Xunit;

namespace IntegrationTests.MonthlyBloodSubscriptionTests
{
    public class IntegrationTests
    {
        [Fact, Priority(2)]
        public void Get_All_News()
        {
            /*
            IServiceScope scope = Factory.Services.CreateScope();
            BankNewsController controller = SetupController(scope);

            List<BankNews> result = ((OkObjectResult)controller.GetAll()).Value as List<BankNews>;

            Assert.Equal(1, result[0].Id);
            Assert.Equal(2, result[1].Id);
            Assert.Equal(3, result[2].Id);
            */
        }
    }
}
