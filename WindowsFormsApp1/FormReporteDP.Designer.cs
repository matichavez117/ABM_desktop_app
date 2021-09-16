namespace WindowsFormsApp1
{
    partial class FormReporteDP
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.DATOS_PERSONALESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsDatosPersonales = new WindowsFormsApp1.dsDatosPersonales();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DATOS_PERSONALESTableAdapter = new WindowsFormsApp1.dsDatosPersonalesTableAdapters.DATOS_PERSONALESTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnImprimirTodo = new System.Windows.Forms.Button();
            this.rbtApellidoF = new System.Windows.Forms.RadioButton();
            this.rbtNroDocF = new System.Windows.Forms.RadioButton();
            this.btnImprimirFiltro = new System.Windows.Forms.Button();
            this.txtNombreF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DATOS_PERSONALESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatosPersonales)).BeginInit();
            this.SuspendLayout();
            // 
            // DATOS_PERSONALESBindingSource
            // 
            this.DATOS_PERSONALESBindingSource.DataMember = "DATOS_PERSONALES";
            this.DATOS_PERSONALESBindingSource.DataSource = this.dsDatosPersonales;
            // 
            // dsDatosPersonales
            // 
            this.dsDatosPersonales.DataSetName = "dsDatosPersonales";
            this.dsDatosPersonales.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSetDP";
            reportDataSource1.Value = this.DATOS_PERSONALESBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.reportDP.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(855, 477);
            this.reportViewer1.TabIndex = 0;
            // 
            // DATOS_PERSONALESTableAdapter
            // 
            this.DATOS_PERSONALESTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSetDP";
            reportDataSource2.Value = this.DATOS_PERSONALESBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "WindowsFormsApp1.reportDP.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(780, 12);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(8, 28);
            this.reportViewer2.TabIndex = 1;
            // 
            // btnImprimirTodo
            // 
            this.btnImprimirTodo.Location = new System.Drawing.Point(2, 495);
            this.btnImprimirTodo.Name = "btnImprimirTodo";
            this.btnImprimirTodo.Size = new System.Drawing.Size(114, 33);
            this.btnImprimirTodo.TabIndex = 2;
            this.btnImprimirTodo.Text = "Imprimir";
            this.btnImprimirTodo.UseVisualStyleBackColor = true;
            this.btnImprimirTodo.Click += new System.EventHandler(this.btnImprimirTodo_Click);
            // 
            // rbtApellidoF
            // 
            this.rbtApellidoF.AutoSize = true;
            this.rbtApellidoF.Location = new System.Drawing.Point(298, 507);
            this.rbtApellidoF.Name = "rbtApellidoF";
            this.rbtApellidoF.Size = new System.Drawing.Size(79, 21);
            this.rbtApellidoF.TabIndex = 3;
            this.rbtApellidoF.TabStop = true;
            this.rbtApellidoF.Text = "Apellido";
            this.rbtApellidoF.UseVisualStyleBackColor = true;
            // 
            // rbtNroDocF
            // 
            this.rbtNroDocF.AutoSize = true;
            this.rbtNroDocF.Location = new System.Drawing.Point(144, 507);
            this.rbtNroDocF.Name = "rbtNroDocF";
            this.rbtNroDocF.Size = new System.Drawing.Size(128, 21);
            this.rbtNroDocF.TabIndex = 4;
            this.rbtNroDocF.TabStop = true;
            this.rbtNroDocF.Text = "Nro Documento";
            this.rbtNroDocF.UseVisualStyleBackColor = true;
            // 
            // btnImprimirFiltro
            // 
            this.btnImprimirFiltro.Location = new System.Drawing.Point(718, 495);
            this.btnImprimirFiltro.Name = "btnImprimirFiltro";
            this.btnImprimirFiltro.Size = new System.Drawing.Size(139, 33);
            this.btnImprimirFiltro.TabIndex = 5;
            this.btnImprimirFiltro.Text = "Imprimir con filtro";
            this.btnImprimirFiltro.UseVisualStyleBackColor = true;
            this.btnImprimirFiltro.Click += new System.EventHandler(this.btnImprimirFiltro_Click);
            // 
            // txtNombreF
            // 
            this.txtNombreF.Location = new System.Drawing.Point(561, 506);
            this.txtNombreF.Name = "txtNombreF";
            this.txtNombreF.Size = new System.Drawing.Size(137, 22);
            this.txtNombreF.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // FormReporteDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 540);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNombreF);
            this.Controls.Add(this.btnImprimirFiltro);
            this.Controls.Add(this.rbtNroDocF);
            this.Controls.Add(this.rbtApellidoF);
            this.Controls.Add(this.btnImprimirTodo);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReporteDP";
            this.Text = "FormReporteDP";
            this.Load += new System.EventHandler(this.FormReporteDP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DATOS_PERSONALESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsDatosPersonales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DATOS_PERSONALESBindingSource;
        private dsDatosPersonales dsDatosPersonales;
        private dsDatosPersonalesTableAdapters.DATOS_PERSONALESTableAdapter DATOS_PERSONALESTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.Button btnImprimirTodo;
        private System.Windows.Forms.RadioButton rbtApellidoF;
        private System.Windows.Forms.RadioButton rbtNroDocF;
        private System.Windows.Forms.Button btnImprimirFiltro;
        private System.Windows.Forms.TextBox txtNombreF;
        private System.Windows.Forms.Label label1;
    }
}