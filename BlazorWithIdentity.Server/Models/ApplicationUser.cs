using Microsoft.AspNetCore.Identity;
using System;

namespace BlazorWithIdentity.Server.Models
{
    public class ApplicationUser : IdentityUser<Guid>
    {
    }
}