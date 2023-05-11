using Microsoft.AspNetCore.Mvc;

namespace tp04.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.DiccionarioEquipos = Equipos.EquiposIndumentaria;
        return View();
    }
    public IActionResult SelectIndumentaria()
    {
        ViewBag.Teams = Equipos.ListaEquipos;
        ViewBag.Medias = Equipos.ListaMedias;
        ViewBag.Remeras = Equipos.ListaRemeras;
        ViewBag.Pantalones = Equipos.ListaPantalones;
        return View();
    }
    public IActionResult GuardarIndumentaria(int Equipo, int Medias, int Pantalon, int Remera)
    {
      Indumentaria UnaIndumentaria = new Indumentaria(Equipos.ListaMedias[Medias-1],Equipos.ListaPantalones[Pantalon-1],Equipos.ListaRemeras[Remera-1]);
      ViewBag.verificacion = Equipos.IngresarIndumentaria(Equipos.ListaEquipos[Equipo-1],UnaIndumentaria);
      ViewBag.DiccionarioEquipos = Equipos.EquiposIndumentaria;
      if (ViewBag.verificacion == false)return View("SelectIndumentaria");
      else return View("Index");
    }
    
}
