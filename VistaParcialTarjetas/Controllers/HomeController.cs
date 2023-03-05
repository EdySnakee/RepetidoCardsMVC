using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VistaParcialTarjetas.Models;
using VistaParcialTarjetas.Servicios;

namespace VistaParcialTarjetas.Controllers 
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepositoriosPropiedades repositorioPropiedades;

        public HomeController(ILogger<HomeController> logger, IRepositoriosPropiedades repositorioPropiedades)
        {
            _logger = logger;
            this.repositorioPropiedades = repositorioPropiedades;
        }



        //Modelo 1
        public IActionResult Index()
        {
            List<Propiedadess> propiedades = new List<Propiedadess>()
            {
                new Propiedadess {ID=1,Nombre="Propiedad1",Precio=33000,Descripcion="Bonita casa Roja", ImagenURL="/img/i-3.jpg" },
                new Propiedadess {ID=2,Nombre="Propiedad2",Precio=43000,Descripcion="Bonita casa azul", ImagenURL="/img/i-3.jpg" },
                new Propiedadess {ID=3,Nombre="Propiedad3",Precio=53000,Descripcion="Bonita casa ", ImagenURL="/img/i-3.jpg" },
                new Propiedadess {ID=4,Nombre="Propiedad4",Precio=63000,Descripcion="Bonita casa viol", ImagenURL="/img/i-3.jpg" },
                new Propiedadess {ID=5,Nombre="Propiedad5",Precio=73000,Descripcion="Bonita casa ", ImagenURL="/img/i-3.jpg" },
                new Propiedadess {ID=6,Nombre="Propiedad6",Precio=83000,Descripcion="Bonita casa cian", ImagenURL="/img/i-3.jpg" },
                new Propiedadess {ID=7,Nombre="Propiedad1",Precio=93000,Descripcion="Bonita casa Roja1", ImagenURL="/img/i-3.jpg" },
                new Propiedadess {ID=8,Nombre="Propiedad2",Precio=103000,Descripcion="Bonita casa azul1", ImagenURL="/img/i-3.jpg" },
                new Propiedadess {ID=9,Nombre="Propiedad3",Precio=11000,Descripcion="Bonita casa verde1", ImagenURL="/img/i-3.jpg"},
                new Propiedadess {ID=10,Nombre="Propiedad4",Precio=12000,Descripcion="Bonita casa violeta1", ImagenURL="/img/i-3.jpg"},
                new Propiedadess {ID=11,Nombre="Propiedad5",Precio=13000,Descripcion="Bonita casa magenta1", ImagenURL="/img/i-3.jpg"},
                new Propiedadess {ID=12,Nombre="Propiedad6",Precio=14000,Descripcion="Bonita casa cian1", ImagenURL="/img/i-3.jpg"}
            };

            return View(propiedades);

        }

     
        //Modelo 2

        public IActionResult Privacy()
        {
            var propiedades = repositorioPropiedades.ObtenerPropiedad().Take(6).ToList();
            var modelo = new HomePropViewModel() { Propiedades = propiedades };
            return View(modelo);
        }

        public IActionResult Proyectos()
        {
            var proyectos = repositorioPropiedades.ObtenerPropiedad();
            return View(proyectos);        
        }






        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}