using System.ComponentModel.DataAnnotations;

namespace Mds.Blazor.Web.ViewModels;

public sealed class UserViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Firstname { get; set; } = string.Empty;

        [Required]
        public string Lastname { get; set; } = string.Empty;

        [Required]
        public string Email { get; set; } = string.Empty;

        [Required]
        public DateOnly DateOfBirth { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; } 
        public string? Interests { get; set; } 
    }

