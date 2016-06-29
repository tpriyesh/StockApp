using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Stock.Web.Interfaces
{
 public interface IUserInfo
    {
        string UserId { get; }
        string UserToken { get; }
    }
}
