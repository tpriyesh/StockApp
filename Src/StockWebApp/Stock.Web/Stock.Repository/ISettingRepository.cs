using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stock.Dal;
namespace Stock.Repository
{
   public interface ISettingRepository
    {
       IEnumerable<stock> GetAllStocks();
    }
}
