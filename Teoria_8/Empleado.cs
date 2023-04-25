namespace Teoria_8;

class Empleado:IComparable
{
public int Legajo { get; set; }
public string Nombre { get; private set; }
public Empleado(string nombre)
{
Nombre = nombre;
}
public int CompareTo(object? obj)
{
int result = 0;
if (obj is Empleado)
{
string nombre = ((Empleado)obj).Nombre;
result = this.Nombre.CompareTo(nombre);
}
return result;
}
public void Imprimir(){
Console.Write($"Soy el empleado {Nombre}");
Console.WriteLine($", Legajo: {Legajo}" );
}
}