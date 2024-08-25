using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Portafolio.Pages
{
    public class ContactoModel : PageModel
    {
        [BindProperty]
        public ContactoFormModel ContactoForm { get; set; }

        public bool IsSent { get; set; }
        public string ErrorMessage { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {


                IsSent = true;



            }
            else
            {
                ErrorMessage = "Por favor, corrige los errores en el formulario.";
            }
        }

        public class ContactoFormModel
        {
            [Required]
            public string Company { get; set; }

            [Required]
            public string ContactName { get; set; }

            [Required]
            public string Position { get; set; }

            [Required]
            [EmailAddress]
            public string Email { get; set; }

            public string Phone { get; set; }

            public string Message { get; set; }
        }
    }
}
