using System.Collections.Generic;
using Web.App.Dominio;

namespace Web.App.Persistencia.AppRepositorios       
{

public interface IRepositorioIdioma{
IEnumerable<Idioma> GetAll();

}

}