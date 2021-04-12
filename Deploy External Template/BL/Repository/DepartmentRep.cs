using AutoMapper;
using Deploy_External_Template.BL.Interface;
using Deploy_External_Template.DAL.DataBase;
using Deploy_External_Template.DAL.Entities;
using Deploy_External_Template.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Deploy_External_Template.BL.Repository
{
    public class DepartmentRep : IDepartmentRep

    {
        private Dbcontiner db;
        private readonly IMapper mapper;

        public DepartmentRep(Dbcontiner db,IMapper mapper)
        {
            this.db = db;
            this.mapper = mapper;
        }
        public IQueryable<DepartmentVM> Get()
        {
            //var data = db.Departments.Select(a => new DepartmentVM
            //{
            //    id = a.id,
            //    Name = a.Name,
            //    code = a.code
            //}
            //);
            var dept = (db.Departments); ;
            var data = mapper.Map<Department>(dept);
            return (IQueryable<DepartmentVM>)data;
        }
        public void Add(DepartmentVM dept)
        {
            var data = mapper.Map<Department>(dept);
            db.Departments.Add(data);
            db.SaveChanges();

        }
        public DepartmentVM GetById(int Id)
        {
            return Getdeparbyid(Id);
        }

        private DepartmentVM Getdeparbyid(int Id)
        {
            return db.Departments.Where(a => a.id == Id).Select(a => new DepartmentVM
            {
                id = a.id,
                Name = a.Name,
                code = a.code
            }).FirstOrDefault();
        }

        public void Edit(DepartmentVM dep)
        {
            var data=mapper.Map<Department>(dep);
            db.Entry(data).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var data = db.Departments.Find(id);
            db.Departments.Remove(data);
            db.SaveChanges();
        }
        
    }
}
