using System.Collections.Generic;
using Web.App.Dominio;

namespace Web.App.Persistencia.AppRepositorios
{

    public class RepositorioIdioma : IRepositorioIdioma
    {

        List<Idioma> idiomas;

        public RepositorioIdioma()
        {
            idiomas = new List<Idioma>()
{

new Idioma{Id=1,Ingles="Programming",Frances="Programmation",Portugues="Programação"},
new Idioma{Id=2,Ingles="Project",Frances="Projet",Portugues="Projeto"}
};

        }

        public IEnumerable<Idioma> GetAll()
        {
            return idiomas;
        }


    }

}