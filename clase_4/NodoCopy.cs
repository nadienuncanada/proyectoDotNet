
/*class Nodo
{
  Elemento? raiz = null;
  int tam = 0;
  int altura = 0;

  public Nodo(int d)
  {
   Insertar(d);
  }
  public void Insertar(int d){
    int nivel = 0;
    Elemento n = new Elemento(d);
    if (raiz == null){
      raiz = n;
      tam++;
      altura = 0;
    }
    else{
      Elemento anterior = null, actual;
      actual = raiz;
      while (actual != null){
        anterior = actual;
        if (d < actual.Dato){
          actual = actual.Izq;
          nivel++;
          }
        else if (d > actual.Dato){
          actual = actual.Der;
          nivel++;
        }
        else{
          Console.WriteLine("{0} es un dato reetido", d);
          return;
        }
      }
      if (d < anterior.Dato){
        anterior.Izq = n;
        tam++;
      }
      else{
        anterior.Der = n;
        tam++;
      }
    }
    if (nivel > altura)
      altura = nivel;
  }
  public void GetInOrder(Elemento n, ref int[] array, ref int i){
      if (n != null){
        GetInOrder(n.Izq, ref array, ref i);
        array[i] = n.Dato;
        i++;
        GetInOrder(n.Der, ref array, ref i);
      }
  }
  public int[] GetInOrder(){
    int i = 0;
    int[] array = new int[tam];
    GetInOrder(raiz, ref array, ref i);
    return array;
  }
  public int GetValorMinimo(){
    if (raiz == null)
      return 0;
    Elemento trabajo = raiz;
    int minimo = trabajo.Dato;
    while (trabajo.Izq != null){
      trabajo = trabajo.Izq;
      minimo = trabajo.Dato;
    }
    return minimo;
  }
  public int GetValorMaximo(){
    if (raiz == null)
      return 0;
    Elemento trabajo = raiz;
    int maximo = trabajo.Dato;
    while (trabajo.Der != null){
      trabajo = trabajo.Der;
      maximo = trabajo.Dato;
    }
    return maximo;
  }
  public int GetAltura(){
    return altura;
  }
  public int GetCantNodos(){
    return tam;
  }

}
class Elemento{
  private int dato;
  private Elemento? izq;
  private Elemento? der;

  public Elemento(int d){
    dato = d;
    izq = der = null;
  }
  public int Dato { get => dato; set => dato = value; }
  internal Elemento Izq { get => izq; set => izq = value; }
  internal Elemento Der { get => der; set => der = value; }
}
*/