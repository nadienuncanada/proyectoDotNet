namespace clase_4;
class Matriz
{
  double[,] _matriz;
  private int filas;
  private int columnas;

  public Matriz(int filas,int columnas){
    this.filas=filas;
    this.columnas=columnas;
    _matriz =new double[filas,columnas];
  }
  public Matriz(double[,] matriz){
    _matriz=matriz;
  }
  public double this[int fila, int columna]//esto es el getelemnto y el setelemento en un indizador
  {
    get{return _matriz[fila,columna];}
    set{_matriz[fila,columna]=value;}
  }
  /*
  public void SetElemento(int fila, int columna, double elemento){
    _matriz[fila,columna]=elemento;
  }
  public double GetElemento(int fila, int columna)=>
    _matriz[fila,columna];*/
  public void imprimir(){
    for(int i=0;i<filas;i++){
      for(int j=0;j<columnas;j++){
        Console.Write(_matriz[i,j]+" ");
      }
      Console.WriteLine();
    }
  }

  public void imprimir(string formatString){
    for(int i=0;i<_matriz.GetLength(0);i++){
      for(int j=0;j<_matriz.GetLength(1);j++){
        Console.Write(_matriz[i,j].ToString(formatString)+ " ");
      }
    }
  }
  public double[] GetFila(int fila){
    double[] ret= new double[filas];
    for(int i=0;i<columnas;i++){
      ret[i]=_matriz[fila,i];
    }
    return ret;
  }
  public double[] GetColumna(int columna){
    double[] ret= new double[columnas];
    for(int i=0;i<filas;i++){
      ret[i]=_matriz[i,columnas];
    }
    return ret;
  }

  
  public double[] DiagonalPrincipal{//ahora es una propiedad y solo de lectura, ya que solo tiene get
    get{
  int columnas=_matriz.GetLength(0);
  int filas=_matriz.GetLength(1);
    if (filas!=columnas){
      throw new ArgumentException();
    }
    double[] vector=new double[columnas];
    for(int i=0;i<columnas;i++){
      vector[i]=_matriz[i,i];
      }
    return vector;
    }
  }

 public double[] DiagonalSecundaria{//ahora tambien es una propiedad y solo de lectura.
    get{
  int columnas=_matriz.GetLength(0);
  int filas=_matriz.GetLength(1);
    if (filas!=columnas){
      throw new ArgumentException();
    }
    double[] vector2=new double[columnas];
    for(int i=0,j=filas-1;i<columnas;i++,j--){
      vector2[i]=_matriz[i,j];
      }
    return vector2;
    }
  }
  
  public double[][] GetArregloDeArreglo(){
  int f= _matriz.GetLength(0);
  int c= _matriz.GetLength(1);
  double[][] imp=new double[f][];
    for(int i=0;i<f;i++){// me paro en la primera fila.
      imp[i]=new double[c];//creo un vector con la cantidad de columnas que tenga la matriz en i fila.
      for(int j=0;j<c;j++){//cargo el vector de c columnas. 
        imp[i][j]=_matriz[i,j];//con los datos de la fila i con los j datos.
      }
    }
    return imp;
  }
  public double[,]? Sumarle(double[,] A){
  int fA= A.GetLength(0);
  int cA= A.GetLength(1);
  int fB= _matriz.GetLength(0);
  int cB= _matriz.GetLength(1);
  if((fA!=fB) | (cA!=cB)){
    throw new Exception();
  }
  double[,] dev=new double[filas,columnas];
  for(int i=0;i<filas;i++){
    for(int j=0;j<columnas;j++){
    dev[i,j]=A[i,j]+_matriz[i,j];
    }
  }
  return dev;
  }
  public double[,]? Resta(double[,] A){
  int fA= A.GetLength(0);
  int cA= A.GetLength(1);
  int fB= _matriz.GetLength(0);
  int cB= _matriz.GetLength(1);
  if((fA!=fB) | (cA!=cB)){
    throw new Exception();
  }
  double[,] dev=new double[filas,columnas];
  for(int i=0;i<filas;i++){
    for(int j=0;j<columnas;j++){
    dev[i,j]=A[i,j]-_matriz[i,j];
    }
  }
  return dev;
  }
  double[,] multiplicarPor(double[,] m){
  int fA= m.GetLength(0);
  int cA= m.GetLength(1);
  int fB= _matriz.GetLength(0);
  int cB= _matriz.GetLength(1);
  double temp;
  double[,] result=new double[fA,cB];
  for (int i = 0; i < fA; i++){
    for(int j = 0; j < cB; j++){
      temp= 0;
      for(int k = 0; k < cA; k++){
          temp += m[i, k] * _matriz[k, j];
      }
      result[i,j]=temp;
    }
  }
  return result;
}
}