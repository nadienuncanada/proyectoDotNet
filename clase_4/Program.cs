﻿using clase_4;
/*  EJERCICIO 1:
Definir una clase Persona con 3 campos públicos: Nombre, Edad y DNI. Escribir un algoritmo que permita al
usuario ingresar en una consola una serie de datos de la forma Nombre,Documento,Edad<ENTER>. Una vez
finalizada la entrada de datos, el programa debe imprimir en la consola un listado con 4 columnas de la
siguiente forma:
Nro) Nombre Edad DNI.
Ejemplo de listado por consola:
1) Juan Perez 40 2098745
2) José García 41 1965412
...
NOTA: Puede utilizar: Console.SetIn(new System.IO.StreamReader(nombreDeArchivo));
para cambiar la entrada estándar de la consola y poder leer directamente desde un archivo de texto.

 StreamReader sr = new System.IO.StreamReader("dataEj1.txt");
Persona p = new Persona();//creo uno solo lo printeo y despues lo sobre escribo.
string line;
int i=1;
 Console.WriteLine("{0}) {1,-10} {2,4} {3,10}", "Nro", "Nombre", "Edad", "DNI");
while ((line = sr.ReadLine()) != null){
string[] corte= line.Split(",");//por cada , se vuelve un array.(separa la string por cada ,).
  p.Nombre = corte[0];//Nombre
  p.Edad = Int32.Parse(corte[1]);//Edad, pasarlo de string a int
  p.DNI = corte[2];//DNI
  Console.WriteLine("{0}) {1,-10} {2,5} {3,12}", i, p.Nombre, p.Edad, p.DNI);//printeo el dato ingresado.
  i++;//para darle numeros a las personas
}
*/
/* EJERCICIO 2:
 Modificar el programa anterior haciendo privados todos los campos. Definir un constructor adecuado y un
método público Imprimir() que escriba en la consola los campos del objeto con el formato requerido para el
listado


StreamReader sr = new System.IO.StreamReader("dataEj1.txt");
string line;
int i=1;
while((line=sr.ReadLine())!=null){
string [] corte=line.Split(",");
Persona p= new Persona(corte[0], Int32.Parse(corte[1]), corte[2]);
p.Imprimir(i);
i++;
}
*/
/* EJERCICIO 3: 
Agregar a la clase Persona un método EsMayorQue(Persona p) que devuelva verdadero si la persona que
recibe el mensaje tiene más edad que la persona enviada como parámetro. Utilizarlo para realizar un programa
que devuelva la persona más jóven de la lista.

Persona joven=new Persona("Young",15,"777");
Persona p=new Persona("Old",20,"888");

if(p.EsMayorQue(joven))//si p es mayor returnea true
  joven.Imprimir(1);//imprimo al joven
else
  p.Imprimir(2);//si no returnea true, imprimo p porque seria menor que joven
 */
 /* EJERCICIO 4: 
     Codificar la clase Hora de tal forma que el siguiente código produzca la salida por consola que se observa.
  Hora h = new Hora(23,30,15);
  h.Imprimir();
 */
/*  EJERCICIO 5:
Agregar un segundo constructor a la clase Hora para que pueda especificarse la hora por medio de un único
valor que admita decimales. Por ejemplo 3,5 indica la hora 3 y 30 minutos. Si se utiliza este segundo
constructor, el método imprimir debe mostrar los segundos con tres dígitos decimales. Así el siguiente código
debe producir la salida por consola que se observa.

new Hora(23, 30, 15).Imprimir();
new Hora(14.43).Imprimir();//si recibe un double usa otro creador.
new Hora(14.45).Imprimir();
new Hora(14.45114).Imprimir();
*/
/*  EJERCICIO 6:
Codificar una clase llamada Ecuacion2 para representar una ecuación de 2º grado. Esta clase debe tener 3
campos privados, los coeficientes a, b y c de tipo double. La única forma de establecer los valores de estos
campos será en el momento de la instanciación de un objeto Ecuacion2.
GetDiscriminante(): devuelve el valor del discriminante (double), el discriminante tiene la siguiente
formula, (b^2)-4*a*c.
GetCantidadDeRaices(): devuelve 0, 1 ó 2 dependiendo de la cantidad de raíces reales que posee la
ecuación. Si el discriminante es negativo no tiene raíces reales, si el discriminante es cero tiene una
única raíz, si el discriminante es mayor que cero posee 2 raíces reales.
ImprimirRaices(): imprime la única o las 2 posibles raíces reales de la ecuación. En caso de no poseer
soluciones reales debe imprimir una leyenda que así lo especifique.

Ecuacion2 e1=new Ecuacion2(1,2,-3);//dis=16,2 raices=1 y -3
Ecuacion2 e2=new Ecuacion2(4,2,-2);//dis=36,2 raices= 0,5 y -1
Ecuacion2 e3=new Ecuacion2(-3,1,2);// todo funciona ok :)
Console.WriteLine("Discriminante: "+e1.GetDescriminante());
Console.WriteLine("Cantidad de Raices: "+e1.GetCantidadDeRaices());
e1.ImprimirRaices();

Console.WriteLine("Discriminante: "+e2.GetDescriminante());
Console.WriteLine("Cantidad de Raices: "+e2.GetCantidadDeRaices());
e2.ImprimirRaices();

Console.WriteLine("Discriminante: "+e3.GetDescriminante());
Console.WriteLine("Cantidad de Raices: "+e3.GetCantidadDeRaices());
e3.ImprimirRaices();
*/
/* EJERCICIO 7: 
Codificar la clase Nodo de un árbol binario de búsqueda de valores enteros. Un árbol binario de búsqueda no
tiene valores duplicados y el valor de un nodo cualquiera es mayor a todos los valores de su subárbol izquierdo
y es menor a todos los valores de su subárbol derecho.
Desarrollar los métodos:
1. Insertar(valor): Inserta valor en el árbol descartándolo en caso que ya exista.
2. GetInorden(): devuelve un ArrayList con los valores ordenados en forma creciente.
3. GetAltura(): devuelve la altura del árbol.
4. GetCantNodos(): devuelve la cantidad de nodos que posee el árbol.
5. GetValorMáximo(): devuelve el valor máximo que contiene el árbol.
6. GetValorMínimo(): devuelve el valor mínimo que contiene el árbol.
*/
