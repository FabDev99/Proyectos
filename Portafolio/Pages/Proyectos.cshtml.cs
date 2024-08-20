using Microsoft.AspNetCore.Mvc.RazorPages;
using Portafolio.Services; 
using Portafolio.Models; 
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Portafolio.Pages 
{
    public class ProyectosModel : PageModel
    {
        private readonly GitHubService _gitHubService;

        public ProyectosModel(GitHubService gitHubService)
        {
            _gitHubService = gitHubService;
        }

        public List<GitHubRepo> Repos { get; set; }

        public async Task OnGetAsync()
        {
            Repos = await _gitHubService.GetReposAsync("fabdev99");
        }
    }
}
