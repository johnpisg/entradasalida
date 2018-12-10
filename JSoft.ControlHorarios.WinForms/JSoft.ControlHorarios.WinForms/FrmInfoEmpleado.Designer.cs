namespace JSoft.ControlHorarios.WinForms
{
    partial class FrmInfoEmpleado
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
            this.components = new System.ComponentModel.Container();
            this.PanelEmpleado = new System.Windows.Forms.GroupBox();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.LblHoraRegistrada = new System.Windows.Forms.Label();
            this.LblCargo = new System.Windows.Forms.Label();
            this.LblApellidos = new System.Windows.Forms.Label();
            this.LblNombres = new System.Windows.Forms.Label();
            this.ImgFoto = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.LblHora = new System.Windows.Forms.Label();
            this.TxtCodigoEmpleado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TimerHora = new System.Windows.Forms.Timer(this.components);
            this.TimerButton = new System.Windows.Forms.Timer(this.components);
            this.TimerMsg = new System.Windows.Forms.Timer(this.components);
            this.TxtEmpleadoId = new System.Windows.Forms.TextBox();
            this.PanelEmpleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgFoto)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelEmpleado
            // 
            this.PanelEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelEmpleado.Controls.Add(this.BtnRegistrar);
            this.PanelEmpleado.Controls.Add(this.LblHoraRegistrada);
            this.PanelEmpleado.Controls.Add(this.LblCargo);
            this.PanelEmpleado.Controls.Add(this.LblApellidos);
            this.PanelEmpleado.Controls.Add(this.LblNombres);
            this.PanelEmpleado.Controls.Add(this.ImgFoto);
            this.PanelEmpleado.Location = new System.Drawing.Point(12, 188);
            this.PanelEmpleado.Name = "PanelEmpleado";
            this.PanelEmpleado.Size = new System.Drawing.Size(808, 367);
            this.PanelEmpleado.TabIndex = 0;
            this.PanelEmpleado.TabStop = false;
            this.PanelEmpleado.Text = "Información del empleado";
            this.PanelEmpleado.Visible = false;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnRegistrar.BackColor = System.Drawing.Color.Blue;
            this.BtnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistrar.ForeColor = System.Drawing.Color.White;
            this.BtnRegistrar.Location = new System.Drawing.Point(296, 285);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(250, 76);
            this.BtnRegistrar.TabIndex = 5;
            this.BtnRegistrar.Text = "Aceptar";
            this.BtnRegistrar.UseVisualStyleBackColor = false;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            this.BtnRegistrar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BtnRegistrar_KeyDown);
            // 
            // LblHoraRegistrada
            // 
            this.LblHoraRegistrada.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblHoraRegistrada.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHoraRegistrada.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LblHoraRegistrada.Location = new System.Drawing.Point(18, 210);
            this.LblHoraRegistrada.Name = "LblHoraRegistrada";
            this.LblHoraRegistrada.Size = new System.Drawing.Size(766, 59);
            this.LblHoraRegistrada.TabIndex = 4;
            this.LblHoraRegistrada.Text = "Hora registrada: 00:00 AM/PM";
            this.LblHoraRegistrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblCargo
            // 
            this.LblCargo.AutoSize = true;
            this.LblCargo.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCargo.Location = new System.Drawing.Point(175, 153);
            this.LblCargo.Name = "LblCargo";
            this.LblCargo.Size = new System.Drawing.Size(87, 37);
            this.LblCargo.TabIndex = 3;
            this.LblCargo.Text = "Cargo";
            // 
            // LblApellidos
            // 
            this.LblApellidos.AutoSize = true;
            this.LblApellidos.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblApellidos.ForeColor = System.Drawing.Color.Blue;
            this.LblApellidos.Location = new System.Drawing.Point(172, 88);
            this.LblApellidos.Name = "LblApellidos";
            this.LblApellidos.Size = new System.Drawing.Size(626, 59);
            this.LblApellidos.TabIndex = 2;
            this.LblApellidos.Text = "Nombre1 Nombres2 Nombre3 ";
            // 
            // LblNombres
            // 
            this.LblNombres.AutoSize = true;
            this.LblNombres.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombres.ForeColor = System.Drawing.Color.Blue;
            this.LblNombres.Location = new System.Drawing.Point(172, 29);
            this.LblNombres.Name = "LblNombres";
            this.LblNombres.Size = new System.Drawing.Size(626, 59);
            this.LblNombres.TabIndex = 1;
            this.LblNombres.Text = "Nombre1 Nombres2 Nombre3 ";
            // 
            // ImgFoto
            // 
            this.ImgFoto.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ImgFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ImgFoto.Location = new System.Drawing.Point(18, 29);
            this.ImgFoto.Name = "ImgFoto";
            this.ImgFoto.Size = new System.Drawing.Size(148, 161);
            this.ImgFoto.TabIndex = 0;
            this.ImgFoto.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.TxtEmpleadoId);
            this.groupBox2.Controls.Add(this.LblHora);
            this.groupBox2.Controls.Add(this.TxtCodigoEmpleado);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(808, 170);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registro";
            // 
            // LblHora
            // 
            this.LblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblHora.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.LblHora.Location = new System.Drawing.Point(30, 16);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(754, 59);
            this.LblHora.TabIndex = 6;
            this.LblHora.Text = "Hora: 00:00 AM/PM";
            this.LblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtCodigoEmpleado
            // 
            this.TxtCodigoEmpleado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCodigoEmpleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtCodigoEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigoEmpleado.Location = new System.Drawing.Point(331, 110);
            this.TxtCodigoEmpleado.Name = "TxtCodigoEmpleado";
            this.TxtCodigoEmpleado.Size = new System.Drawing.Size(453, 29);
            this.TxtCodigoEmpleado.TabIndex = 5;
            this.TxtCodigoEmpleado.TextChanged += new System.EventHandler(this.TxtCodigoEmpleado_TextChanged);
            this.TxtCodigoEmpleado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCodigoEmpleado_KeyDown);
            this.TxtCodigoEmpleado.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCodigoEmpleado_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código de Empleado:";
            // 
            // TimerHora
            // 
            this.TimerHora.Interval = 1000;
            this.TimerHora.Tick += new System.EventHandler(this.TimerHora_Tick);
            // 
            // TimerButton
            // 
            this.TimerButton.Interval = 1000;
            this.TimerButton.Tick += new System.EventHandler(this.TimerButton_Tick);
            // 
            // TimerMsg
            // 
            this.TimerMsg.Interval = 1000;
            this.TimerMsg.Tick += new System.EventHandler(this.TimerMsg_Tick);
            // 
            // TxtEmpleadoId
            // 
            this.TxtEmpleadoId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEmpleadoId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtEmpleadoId.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEmpleadoId.Location = new System.Drawing.Point(18, 19);
            this.TxtEmpleadoId.Name = "TxtEmpleadoId";
            this.TxtEmpleadoId.Size = new System.Drawing.Size(20, 29);
            this.TxtEmpleadoId.TabIndex = 7;
            this.TxtEmpleadoId.Visible = false;
            // 
            // FrmInfoEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 567);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.PanelEmpleado);
            this.Name = "FrmInfoEmpleado";
            this.Text = "Control de Entrada/Salida";
            this.Load += new System.EventHandler(this.FrmInfoEmpleado_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmInfoEmpleado_KeyDown);
            this.PanelEmpleado.ResumeLayout(false);
            this.PanelEmpleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImgFoto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PanelEmpleado;
        private System.Windows.Forms.PictureBox ImgFoto;
        private System.Windows.Forms.Label LblApellidos;
        private System.Windows.Forms.Label LblNombres;
        private System.Windows.Forms.Label LblCargo;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Label LblHoraRegistrada;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TxtCodigoEmpleado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.Timer TimerHora;
        private System.Windows.Forms.Timer TimerButton;
        private System.Windows.Forms.Timer TimerMsg;
        private System.Windows.Forms.TextBox TxtEmpleadoId;
    }
}

