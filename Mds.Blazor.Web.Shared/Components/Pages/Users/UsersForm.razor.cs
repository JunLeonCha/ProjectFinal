using Mds.Blazor.Web.Services.Abstractions;
using Mds.Blazor.Web.Shared.ViewModels;
using Microsoft.AspNetCore.Components;

namespace Mds.Blazor.Web.Shared.Components.Pages.Users;

public sealed partial class UsersForm
{
    private UserViewModel user = new();

    [Parameter]
    public int UserId { get; set; }

    [Inject]
    public IUserService UserService { get; set; } = null!;

    [Inject]
    public NavigationManager Navigation { get; set; } = null!;

    private void OnValidSubmitHandler()
    {
        try
        {
            string interestsAsString = string.Join(",", user.Interests);
            this.UserService.Add(new()
            {
                Email = user.Email,
                Firstname = user.Firstname,
                Lastname = user.Lastname,
                Phone = user.Phone,
                Interests = interestsAsString,
                DateOfBirth = user.DateOfBirth,
                Address = user.Address,
            });

            this.Navigation.NavigateTo("/users");
        }
        catch (Exception ex)
        {
            // Log or show an error message if necessary
            Console.WriteLine($"Error: {ex.Message}");
        }


    }
}
