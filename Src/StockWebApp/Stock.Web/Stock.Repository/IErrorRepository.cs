using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stock.Repository
{
  public interface IErrorRepository
    {
      void InsertException(Exception _exception);
    }
}
