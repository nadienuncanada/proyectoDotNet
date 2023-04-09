namespace clase_5;
class Cuenta
{
  // private static List<Cuenta> lista=new List<Cuenta>();
  private static readonly List<Cuenta> lista= new List<Cuenta>();//el readonly proteje la lista no dejando que incialices de nuevo la misma.
  private static int s_totalDepositado;
  private static int s_totalExtraido;
  private static int s_depositos;
  private static int s_extracciones;
  private static int s_extraccionesDene;
  private static int s_numC;
  private int _numC;//la instancia numero de cuenta
  private int cant;//la instancia cantidad de guita
  // private static int s_cantC;

public Cuenta(){
  s_numC++;
  _numC=s_numC;
  Console.WriteLine("Se creo la cuenta {0}",_numC);
   lista.Add(this);
}

public Cuenta Depositar(int aDepositar){//se declara del tipo de clase y se devuelve a si mismo, logrando con esto hacer c1.Depositar(x).Depositar(x).etc
  cant+=aDepositar;
  s_totalDepositado+=aDepositar;
  s_depositos++;
  Console.WriteLine($"Se deposito {aDepositar} en la cuenta {_numC} (Saldo={this.cant})");
  return this;
} 

public Cuenta Extraer(int aExtraer){
if(cant>=aExtraer){
  s_extracciones++;
  this.cant-=aExtraer;
  s_totalExtraido+=aExtraer;
  Console.WriteLine($"Se extrajo {aExtraer} en la cuenta {_numC} (Saldo={this.cant})");
}
else{
  s_extraccionesDene++;
  //  s_totalExtraido+=aExtraer;
  Console.WriteLine($"Operacion Denegada-Saldo Insuficiente!");
}
return this;
} 
public static void ImprimirDetalle(){
Console.WriteLine("Cuentas Creadas {0} ",s_numC);
Console.WriteLine("Depositos: {0} ",s_depositos);
Console.WriteLine("Extracciones: {0} ",s_extracciones);
Console.WriteLine("Total Depositado: {0} ",s_totalDepositado);
Console.WriteLine("Total Extraido: {0} ",s_totalExtraido);
Console.WriteLine("Se denegaron {0} extracciones por falta de fondos",s_extraccionesDene);
}
public static List<Cuenta> GetCuentas(){//returnea una copia de la lista 
  List<Cuenta> lCopy=new List<Cuenta>();//creo una nueva lsita
  foreach (Cuenta c in lista)//le asigno todo lo que tiene
  {
    lCopy.Add(c);  
  }
  return lCopy;
}
 public static void RemoveAt(int pos)=>//recibe las pos y elimina
  lista.RemoveAt(pos);


}
