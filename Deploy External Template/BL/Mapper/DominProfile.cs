using AutoMapper;
using Deploy_External_Template.DAL.Entities;
using Deploy_External_Template.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deploy_External_Template.BL.Mapper
{
    public class DominProfile:Profile
    {
        public DominProfile()
        {
            CreateMap<Department, DepartmentVM>();
            CreateMap<DepartmentVM, Department>();
        }
    }
}
