using clase_5;
using clase_4;
/*  EJERCICIO 1:
  Cuenta c1 = new Cuenta();
  c1.Depositar(100).Depositar(50).Extraer(120).Extraer(50);
  Cuenta c2 = new Cuenta();
  c2.Depositar(200).Depositar(800);
  new Cuenta().Depositar(20).Extraer(20);
  c2.Extraer(1000).Extraer(1);
  Console.WriteLine("\nDETALLE");
  Cuenta.ImprimirDetalle();
  */
  /*  EJERCICIO 2: 
  

new Cuenta();
new Cuenta();
List<Cuenta> cuentas = Cuenta.GetCuentas();
// se recuperó la lista de cuentas creadas
cuentas[0].Depositar(50);
// se depositó 50 en la primera cuenta de la lista devuelta
cuentas.RemoveAt(0);
Console.WriteLine("Tiene que dar 1:"+cuentas.Count);
// se borró un elemento de la lista devuelta
// pero la clase Cuenta sigue manteniendo todos
// los datos "La cuenta id: 1 tiene 50 de saldo"
cuentas = Cuenta.GetCuentas();
Console.WriteLine("Tendria que dar 2: "+cuentas.Count);
// se recupera nuevamente la lista de cuentas
cuentas[0].Extraer(30);
//se extrajo 30 de la cuenta id: 1 que tenía 50 de saldo
*/
/*  EJERCICIO 3: 
A)El primero funciona correctamente

class A {
static int s_a=0;
static A() {
s_a++;
}
public A() {
s_a++;
}
}

B)El segundo no anda ya que, el constructor estatico esta declarado como public y el constructor A se declaro sin nada delante y por defecto es private
class A {
static int s_a = 0;
public static A() {
s_a++;
}
A() {
s_a++;
}
}
c)
class A {
static int s_a = 0;
static A(int a) {// no se le puedo dar parametros a un constructor statico.
s_a=a;
}
A(int a) {
s_a = a;
}
}
D)
A a=new A(5);//no se puede acceder a su constructor, pero teoricamente fuera de eso todo andaria.
class A {
static int s_a = 0;
int a = 0;
static A() {
s_a = 30;
}
A(int a) {
s_a = a;
this.a = a;
}
}

E) Desde un constructor estatico esta trantando de modificar una variable no static.
class A {
static int s_a = 0;
int a = 0;
static A() {
a = 30;
}
A(int a) {
a = s_a;
}
}
F) Andaria todo, de nuevo esta private el constructor dinamico.
class A
{
static int s_a = 1;
int a = 0;
static A() => s_a += s_a;
public static A GetInstancia()
=> new A(1);
A(int a) => this.a = a + s_a;
}

G) Las constantes se resuelven antes que las statics, por esto te deja usar PI que es una constante.
class A
{
const double PI = 3.1416;//la intenta resolver antes el compilador, antes de ejecucion.
static double DoblePI = 2 * PI;
}
// H) Encambio, este no se puede
class B
{
static double PI = 3.1416;
const double DoblePI = 2*PI;//intenta resolver si tener PI declarado.
}
I) Esta todo correcto.
class A {
static readonly List<int> _lista;
static A() {
_lista = new List<int>();
}
public static void P(int i) {
_lista.Add(i);
}
}
J) Esta mal ya que intenta modificar desde un constructor no estatico la variable readonly.
class A {
static readonly List<int> _lista;
static A() {
_lista = new List<int>();
}
public static void P(List<int> li) {
_lista = li;
}
}
K) NU C PERO ANDA
A a=new A();
Console.WriteLine(a);
class A
{
static int[] vector = { 1, 2, 3 };
public int this[int i]
{
get { return vector[i]; }
}
}
J) NU C PERO NO ANDA
class A
{
static int[] vector = { 1, 2, 3 };
public static int this[int i]
{
get { return vector[i]; }
}
}
*/
/* EJERCICIO 5: 
class A
{
char c;
static string st;
void metodo1()//todo este metodo esta bien
{
st = "string";
c = 'A';
}
static void metodo2()
{
new ClaseA().c = 'a';//nose si esta escrito mal a proposito, pero la claseA no existe, si fuera solo A().c si se podria.
st = "st2";//esto esta bien
c = 'B';//no se puede asignar algo dinamico en un metodo statico.
new A().st = "otro string";// no se puede modificar la variable statica desde una instancia, aunque no este muy claro esta pasando eso.
}
}
*/
/*  EJERCICIO 6:
Matriz m=new Matriz(3,3);
 m[0,0] = 5.5;
 m[0,1]=6.6;
 m[0,2]=7.7;
 m[1,0]=8.8;
//  Console.WriteLine(m[0,0]);
//  Console.WriteLine(m[1,0]);
m.imprimir();
double[] v=m.DiagonalPrincipal;
foreach (double d in v)
{
  Console.WriteLine(d);
}
*/
/*  EJERCICIO 7:
Definir la clase Persona con las siguientes propiedades de lectura y escritura: Nombre de tipo
string, Sexo de tipo char, DNI de tipo int, y FechaNacimiento de tipo DateTime. Además
definir una propiedad de sólo lectura (calculada) Edad de tipo int. Definir un indizador de
lectura/escritura que permita acceder a las propiedades a través de un índice entero. Así, si p es un
objeto Persona, con p[0] se accede al nombre, p[1] al sexo p[2] al DNI, p[3] a la fecha de
nacimiento y p[4] a la edad. En caso de asignar p[4] simplemente el valor es descartado. Observar
que el tipo del indizador debe ser capaz almacenar valores de tipo int, char, DateTime y string

Persona p = new Persona();
p[0]="Pedro";
p[1]='M';
p[2]=22222;
p[3]=new DateTime(2002,06,28);

Console.WriteLine("Nombre {0},Sexo {1},DNI {2},Fecha de Nacimiento {3:dd/MM/yyyy},Edad {4}",p[0],p[1],p[2],p[3],p[4]);
*/
/*  EJERCICIO 8:


Persona p = new Persona();
p[0]="Pedro";
p[1]='M';
p[2]=22222;
p[3]=new DateTime(2002,06,28);
Persona p2 = new Persona();
p2[0]="Mario";
p2[1]='M';
p2[2]=22223;
p2[3]=new DateTime(2002,06,18);
Persona p3 = new Persona();
p3[0]="Pablo";
p3[1]='M';
p3[2]=22222;
p3[3]=new DateTime(2002,06,08);
ListaDePersonas lp = new ListaDePersonas();//se crea una instancia de la clase
lp.Agregar(p);// se le agrega p de tipo persona
lp.Agregar(p2);
lp.Agregar(p3);
Persona encontrado= p=lp[22222];//busca un dni de una persona y si existe se le asigna a la nueva persona.
Console.WriteLine(encontrado[0]);
List<string> imprimir= lp['P'];
foreach (string s in imprimir)
{
  Console.WriteLine("Nombres: "+s);
}
*/
/*  EJERCICIO 9: 
¿Cuál es el error en el siguiente programa?
El error es que dentro del set se esta asignado el valor al propiedad, no a la variable, por eso el uso de _ y eso esta bueno.
Auto a = new Auto();
a.Marca = "Ford";
Console.WriteLine(a.Marca);
class Auto
{
private string marca;
public string Marca
{
set
{
Marca = value;
}
get
{
return marca;
}
}
}

*/
/*  EJERCICIO 10: 
class A
{
private static int a;//CAMPO statico.
private static readonly int b;// campo statico solo lectura.
A() { }//cosntructor vacio.
public A(int i) : this() { }//constructor que recibe parametro y llama al constructor vacio.
static A() => b = 2;//constructor statico vacio que asigna 2 a b
int c;// campo privado
public static void A1() => a = 1;//metodo statico que se llama A1, le asigna 1 a a.
public int A1(int a) => A.a + a;//metodo dinamico que recibe a, 
public static int A2;//propiedad statica
static int A3 => 3; //propierda statica 
private int A4() => 4;// metodo de instancia
public int A5 { get => 5; }//propiedad de solo lectura 
int A6 { set => c = value; }//propiedad de solo escritura
public int A7 { get; set; }//propierda de lec/esc auto implementadas.
public int A8 { get; } = 8;//propiedad de solo lectura e inicializa con 8 la variable A8.
public int this[int i] => i;// indizador que devuelve i.
}
*/
/*  EJERCICIO 11: 
 ¿ Qué diferencia hay entre estas dos declaraciones?
 a) public int X = 3;// la primera es una declaracion que le asigna 3 a X
  y 
 b) public int X => 3// la segunda es una propiedad que devuelve 3.
*/