﻿
using clase_6;
/*
Auto a = new Auto();
Colectivo c = new Colectivo();
a.Marca = "Ford";
a.Modelo = 2000;
c.Marca = "Mercedes";
c.Modelo = 2010;
c.CantPasajeros = 20;
a.Tipo = TipoAuto.Deportivo;
a.Imprimir();
c.Imprimir();
*/
Auto a = new Auto("Ford", 2000, TipoAuto.Deportivo);
Colectivo c = new Colectivo("Mercedes", 2010, 20);
a.Imprimir();
c.Imprimir();
Console.WriteLine(a.Marca + " " + a.Modelo);
Console.WriteLine(c.Marca + " " + c.Modelo);