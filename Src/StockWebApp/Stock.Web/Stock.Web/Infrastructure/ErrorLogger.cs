using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Stock.Repository;

namespace Stock.Web.Infrastructure
{
    public class ErrorLogger
    {
        private readonly Exception _exception;

        public ErrorLogger(Exception exception)
        {
            _exception = exception;
        }

        public void Log()
        {
            LogError();
            SendEmail();
        }

        /// <summary>
        /// Sends an email 
        /// /// If they are invalid, it fails silently
        /// </summary>
        private void SendEmail()
        {
            // send email logic will come here
        }

        private void LogError()
        {
            IErrorRepository errorRepository = new ErrorRepository();
            errorRepository.InsertException(_exception);
        }
    }

}