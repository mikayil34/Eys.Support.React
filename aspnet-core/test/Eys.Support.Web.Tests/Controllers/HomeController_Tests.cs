using System.Threading.Tasks;
using Eys.Support.Models.TokenAuth;
using Eys.Support.Web.Controllers;
using Shouldly;
using Xunit;

namespace Eys.Support.Web.Tests.Controllers
{
    public class HomeController_Tests: SupportWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}