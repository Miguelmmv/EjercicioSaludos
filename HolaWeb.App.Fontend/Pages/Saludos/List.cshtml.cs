using HolaWeb.App.Dominio;
using HolaWeb.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HolaWeb.App.Fontend.Pages
{
    public class ListModel : PageModel
    {
        //private String[] saludos ={"Buenos días", "Buenas tardes", "Buenas noches", "Hasta mañana"};
        //public List<string> ListaSaludos {get;set;}
        private readonly IRepositorioSaludos repositorioSaludos;

        public IEnumerable<Saludo> Saludos {get;set;}
        [BindProperty(SupportsGet=true)]
        public string FiltroBusqueda { get; set; }
        public ListModel(IRepositorioSaludos repositorioSaludos)
        {
            this.repositorioSaludos = repositorioSaludos;
        }

        public void OnGet(string filtroBusqueda)
        {
            // ListaSaludos = new List<string>();
            // ListaSaludos.AddRange(saludos);
            // Saludos = repositorioSaludos.GetAll();
            FiltroBusqueda=filtroBusqueda;
            Saludos = repositorioSaludos.GetSaludosPorFiltro(filtroBusqueda);
        }
    }
}
