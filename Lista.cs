using Nodi;
namespace lista
{
    public class ListaConcatenata
    {
        private Nodo Testa { get; set; }
        public void Aggiungi(int valore)
        {
            Nodo nuovoNodo = new Nodo(valore);
            if (Testa == null)
            {
                Testa = nuovoNodo;
            }
            else
            {
                Nodo nodoCorrente = Testa;
                while (nodoCorrente.succ != null)
                {
                    nodoCorrente = nodoCorrente.succ;
                }
                nodoCorrente.succ = nuovoNodo;
            }
        }

        public Nodo get(int indice)
        {
            Nodo tmp = Testa;
            for (int i = 0; indice < i; i++)
            {
                tmp = tmp.succ;
            }
            return tmp;
        }
    }
}