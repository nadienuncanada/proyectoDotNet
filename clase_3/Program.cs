/*
string marca = "Ford";
int modelo = 2000;
string st = string.Format("Es un {0} año {1}", marca, modelo);//marca seria 0 modelo seria 1.
Console.WriteLine(st);
int ancho = 30;
Console.WriteLine($"ancho = {ancho} y alto = {20}");

string marca = "Ford";
int modelo = 2000;
Console.WriteLine($"Es un {marca,-7} año {modelo}");// el ,7 hace que ocupe mas espacios, con espacios vacios.
Console.WriteLine($"Es un {"Nissan",7} año {2020}");// y con -7 hace espacios para para la izquierda.
double r = 2.417;
Console.WriteLine($"Valor = {r:0.0}");//es el :0:2 etc de pascal.
Console.WriteLine($"Valor = {r:0.00}");//mayor o menos precision etc.REDONDEA.

DateTime fecha = new DateTime(1492,10,12,15,5,6,325);
Console.WriteLine("a) {0}", fecha);//normal
Console.WriteLine("b) {0:d}", fecha);//corto
Console.WriteLine("c) {0:D}", fecha);//largo
Console.WriteLine($"d) {fecha:dddd d 'del mes de' MMMM 'del año' yyyy}");//perzonalizado
Console.WriteLine($"e) {fecha:t}");
Console.WriteLine("f) {0:hh:mm:s fff}",fecha); 

List<int> lista = new List<int>() { 10, 20, 30, 30, 40 };
lista.Add(55);//agrega ese valor al final
lista.Remove(30);//elimina el valor ingresado
lista.RemoveAt(1);//elimina en esa posicion
lista.Insert(2,33);//inserta en posicion y el valor a agregar.
for (int i = 0; i < lista.Count; i++)
{
 Console.WriteLine(lista[i]);
}

List<int> lista = new List<int>() { 10, 20, 30, 40 };
int[] vector = new int[] { 31, 32, 33 };
lista.InsertRange(3,vector);
for (int i = 0; i < lista.Count; i++)
{
 Console.WriteLine(lista[i]);
}
*/
double[]? vector = new double[10];
Procesar(vector, 1, 1);
Procesar(null,1,1);//no es error sintactico, por eso es un error en el momento de correr el programa.
void Procesar(double[]? v, int i, int c){
try
 {
 c = c + 10;
 v[i] = 1000 / c;
 Console.WriteLine(v[i]);
 }
 catch (Exception e)
 {
 Console.WriteLine(e.Message);
 }
}