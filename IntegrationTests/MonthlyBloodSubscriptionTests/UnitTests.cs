using IntegrationLibrary.Features.BloodBankNews.Model;
using IntegrationLibrary.Features.BloodBankNews.Repository;
using IntegrationLibrary.Features.BloodBankReports.Service;
using IntegrationLibrary.Features.MonthlyBloodSubscription.Model;
using IntegrationLibrary.Features.MonthlyBloodSubscription.Repository;
using IntegrationLibrary.Features.MonthlyBloodSubscription.Service;
using IntegrationLibrary.HospitalService;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace IntegrationTests.MonthlyBloodSubscriptionTests
{
    public class UnitTests
    {
        [Fact]
        public void Get_All_Monthly_Blood_Subscriptions()
        {
            List<BloodSubscription> data = GetMonthlyBloodSubscriptionsData();
            BloodSubscriptionService service = new(CreatesubscriptionRepository(data));

            IEnumerable<BloodSubscription> ret = service.GetAll();

            Assert.Equal(ret, data);
        }


        private static List<BloodSubscription> GetMonthlyBloodSubscriptionsData()
        {
            return new()
            {
                new BloodSubscription() { Id = 1, BloodBankId = 1, BloodType = IntegrationLibrary.Features.Blood.Enums.BloodType.AB_PLUS, QuantityInLiters = 3.0,StartDate = new DateTime(2022, 10, 24) },
                new BloodSubscription() { Id = 2, BloodBankId = 2, BloodType = IntegrationLibrary.Features.Blood.Enums.BloodType.A_PLUS, QuantityInLiters = 2.0,StartDate = new DateTime(2022, 09, 24) },
                new BloodSubscription() { Id = 3, BloodBankId = 3, BloodType = IntegrationLibrary.Features.Blood.Enums.BloodType.O_MINUS, QuantityInLiters = 5.0,StartDate = new DateTime(2022, 11, 24) }
            };
        }

        private static IBloodSubscriptionRepository CreatesubscriptionRepository(List<BloodSubscription> data)
        {
            Mock<IBloodSubscriptionRepository> studRepo = new();
            studRepo.Setup(m => m.GetAll()).Returns(data);

            return studRepo.Object;
        }
    }
}
