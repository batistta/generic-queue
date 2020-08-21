using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FILA_GENÉRICA
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        class Celula<T>
        {
            public T dado { get; set; }
            public Celula<T> prox { get; set; }
        }
        class FilaDinamica<T>
        {
            public Celula<T> Primeiro;
            public Celula<T> Ultimo;
            int tam;

            public FilaDinamica()
            {
                Primeiro = new Celula<T>();
                Ultimo = Primeiro;
                Primeiro.prox = null;
            }

            public void Enfileirar(T dado)
            {
                Celula<T> temp = new Celula<T>();
                temp.dado = dado;
                temp.prox = null;

                Ultimo.prox = temp;
                Ultimo = temp;

                tam++;
            }
            public bool Vazia()
            {
                return Primeiro == Ultimo;
            }

            public T Desenfileirar()
            {
                if (Vazia())
                {
                    object r = "";
                    Console.WriteLine("FILA VAZIA!");
                    T retorno = (T)r;
                    return retorno;
                }
                Primeiro = Primeiro.prox;
                tam--;
                return Primeiro.dado;
            }
        }
    }
}
