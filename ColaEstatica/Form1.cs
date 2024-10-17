using System.Xml.Linq;

namespace ColaEstatica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        QueueStatic queueNumbers = new QueueStatic();
        QueueStatic queueNumbers_Priority = new QueueStatic();


        private void BtnEnqueue_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(TxtNumberAdd.Text);
                if (!queueNumbers_Priority.IsFull()) 
                {
                    queueNumbers_Priority.Enqueue(number);
                    TxtNumberAdd.Clear();
                    LisboxPriority.Items.Add(number.ToString());
                    return;
                }

                if (!queueNumbers.IsFull())
                {
                    queueNumbers.Enqueue(number);
                    TxtNumberAdd.Clear();
                    LisBxDataNumber.Items.Add(number.ToString());
                    return;
                }

                MessageBox.Show("La cola esta llena, si quieres introducir mas datos borra alugnos con el boton remove");



                TxtNumberAdd.Clear();
            }
            catch (System.FormatException)
            {
                MessageBox.Show("No puedes ingresar letras, porfavor ingresa un numero");
                TxtNumberAdd.Clear();
            }

        }

        private void BtnDequeue_Click(object sender, EventArgs e)
        {
            if (!queueNumbers_Priority.IsEmpty()) 
            {
                MessageBox.Show(queueNumbers_Priority.Dequeue());
                LisboxPriority.Items.RemoveAt(0);
                return;
            }
            if (!queueNumbers.IsEmpty())
            {
                MessageBox.Show(queueNumbers.Dequeue());
                LisBxDataNumber.Items.RemoveAt(0); // Remueve el primer elemento de la ListView
                return;
            }
            MessageBox.Show("No hay datos para sacar");
        }

        private void BtnIsFull_Click(object sender, EventArgs e)
        {

            MessageBox.Show("en la cola prioridad hay " + queueNumbers_Priority.Size().ToString() + " espacios ocupados en la cola estatica de 5");
            MessageBox.Show("en la cola sin normal hay " + queueNumbers.Size().ToString() + " espacios ocupados en la cola estatica de 5");
            return;
        }

        private void BtnPeek_Click(object sender, EventArgs e)
        {
            MessageBox.Show(queueNumbers_Priority.Peek());
            MessageBox.Show(queueNumbers.Peek());
        }
    }
}
