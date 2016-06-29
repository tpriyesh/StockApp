using Stock.Repository;
using Stock.Web.Tests.MockObjects;
namespace Stock.Web.Tests.MockFrameworkObjects
{
    internal class MockObjectFactory
    {
        public static ISettingRepository CreateSettingRepository()
        {
            return new MockSetting();
        }

        public static IPersonalizedStockRepository CreatePersonalizedRepository()
        {
            return new MockPersonalizedRepo();
        }

      
    }
}
