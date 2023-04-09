namespace clase_5;
class Persona
{
 public string Nombre {get; set;}
  public char Sexo {get; set;}
  public int DNI {get; set;}
  public DateTime FechaNacimiento {get; set;}
  
  public int Edad{
    get{
      DateTime ahora= DateTime.Now;
      int edad = ahora.Year - FechaNacimiento.Year;//se podria hacer mas simple pero es para dar precisas la edad.
      if(ahora.Year>FechaNacimiento.Year-(edad));
        edad--;
      return edad;
    }
  }
  public object this[int i]{
    get{
      if(i==0)
        return this.Nombre;
      if(i==1)
        return this.Sexo;
      if(i==2)
        return this.DNI;
      if(i==3)
        return this.FechaNacimiento;
      if(i==4)
        return this.Edad;
      else 
        return null;
  }
  set{
    if(i==0)
      this.Nombre=(string)value;
    if(i==1)
      this.Sexo=(char)value;
    if(i==2)
      this.DNI=(int)value;
    if(i==3)
      this.FechaNacimiento=(DateTime)value;
  }
  }
}
