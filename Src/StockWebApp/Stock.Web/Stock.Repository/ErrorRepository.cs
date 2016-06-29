using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Stock.Dal;
using Stock.Repository.Extensions;

namespace Stock.Repository
{
    public class ErrorRepository : DefaultDisposable, IErrorRepository
    {
      
        public void InsertException(Exception _exception)
        {
            var errorEntity = _exception.ToApplicationErrorEntity();
            _context.errors.InsertOnSubmit(errorEntity);
            _context.SubmitChanges();
        }
    }
}
