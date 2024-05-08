namespace Nodi
{

    public class Nodo : IComparable
    {
        public int Valore { get; set; }
        public Nodo succ { get; set; }

        public Nodo(int valore)
        {
            Valore = valore;
            succ = null;
        }

        public int CompareTo(object other)
        {
            if (other == null) return 1;

                Nodo otherNodo = other as Nodo;
            
            if(otherNodo != null)
            {
                return this.Valore.CompareTo(otherNodo.Valore);
            }
            else
           throw new ArgumentException("3");

        }

    }
}