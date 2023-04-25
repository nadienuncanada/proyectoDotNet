using Teoria_8;
/*
var vector = new Empleado[] {
new Empleado("Juan") {Legajo=79},//sintaxis de inicializacion(utiliza los get;set;(creo))
new Empleado("Adriana") {Legajo=123},
new Empleado("Diego") {Legajo=12}
};

Array.Sort(vector, new ComparadorPorLegajo());
foreach (Empleado e in vector)
{
e.Imprimir();
}
*/
Pyme miPyme = new Pyme(new Empleado("Juan"),
new Empleado("Adriana"),
new Empleado("Diego"));

foreach (Empleado e in miPyme)
{
e.Imprimir();
}