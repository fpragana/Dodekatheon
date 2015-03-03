using Dodekatheon.Core.Models;
using System;

namespace Dodekatheon.Core.Interfaces.Services
{
    public interface IAuthenticationService : IDisposable
    {
        User Authenticate(string email, string password);
    }
}