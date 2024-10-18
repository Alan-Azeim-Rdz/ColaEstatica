using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColaEstatica
{
    internal class QueueStatic
    {
        int head;
        int count;
        public int?[] queueNumber;


        public QueueStatic()
        {
            head = 0;
            count = 0;
            queueNumber = new int?[3];
        }


        public bool IsEmpty()
        {
            return count == 0;
        }

        public bool IsFull()
        {
            return count == queueNumber.Length;
        }

        public void Enqueue(int Number)
        {
            if (!IsFull())
            {
                queueNumber[count] = Number;
                count++;
                return;
            }

            return;

        }

        public string Dequeue()
        {
            if (IsEmpty())
            {
                return "La cola está vacía.";
            }

            string numberInHead = queueNumber[0].ToString();

            // Desplazar los elementos restantes hacia la izquierda
            for (int i = 0; i < count - 1;)
            {
                queueNumber[i] = queueNumber[i + 1];
                i++;
            } 

            count--;
            queueNumber[count] = null;

            return numberInHead;
        }

        public int Size()
        {

            return count;
        }

        public string Peek()
        {
            if (IsEmpty())
            {
                return "La cola está vacía.";
            }

            string numberInTheHead = queueNumber[0].ToString();
            return numberInTheHead;
        }


    }
}
