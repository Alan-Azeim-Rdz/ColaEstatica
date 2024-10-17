namespace ColaEstatica
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            BtnEnqueue = new Button();
            BtnDequeue = new Button();
            BtnPeek = new Button();
            BtnIsFull = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            TxtNumberAdd = new TextBox();
            LisBxDataNumber = new ListBox();
            LisboxPriority = new ListBox();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // BtnEnqueue
            // 
            BtnEnqueue.Location = new Point(230, 43);
            BtnEnqueue.Name = "BtnEnqueue";
            BtnEnqueue.Size = new Size(75, 23);
            BtnEnqueue.TabIndex = 0;
            BtnEnqueue.Text = "Add";
            BtnEnqueue.UseVisualStyleBackColor = true;
            BtnEnqueue.Click += BtnEnqueue_Click;
            // 
            // BtnDequeue
            // 
            BtnDequeue.Location = new Point(230, 96);
            BtnDequeue.Name = "BtnDequeue";
            BtnDequeue.Size = new Size(75, 23);
            BtnDequeue.TabIndex = 1;
            BtnDequeue.Text = "Remove";
            BtnDequeue.UseVisualStyleBackColor = true;
            BtnDequeue.Click += BtnDequeue_Click;
            // 
            // BtnPeek
            // 
            BtnPeek.Location = new Point(230, 150);
            BtnPeek.Name = "BtnPeek";
            BtnPeek.Size = new Size(75, 23);
            BtnPeek.TabIndex = 2;
            BtnPeek.Text = "Mostrar";
            BtnPeek.UseVisualStyleBackColor = true;
            BtnPeek.Click += BtnPeek_Click;
            // 
            // BtnIsFull
            // 
            BtnIsFull.Location = new Point(230, 204);
            BtnIsFull.Name = "BtnIsFull";
            BtnIsFull.Size = new Size(75, 23);
            BtnIsFull.TabIndex = 3;
            BtnIsFull.Text = "size";
            BtnIsFull.UseVisualStyleBackColor = true;
            BtnIsFull.Click += BtnIsFull_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 47);
            label1.Name = "label1";
            label1.Size = new Size(107, 15);
            label1.TabIndex = 4;
            label1.Text = "Agrega un numero";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 96);
            label2.Name = "label2";
            label2.Size = new Size(177, 15);
            label2.TabIndex = 5;
            label2.Text = "Quitar datos (Dato mas antiguo)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 150);
            label3.Name = "label3";
            label3.Size = new Size(144, 15);
            label3.TabIndex = 6;
            label3.Text = "mostrar dato mas antiguo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 204);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 7;
            label4.Text = "verificar espacio";
            // 
            // TxtNumberAdd
            // 
            TxtNumberAdd.Location = new Point(334, 43);
            TxtNumberAdd.Name = "TxtNumberAdd";
            TxtNumberAdd.Size = new Size(100, 23);
            TxtNumberAdd.TabIndex = 8;
            // 
            // LisBxDataNumber
            // 
            LisBxDataNumber.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LisBxDataNumber.FormattingEnabled = true;
            LisBxDataNumber.ItemHeight = 45;
            LisBxDataNumber.Location = new Point(682, 25);
            LisBxDataNumber.Name = "LisBxDataNumber";
            LisBxDataNumber.Size = new Size(135, 409);
            LisBxDataNumber.TabIndex = 9;
            // 
            // LisboxPriority
            // 
            LisboxPriority.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LisboxPriority.FormattingEnabled = true;
            LisboxPriority.ItemHeight = 45;
            LisboxPriority.Location = new Point(460, 29);
            LisboxPriority.Name = "LisboxPriority";
            LisboxPriority.Size = new Size(135, 409);
            LisboxPriority.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(500, 7);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 11;
            label5.Text = "Prioridad 1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(723, 7);
            label6.Name = "label6";
            label6.Size = new Size(64, 15);
            label6.TabIndex = 12;
            label6.Text = "Prioridad 2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 450);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(LisboxPriority);
            Controls.Add(LisBxDataNumber);
            Controls.Add(TxtNumberAdd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnIsFull);
            Controls.Add(BtnPeek);
            Controls.Add(BtnDequeue);
            Controls.Add(BtnEnqueue);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnEnqueue;
        private Button BtnDequeue;
        private Button BtnPeek;
        private Button BtnIsFull;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox TxtNumberAdd;
        private ListBox LisBxDataNumber;
        private ListBox LisboxPriority;
        private Label label5;
        private Label label6;
    }
}
