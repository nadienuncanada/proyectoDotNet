using clase_7;

object[] vector = new object[] {
       new Moto("Zanella"),
       new Empleado("Juan"),
       new Moto("Gilera")
   };

foreach (IImprimible imp in vector)
{
  imp.Imprimir();
}
for(int i=0;i<vector.Length;i++){
  (vector[i] as IImprimible)?.Imprimir();// si el vector fuera de tipo IImprimible se podria hacer vector[i].Imprimir()
}
