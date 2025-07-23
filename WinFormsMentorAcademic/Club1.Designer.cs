namespace WinFormsMentorAcademic;

partial class Club1
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
        btn_regresar = new System.Windows.Forms.Button();
        btn_porristas = new System.Windows.Forms.Button();
        btn_rondallaCanto = new System.Windows.Forms.Button();
        btn_ritmosLatinos = new System.Windows.Forms.Button();
        btn_bandaGuerra = new System.Windows.Forms.Button();
        btn_ajedrez = new System.Windows.Forms.Button();
        btn_danzaFolk = new System.Windows.Forms.Button();
        SuspendLayout();
        // 
        // btn_regresar
        // 
        btn_regresar.BackColor = System.Drawing.Color.FromArgb(((int)((byte)218)), ((int)((byte)241)), ((int)((byte)222)));
        btn_regresar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        btn_regresar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_regresar.Location = new System.Drawing.Point(356, 670);
        btn_regresar.Name = "btn_regresar";
        btn_regresar.Size = new System.Drawing.Size(256, 87);
        btn_regresar.TabIndex = 6;
        btn_regresar.Text = "Regresar";
        btn_regresar.UseVisualStyleBackColor = false;
        btn_regresar.Visible = false;
        btn_regresar.Click += btn_regresar_Click;
        // 
        // btn_porristas
        // 
        btn_porristas.BackColor = System.Drawing.Color.Black;
        btn_porristas.BackgroundImage = global::WinFormsMentorAcademic.Fondos.porristas;
        btn_porristas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        btn_porristas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_porristas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        btn_porristas.Location = new System.Drawing.Point(28, 348);
        btn_porristas.Name = "btn_porristas";
        btn_porristas.Size = new System.Drawing.Size(300, 300);
        btn_porristas.TabIndex = 3;
        btn_porristas.Text = "Porristas";
        btn_porristas.UseVisualStyleBackColor = false;
        btn_porristas.Click += btn_seleccionado;
        // 
        // btn_rondallaCanto
        // 
        btn_rondallaCanto.BackColor = System.Drawing.Color.Black;
        btn_rondallaCanto.BackgroundImage = global::WinFormsMentorAcademic.Fondos.rondalla_y_canto;
        btn_rondallaCanto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        btn_rondallaCanto.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_rondallaCanto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        btn_rondallaCanto.Location = new System.Drawing.Point(334, 348);
        btn_rondallaCanto.Name = "btn_rondallaCanto";
        btn_rondallaCanto.Size = new System.Drawing.Size(300, 300);
        btn_rondallaCanto.TabIndex = 4;
        btn_rondallaCanto.Text = "Rondalla y canto";
        btn_rondallaCanto.UseVisualStyleBackColor = false;
        btn_rondallaCanto.Click += btn_seleccionado;
        // 
        // btn_ritmosLatinos
        // 
        btn_ritmosLatinos.BackColor = System.Drawing.Color.Black;
        btn_ritmosLatinos.BackgroundImage = global::WinFormsMentorAcademic.Fondos.ritmos_latinos;
        btn_ritmosLatinos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        btn_ritmosLatinos.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_ritmosLatinos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        btn_ritmosLatinos.Location = new System.Drawing.Point(640, 348);
        btn_ritmosLatinos.Name = "btn_ritmosLatinos";
        btn_ritmosLatinos.Size = new System.Drawing.Size(300, 300);
        btn_ritmosLatinos.TabIndex = 5;
        btn_ritmosLatinos.Text = "Ritmos Latinos";
        btn_ritmosLatinos.UseVisualStyleBackColor = false;
        btn_ritmosLatinos.Click += btn_seleccionado;
        // 
        // btn_bandaGuerra
        // 
        btn_bandaGuerra.BackColor = System.Drawing.Color.Black;
        btn_bandaGuerra.BackgroundImage = global::WinFormsMentorAcademic.Fondos.minion_tarolero;
        btn_bandaGuerra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        btn_bandaGuerra.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_bandaGuerra.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        btn_bandaGuerra.Location = new System.Drawing.Point(640, 42);
        btn_bandaGuerra.Name = "btn_bandaGuerra";
        btn_bandaGuerra.Size = new System.Drawing.Size(300, 300);
        btn_bandaGuerra.TabIndex = 2;
        btn_bandaGuerra.Text = "Banda de guerra";
        btn_bandaGuerra.UseVisualStyleBackColor = false;
        btn_bandaGuerra.Click += btn_seleccionado;
        // 
        // btn_ajedrez
        // 
        btn_ajedrez.BackColor = System.Drawing.Color.Black;
        btn_ajedrez.BackgroundImage = global::WinFormsMentorAcademic.Fondos.ajedrez;
        btn_ajedrez.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        btn_ajedrez.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_ajedrez.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        btn_ajedrez.Location = new System.Drawing.Point(334, 42);
        btn_ajedrez.Name = "btn_ajedrez";
        btn_ajedrez.Size = new System.Drawing.Size(300, 300);
        btn_ajedrez.TabIndex = 1;
        btn_ajedrez.Text = "Ajedrez";
        btn_ajedrez.UseVisualStyleBackColor = false;
        btn_ajedrez.Click += btn_seleccionado;
        // 
        // btn_danzaFolk
        // 
        btn_danzaFolk.BackColor = System.Drawing.Color.Black;
        btn_danzaFolk.BackgroundImage = global::WinFormsMentorAcademic.Fondos.danza_folklorica;
        btn_danzaFolk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        btn_danzaFolk.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_danzaFolk.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
        btn_danzaFolk.Location = new System.Drawing.Point(28, 42);
        btn_danzaFolk.Name = "btn_danzaFolk";
        btn_danzaFolk.Size = new System.Drawing.Size(300, 300);
        btn_danzaFolk.TabIndex = 0;
        btn_danzaFolk.Text = "Danza Folklórica";
        btn_danzaFolk.UseVisualStyleBackColor = false;
        btn_danzaFolk.Click += btn_seleccionado;
        // 
        // Club1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        BackColor = System.Drawing.Color.FromArgb(((int)((byte)0)), ((int)((byte)63)), ((int)((byte)63)));
        BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
        CancelButton = btn_regresar;
        ClientSize = new System.Drawing.Size(978, 803);
        Controls.Add(btn_regresar);
        Controls.Add(btn_ritmosLatinos);
        Controls.Add(btn_porristas);
        Controls.Add(btn_bandaGuerra);
        Controls.Add(btn_ajedrez);
        Controls.Add(btn_rondallaCanto);
        Controls.Add(btn_danzaFolk);
        Location = new System.Drawing.Point(22, 22);
        Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        Text = "Clubes Culturales";
        ResumeLayout(false);
    }

    private System.Windows.Forms.Button btn_porristas;
    private System.Windows.Forms.Button btn_rondallaCanto;
    private System.Windows.Forms.Button btn_ritmosLatinos;
    private System.Windows.Forms.Button btn_bandaGuerra;
    private System.Windows.Forms.Button btn_ajedrez;
    private System.Windows.Forms.Button btn_danzaFolk;

    #endregion

    private System.Windows.Forms.Button btn_regresar;
}