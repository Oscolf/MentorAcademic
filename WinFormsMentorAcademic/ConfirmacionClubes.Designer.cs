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
        btn_regresar = new System.Windows.Forms.Button();
        btn_send = new System.Windows.Forms.Button();
        tBz_ssn = new System.Windows.Forms.TextBox();
        tBx_cellphoneNum = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        lbl_clubSel = new System.Windows.Forms.Label();
        SuspendLayout();
        // 
        // lbl_clubSelec
        // 
        lbl_clubSelec.AutoSize = true;
        lbl_clubSelec.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lbl_clubSelec.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
        lbl_clubSelec.Location = new System.Drawing.Point(126, 183);
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
        label2.Location = new System.Drawing.Point(22, 85);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(383, 25);
        label2.TabIndex = 1;
        label2.Text = "Rectifica si los datos que elegiste son correctos";
        // 
        // btn_regresar
        // 
        btn_regresar.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        btn_regresar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        btn_regresar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_regresar.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)22)), ((int)((byte)56)), ((int)((byte)50)));
        btn_regresar.Location = new System.Drawing.Point(29, 629);
        btn_regresar.Name = "btn_regresar";
        btn_regresar.Size = new System.Drawing.Size(158, 62);
        btn_regresar.TabIndex = 3;
        btn_regresar.Text = "Regresar";
        btn_regresar.UseVisualStyleBackColor = false;
        // 
        // btn_send
        // 
        btn_send.BackColor = System.Drawing.Color.FromArgb(((int)((byte)142)), ((int)((byte)182)), ((int)((byte)155)));
        btn_send.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_send.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        btn_send.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
        btn_send.Location = new System.Drawing.Point(301, 498);
        btn_send.Name = "btn_send";
        btn_send.Size = new System.Drawing.Size(374, 83);
        btn_send.TabIndex = 2;
        btn_send.Text = "Enviar";
        btn_send.UseVisualStyleBackColor = false;
        btn_send.Click += btn_send_Click;
        // 
        // tBz_ssn
        // 
        tBz_ssn.AcceptsReturn = true;
        tBz_ssn.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        tBz_ssn.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        tBz_ssn.Location = new System.Drawing.Point(411, 310);
        tBz_ssn.Name = "tBz_ssn";
        tBz_ssn.Size = new System.Drawing.Size(345, 50);
        tBz_ssn.TabIndex = 0;
        // 
        // tBx_cellphoneNum
        // 
        tBx_cellphoneNum.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        tBx_cellphoneNum.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        tBx_cellphoneNum.Location = new System.Drawing.Point(411, 400);
        tBx_cellphoneNum.Name = "tBx_cellphoneNum";
        tBx_cellphoneNum.Size = new System.Drawing.Size(344, 50);
        tBx_cellphoneNum.TabIndex = 1;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(141, 310);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(264, 75);
        label1.TabIndex = 4;
        label1.Text = "Número de seguridad social (NSS):";
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(141, 385);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(264, 75);
        label3.TabIndex = 5;
        label3.Text = "Número de teléfono celular:";
        // 
        // lbl_clubSel
        // 
        lbl_clubSel.AutoSize = true;
        lbl_clubSel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)0));
        lbl_clubSel.ForeColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        lbl_clubSel.Location = new System.Drawing.Point(12, 18);
        lbl_clubSel.Name = "lbl_clubSel";
        lbl_clubSel.Size = new System.Drawing.Size(382, 54);
        lbl_clubSel.TabIndex = 6;
        lbl_clubSel.Text = "Club seleccionado: ";
        // 
        // ConfirmacionClubes
        // 
        AcceptButton = btn_send;
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)35)), ((int)((byte)83)), ((int)((byte)71)));
        CancelButton = btn_regresar;
        ClientSize = new System.Drawing.Size(941, 759);
        Controls.Add(lbl_clubSel);
        Controls.Add(label3);
        Controls.Add(label1);
        Controls.Add(tBx_cellphoneNum);
        Controls.Add(tBz_ssn);
        Controls.Add(btn_send);
        Controls.Add(btn_regresar);
        Controls.Add(label2);
        Controls.Add(lbl_clubSelec);
        ForeColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        Text = "Confirmar Club";
        TransparencyKey = System.Drawing.Color.White;
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
}