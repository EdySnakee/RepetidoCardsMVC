using VistaParcialTarjetas.Models;

namespace VistaParcialTarjetas.Servicios
{

    public interface IRepositoriosPropiedades
    {
        List<PropiedadDTO> ObtenerPropiedad();
    }
    public class RepositoriosPropiedades: IRepositoriosPropiedades
    {
        public List<PropiedadDTO> ObtenerPropiedad()
        {
            return new List<PropiedadDTO>() {
                new PropiedadDTO
            {
                Titulo = "Casa 1",
                Descripcion = "calle42 xxx",
                Link = "/Home/Index",
                imgUrl = "/img/i-3.jpg"
            },

                new PropiedadDTO
            {
                Titulo = "Casa 2",
                Descripcion = "calle42 xxx",
                Link = "",
                imgUrl = "/img/i-3.jpg"
            },

                new PropiedadDTO
            {
                Titulo = "Casa 3",
                Descripcion = "calle42 xxx",
                Link = "",
                imgUrl = "/img/i-3.jpg"
            },

                new PropiedadDTO
            {
                Titulo = "Casa 4",
                Descripcion = "calle42 xxx",
                Link = "",
                imgUrl = "/img/i-3.jpg"
            },

                new PropiedadDTO
            {
                Titulo = "Casa 5",
                Descripcion = "calle42 xxx",
                Link = "",
                imgUrl = "/img/i-3.jpg"
            },
                new PropiedadDTO
            {
                Titulo = "Casa 6",
                Descripcion = "calle42 xxx",
                Link = "/Home/Index",
                imgUrl = "/img/i-3.jpg"
            },
                new PropiedadDTO
            {
                Titulo = "Casa 7",
                Descripcion = "calle42 xxx",
                Link = "/Home/Index",
                imgUrl = "/img/i-3.jpg"
            },

                new PropiedadDTO
            {
                Titulo = "Casa 8",
                Descripcion = "calle42 xxx",
                Link = "",
                imgUrl = "/img/i-3.jpg"
            },

                new PropiedadDTO
            {
                Titulo = "Casa 9",
                Descripcion = "calle42 xxx",
                Link = "",
                imgUrl = "/img/i-3.jpg"
            },

                new PropiedadDTO
            {
                Titulo = "Casa 10",
                Descripcion = "calle42 xxx",
                Link = "",
                imgUrl = "/img/i-3.jpg"
            },

                new PropiedadDTO
            {
                Titulo = "Casa 11",
                Descripcion = "calle42 xxx",
                Link = "",
                imgUrl = "/img/i-3.jpg"
            },
                new PropiedadDTO
            {
                Titulo = "Casa 12",
                Descripcion = "calle42 xxx",
                Link = "/Home/Index",
                imgUrl = "/img/i-3.jpg"
            },
            };
        }

    }
}
