namespace clase_4;
class Auto{
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
public string GetDescription()=>
  $"Auto {_marca} {_modelo}"; 

}
/*auto a;
a=new auto();
a.Marca="Nissan";//por defecto es null
a.Modelo=2017;//por defecto vale 0
auto b=new auto();
b.Modelo=2015;
b.Marca="Ford";*//*
Auto a= new Auto("Nissan",2017);
Auto b=new Auto("Ford",2015);
Auto c=new Auto();
Auto d=new Auto("Pepito");
//Console.WriteLine($"auto {a.Marca} {a.Modelo}");
//Console.WriteLine($"auto {b.Marca} {b.Modelo}");
Console.WriteLine(b.GetDescription());
Console.WriteLine(a.GetDescription());
Console.WriteLine(c.GetDescription());
Console.WriteLine(d.GetDescription());
*/