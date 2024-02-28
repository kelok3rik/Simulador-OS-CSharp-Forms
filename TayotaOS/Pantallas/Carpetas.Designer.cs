namespace TayotaOS.Pantallas
{
    partial class Carpetas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombreCarpeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carpeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombreCarpeta = new System.Windows.Forms.TextBox();
            this.txtnombreArchivoTxt = new System.Windows.Forms.TextBox();
            this.txtEditorTexto = new System.Windows.Forms.RichTextBox();
            this.btnEditor = new System.Windows.Forms.Button();
            this.btnEditarTxt = new System.Windows.Forms.Button();
            this.btnAgregarTxt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAtras);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 82);
            this.panel1.TabIndex = 0;
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(33, 12);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(134, 57);
            this.btnAtras.TabIndex = 3;
            this.btnAtras.Text = "<=";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(453, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(134, 57);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(313, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(134, 57);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(173, 12);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(134, 57);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreCarpeta,
            this.carpeta});
            this.dataGridView1.Location = new System.Drawing.Point(30, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(414, 291);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // nombreCarpeta
            // 
            this.nombreCarpeta.Frozen = true;
            this.nombreCarpeta.HeaderText = "Nombre";
            this.nombreCarpeta.MinimumWidth = 6;
            this.nombreCarpeta.Name = "nombreCarpeta";
            this.nombreCarpeta.ReadOnly = true;
            this.nombreCarpeta.Width = 125;
            // 
            // carpeta
            // 
            this.carpeta.Frozen = true;
            this.carpeta.HeaderText = "Direccion";
            this.carpeta.MinimumWidth = 6;
            this.carpeta.Name = "carpeta";
            this.carpeta.ReadOnly = true;
            this.carpeta.Width = 125;
            // 
            // txtNombreCarpeta
            // 
            this.txtNombreCarpeta.Location = new System.Drawing.Point(30, 88);
            this.txtNombreCarpeta.Name = "txtNombreCarpeta";
            this.txtNombreCarpeta.Size = new System.Drawing.Size(414, 22);
            this.txtNombreCarpeta.TabIndex = 2;
            // 
            // txtnombreArchivoTxt
            // 
            this.txtnombreArchivoTxt.Location = new System.Drawing.Point(684, 88);
            this.txtnombreArchivoTxt.Name = "txtnombreArchivoTxt";
            this.txtnombreArchivoTxt.Size = new System.Drawing.Size(414, 22);
            this.txtnombreArchivoTxt.TabIndex = 3;
            // 
            // txtEditorTexto
            // 
            this.txtEditorTexto.Location = new System.Drawing.Point(684, 116);
            this.txtEditorTexto.Name = "txtEditorTexto";
            this.txtEditorTexto.Size = new System.Drawing.Size(414, 302);
            this.txtEditorTexto.TabIndex = 4;
            this.txtEditorTexto.Text = "";
            // 
            // btnEditor
            // 
            this.btnEditor.Location = new System.Drawing.Point(684, 12);
            this.btnEditor.Name = "btnEditor";
            this.btnEditor.Size = new System.Drawing.Size(161, 57);
            this.btnEditor.TabIndex = 5;
            this.btnEditor.Text = "Editor";
            this.btnEditor.UseVisualStyleBackColor = true;
            // 
            // btnEditarTxt
            // 
            this.btnEditarTxt.Location = new System.Drawing.Point(824, 445);
            this.btnEditarTxt.Name = "btnEditarTxt";
            this.btnEditarTxt.Size = new System.Drawing.Size(134, 57);
            this.btnEditarTxt.TabIndex = 6;
            this.btnEditarTxt.Text = "Editar";
            this.btnEditarTxt.UseVisualStyleBackColor = true;
            // 
            // btnAgregarTxt
            // 
            this.btnAgregarTxt.Location = new System.Drawing.Point(684, 445);
            this.btnAgregarTxt.Name = "btnAgregarTxt";
            this.btnAgregarTxt.Size = new System.Drawing.Size(134, 57);
            this.btnAgregarTxt.TabIndex = 4;
            this.btnAgregarTxt.Text = "Agregar";
            this.btnAgregarTxt.UseVisualStyleBackColor = true;
            this.btnAgregarTxt.Click += new System.EventHandler(this.btnAgregarTxt_Click);
            // 
            // Carpetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 682);
            this.Controls.Add(this.btnEditarTxt);
            this.Controls.Add(this.btnEditor);
            this.Controls.Add(this.txtEditorTexto);
            this.Controls.Add(this.btnAgregarTxt);
            this.Controls.Add(this.txtnombreArchivoTxt);
            this.Controls.Add(this.txtNombreCarpeta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Carpetas";
            this.Text = "Carpetas";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNombreCarpeta;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.TextBox txtnombreArchivoTxt;
        private System.Windows.Forms.RichTextBox txtEditorTexto;
        private System.Windows.Forms.Button btnEditor;
        private System.Windows.Forms.Button btnEditarTxt;
        private System.Windows.Forms.Button btnAgregarTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCarpeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn carpeta;
    }
}