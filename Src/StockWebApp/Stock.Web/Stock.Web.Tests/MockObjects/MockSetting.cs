using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stock.Repository;
using Stock.Dal;


namespace Stock.Web.Tests.MockObjects
{
  public  class MockSetting:ISettingRepository
    {
        public IEnumerable<Stock.Dal.stock> GetAllStocks()
        {
            List<stock> stocks = new List<stock>();
            stock s1 = new stock();
            s1.id = 1;
            s1.stockcode = "goog";
            stocks.Add(s1);
            stock s2 = new stock();
            s2.id = 2;
            s2.stockcode = "appl";
            stocks.Add(s2);
            stock s3 = new stock();
            s3.id = 3; ;
            s3.stockcode = "msft";
            stocks.Add(s3);
            return stocks;
        }
    }
}
