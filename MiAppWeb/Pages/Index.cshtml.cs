using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MiAppWebBD.Data;
using MiAppWebBD.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiAppWebBD.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public int? SelectedEmpresaId { get; set; }
        public List<SelectListItem> Empresas { get; set; }
        public List<Empleado> Empleados { get; set; }

        public async Task OnGetAsync()
        {
            Empresas = await _context.Empresas
                .Select(e => new SelectListItem
                {
                    Value = e.EmpresaID.ToString(),
                    Text = e.Nombre
                }).ToListAsync();

            Empleados = new List<Empleado>();
        }

        public async Task OnPostAsync()
        {
            Empresas = await _context.Empresas
                .Select(e => new SelectListItem
                {
                    Value = e.EmpresaID.ToString(),
                    Text = e.Nombre
                }).ToListAsync();

            if (SelectedEmpresaId.HasValue)
            {
                Empleados = await _context.Empleados
                    .Where(e => e.EmpresaID == SelectedEmpresaId.Value)
                    .ToListAsync();
            }
            else
            {
                Empleados = new List<Empleado>();
            }
        }
    }
}


