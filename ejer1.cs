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
Te da una longitud de 3.
*/
/* EJERCICIO 8: Sea st una variable de tipo string correctamente declarada. ¿Es válida la siguiente instrucción:
string st;
Console.WriteLine(st=Console.ReadLine());
*/