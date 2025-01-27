using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mds.Blazor.Web.Services.Models
{
    public sealed class User : AObjectBase
    {
        public string Firstname { get; set; } = string.Empty;

        public string Lastname { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public DateOnly DateOfBirth { get; set; }

        public string? Address { get; set; }
        
        public string? Phone { get; set; }
        
        public string? Interests { get; set; }
    }
}
