using System;
using System.Collections.Generic;
using DTO.Entities;

namespace Contracts.IManager
{
    public interface IManagerDepartament
    {
        IEnumerable<DepartmentDto> GetAllDepartaments();

        IEnumerable<DepartmentDto> GetDepartmentByName(String name);
    }
}