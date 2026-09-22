using Job.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Job.Domain.Interface
{
    public interface IUserInterface
    {
        Task<List<UserProfile>> GetAllAsync();
        Task<UserProfile> GetByIdAsync(int id);
        Task<UserProfile> CreateAsync(UserProfile userProfile);
        Task<int> UpdateAsync(int Id, UserProfile userProfile);
        Task<bool> DeleteAsync(int id);
    }
}
