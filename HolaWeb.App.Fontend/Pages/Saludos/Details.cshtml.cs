using HolaWeb.App.Dominio;
using HolaWeb.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HolaWeb.App.Fontend.Pages
{
    public class DetailsModel : PageModel
    {
        private readonly IRepositorioSaludos repositorioSaludos;
        public Saludo Saludo { get; set; }
        public DetailsModel(IRepositorioSaludos repositorioSaludos)
        {
            this.repositorioSaludos = repositorioSaludos;
        }


        public IActionResult OnGet(int saludoId)
        {
            //Console.WriteLine(saludoId);
            Saludo = repositorioSaludos.GetSaludoPorId(saludoId);
            if (Saludo == null)
            {
                //Console.WriteLine("No lo encontro");
                return RedirectToPage("./NoFound");
            }
            else
            {
                //Console.WriteLine("Sí Lo encontro");
                return Page();
            }
        }
    }
}
