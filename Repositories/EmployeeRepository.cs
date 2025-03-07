﻿using BethanysPieShopHRM.Contracts.Repositories;
using BethanysPieShopHRM.Data;
using BethanysPieShopHRM.Shared.Domain;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShopHRM.Repositories
{
    public class EmployeeRepository : IEmployeeRepository, IDisposable
    {
        private AppDbContext _appDbContext;

        public EmployeeRepository(IDbContextFactory<AppDbContext> dbFactory)
        {
            _appDbContext = dbFactory.CreateDbContext();
        }

        public void Dispose()
        {
            _appDbContext.Dispose();
        }
        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await _appDbContext.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployeeById(int employeeId)
        {
            return await _appDbContext.Employees.FirstOrDefaultAsync(c => c.EmployeeId == employeeId);
        }
    }
}
