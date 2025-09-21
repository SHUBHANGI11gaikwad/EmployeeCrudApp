using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EmployeeCrudApp.Data;
using EmployeeCrudApp.Models;

namespace EmployeeCrudApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly EmployeeCrudApp.Data.ApplicationDbContext _context;

        public IndexModel(EmployeeCrudApp.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Employee = await _context.Employees.ToListAsync();
        }
    }
}
