using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Numerics;
using System.Web;
 
namespace MiAppWeb.Pages;
 
public class CalculatorModel : PageModel
{
    private readonly ILogger<CalculatorModel> _logger;
    public CalculatorModel(ILogger<CalculatorModel> logger)
    {
        _logger = logger;
    }
 
    public string Message { get; private set; } = "PageModel in C#";
    [BindProperty]
 
    public double Fnumber { get; set; } = 0;
    [BindProperty]
 
    public double Snumber { get; set; } = 0;
 
    public double Result { get; private set; } = 0;
 
    public void OnGet()
    {
        Message += $"Server time is {DateTime.Now}";
    }
 
    public void OnPost()
    {
        Message += $"Server time is {DateTime.Now}";
        Result = Fnumber + Snumber;
    }
 
    public void OnPostAdd()
    {
        Result = Fnumber + Snumber;
    }
    public void OnPostSub()
    {
        Result = Fnumber - Snumber;
    }
    public void OnPostMul()
    {
        Result = Fnumber * Snumber;
    }
    public void OnPostDiv()
    {
        if (Snumber == 0)
        {
            Message += $"No se puede dividir entre cero.";
        } else
        {
            Result = Fnumber / Snumber;
        }
       
    }
}