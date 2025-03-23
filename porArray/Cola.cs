namespace Pilas;

public class Cola {
    private int[] cola;
    private int frente;
    private int fin;
    private int max;

    public Cola(int max) {
        this.max = max;
        cola = new int[max];
        frente = 0;
        fin = -1;
    }

    public void Insertar(int dato) {
        if (fin < max - 1) {
            fin++;
            cola[fin] = dato;
        } else {
            Console.WriteLine("Cola llena");
        }
    }

    public int Eliminar() {
        int dato = -1;
        if (frente <= fin) {
            dato = cola[frente];
            for (int i = frente; i < fin; i++) {
                cola[i] = cola[i + 1];
            }
            fin--;
        } else {
            Console.WriteLine("Cola vacía");
        }
        return dato;
    }

    public void Imprimir() {
        for (int i = frente; i <= fin; i++) {
            Console.WriteLine(cola[i]);
        }
    }
}
