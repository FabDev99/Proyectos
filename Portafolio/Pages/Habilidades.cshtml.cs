using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace Portafolio.Pages
{
    public class HabilidadesModel : PageModel
    {
        public List<string> HabilidadesTecnicas { get; set; }
        public List<string> HabilidadesProfesionales { get; set; }

        public void OnGet()
        {


            HabilidadesTecnicas = new List<string>
            {
                "C#",
                "ASP.NET Core",
                "JavaScript",
                "HTML/CSS",
                "SQL"
            };


            HabilidadesProfesionales = new List<string>
            {
                "Comunicación efectiva",
                "Trabajo en equipo",
                "Gestión del tiempo",
                "Resolución de problemas",
                "Liderazgo"
            };
        }
    }
}
