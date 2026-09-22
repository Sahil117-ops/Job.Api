using Job.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Job.Domain.Interface
{
    public interface ICompany
    {
        Task<List<Company>> GetAllAsync();
        Task<Company> GetByIdAsync(int id);
        Task<Company> CreateAsync(Company company);
    }
}
