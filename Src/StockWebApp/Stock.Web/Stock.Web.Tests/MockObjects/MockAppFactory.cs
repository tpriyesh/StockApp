using Moq;
using System.Security.Principal;
using Stock.Web.Interfaces;

namespace Stock.Web.Tests.MockObjects
{
    public static class MockAppFactory
    {
       
        public static IIdentity GetMockUserIdentity(int userId)
        {
            var iIdentity = new Mock<IIdentity>();
            iIdentity.SetupGet(x => x.IsAuthenticated).Returns(true);
            iIdentity.SetupGet(x => x.AuthenticationType).Returns("User");
           // iIdentity.SetupGet(x => x.Name).Returns("awayi188");
            iIdentity.SetupGet(x => x.Name).Returns("test123");

            var iUserInfo = iIdentity.As<IUserInfo>();
           
            return iIdentity.Object;
        }

            }
}