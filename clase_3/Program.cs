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
*/
/* EJERCICIO 1: 
  Ejecutar y analizar cuidadosamente el siguiente programa:
Console.CursorVisible = false;
ConsoleKeyInfo k = Console.ReadKey(true);
while (k.Key != ConsoleKey.End)
{
Console.Clear();
Console.Write($"{k.Modifiers}-{k.Key}-{k.KeyChar}");
k = Console.ReadKey(true);
}
Comprobar tipeando teclas y modificadores (shift, ctrl, alt) para apreciar de qué manera
se puede acceder a esta información en el código del programa.

Console.CursorVisible = false;
ConsoleKeyInfo k = Console.ReadKey(true);
while (k.Key != ConsoleKey.End)
{
Console.Clear();
Console.Write($"{k.Modifiers}-{k.Key}-{k.KeyChar}");
k = Console.ReadKey(true);
}
*/
/* EJERCICIO 1: 
Ejecutar y analizar cuidadosamente el siguiente programa:
CConsole.CursorVisible = false;// creo que hace q no se ve el cosito en la consola
ConsoleKeyInfo k = Console.ReadKey(true);//se declara k de tipo consolekeyinfo,haciendo que obtenga la tecla que se presione
while (k.Key != ConsoleKey.End)// corte cuando se toque end
{
Console.Clear();//limpia la consola
Console.Write($"{k.Modifiers}-{k.Key}-{k.KeyChar}");// printea si se presiono shit ctrl o alt mas la key(nombre) mas  su valor char(ej: key=oem7,keychar=')
k = Console.ReadKey(false);
}
Comprobar tipeando teclas y modificadores (shift, ctrl, alt) para apreciar de qué manera
se puede acceder a esta información en el código del programa.
*/
/* EJERCICIO 2:
  Implementar un método para imprimir por consola todos los elementos de una matriz (arreglo
de dos dimensiones) pasada como parámetro. Debe imprimir todos los elementos de una fila en
la misma línea en la consola.
void ImprimirMatriz(double[,] matriz)
Ayuda: Si A es un arreglo, A.GetLength(i) devuelve la longitud del arreglo en la
dimensión i.

double [,] matriz= new double[2,5]
{{1,2,3,4,5},{6,7,8,9,10}};
 ImprimirMatriz(matriz); 
  int c=matriz.GetLength(0);
  int d=matriz.GetLength(1);
  Console.WriteLine();
  Console.WriteLine("getLength en la dimension 0 es: "+c+" getLength en la dimension 1 es: "+ d);

void ImprimirMatriz(double[,] matriz){
  int filas=matriz.GetLength(1);
  int contador=0;
  foreach(int i in matriz){ //con FOREACH
    if(contador==filas){
      Console.WriteLine();
      contador=0;
    }
    Console.Write(i);
    contador++;
  }

  int columnas=matriz.GetLength(0);//con FOR
  
  for(int i=0;i<columnas;i++){
    Console.WriteLine();
  for(int j=0;j<filas;j++){
    Console.Write(matriz[i,j]);
  }
  }
}
*/
/*  EJERCICIO 3:
Implementar el método ImprimirMatrizConFormato, similar al anterior pero ahora con un
parámetro más que representa la plantilla de formato que debe aplicarse a los números al
imprimirse. La plantilla de formato es un string de acuerdo a las convenciones de formato
compuesto, por ejemplo “0.0” implica escribir los valores reales con un dígito para la parte
decimal.
void ImprimirMatrizConFormato(double[,] matriz, string formatString)

double [,] matriz= new double[2,5]
{{1.890667,2.897680,3.876890,4.898760,5.887690},{6.897680,7.887690,8.88790,9.89540,10.832490}};
Console.WriteLine("Ingrese Formato de los decimales: (ej:0.00)");
string formato=Console.ReadLine();
ImprimirMatrizConFormato(matriz,formato);
void ImprimirMatrizConFormato(double[,] m, string formatString){
 int columnas=m.GetLength(0);
 int filas=m.GetLength(1);
 for(int i=0;i<columnas;i++){
  Console.WriteLine();
  for(int j=0;j<filas;j++){
    Console.Write(m[i,j].ToString(formatString)+ " ");
  }
 }
}
*/
/* EJERCICIO 4: 
Implementar los métodos GetDiagonalPrincipal y GetDiagonalSecundaria que
devuelven un vector con la diagonal correspondiente de la matriz pasada como parámetro. Si la
matriz no es cuadrada generar una excepción ArgumentException.
double[] GetDiagonalPrincipal(double[,] matriz)
double[] GetDiagonalSecundaria(double[,] matriz)

double [,] matriz= new double[3,3]{{1,2,3},{4,5,6},{7,8,9}};
double[] imprimir=GetDiagonalPrincipal(matriz);
foreach(int i in imprimir){
Console.WriteLine(i);
}
double[] imprimir2=GetDiagonalSecundaria(matriz);
foreach(int i in imprimir2){
Console.WriteLine(i);
}
//GetDiagonalSecundaria(matriz);
double[] GetDiagonalPrincipal(double[,] matriz){
  int columnas=matriz.GetLength(0);
  int filas=matriz.GetLength(1);
    if (filas!=columnas){
      throw new ArgumentException();
    }
    double[] vector=new double[columnas];
    for(int i=0;i<columnas;i++){
      vector[i]=matriz[i,i];
      }
    return vector;
  }
double[] GetDiagonalSecundaria(double[,] matriz){
  int columnas=matriz.GetLength(0);
  int filas=matriz.GetLength(1);
    if (filas!=columnas){
      throw new ArgumentException();
    }
    double[] vector2=new double[columnas];
    for(int i=0,j=filas-1;i<columnas;i++,j--){
      vector2[i]=matriz[i,j];
      }
    return vector2;
  }
  */
/* EJERCICIO 5: 
Implementar un método que devuelva un arreglo de arreglos con los mismos elementos que la
matriz pasada como parámetro:
double[][] GetArregloDeArreglo(double [,] matriz)


double [,] matriz= new double[4,3]{{1,2,3},{4,5,6},{7,8,9},{10,11,12}};
double[][] imprimir=GetArregloDeArreglo(matriz);
int f= matriz.GetLength(0);
int c= matriz.GetLength(1);
for(int i=0;i<f;i++){
  for(int j=0;j<c;j++){
    Console.Write(imprimir[i][j]+" ");
  }
  Console.WriteLine();
}
double[][] GetArregloDeArreglo(double [,] matriz){
  int f= matriz.GetLength(0);
  int c= matriz.GetLength(1);
  double[][] imp=new double[f][];
    for(int i=0;i<f;i++){// me paro en la primera fila.
      imp[i]=new double[c];//creo un vector con la cantidad de columnas que tenga la matriz en i fila.
      for(int j=0;j<c;j++){//cargo el vector de c columnas. 
        imp[i][j]=matriz[i,j];//con los datos de la fila i con los j datos.
      }
    }
    return imp;
  }
*/
/* EJERCICIO 6:
Implementar los siguientes métodos que devuelvan la suma, resta y multiplicación de matrices
pasadas como parámetros. Para el caso de la suma y la resta, las matrices deben ser del mismo
tamaño, en caso de no serlo devolver null. Para el caso de la multiplicación la cantidad de
columnas de A debe ser igual a la cantidad de filas de B, en caso contrario generar una
excepción ArgumentException.
double[,]? Suma(double[,] A, double[,] B)
double[,]? Resta(double[,] A, double[,] B)
double[,] Multiplicacion(double[,] A, double[,] B)

double[,] A=new double[2,2]{
  {1,2},
  {3,4}
  };
double[,] B=new double[2,2]{
  {5,5},
  {10,10},
  };
  int f= A.GetLength(0);
  int c= A.GetLength(1);
  double[,]? resultS=Suma(A,B);
  Console.WriteLine("Suma A+B: ");
  Imprimir(resultS);
  double[,]? resultR=Resta(A,B);
  Console.WriteLine("Resta A-B: ");
  Imprimir(resultR);
  double[,]? resultM=Multiplicacion(A,B);
  Console.WriteLine("Multiplicacion A*B: ");
  Imprimir(resultM);
double[,]? Suma(double[,] A, double[,] B){
  int fA= A.GetLength(0);
  int cA= A.GetLength(1);
  int fB= B.GetLength(0);
  int cB= B.GetLength(1);
  if((fA!=fB) | (cA!=cB)){
    throw new Exception();
  }
  double[,] dev=new double[f,c];
  for(int i=0;i<f;i++){
    for(int j=0;j<c;j++){
    dev[i,j]=A[i,j]+B[i,j];
    }
  }
  return dev;
  }
   
double[,]? Resta(double[,] A, double[,] B){
  int fA= A.GetLength(0);
  int cA= A.GetLength(1);
  int fB= B.GetLength(0);
  int cB= B.GetLength(1);
  if((fA!=fB) | (cA!=cB)){
    throw new Exception();
  }
  double[,] dev=new double[f,c];
  for(int i=0;i<f;i++){
    for(int j=0;j<c;j++){
    dev[i,j]=A[i,j]-B[i,j];
    }
  }
  return dev;
  }
double[,] Multiplicacion(double[,] A, double[,] B){
  int fA= A.GetLength(0);
  int cA= A.GetLength(1);
  int fB= B.GetLength(0);
  int cB= B.GetLength(1);
  double temp;
  double[,] result=new double[fA,cB];
  for (int i = 0; i < fA; i++){
    for(int j = 0; j < cB; j++){
      temp= 0;
      for(int k = 0; k < cA; k++){
          temp += A[i, k] * B[k, j];
      }
      result[i,j]=temp;
    }
  }
  return result;
}

void Imprimir(double[,]result){
  for(int i=0;i<f;i++){
    for(int j=0;j<c;j++){
      Console.Write(result[i,j]);
    }
  Console.WriteLine();
  }
}
*/
/* EJERCICIO 7: ¿De qué tipo quedan definidas las variables x, y, z en el siguiente código?
int i = 10;//integer
var x = i * 1.0;//double
var y = 1f;//float
var z = i * y;//float
*/
/* EJERCICIO 8:
¿Qué líneas del siguiente método provocan error de compilación y por qué?

var a = 3L;//long
dynamic b = 32;//integer
object obj = 3;//integer
a = a * 2.0;//no deja por la perdida de informacion.
b = b * 2.0;//double
b = "hola";//string
obj = b;//error pasar de integer a char/string
b = b + 11;//Agrega a la string "hola" el 11 quedando "hola11".
obj = obj + 11;//da error,esto demuestra que los obj pueden pasar de int a string pero despues no podes ponerle + 11 y que quede por ejemplo "hola11".
var c = new { Nombre = "Juan" };//se puede
var d = new { Nombre = "María" };//se puede
var e = new { Nombre = "Maria", Edad = 20 };//se puede
var f = new { Edad = 20, Nombre = "Maria" };//se puede
//f.Edad = 22;//se puede// no se puede
d = c;//se puede cambia de Maria a Juan
//e = d;//creo que le cambiarias de Maria a Juan con edad 20//no funciona
//f = e;//para mi no funca.// no funciona en efecto
*/
/*  EJERCICIO 9:
Señalar errores de compilación y/o ejecución en el siguiente código
object obj = new int[10];
dynamic dyn = 13;
Console.WriteLine(obj.Length);// el object no te deja conseguir la length aunque sea un array
Console.WriteLine(dyn.Length)// no da error pero en verdad no se puede hacer esto, pero el compilador no se fija si se puede hacer o no ya que es un tipo dynamic.

*/  
/*  EJERCICIO 10: 
Verificar con un par de ejemplos si la sección opcional [:formatString] de formatos compuestos
redondea o trunca cuando se formatean números reales restringiendo la cantidad de decimales.
Plantear los ejemplos con cadenas de formato compuesto y con cadenas interpoladas

double number = 3.141592653589793;
string formatted = string.Format("{0:F2}", number);
Console.WriteLine(formatted); // Imprime "3.14"
double number2 = 1.23456789;
int decimals = 3;
string formatted2 = $"{number2:F(decimals)}";
Console.WriteLine(formatted2); // Imprime "1.235"
*/
/* EJERCICIO 11: Señalar errores de ejecución en el siguiente código

List<int> a = new List<int>() { 1, 2, 3, 4 };
a.Remove(5);//no da error.
a.RemoveAt(4);//da error de ejecucion, te vas del array
/*
/* EJERCICIO 12: 
Utilizar la clase Queue<T> para implementar un programa que realice el cifrado de un texto
aplicando la técnica de clave repetitiva. La técnica de clave repetitiva consiste en desplazar un
carácter una cantidad constante de acuerdo a la lista de valores que se encuentra en la clave. Por
ejemplo: para la siguiente tabla de caracteres:
A B C D E F G H I J K L M N Ñ O P Q R S T U V W X Y Z sp
1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26 27 28
Si la clave es {5,3,9,7} y el mensaje a cifrar “HOLA MUNDO”
Se cifra de la siguiente manera:
H O L A sp M U N D O ← Mensaje original
8 16 12 1 28 13 22 14 4 16 ← Código sin cifrar
5 3 9 7 5 3 9 7 5 3 ← Clave repetida
13 19 21 8 5 16 3 21 9 19 ← Código cifrado
M R T H E O C T I R ← Mensaje cifrado
A cada carácter del mensaje original se le suma la cantidad indicada en la clave. En el caso que
la suma fuese mayor que 28 se debe volver a contar desde el principio, Implementar una cola
con los números de la clave encolados y a medida que se desencolen para utilizarlos en el
cifrado, se vuelvan a encolar para su posterior utilización. Programar un método para cifrar y
otro para descifrar
*/
/*  EJERCICIO 14:
Utilizar la clase Stack<T> (pila) para implementar un programa que pase un número en base
10 a otra base realizando divisiones sucesivas. Por ejemplo para pasar 35 en base 10 a binario
dividimos sucesivamente por dos hasta encontrar un cociente menor que el divisor, luego el
resultado se obtiene leyendo de abajo hacia arriba el cociente de la última división seguida por
todos los restos

Console.WriteLine("Ingrese Numero que quiere convertir: ");
int num=int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la Base que quiera: ");
int bas=int.Parse(Console.ReadLine());
Console.WriteLine("------------------------");
Stack<int> imp=Convertidor(num,bas);
//Console.WriteLine(imp.Count);
foreach(int i in imp){
  Console.Write(i);
}

Stack<int>Convertidor(int num,int bas){
  Stack<int> res=new Stack<int>();
    res.Push(num%bas);
  while(num>=bas){
    num/=bas;
    res.Push(num%bas);
  } 
  return res;
}
*/
/*  EJERCICIO 13: 
Realizar un análisis sintáctico para determinar si los paréntesis en una expresión aritmética están
bien balanceados. Verificar que por cada paréntesis de apertura exista uno de cierre en la cadena
de entrada. Utilizar una pila para resolverlo. Los paréntesis de apertura de la entrada se
almacenan en una pila hasta encontrar uno de cierre, realizándose entonces la extracción del
último paréntesis de apertura almacenado. Si durante el proceso se lee un paréntesis de cierre y
la pila está vacía, entonces la cadena es incorrecta. Al finalizar el análisis, la pila debe quedar
vacía para que la cadena leída sea aceptada, de lo contrario la misma no es válida.

Console.Clear();
Console.WriteLine("Ingrese Expresion: ");
String entrada=Console.ReadLine();
Stack<Char> res=new Stack<Char>();
verificar(entrada,res);

void verificar(string entrada,Stack<Char> res){
 foreach(char i in entrada){
  if(i.Equals('(')){//va pusheando cada apertura
    res.Push(i);
  }
  if(i.Equals(')')){//si encuentra un cierre
    if(res.Count>0){//se fija si la pila tiene datos
        res.Pop();//popea de la pila una apertura por cada cierre encontrado 
      }
      else{
      throw new Exception("No hay parentesis de apertura!");//si esta vacia la pila
    }
    }
  }
  if(res.Count>0){// si al final de recorrer la pila quedaron Aperturas esta mal
    Console.WriteLine("Quedo la pila con Aperturas");
  }
  else{
    Console.WriteLine("La Expresion esta Bom de Parentesis");//sino esta todo bien :)
  }
 }
*/
 /* EJERCICIO 15: 
 ¿Qué salida por la consola produce el siguiente código?
 int x = 0;
try
{
Console.WriteLine(1.0 / x);// da 8 que creemos que es infinito
//Console.WriteLine(1 / x);//da la exepcion de intentar dividir por 0
Console.WriteLine("todo OK");
}
catch (Exception e)
{
Console.WriteLine(e.Message);
}
¿Qué se puede inferir respecto de la excepción división por cero en relación al tipo de los
operandos? Cambia dependiendo de si es int, float.
 */
 /* EJERCICIO 16:
 Implementar un programa que permita al usuario ingresar números por la consola. Debe
ingresarse un número por línea finalizado el proceso cuando el usuario ingresa una línea vacía.
A medida que se van ingresando los valores el sistema debe mostrar por la consola la suma
acumulada de los mismos. Utilizar la instrucción try/catch para validar que la entrada
ingresada sea un número válido, en caso contrario advertir con un mensaje al usuario y
proseguir con el ingreso de datos.

Console.Clear();
proceso();

void proceso(){
  int tot=0;
  int num=0;
  while(num!=' '){//mientras num ' ' arranca
    try{// intenta
      Console.WriteLine("Ingrese Numero: ");//pide numero
      num=int.Parse(Console.ReadLine());
      tot+=num;//lo suma a otra var tot
      Console.WriteLine(tot);//printea total
    }
    catch(Exception e){// si hay expecion se fija si es la condicion de corte
      if(e.Message.Equals("The input string '' was not in a correct format.")){//si es espacio vacio corta con exepcion
        throw new Exception(e.Message);//corta con exepcion
        }
        Console.WriteLine(e.Message);//sino printea la expecion y sigue.
    }
  }
}
 */
 /* EJERCICIO 17: 
 Implementar un programa calculadora que calcule una expresión ingresada por el usuario
correspondiente a una operación binaria de las cuatro elementales (ejemplo “44.5/456”,
“456*45”, “549-12”, “54+6” ). Utilizar try/catch para validar los números y controlar
cualquier tipo de excepción que pudiese ocurrir en la evaluación de la expresión.
 */

