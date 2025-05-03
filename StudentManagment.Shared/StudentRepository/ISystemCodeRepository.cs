﻿using StudentManagment.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagment.Shared.StudentRepository
{
    public interface ISystemCodeRepository
    {
        Task<SystemCode> AddAsync(SystemCode mod);

        Task<SystemCode> UpdateAsync(SystemCode mod);

        Task<SystemCode> DeleteAsync(int id);

        Task<List<SystemCode>> GetAllAsync();

        Task<SystemCode> GetByIdAsync(int id);
    }
}
