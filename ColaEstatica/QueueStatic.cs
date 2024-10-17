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
        public int[] queueNumber;


        public QueueStatic()
        {
            head = 0;
            count = 0;
            queueNumber = new int[5];
        }


        public bool IsEmpty()
        {
            return count == 0;
        }

        public bool IsFull()
        {
            return count == sice;
        }

        public void Enqueue(int Number)
        {
            if (!IsFull())
            {
               queueNumber[count] = Number;
                return;
            }

            MessageBox.Show("ya no hay boletos que califiquen al descuento");
            return;

        }

    }
}
