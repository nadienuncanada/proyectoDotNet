/*namespace clase_4;
class Nodo{
  private int cantidad=0;
  private int altura=0;
  private int? info;
  private Nodo? izq,der;
  private Nodo? raiz=null;

  public Nodo(int cant){
    Insertar(cant);
  }
  public void Insertar(int info){
    Nodo? nuevo;
    int n=0;
    nuevo = new Nodo(info);//creo nuevo nodo//le pongo el dato al nodo
    nuevo.izq = null;//arranco izq y derecha
    nuevo.der = null;
    if (raiz == null){//si la razi no esta creada
        raiz = nuevo;//la creo
        this.cantidad++;//aumento la cantidad de nodos
        this.altura=0;
    }
    else{//sino
      Nodo? anterior = null, actual;//creo anterior y actual;
      actual = raiz;//actual es raiz
      while (actual != null){//mientras actual no sea vacio
        anterior = actual;//anterior se vuelve raiz o lo anterior
        if (info < actual.info){//veo en que lado meto el dato, respetando los 
          actual = actual.izq;//si es mas chico que el dato actual va a la izquierda
          n++;//aumento de nivel
        }
        else{
          actual = actual.der;//sino a la derecha.
          n++;//aumento de nivel
        }
      }
      if (info < anterior.info){//esto crearia la subparte del arbol
        anterior.izq = nuevo;
        cantidad++;
      }
      else{
        anterior.der = nuevo;
        cantidad++;
      }
    }
    if(n<altura)
      altura=n;
  }
  /*public ArrayList GetInorden(Nodo raiz){
    ArrayList l= new ArrayList();
    if(raiz!=null){
        GetInorden(raiz.izq);
        l.add(raiz.dato);
        GetInorden(raiz.der);
    }
    return l;
  }
  
  public void GetInordenC(Nodo raiz){
    //ArrayList l= new ArrayList();
    if(raiz!=null){
        GetInordenC(raiz.izq);
        //l.add(raiz.dato);
        Console.WriteLine(raiz.info);
        GetInordenC(raiz.der);
    }
  }
  public int GetAltura()=>
    this.altura;
 
  public int GetCantNodos()=>
    this.cantidad;
  public int GetValorMáximo(){

  }
 public int GetValorMínimo(){

  }
  
}*/