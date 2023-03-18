using System.Text;
/*object obj=7.3;
Console.WriteLine(obj.GetType());
obj="casa";
Console.WriteLine(obj);
obj=4;
Console.WriteLine((int)obj+1);
object obj="cas"+5+1;
Console.WriteLine(obj.GetType());
Console.WriteLine(obj);
char c1= 'a';
char c2= 'a';
Console.Write(c1==c2);
object o1= 'a';
object o2= 'a';
Console.Write(o1==o2);
object oo1= 'a';
object oo2= oo1;
Console.Write(oo1==oo2);

int cantidad=20;
int[] vec1= new int[cantidad];
*/
/* EJERCICIO 1:
1) Qué líneas del siguiente código provocan conversiones boxing y unboxing.
Las conversiones boxing y unboxing permiten 
asignar variables de tipo de valor a variables de tipo 
de referencia y viceversa
char c1 = 'A';
string st1 = "A";
object o1 = c1;//boxing/ variable de tipo valor se asigna una de tipo referencia
object o2 = st1;// NO HAY BOXING YA QUE LAS STRINGS SON REFERENCIAS
char c2 = (char)o1;// utiliza unboxing
string st2 = (string)o2;//no es unboxing es referencia a referencia, las strings funcionan DISTINTAS ACORDATE. son punteros a el "texto" en memoria.
*/
/* EJERCICIO 2:
Sea el siguiente código:
object o1 = "A";
object o2 = o1;
o2 = "Z";
Console.WriteLine(o1 + " " + o2);
El tipo object es un tipo referencia, por lo tanto luego de la sentencia o2 = o1 ambas
variables están apuntando a la misma dirección. ¿Cómo explica entonces que el resultado en la
consola no sea “Z Z”?
PORQUE a o1 queda apuntando a A pero o2 cambia de apuntar a A a tener un puntero nuevo con el valor Z
*/
/* EJERCICIO 3:
Analizar la siguiente porción de código para calcular la sumatoria de 1 a 10. ¿Cuál es el error?
¿Qué hace realmente?
int sum = 0;
int i = 1;
while (i <= 10);
{
sum += i++;
}
El erro es sintactico, y si es la sumatoria del 1 al 10.

int sum = 0;
int i = 1;
while (i <= 10)
{
sum += i++;
Console.WriteLine(sum+" "+i);
}
*/
/* EJERCICIO 4:
¿Cuál es la salida por consola si no se pasan argumentos por la línea de comandos?
Console.WriteLine(args == null);// es distinto de null
Console.WriteLine(args.Length);// es 0 ya que es un vector sin inicializar que tira 0
Console.WriteLine(args.GetType());
*/
/* EJERCICIO 5: 
 ¿Qué hace la instrucción
int[]? vector = new int[0];
crea un vector de 0 elementos(inservible) que acepta valor null.
Console.WriteLine(vector=null);//te deja ponerle null
¿asigna a la variable vector el valor null? PERO NO SE LE ASIGNA SOLO.
*/
/* EJERCICIO 6:
Determinar qué hace el siguiente programa y explicar qué sucede si no se pasan parámetros
cuando se invoca desde la línea de comandos.
Console.WriteLine("¡Hola {0}!", args[0]);
si no se pasan parametros tira error, si se le pasa 1 parametro te dice hola + el parametro pasado, y esto acepta 2 parametros:
Console.WriteLine("¡Hola {0} {1}!", args[0],args[1]); 
*/
/*  EJERCICIO 7:
7. Analizar el siguiente código. ¿Qué líneas producen error de compilación y por qué?
char c;
char? c2;
string? st;
c = "";//error string a char
c = '';
c = null;//error null a char
c2 = null;
c2 = (65 as char?);
st = "";
st = '';//no tira error porque string acepta chars pero talvez lo restalte
st = null;//tendria que dejar 
st = (char)65;// no deja de int a char de esta manera
st = (string)65;// no deja pasar de int a string
st = 47.89.ToString();//nose bien que hace

string? st;
st = 47.89.ToString();
Console.WriteLine(st);
Console.WriteLine(st.GetType());
char? c1;
char? c2;
int? a=65;
c1=(char) 65;
c2=(a as char?);
Console.WriteLine(c1);
Console.WriteLine(c2);
*/
/* EJERCICIO 8:
Escribir un programa que reciba una lista de nombres como parámetro e imprima por consola un
saludo personalizado para cada uno de ellos.
a) utilizando la sentencia for
b) utilizando la sentencia foreach
 for (int i=0;i<args.Length;i++){
    Console.WriteLine("Hola "+ args[i] +" eres genial!");
 }
 Console.WriteLine("----------------------------------");
 foreach(string st in args){
   Console.WriteLine("Hola "+ st +" eres genial!");
 }
*/
/* EJERCICIO 9:
Investigar acerca de la clase StringBuilder del espacio de nombre System.Text ¿En qué
circunstancias es preferible utilizar StringBuilder en lugar de utilizar string? Implementar
un caso de ejemplo en el que el rendimiento sea claramente superior utilizando
StringBuilder en lugar de string y otro en el que no.
 El string builder se utiliza cuando se va a trabajar sobre una misma string agregandole o modificandole valores a la misma, ya que una string normal cada vez que se le hace esto se crea una nueva string en memoria y se le asigna un puntero a la variable string. Lo cual lo hace muy ineficiente.
string s=" ";
for(int i=0;i<5000;i++){
  s=s+i;
}
Console.WriteLine(s);
StringBuilder sb=new StringBuilder("0");
 Console.WriteLine("----------------------------------");

for(int i=0;i<5000;i++){
  sb.Append(i);

}
Console.WriteLine(sb);
*/
/* EJERCICIO 10: 
  Investigar sobre el tipo DateTime y usarlo para medir el tiempo de ejecución de los algoritmos
implementados en el ejercicio anterior
Declaramos un DateTime antes y despues de la ejecuion, luego hacemos la resta de estos 2 y lo asignamos en un TimeSpan donde despues lo imprimimos.

DateTime actual=DateTime.Now;
string s=" ";
for(int i=0;i<99999;i++){
  s=s+i;
}
DateTime paso=DateTime.Now;
TimeSpan p=(paso-actual);
Console.WriteLine(s);
DateTime actual2=DateTime.Now;
StringBuilder sb=new StringBuilder("0");
 Console.WriteLine("----------------------------------");

for(int i=0;i<99999;i++){
  sb.Append(i);

}
DateTime paso2=DateTime.Now;
TimeSpan p2=(paso2-actual2);
Console.WriteLine(sb);
Console.WriteLine("Tiempo String: "+p);
Console.WriteLine("Tiempo StringBuilder: "+p2);
*/
/*  EJERCICIO 11:
¿Para qué sirve el método Split de la clase string? Usarlo para escribir en la consola todas
las palabras (una por línea) de una frase ingresada por consola por el usuario

 foreach(string s in args[0].Split(' ')){
  Console.WriteLine(s);
}
// se le tiene que mandar dotnet run "Hola que tal"
*/
/* EJERCICIO 12:
. Comprobar el funcionamiento del siguiente programa y dibujar el estado de la pila y la memoria
heap cuando la ejecución alcanza los puntos indicados (comentarios en el código)
using System.Text;

 En la primera parte todos derivan de v[0] osea todos  valen .net(tienen un mismo puntero a el valor .net), luego se modifica el v[5], insertandole Framwork, lo que hace que todas se vean modificadas ya que comparten el valor.
 Luego crea un new v[5], lo que hace que cambie solo esa y el resto quede igual.
object[] v = new object[10];
v[0] = new StringBuilder("Net");
for (int i = 1; i < 10; i++)
{
v[i] = v[i - 1];
}
(v[5] as StringBuilder).Insert(0, "Framework .");
foreach (StringBuilder s in v)
Console.WriteLine(s);
Console.WriteLine("--------------------------------");
//dibujar el estado de la pila y la mem. heap
//en este punto de la ejecución
v[5] = new StringBuilder("CSharp");
foreach (StringBuilder s in v)
Console.WriteLine(s);
//dibujar el estado de la pila y la mem. heap
//en este punto de la ejecución
*/
/* EJERCICIO 13: 
Definir el tipo de datos enumerativo llamado Meses y utilizarlo para:
a) Imprimir en la consola el nombre de cada uno de los meses en orden inverso (diciembre,
noviembre, octubre …, enero)
c) Solicitar al usuario que ingrese un texto y responder si el texto tipeado corresponde al
nombre de un mes
Nota: en todos los casos utilizar un for iterando sobre una variable de tipo Meses

for(Meses m= Meses.diciembre;m>=Meses.enero;m--){
  Console.Write(m+" ");
}
Boolean ok=false;
Console.WriteLine("Ingrese Mes: ");
String mes=Console.ReadLine();
for(Meses a=Meses.enero;a<=Meses.diciembre;a++){ CONSULTAR COMO COMPARAR
  if(mes=a){
    ok=true;
  }
}
Console.WriteLine(ok);
enum Meses{
  enero, febrero, marzo, abril, mayo, junio, julio, agosto, septiembre, octubre, nomviembre, diciembre
}
*/
/*  EJERCICIO 14: 
 Implementar un programa que muestre todos los números primos entre 1 y un número natural
dado (pasado al programa como argumento por la línea de comandos). Definir el método bool
EsPrimo(int n) que devuelve true sólo si n es primo. Esta función debe comprobar si n es
divisible por algún número entero entre 2 y la raíz cuadrada de n. (Nota: Math.Sqrt(d)
devuelve la raíz cuadrada de d)

int Valor=int.Parse(args[0]);//100;
for(int i=1;i<=Valor;i++){
  if(EsPrimo(i)){
    Console.WriteLine(i);
  }
}
bool EsPrimo(int n){
  for(int i=2;i<=Math.Sqrt(n);i++){
    if(n%i==0)
      return false;
  }
  return true;
}
*/
/*EJERCICIO 15: . Escribir una función (método int Fib(int n)) que calcule el término n de la serie de
Fibonacci.
Fib(n) = 1, si n <=2
Fib(n) = Fib(n-1) + Fib(n-2), si n > 2

Console.WriteLine("Ingrese Valor: ");
int n=int.Parse(Console.ReadLine());
int Fib(int n){
  if(n<=2)
    return 1;
  else
    return (Fib(n-1)+Fib(n-2));
}
Console.WriteLine(Fib(n));
*/
/* EJERCICIO 16:
  . Escribir una función (método int Fac(int n)) que calcule el factorial de un número n
pasado al programa como parámetro por la línea de comando
a) Definiendo una función no recursiva
b) Definiendo una función recursiva
c) idem a b) pero con expression-bodied methods (Tip: utilizar el operador condicional
ternario)
Console.WriteLine(FacR(5));
int Fac(int n){
  int m=1;
  for(int i=1;i<=n;i++){
    m*=i;
  }
 return (m);
}
int FacR(int n){
 if(n<=1)
 return 1;
 else
   return FacR(n-1)*n;
}
int FacR(int n)=> n<=1? 1:FacR(n-1)*n;
*/
/* EJERCICIO 17:
 Ídem. al ejercicio 16.a) y 16.b) pero devolviendo el resultado en un parámetro de salida
void Fac(int n, out int f)


  int f;
void Fac(int n,out int f){
  int m=1;
  for(int i=1;i<=n;i++){
    m*=i;
  }
  f=m;
}
Fac(int.Parse((args[0])),out f);
Console.WriteLine(f);

int f;
void Fac(int n,out int f){
  if(n<=1)
  f=1;
 else
   Fac(n-1*n,out f);
}
Fac(int.Parse((args[0])),out f);
Console.WriteLine(f);
*/
/* EJERCICIO 18:
 Codificar el método Swap que recibe 2 parámetros enteros e intercambia sus valores. El cambio
debe apreciarse en el método invocador.

 void Swap(ref int a,ref int b){
  int c=a;
  a=b;
  b=c;
 }
 int a=5;
 int b=10;
 Swap(ref a,ref b);
 Console.WriteLine(a+" " +b);
 */
 /* EJERCICIO 19:
 Codificar el método Imprimir para que el siguiente código produzca la salida por consola que
se observa. Considerar que el usuario del método Imprimir podría querer más adelante
imprimir otros datos, posiblemente de otros tipos pasando una cantidad distinta de parámetros
cada vez que invoque el metodo

 
 void Imprimir(params object []list){
  for (int i=0;i<list.Length;i++){
    Console.Write(list[i]+ " ");
  }
 }
 Imprimir(1,2,3,4,"hola",5);
*/