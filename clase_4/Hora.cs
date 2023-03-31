namespace clase_4;
class Hora{
  private int _Hora;
  private int _Minutos;
  private double _Segundos;


  public Hora(int h,int m,int s){
    this._Hora=h;
    this._Minutos=m;
    this._Segundos=s;
  }
  public Hora(double h){
    this._Hora=(int)(h);//el double a int para que quede solo la parte entera
    this._Minutos=(int)((h-this._Hora)*60);//el double menos la entera te deja detras de la coma, *60 te da los mins y segs, si te quedas con la entera son solo los mins
    this._Segundos=((((h-this._Hora)*60)-(this._Minutos))*60);//lo mismo que la anterior pero ahora tmb se le resta los minutos, dejando solo los segundos
    if(Math.Round(this._Segundos)==60){//redondeas los segundos porque si da cerca de 60 redondea a 60 pero en 60 ya queres cambiar a 1 minuto mas
      this._Segundos=0;//se ponen los segundos en 0
      this._Minutos++;//se aumenta el minuto
    }
  }
  public void Imprimir()=>
    Console.WriteLine($"{this._Hora} horas, {this._Minutos} minutos, {this._Segundos:0.000} segundos.");
}