namespace clase_5;
class ListaDePersonas
{
 private List<Persona> lista= new List<Persona>();
public void Agregar(Persona p)
{
  lista.Add(p);
}
public Persona this[int i]{
  get{
  Persona pEncontrada = lista.FirstOrDefault(p => p.DNI == i);
  if (pEncontrada == null)
    return null;
  else
    return pEncontrada;
  }
}
public List<string> this[char c]{
  get{
  List<string> nombres=new List<string>();
  foreach (Persona pe in lista)
  {
    if(pe.Nombre[0]==c)
      nombres.Add(pe.Nombre);
  }
  return nombres;
  }
}
}
