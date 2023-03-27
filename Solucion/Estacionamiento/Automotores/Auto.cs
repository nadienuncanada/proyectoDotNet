namespace Automotores;
public class Auto{
  private string _marca;
  private int _modelo;
  public Auto(string marca, int modelo){
    _marca=marca;
    _modelo=modelo;
}
public Auto(){
  _marca="Fiat";
  _modelo=DateTime.Now.Year;
}
public Auto(string marca) : this(){// con this se llama al costructor vacio
       _marca=marca;  //(ya que el parentesis estan vacios, si los parentesis tuvieran cosas llamaria otro constructor).
}
public string GetDescripcion()=>
  $"Auto {_marca} {_modelo}"; 

}
