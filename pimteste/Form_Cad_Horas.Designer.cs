namespace pimteste
{
    partial class Form_Cad_Horas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox3 = new MaskedTextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 61);
            label1.Name = "label1";
            label1.Size = new Size(84, 35);
            label1.TabIndex = 1;
            label1.Text = "Nome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(465, 118);
            label2.Name = "label2";
            label2.Size = new Size(128, 35);
            label2.TabIndex = 2;
            label2.Text = "Hora Final";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(231, 117);
            label3.Name = "label3";
            label3.Size = new Size(141, 35);
            label3.TabIndex = 3;
            label3.Text = "Hora Inicial";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 70);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(534, 27);
            textBox1.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(39, 116);
            label4.Name = "label4";
            label4.Size = new Size(67, 35);
            label4.TabIndex = 8;
            label4.Text = "Data";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(121, 125);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(81, 27);
            maskedTextBox1.TabIndex = 9;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(608, 126);
            maskedTextBox2.Mask = "00:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(47, 27);
            maskedTextBox2.TabIndex = 10;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // maskedTextBox3
            // 
            maskedTextBox3.Location = new Point(387, 125);
            maskedTextBox3.Mask = "00:00";
            maskedTextBox3.Name = "maskedTextBox3";
            maskedTextBox3.Size = new Size(47, 27);
            maskedTextBox3.TabIndex = 11;
            maskedTextBox3.ValidatingType = typeof(DateTime);
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(465, 357);
            button1.Name = "button1";
            button1.Size = new Size(147, 45);
            button1.TabIndex = 12;
            button1.Text = "Inserir registro";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(312, 357);
            button2.Name = "button2";
            button2.Size = new Size(122, 45);
            button2.TabIndex = 13;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(141, 357);
            button3.Name = "button3";
            button3.Size = new Size(147, 45);
            button3.TabIndex = 14;
            button3.Text = "Voltar";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form_Cad_Horas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(maskedTextBox3);
            Controls.Add(maskedTextBox2);
            Controls.Add(maskedTextBox1);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form_Cad_Horas";
            Text = "Form_Cad_Horas";
            Load += Form_Cad_Horas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private Label label4;
        private MaskedTextBox maskedTextBox1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox3;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}