namespace clase_4;
class Nodo{
  private int cantidad=0;
  private int altura=0;
  private int dato;
  private Nodo izq,der;
  private Nodo raiz=null;

  public Nodo(int cant){
    Insertar(cant);
  }
  public void Insertar(int info){
    Nodo nuevo;
    int n=0;
    nuevo = new Nodo();//creo nuevo nodo
    nuevo.info = info;//le pongo el dato al nodo
    nuevo.izq = null;//arranco izq y derecha
    nuevo.der = null;
    if (raiz == null){//si la razi no esta creada
        raiz = nuevo;//la creo
      this.cantidad++;//aumento la cantidad de nodos
    }
    else{//sino
      Nodo anterior = null, actual;//creo anterior y actual;
      actual = raiz;//actual es raiz
      while (actual != null){//mientras actual no sea vacio
        anterior = actual;//anterior se vuelve raiz o lo anterior
        if (info < actual.info)//veo en que lado meto el dato, respetando los 
          actual = actual.izq;//si es mas chico que el dato actual va a la izquierda
        else
          actual = actual.der;//sino a la derecha.
      }
      if (info < anterior.info)//esto crearia la subparte del arbol
        anterior.izq = nuevo;
      else
        anterior.der = nuevo;
    }
  }
}