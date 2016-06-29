using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.Script.Services;
using System.Web.Services;

namespace QuoteService
{
    /// <summary>
    /// Summary description for Service1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod()]
        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        public void GetData(string callback)
        {
            var ip = GetUserIP();
            Random random = new Random();
            int randomNumber = random.Next(0, 1000);

            List<Stock> stocks = new List<Stock>();
            Stock s1 = new Stock();
            s1.StockPrice = random.Next(0, 1000);

            s1.StockSymbol = "msft";
            stocks.Add(s1);
            Stock s2 = new Stock();
            s2.StockPrice = random.Next(0, 1000);

            s2.StockSymbol = "goog";
            stocks.Add(s2);
            Stock s3 = new Stock();
            s3.StockPrice = random.Next(0, 1000);

            s3.StockSymbol = "appl";
            stocks.Add(s3);


            // <code here to populate list on line above>

            // Method 1: use built-in serializer:
            StringBuilder sb = new StringBuilder();
            JavaScriptSerializer js = new JavaScriptSerializer();
            sb.Append(callback + "(");
            sb.Append(js.Serialize(stocks));
            sb.Append(");");

            // Method 2: NewtonSoft JSON serializer (delete as applicable)
            // StringBuilder sb = new StringBuilder();
            // sb.Append(callback + "(");
            // sb.Append(JsonConvert.SerializeObject(videos, Formatting.Indented)); // indentation is just for ease of reading while testing
            // sb.Append(");");     

            Context.Response.Clear();
            Context.Response.ContentType = "application/json";
            Context.Response.Write(sb.ToString());
            Context.Response.End();
        }

        private string GetUserIP()
        {
            string ipList = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];

            if (!string.IsNullOrEmpty(ipList))
            {
                return ipList.Split(',')[0];
            }

            return HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
        }
    }
}