//ejer1 
/*{
      DateTime dat = DateTime.Now;
      Console.WriteLine("The time: {0:d} at {0:t}", dat);
      TimeZoneInfo tz = TimeZoneInfo.Local;
      Console.WriteLine("The time zone: {0}\n",
                        tz.IsDaylightSavingTime(dat) ?
                           tz.DaylightName : tz.StandardName);
      Console.Write("Press <Enter> to exit... ");
      while (Console.ReadKey().Key != ConsoleKey.Enter) {}
   }
   
   {
      ConsoleKeyInfo cki;
      // Prevent example from ending if CTL+C is pressed.
      Console.TreatControlCAsInput = true;

      Console.WriteLine("Press any combination of CTL, ALT, and SHIFT, and a console key.");
      Console.WriteLine("Press the Escape (Esc) key to quit: \n");
      do
      {
         cki = Console.ReadKey();
         Console.Write(" --- You pressed ");
         if((cki.Modifiers & ConsoleModifiers.Alt) != 0) Console.Write("ALT+");
         if((cki.Modifiers & ConsoleModifiers.Shift) != 0) Console.Write("SHIFT+");
         if((cki.Modifiers & ConsoleModifiers.Control) != 0) Console.Write("CTL+");
         Console.WriteLine(cki.Key.ToString());
       } while (cki.Key != ConsoleKey.Escape);
    }
    */
/* EJERCICIO 1: 
Consultar en la documentación de Microsoft y responder cuál es la diferencia entre los métodos
WriteLine() y Write() de la clase System.Console ¿Cómo funciona el método ReadKey() de
la misma clase? Escribir un programa que imprima en la consola la frase “Hola Mundo”
haciendo una pausa entre palabra y palabra esperando a que el usuario presione una tecla para
continuar Tip: usar los métodos ReadKey() y Write() de la clase System.Console.

Console.Write("Hola");
Console.ReadKey(true);
Console.Write(" Mundo");
*/
/*EJERCICIO 2: 
Investigar por las secuencias de escape \n, \t , \" y \\. Escribir un programa que las utilice
para imprimir distintos mensajes en la consola.

Console.Write("Hola \n Mundo");
Console.Write("Hola \t Mundo");
Console.Write("Hola \" Mundo");
Console.Write("Hola \\ Mundo");
*/
/*EJERCICIO 3: El carácter @ delante de un string desactiva los códigos de escape. Probar el siguiente
fragmento de código, eliminar el carácter @ y utilizar las secuencias de escape necesarias para
que el programa siga funcionando de igual manera
*/
/*
string st = "c:\\windows\\system";
Console.WriteLine(st);
*/
/*EJERCICIO 4: Escribir un programa que solicite al usuario ingresar su nombre e imprima en la consola un
saludo personalizado utilizando ese nombre o la frase “Hola mundo” si el usuario ingresó una
línea en blanco. Para ingresar un string desde el teclado utilizar Console.ReadLine()

Console.Write("Ingrese su nombre:");
string a=Console.ReadLine();
Console.Write("Hola Mundo "+ a);
*/
/* EJERCICIO 5: Idem. al ejercicio anterior salvo que se imprimirá un mensaje de saludo diferente según sea el
nombre ingresado por el usuario. Así para “Juan” debe imprimir “¡Hola amigo!”, para “María”
debe imprimir “Buen día señora”, para “Alberto” debe imprimir “Hola Alberto”. En otro caso,
debe imprimir “Buen día ” seguido del nombre ingresado o “¡Buen día mundo!” si se ha
ingresado una línea vacía.

a) utilizando if ... else if
b) utilizando switch

A)
Console.Write("Ingrese su nombre:");
string a=Console.ReadLine();
if(a == "Juan"){
  Console.Write("Hola Amigo!");
}
else if(a == "Maria"){
  Console.Write("Buen dia seniora");
}
else if(a == "Alberto"){
  Console.Write("Hola Alberto");
}
else if(string.IsNullOrEmpty(a)){ //tambien sirve poner ""
  Console.Write("Buen dia mundo!");
}
else {
   Console.Write("Buen dia"+ a);
}

B)
Console.Write("Ingrese su nombre:");
string a=Console.ReadLine();
switch(a){
  case "Juan":
   Console.Write("Hola Amigo!");
   break;

  case "Maria":
   Console.Write("Buen dia seniora");
   break;

  case "Alberto":
   Console.Write("Hola Alberto");
   break;

  case "":
   Console.Write("Buen dia mundo!");
   break;
  default:
   Console.Write("Buen dia"+ a);
   break;
}
*/
/*EJERCICIO 6: 
Utilizar Console.ReadLine() para leer líneas de texto (secuencia de caracteres que finaliza al
presionar <ENTER>) por la consola. Por cada línea leída se debe imprimir la cantidad de
caracteres de la misma. El programa termina al ingresar la cadena vacía. (si st es una variable
de tipo string, entonces st.Length devuelve la cantidad de caracteres del string).

   Console.Write("Ingrese la cadena: ");
   string a=Console.ReadLine();
   while(string.IsNullOrEmpty(a)==false){
      Console.WriteLine("Caracteres: "+a.Length);
      Console.Write("Ingrese la cadena: ");
      a=Console.ReadLine();
   }
*/
/*EJERCICIO 7: Qué hace la instrucción Console.WriteLine("100".Length); ? 
Te da que la longitud es de 3.
*/
/* EJERCICIO 8: Sea st una variable de tipo string correctamente declarada. ¿Es válida la siguiente instrucción:
string st;
Console.WriteLine(st=Console.ReadLine());
*/
/*EJERCICIO 9: Escribir un programa que lea dos palabras separadas por un blanco que terminan con <ENTER>,
y determinar si son simétricas (Ej: 'abbccd' y 'dccbba' son simétricas).
Tip: si st es un string, entonces st[0] devuelve el primer carácter de st, y st[st.Length-1]
devuelve el último carácter de st.

String a;
String b;
Console.WriteLine("Ingrese su primera cadena:");
a=Console.ReadLine();
Console.WriteLine("Ingrese su segunda cadena:");
b=Console.ReadLine();
bool ok=true;
int i=0;
if(a.Length==b.Length){
   while (i<a.Length && ok){
      if((a[i])!=(b[b.Length-i-1])){
        ok=false;
      }
      else{
         i++;
      }
   } 
}
else{
   ok=false;
}
if(ok){
 Console.Write("Son simetricas");
}
else{
 Console.Write("No son simetricas");
}
*/
/*EJERCICIO 10: Escribir un programa que imprima en la consola todos los números que sean múltiplos de 17 o
de 29 comprendidos entre 1 y 1000

for(int i=1;i<1000;i++){
   if(i%17==0){
      Console.WriteLine(i+" Es multiplo de 17");
   }
   else if(i%29==0){
      Console.WriteLine(i+" Es multiplo de 29");
   }
}
*/
/*EJERCICIO 11:
   Comprobar el funcionamiento del siguiente fragmento de código, analizar el resultado y
contestar las preguntas.

Console.WriteLine("10/3 = " + 10 / 3);
Console.WriteLine("10.0/3 = " + 10.0 / 3);
Console.WriteLine("10/3.0 = " + 10 / 3.0);
int a = 10, b = 3;
Console.WriteLine("Si a y b son variables enteras, si a=10 y b=3");
Console.WriteLine("entonces a/b = " + a / b);
double c = 3;
Console.WriteLine("Si c es una variable double, c=3");
Console.WriteLine("entonces a/c = " + a / c);

¿Qué se puede concluir respecto del operador de división “/” ?
QUE SI HAY UN DOUBLE EL RESULTADO ES EN DOUBLE SI ES TODOS INT EL RESULTADO ES EN INT
¿Cómo funciona el operador + entre un string y un dato numérico?
AGREGA A LA STRING EL DATO NUMERICO
*/
/*EJERCICIO 12: Escribir un programa que imprima todos los divisores de un número entero ingresado desde la
consola. Para obtener el entero desde un string st utilizar int.Parse(st).

String a;
Console.WriteLine("Ingrese el numero: ");
a=Console.ReadLine();
for(int i=int.Parse(a);i>0;i--){
   if(int.Parse(a)%i==0){
      Console.WriteLine(a+" Es divisible por: "+i);
   }
}
*/
/*EJERCICIO 13: Escribir un programa que calcule la suma de dos números reales introducidos por teclado y
muestre el resultado en la consola (utilizar double.Parse(st) para obtener el valor double a
partir del string st.

String a;
String b;
Console.WriteLine("Ingrese primer valor a sumar: ");
a=Console.ReadLine();
Console.WriteLine("Ingrese segundo valor a sumar: ");
b=Console.ReadLine();
Console.WriteLine("El valor de la suma es: "+(double.Parse(a)+double.Parse(b)));
*/
/*EJERCICIO 14: Escribir un programa que multiplique por 365 el número entero ingresado por el usuario desde
la consola. El resultado debe imprimirse en la consola dígito por dígito, separado por un espacio
comenzando por el dígito menos significativo al más significativo.

String a;
Console.WriteLine("Ingrese el valor: ");
a=Console.ReadLine();
int resultado=(int.Parse(a)*365);
while(resultado!=0){
   Console.WriteLine(resultado%10);
   resultado=resultado/10;
}
*/
/*EJERCICIO 15:Escribir un programa que solicite un año por pantalla y diga si es bisiesto. Un año es bisiesto si
es divisible por 4 pero no por 100. Si es divisible por 100, para ser bisiesto debe ser divisible
por 400.

String a;
Console.WriteLine("Ingrese el anio: ");
a=Console.ReadLine();
if(int.Parse(a)%100==0){
   if(int.Parse(a)%400==0){
      Console.Write("Es bisiesto");
   }
   else{
     Console.Write("No es bisiesto"); 
   }
}
else if(int.Parse(a)%4==0)
   Console.Write("Es bisiesto");
else{
   Console.Write("No es bisiesto");
}
*/
/* EJERCICIO 16: Si a y b son variables enteras, identificar el problema (y la forma de resolverlo) de la siguiente
expresión (tip: observar qué pasa cuando b = 0):
if ((b != 0) & (a/b > 5)) Console.WriteLine(a/b);
HACE AMBAS CONDICIONES AUNQUE LA PRIMERA SEA FALSA.&& en cambio ya al ver que la primera es falsa no evalua la segunda.
EL EJERCICIO TIRAR ERROR AL INTENTAR DIVIDIR POR 0.
*/
/* EJERCICIO 17:Utilizar el operador ternario condicional para establecer el contenido de una variable entera con
el menor valor de otras dos variables enteras.


int b=5;
int c=10;
int a= b<c ? a=b : a=c;
Console.WriteLine(a);
*/
/* EJERCICIO 18:¿Cuál es la salida por consola del siguiente código?

IMPRIME <1,uno,dos,tres,>3.

for (int i = 0; i <= 4; i++)
{
string st = i < 3 ? i == 2 ? "dos" : i == 1 ? "uno" : "< 1" : i < 4 ? "tres" : "> 3";
Console.WriteLine(st);
}
*/
/*EJERCICIO 19: 1. int a, b, c;
2. int a; int b; int c, d;
3. int a = 1; int b = 2; int c = 3;
4. int b; int c; int a = b = c = 1;
5. int c; int a, b = c = 1;
6. int c; int a = 2, b = c = 1;
7. int a = 2, b, c, d = 2 * a;
8. int a = 2, int b = 3, int c = 4;
9. int a = 2; b = 3; c = 4;
10. int a; int c = a;
11. char c = 'A', string st = "Hola";
12. char c = 'A'; string st = "Hola";
13. char c = 'A', st = "Hola";
EL 13 esta mal el 9 esta mal y el 8 esta mal.
*/
/* EJERCICIO 20: ¿Cuál es el problema del código siguiente y cómo se soluciona?

int i = 0;
for (int i = 1; i <= 10;)
{
Console.WriteLine(i++);
ERROR: Declaro i arriba y dentro del for otra vez.
}
*/
/*EJERCICIO 21:Analizar el siguiente código. ¿Cuál es la salida por consola?

int i=1;
if (i-- == 0)// --i(Originalmente).
{
Console.WriteLine("cero");
Console.WriteLine(i);
}
Console.WriteLine(i);
if (i++ == 0)
{
Console.WriteLine(i);
Console.WriteLine("cero");

}
Console.WriteLine(i);
EL --i y el i-- funcionan de diferente manera, uno antes de que entre al if y otro despues(NO ENTIENDO MUY BIEN PORQUE).
*/