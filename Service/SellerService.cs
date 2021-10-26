using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesProject.Data;
using SalesProject.Models;

namespace SalesProject.Service
{
    public class SellerService
    {
        private readonly SalesProjectContext _context;

        public SellerService(SalesProjectContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }

        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
            
        }
    }
}
