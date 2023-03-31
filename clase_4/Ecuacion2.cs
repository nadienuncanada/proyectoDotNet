namespace clase_4;
class Ecuacion2{
 private double _a; 
 private double _b; 
 private double _c; 

public Ecuacion2(double a,double b,double c){
  this._a=a;
  this._b=b;
  this._c=c;
}
public double GetDescriminante()=>
  Math.Pow(this._b,2)-(4*this._a*this._c);
public int GetCantidadDeRaices(){
  if(GetDescriminante()==0)
    return 1;
  else if(GetDescriminante()<0)
    return 0;
  else
    return 2;
}
public void ImprimirRaices(){
  if(GetCantidadDeRaices()==2){
    double res1=(-this._b+Math.Sqrt(GetDescriminante())) / (2*this._a);
    double res2=(-this._b-Math.Sqrt(GetDescriminante())) / (2*this._a);
    Console.WriteLine($" Raiz1: {res1} Raiz2: {res2}");
  }
  else if(GetCantidadDeRaices()==0){
    Console.WriteLine("La Ecuacion no tiene Raices!");
  }
  else{
    double res = (-this._b) / (2 * this._a);
    Console.WriteLine($"Raiz Unica: {res}");
  }
}
}
