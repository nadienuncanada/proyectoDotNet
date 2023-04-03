
namespace clase_4;
class Cuenta
{
private double _monto;
private int _titularDNI;
private string? _titularNobre;

public Cuenta(){
  _monto=0;
  _titularNobre="No especificado";
}
public Cuenta(string? n,int dni){
  _titularDNI=dni;
  _titularNobre=n;
}
public Cuenta(string? n):this(){
  _titularNobre=n;
}
public Cuenta(int d):this(){
  _titularDNI=d;
}
public void Imprimir(){
  if(_titularDNI==0){
    Console.WriteLine("Nombre: "+_titularNobre+" DNI: No especificado"+" Monto: "+_monto );
  }
  else 
  Console.WriteLine("Nombre: "+_titularNobre+" DNI: "+_titularDNI+" Monto: "+_monto );
}
public void Depositar(double num)=>
  _monto+=num;
public void Extraer(double num){
  if((_monto-num)<0){
      Console.WriteLine("Operacion cancelada, monto insuficiente");
  }
  else{
    _monto-=num;
  }

}
}