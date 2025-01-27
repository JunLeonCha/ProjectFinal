using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mds.Blazor.Web.Services.Abstractions;
using Mds.Blazor.Web.Shared.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Mds.Blazor.Web.Shared.Components.Pages.Users
{
    public sealed partial class Users
    {
        private List<UserViewModel> usersCollection = [];

        [Inject]
        public IUserService UserService { get; set; } = null!;

        protected override void OnInitialized()
        {
            this.usersCollection = this.UserService.GetAll()
                .Select(x => new UserViewModel
                {
                    Id = x.Id,
                    Address = x.Address,
                    DateOfBirth = x.DateOfBirth,
                    Email = x.Email,
                    Firstname = x.Firstname,
                    Interests = x.Interests,
                    Lastname = x.Lastname,
                    Phone = x.Phone
                }).ToList();

            base.OnInitialized();
        }
    }
}
