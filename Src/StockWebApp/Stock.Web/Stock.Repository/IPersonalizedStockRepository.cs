using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stock.Dal;
using System.Collections;

namespace Stock.Repository
{
   public interface IPersonalizedStockRepository
    {
        void SaveStocksToUser(user userObj,string stockCode);
        IEnumerable<userstock> GetStocksOfUser(user userObj);
        user GetUser(string userName);
        void DeleteStockFromUser(user userObj, string stockCode);
    }
}
