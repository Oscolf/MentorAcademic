namespace WinFormsMentorAcademic
{
    partial class Confirmacion
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
            groupBox1 = new GroupBox();
            label5 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox2 = new GroupBox();
            btn_print = new Button();
            btn_back = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(218, 241, 222);
            label1.Location = new Point(209, 40);
            label1.Name = "label1";
            label1.Size = new Size(298, 55);
            label1.TabIndex = 0;
            label1.Text = "¿Estás seguro?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(164, 113);
            label2.Name = "label2";
            label2.Size = new Size(373, 30);
            label2.TabIndex = 1;
            label2.Text = "Rectifica que los datos sean correctos";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.ForeColor = Color.FromArgb(218, 241, 222);
            groupBox1.Location = new Point(30, 163);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(634, 181);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 133);
            label5.Name = "label5";
            label5.Size = new Size(98, 30);
            label5.TabIndex = 7;
            label5.Text = "Horario: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 39);
            label3.Name = "label3";
            label3.Size = new Size(98, 30);
            label3.TabIndex = 0;
            label3.Text = "Materia: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 86);
            label4.Name = "label4";
            label4.Size = new Size(106, 30);
            label4.TabIndex = 6;
            label4.Text = "Profesor: ";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(35, 83, 71);
            groupBox2.Controls.Add(btn_print);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(groupBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(218, 241, 222);
            groupBox2.Location = new Point(25, 42);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(691, 473);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Verifica tu registro";
            // 
            // btn_print
            // 
            btn_print.BackColor = Color.FromArgb(142, 182, 155);
            btn_print.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_print.ForeColor = Color.FromArgb(35, 83, 71);
            btn_print.Location = new Point(209, 375);
            btn_print.Name = "btn_print";
            btn_print.Size = new Size(285, 79);
            btn_print.TabIndex = 1;
            btn_print.Text = "Imprimir";
            btn_print.UseVisualStyleBackColor = false;
            btn_print.Click += btn_print_Click;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.FromArgb(218, 241, 222);
            btn_back.DialogResult = DialogResult.Cancel;
            btn_back.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_back.ForeColor = Color.FromArgb(35, 83, 71);
            btn_back.Location = new Point(12, 576);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(163, 62);
            btn_back.TabIndex = 0;
            btn_back.Text = "Regresar";
            btn_back.UseVisualStyleBackColor = false;
            // 
            // Confirmacion
            // 
            AcceptButton = btn_print;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 56, 50);
            CancelButton = btn_back;
            ClientSize = new Size(758, 650);
            Controls.Add(groupBox2);
            Controls.Add(btn_back);
            Margin = new Padding(4, 5, 4, 5);
            Name = "Confirmacion";
            Text = "Confirmar asesoría";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label3;
    }
}