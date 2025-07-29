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
        lbl_clubSelec = new Label();
        label2 = new Label();
        btn_regresar = new Button();
        btn_send = new Button();
        tBz_ssn = new TextBox();
        tBx_cellphoneNum = new TextBox();
        label1 = new Label();
        label3 = new Label();
        lbl_clubSel = new Label();
        lbl_usermatr = new Label();
        lbl_matr = new Label();
        SuspendLayout();
        // 
        // lbl_clubSelec
        // 
        lbl_clubSelec.AutoSize = true;
        lbl_clubSelec.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbl_clubSelec.ForeColor = Color.FromArgb(142, 182, 155);
        lbl_clubSelec.Location = new Point(126, 183);
        lbl_clubSelec.Name = "lbl_clubSelec";
        lbl_clubSelec.Size = new Size(651, 65);
        lbl_clubSelec.TabIndex = 0;
        lbl_clubSelec.Text = "Ingresa los siguientes datos";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.ForeColor = Color.FromArgb(218, 241, 222);
        label2.ImageAlign = ContentAlignment.TopLeft;
        label2.Location = new Point(22, 85);
        label2.Name = "label2";
        label2.Size = new Size(383, 25);
        label2.TabIndex = 1;
        label2.Text = "Rectifica si los datos que elegiste son correctos";
        // 
        // btn_regresar
        // 
        btn_regresar.BackColor = Color.FromArgb(218, 241, 222);
        btn_regresar.DialogResult = DialogResult.Cancel;
        btn_regresar.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn_regresar.ForeColor = Color.FromArgb(22, 56, 50);
        btn_regresar.Location = new Point(29, 629);
        btn_regresar.Name = "btn_regresar";
        btn_regresar.Size = new Size(158, 62);
        btn_regresar.TabIndex = 3;
        btn_regresar.Text = "Regresar";
        btn_regresar.UseVisualStyleBackColor = false;
        // 
        // btn_send
        // 
        btn_send.BackColor = Color.FromArgb(142, 182, 155);
        btn_send.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
        btn_send.ForeColor = Color.FromArgb(218, 241, 222);
        btn_send.ImageAlign = ContentAlignment.TopLeft;
        btn_send.Location = new Point(301, 498);
        btn_send.Name = "btn_send";
        btn_send.Size = new Size(374, 83);
        btn_send.TabIndex = 2;
        btn_send.Text = "Enviar";
        btn_send.UseVisualStyleBackColor = false;
        btn_send.Click += btn_send_Click;
        // 
        // tBz_ssn
        // 
        tBz_ssn.AcceptsReturn = true;
        tBz_ssn.BackColor = Color.FromArgb(218, 241, 222);
        tBz_ssn.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
        tBz_ssn.Location = new Point(411, 310);
        tBz_ssn.Name = "tBz_ssn";
        tBz_ssn.Size = new Size(345, 50);
        tBz_ssn.TabIndex = 0;
        // 
        // tBx_cellphoneNum
        // 
        tBx_cellphoneNum.BackColor = Color.FromArgb(218, 241, 222);
        tBx_cellphoneNum.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
        tBx_cellphoneNum.Location = new Point(411, 400);
        tBx_cellphoneNum.Name = "tBx_cellphoneNum";
        tBx_cellphoneNum.Size = new Size(344, 50);
        tBx_cellphoneNum.TabIndex = 1;
        // 
        // label1
        // 
        label1.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
        label1.Location = new Point(141, 310);
        label1.Name = "label1";
        label1.Size = new Size(264, 75);
        label1.TabIndex = 4;
        label1.Text = "Número de seguridad social (NSS):";
        // 
        // label3
        // 
        label3.Font = new Font("Segoe UI Semilight", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
        label3.Location = new Point(141, 385);
        label3.Name = "label3";
        label3.Size = new Size(264, 75);
        label3.TabIndex = 5;
        label3.Text = "Número de teléfono celular:";
        // 
        // lbl_clubSel
        // 
        lbl_clubSel.AutoSize = true;
        lbl_clubSel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
        lbl_clubSel.ForeColor = Color.FromArgb(218, 241, 222);
        lbl_clubSel.Location = new Point(12, 18);
        lbl_clubSel.Name = "lbl_clubSel";
        lbl_clubSel.Size = new Size(382, 54);
        lbl_clubSel.TabIndex = 6;
        lbl_clubSel.Text = "Club seleccionado: ";
        // 
        // lbl_usermatr
        // 
        lbl_usermatr.AutoSize = true;
        lbl_usermatr.Location = new Point(508, 711);
        lbl_usermatr.Name = "lbl_usermatr";
        lbl_usermatr.Size = new Size(269, 25);
        lbl_usermatr.TabIndex = 7;
        lbl_usermatr.Text = "Matrícula del usuario a registrar: ";
        // 
        // lbl_matr
        // 
        lbl_matr.AutoSize = true;
        lbl_matr.Location = new Point(783, 711);
        lbl_matr.Name = "lbl_matr";
        lbl_matr.Size = new Size(0, 25);
        lbl_matr.TabIndex = 8;
        // 
        // ConfirmacionClubes
        // 
        AcceptButton = btn_send;
        AutoScaleDimensions = new SizeF(10F, 25F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(35, 83, 71);
        CancelButton = btn_regresar;
        ClientSize = new Size(941, 759);
        Controls.Add(lbl_matr);
        Controls.Add(lbl_usermatr);
        Controls.Add(lbl_clubSel);
        Controls.Add(label3);
        Controls.Add(label1);
        Controls.Add(tBx_cellphoneNum);
        Controls.Add(tBz_ssn);
        Controls.Add(btn_send);
        Controls.Add(btn_regresar);
        Controls.Add(label2);
        Controls.Add(lbl_clubSelec);
        ForeColor = Color.FromArgb(218, 241, 222);
        Margin = new Padding(4, 5, 4, 5);
        Name = "ConfirmacionClubes";
        Text = "Confirmar Club";
        TransparencyKey = Color.White;
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label lbl_clubSel;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox tBz_ssn;
    private System.Windows.Forms.TextBox tBx_cellphoneNum;

    private System.Windows.Forms.Button btn_regresar;
    private System.Windows.Forms.Button btn_send;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label lbl_clubSelec;

    #endregion

    private Label lbl_usermatr;
    private Label lbl_matr;
}