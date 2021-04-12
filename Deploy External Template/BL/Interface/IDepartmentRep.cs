using Deploy_External_Template.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deploy_External_Template.BL.Interface
{
     public interface IDepartmentRep
    {
        public IQueryable<DepartmentVM> Get();
        public void Add(DepartmentVM dept);
        public DepartmentVM GetById(int Id);

        public void Edit(DepartmentVM dep);
        public void Delete(int id);

    }
}
