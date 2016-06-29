using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stock.Dal;
using Stock.Repository;

namespace Stock.Web.Tests.MockObjects
{
   public class MockPersonalizedRepo:IPersonalizedStockRepository
    {
        public void SaveStocksToUser(user userObj, string stockCode)
        {
            //throw new NotImplementedException();
        }

        public IEnumerable<userstock> GetStocksOfUser(user userObj)
        {
            List<userstock> ustocks = new List<userstock>();
            userstock ustock = new userstock();
            ustock.user_id = 1;
            ustock.id = 1;
            ustock.stockcode = "appl";
            ustocks.Add(ustock);
            userstock ustock1 = new userstock();
            ustock1.user_id = 1;
            ustock1.id = 2;
            ustock1.stockcode = "goog";
            ustocks.Add(ustock1);
            userstock ustock2 = new userstock();
            ustock2.user_id = 2;
            ustock2.id = 3;
            ustock2.stockcode = "goog";
            ustocks.Add(ustock2);
           
            return ustocks.Where(x=>x.user_id==userObj.id);
        }

        public user GetUser(string userName)
        {
            List<user> users = new List<user>();
            var user = new user();
            user.id = 1;
            user.email = "awayi188@gmail.com";
            user.activestatus = true;
            user.username = "awayi188";
            user.password = "123";
            user.usercode = "123";
            users.Add(user);
            var user1 = new user();
            user1.id = 2;
            user1.email = "test@gmail.com";
            user1.activestatus = true;
            user1.username = "test123";
            user1.password = "123";
            user1.usercode = "123";
            users.Add(user1);
            return users.Where(x => x.username == userName).FirstOrDefault();
        }

        public void DeleteStockFromUser(user userObj, string stockCode)
        {
          //throw new NotImplementedException();
        }

      
    }
}
