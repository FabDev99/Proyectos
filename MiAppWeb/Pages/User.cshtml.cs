using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace MiAppWeb.Pages
{
    public class UserModel : PageModel
    {
        public User User { get; set; }

        public async Task OnGetAsync()
        {
            using HttpClient client = new HttpClient
            {
                BaseAddress = new Uri("https://jsonplaceholder.typicode.com")
            };

            User = await client.GetFromJsonAsync<User>("users/4");
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Username { get; set; }
        public string? Email { get; set; }
    }
}