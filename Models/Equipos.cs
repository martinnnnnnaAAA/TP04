using System;
static class Equipos
{
public static List<string> ListaEquipos {get; private set;} = new List<string> {"Boca unidos","Almagro","Sacachispas","Chicago","Ferro"};
public static List<string> ListaMedias {get; private set;} = new List<string> {"Medias1.PNG","Medias2.PNG","Medias3.PNG","Medias4.PNG","Medias5.PNG"};
public static List<string> ListaPantalones {get; private set;} = new List<string> {"Pantalon1.PNG","Pantalon2.PNG","Pantalon3.PNG","Pantalon4.PNG","Pantalon5.PNG"};
public static List<string> ListaRemeras {get; private set;} = new List<string> {"Remeras1.PNG","Remeras2.PNG","Remeras3.PNG","Remeras4.PNG","Remeras5.PNG"};
public static Dictionary<string, Indumentaria> EquiposIndumentaria {get; private set;} = new Dictionary<string, Indumentaria>();

public static bool IngresarIndumentaria(string EquipoSeleccionado, Indumentaria item)
{
if (EquiposIndumentaria.Keys.Contains(EquipoSeleccionado)){
return false;
} else
EquiposIndumentaria.Add(EquipoSeleccionado,item);
return true;
}
}