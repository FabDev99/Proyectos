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
                // Aquí puedes enviar el mensaje por correo electrónico o guardarlo en una base de datos
                // Por simplicidad, solo marcaremos el formulario como enviado.

                IsSent = true;

                // Puedes añadir lógica para enviar el correo o almacenar el mensaje aquí.

                // Ejemplo de mensaje de éxito:
                // TempData["SuccessMessage"] = "Gracias por tu mensaje. Nos pondremos en contacto contigo pronto.";
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
