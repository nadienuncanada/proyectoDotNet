using clase_4;
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