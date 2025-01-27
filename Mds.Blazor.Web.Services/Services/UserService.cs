using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mds.Blazor.Web.Services.Abstractions;
using Mds.Blazor.Web.Services.Models;

namespace Mds.Blazor.Web.Services.Services;

internal sealed class UserService : AServiceBase<User>, IUserService
{
    public UserService()
    {
    }
}