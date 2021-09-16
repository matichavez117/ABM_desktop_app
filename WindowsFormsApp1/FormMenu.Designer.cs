namespace WindowsFormsApp1
{
    partial class frmUDM
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUDM));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.datosPersonalesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.docentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tecnicaturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.materiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exámenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReporteTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.datosPersonalesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ConsultasTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aCercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enviarComentariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notificarUnProblemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sugerirUnaCaracterísticaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.soporteTécnicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCuenta = new System.Windows.Forms.TextBox();
            this.txtConstrasenia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Linen;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoTSMI,
            this.ReporteTSMI,
            this.ConsultasTSMI,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(467, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoTSMI
            // 
            this.archivoTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosPersonalesToolStripMenuItem,
            this.docentesToolStripMenuItem,
            this.alumnosToolStripMenuItem,
            this.tecnicaturasToolStripMenuItem,
            this.materiasToolStripMenuItem,
            this.exámenesToolStripMenuItem});
            this.archivoTSMI.Name = "archivoTSMI";
            this.archivoTSMI.Size = new System.Drawing.Size(73, 24);
            this.archivoTSMI.Text = "Archivo";
            this.archivoTSMI.Click += new System.EventHandler(this.archivoTSMI_Click);
            // 
            // datosPersonalesToolStripMenuItem
            // 
            this.datosPersonalesToolStripMenuItem.Name = "datosPersonalesToolStripMenuItem";
            this.datosPersonalesToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.datosPersonalesToolStripMenuItem.Text = "Datos personales";
            this.datosPersonalesToolStripMenuItem.Click += new System.EventHandler(this.datosPersonalesToolStripMenuItem_Click);
            // 
            // docentesToolStripMenuItem
            // 
            this.docentesToolStripMenuItem.Name = "docentesToolStripMenuItem";
            this.docentesToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.docentesToolStripMenuItem.Text = "Docentes";
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // tecnicaturasToolStripMenuItem
            // 
            this.tecnicaturasToolStripMenuItem.Name = "tecnicaturasToolStripMenuItem";
            this.tecnicaturasToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.tecnicaturasToolStripMenuItem.Text = "Tecnicaturas";
            // 
            // materiasToolStripMenuItem
            // 
            this.materiasToolStripMenuItem.Name = "materiasToolStripMenuItem";
            this.materiasToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.materiasToolStripMenuItem.Text = "Materias";
            // 
            // exámenesToolStripMenuItem
            // 
            this.exámenesToolStripMenuItem.Name = "exámenesToolStripMenuItem";
            this.exámenesToolStripMenuItem.Size = new System.Drawing.Size(206, 26);
            this.exámenesToolStripMenuItem.Text = "Exámenes";
            // 
            // ReporteTSMI
            // 
            this.ReporteTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosPersonalesToolStripMenuItem1});
            this.ReporteTSMI.Name = "ReporteTSMI";
            this.ReporteTSMI.Size = new System.Drawing.Size(82, 24);
            this.ReporteTSMI.Text = "Reportes";
            this.ReporteTSMI.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // datosPersonalesToolStripMenuItem1
            // 
            this.datosPersonalesToolStripMenuItem1.Name = "datosPersonalesToolStripMenuItem1";
            this.datosPersonalesToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.datosPersonalesToolStripMenuItem1.Text = "Datos personales";
            this.datosPersonalesToolStripMenuItem1.Click += new System.EventHandler(this.datosPersonalesToolStripMenuItem1_Click);
            // 
            // ConsultasTSMI
            // 
            this.ConsultasTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem});
            this.ConsultasTSMI.Name = "ConsultasTSMI";
            this.ConsultasTSMI.Size = new System.Drawing.Size(86, 24);
            this.ConsultasTSMI.Text = "Consultas";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.consultarToolStripMenuItem.Text = "Consultar...";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click_1);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aCercaDeToolStripMenuItem,
            this.enviarComentariosToolStripMenuItem,
            this.soporteTécnicoToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // aCercaDeToolStripMenuItem
            // 
            this.aCercaDeToolStripMenuItem.Name = "aCercaDeToolStripMenuItem";
            this.aCercaDeToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.aCercaDeToolStripMenuItem.Text = "Acerca de...";
            // 
            // enviarComentariosToolStripMenuItem
            // 
            this.enviarComentariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.notificarUnProblemaToolStripMenuItem,
            this.sugerirUnaCaracterísticaToolStripMenuItem});
            this.enviarComentariosToolStripMenuItem.Name = "enviarComentariosToolStripMenuItem";
            this.enviarComentariosToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.enviarComentariosToolStripMenuItem.Text = "Enviar comentarios";
            // 
            // notificarUnProblemaToolStripMenuItem
            // 
            this.notificarUnProblemaToolStripMenuItem.Name = "notificarUnProblemaToolStripMenuItem";
            this.notificarUnProblemaToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.notificarUnProblemaToolStripMenuItem.Text = "Notificar un problema...";
            // 
            // sugerirUnaCaracterísticaToolStripMenuItem
            // 
            this.sugerirUnaCaracterísticaToolStripMenuItem.Name = "sugerirUnaCaracterísticaToolStripMenuItem";
            this.sugerirUnaCaracterísticaToolStripMenuItem.Size = new System.Drawing.Size(267, 26);
            this.sugerirUnaCaracterísticaToolStripMenuItem.Text = "Sugerir una característica...";
            // 
            // soporteTécnicoToolStripMenuItem
            // 
            this.soporteTécnicoToolStripMenuItem.Name = "soporteTécnicoToolStripMenuItem";
            this.soporteTécnicoToolStripMenuItem.Size = new System.Drawing.Size(218, 26);
            this.soporteTécnicoToolStripMenuItem.Text = "Soporte técnico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 35);
            this.label1.TabIndex = 1;
            this.label1.Text = "BIENVENIDO...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(9, 96);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(1);
            this.label3.Size = new System.Drawing.Size(292, 53);
            this.label3.TabIndex = 3;
            this.label3.Text = "UDM es un software gestor de datos creado \r\nespecíficamente para las tecnicaturas" +
    " de la \r\nUniversidad Tecnológica Nacional.";
            // 
            // txtCuenta
            // 
            this.txtCuenta.BackColor = System.Drawing.SystemColors.Control;
            this.txtCuenta.Location = new System.Drawing.Point(6, 58);
            this.txtCuenta.Name = "txtCuenta";
            this.txtCuenta.Size = new System.Drawing.Size(214, 22);
            this.txtCuenta.TabIndex = 4;
            // 
            // txtConstrasenia
            // 
            this.txtConstrasenia.BackColor = System.Drawing.SystemColors.Control;
            this.txtConstrasenia.Location = new System.Drawing.Point(6, 124);
            this.txtConstrasenia.Name = "txtConstrasenia";
            this.txtConstrasenia.Size = new System.Drawing.Size(214, 22);
            this.txtConstrasenia.TabIndex = 5;
            this.txtConstrasenia.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(3, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cuenta:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(3, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Constraseña:";
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Linen;
            this.btnIngresar.Location = new System.Drawing.Point(6, 163);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(96, 45);
            this.btnIngresar.TabIndex = 9;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Linen;
            this.button2.Location = new System.Drawing.Point(385, 502);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 45);
            this.button2.TabIndex = 10;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnCerrarSesion);
            this.groupBox1.Controls.Add(this.txtCuenta);
            this.groupBox1.Controls.Add(this.btnIngresar);
            this.groupBox1.Controls.Add(this.txtConstrasenia);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 189);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 221);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "INICIAR SESIÓN";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Linen;
            this.btnCerrarSesion.Location = new System.Drawing.Point(124, 163);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(96, 45);
            this.btnCerrarSesion.TabIndex = 10;
            this.btnCerrarSesion.Text = "CERRAR SESIÓN";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Visible = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // frmUDM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            //this.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.abcd2c26508a27b6710e033394d8de92;
            this.ClientSize = new System.Drawing.Size(467, 559);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmUDM";
            this.Text = "University Data Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUDM_FormClosing);
            this.Load += new System.EventHandler(this.frmUDM_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoTSMI;
        private System.Windows.Forms.ToolStripMenuItem datosPersonalesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem docentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tecnicaturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem materiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exámenesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReporteTSMI;
        private System.Windows.Forms.ToolStripMenuItem ConsultasTSMI;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aCercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enviarComentariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notificarUnProblemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sugerirUnaCaracterísticaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soporteTécnicoToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCuenta;
        private System.Windows.Forms.TextBox txtConstrasenia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosPersonalesToolStripMenuItem1;
    }
}