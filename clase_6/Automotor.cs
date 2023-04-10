
namespace clase_6;

class Automotor {
  public string Marca { get; }
  private int _modelo;
  public virtual int Modelo
  {
    get => _modelo;
    protected set => _modelo = (value < 2005) ? 2005 : value;// si es menor a 2005 le pone 2005 sino deja el valor que llego
  }
  public Automotor(){

  }
  public Automotor(string marca, int modelo)
  {
   Marca = marca;
    Modelo = modelo;
  }
  public virtual void Imprimir()
     => Console.WriteLine($"{Marca} {Modelo}");
     
}