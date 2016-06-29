using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stock.Dal;

namespace Stock.Repository.Extensions
{
    public static class ExceptionExtensions
    {
        public static error ToApplicationErrorEntity(this Exception exception)
        {
            var applicationErrorEntity = new error
            {
                errordatetime = DateTime.Now,
                errormessage = exception.Message.Replace("'", "''"),
                errordescription = exception.ToString().Replace("'", "''")
            };
            return applicationErrorEntity;
        }
    }
}
