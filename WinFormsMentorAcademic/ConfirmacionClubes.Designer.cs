namespace WinFormsMentorAcademic;

partial class ConfirmacionClubes
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        lbl_clubSelec = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        button1 = new System.Windows.Forms.Button();
        button2 = new System.Windows.Forms.Button();
        button3 = new System.Windows.Forms.Button();
        button4 = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // lbl_clubSelec
        // 
        lbl_clubSelec.AutoSize = true;
        lbl_clubSelec.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lbl_clubSelec.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
        lbl_clubSelec.Location = new System.Drawing.Point(141, 41);
        lbl_clubSelec.Name = "lbl_clubSelec";
        lbl_clubSelec.Size = new System.Drawing.Size(651, 65);
        lbl_clubSelec.TabIndex = 0;
        lbl_clubSelec.Text = "Ingresa los siguientes datos";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
        label2.Location = new System.Drawing.Point(263, 117);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(383, 25);
        label2.TabIndex = 1;
        label2.Text = "Rectifica si los datos que elegiste son correctos";
        // 
        // button1
        // 
        button1.BackColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)56)), ((int)((byte)50)));
        button1.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        button1.ImageKey = "(ninguna)";
        button1.Location = new System.Drawing.Point(141, 199);
        button1.Name = "button1";
        button1.Size = new System.Drawing.Size(308, 136);
        button1.TabIndex = 2;
        button1.Text = "NSS";
        button1.UseVisualStyleBackColor = false;
        // 
        // button2
        // 
        button2.BackColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)56)), ((int)((byte)50)));
        button2.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        button2.Location = new System.Drawing.Point(502, 199);
        button2.Name = "button2";
        button2.Size = new System.Drawing.Size(308, 136);
        button2.TabIndex = 3;
        button2.Text = "Numero celular";
        button2.UseVisualStyleBackColor = false;
        // 
        // button3
        // 
        button3.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        button3.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)56)), ((int)((byte)50)));
        button3.Location = new System.Drawing.Point(27, 515);
        button3.Name = "button3";
        button3.Size = new System.Drawing.Size(119, 50);
        button3.TabIndex = 4;
        button3.Text = "Volver";
        button3.UseVisualStyleBackColor = false;
        // 
        // button4
        // 
        button4.BackColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
        button4.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        button4.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)56)), ((int)((byte)50)));
        button4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
        button4.Location = new System.Drawing.Point(284, 378);
        button4.Name = "button4";
        button4.Size = new System.Drawing.Size(374, 83);
        button4.TabIndex = 5;
        button4.Text = "Enviar";
        button4.UseVisualStyleBackColor = false;
        // 
        // ConfirmacionClubes
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)35)), ((int)((byte)83)), ((int)((byte)71)));
        ClientSize = new System.Drawing.Size(941, 583);
        Controls.Add(button4);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(label2);
        Controls.Add(lbl_clubSelec);
        Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        Text = "Verifica tus datos";
        TransparencyKey = System.Drawing.Color.White;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button button4;

    private System.Windows.Forms.Button button2;

    private System.Windows.Forms.Button button1;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label lbl_clubSelec;

    #endregion
}