namespace clase_4;
class Persona{
  private string Nombre;
  private int Edad;
  private string DNI;

  public Persona(string Nom,int e,string dni){
    this.Nombre=Nom;
    this.Edad=e;
    this.DNI=dni;
  }

public void Imprimir(int pos){
 Console.WriteLine("{0}) {1,-8} {2,5} {3,10}", pos, this.Nombre, this.Edad, this.DNI);
}

}