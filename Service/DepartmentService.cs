using SalesProject.Data;
using System.Linq;
using System.Collections.Generic;
using SalesProject.Models;

namespace SalesProject.Service
{
    public class DepartmentService
    {
        private readonly SalesProjectContext _context;

        public DepartmentService(SalesProjectContext context)
        {
            _context = context;
        }

        public List<Department> findAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }
    }
}
