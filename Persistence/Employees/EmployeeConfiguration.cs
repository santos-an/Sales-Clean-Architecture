﻿using System.Data.Entity.ModelConfiguration;
using Domain.Employees;

namespace Persistance.Employees;

public class EmployeeConfiguration : EntityTypeConfiguration<Employee>
{
    public EmployeeConfiguration()
    {
        HasKey(p => p.Id);
        Property(p => p.Name).IsRequired().HasMaxLength(50);
    }
}