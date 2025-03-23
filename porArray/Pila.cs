
public class Pila {
    private int[] pila;
    private int tope;
    private int max;

    public Pila(int max) {
        this.max = max;
        pila = new int[max];
        tope = -1;
    }

    public void Push(int dato) {
        if (tope < max - 1) {
            tope++;
            pila[tope] = dato;
        } else {
            Console.WriteLine("Pila llena");
        }
    }

    public int Pop() {
        int dato = -1;
        if (tope >= 0) {
            dato = pila[tope];
            tope--;
        } else {
            Console.WriteLine("Pila vacía");
        }
        return dato;
    }

    public void Imprimir() {
        for (int i = tope; i >= 0; i--) {
            Console.WriteLine(pila[i]);
        }
    }
}
