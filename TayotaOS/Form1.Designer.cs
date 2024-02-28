namespace TayotaOS
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnProcesos = new System.Windows.Forms.Button();
            this.btnEditorTexto = new System.Windows.Forms.Button();
            this.barraTareas = new System.Windows.Forms.Panel();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.btnReproductorMusica = new System.Windows.Forms.Button();
            this.btnNavegador = new System.Windows.Forms.Button();
            this.btnCarpetas = new System.Windows.Forms.Button();
            this.barraTareas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProcesos
            // 
            this.btnProcesos.Location = new System.Drawing.Point(12, 142);
            this.btnProcesos.Name = "btnProcesos";
            this.btnProcesos.Size = new System.Drawing.Size(147, 54);
            this.btnProcesos.TabIndex = 0;
            this.btnProcesos.Text = "ADMINISTRADOR TAREAS";
            this.btnProcesos.UseVisualStyleBackColor = true;
            this.btnProcesos.Click += new System.EventHandler(this.btnProcesos_Click);
            // 
            // btnEditorTexto
            // 
            this.btnEditorTexto.Location = new System.Drawing.Point(12, 12);
            this.btnEditorTexto.Name = "btnEditorTexto";
            this.btnEditorTexto.Size = new System.Drawing.Size(147, 45);
            this.btnEditorTexto.TabIndex = 1;
            this.btnEditorTexto.Text = "Bloc notas";
            this.btnEditorTexto.UseVisualStyleBackColor = true;
            this.btnEditorTexto.Click += new System.EventHandler(this.btnEditorTexto_Click);
            // 
            // barraTareas
            // 
            this.barraTareas.BackColor = System.Drawing.Color.RoyalBlue;
            this.barraTareas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.barraTareas.Controls.Add(this.labelFecha);
            this.barraTareas.Controls.Add(this.labelHora);
            this.barraTareas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barraTareas.Location = new System.Drawing.Point(0, 628);
            this.barraTareas.Name = "barraTareas";
            this.barraTareas.Size = new System.Drawing.Size(1229, 38);
            this.barraTareas.TabIndex = 2;
            // 
            // labelFecha
            // 
            this.labelFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelFecha.Location = new System.Drawing.Point(1115, 17);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(77, 17);
            this.labelFecha.TabIndex = 2;
            this.labelFecha.Text = "labelFecha";
            // 
            // labelHora
            // 
            this.labelHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelHora.AutoSize = true;
            this.labelHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelHora.Location = new System.Drawing.Point(1115, 0);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(69, 17);
            this.labelHora.TabIndex = 1;
            this.labelHora.Text = "labelHora";
            // 
            // btnReproductorMusica
            // 
            this.btnReproductorMusica.Location = new System.Drawing.Point(12, 73);
            this.btnReproductorMusica.Name = "btnReproductorMusica";
            this.btnReproductorMusica.Size = new System.Drawing.Size(147, 53);
            this.btnReproductorMusica.TabIndex = 5;
            this.btnReproductorMusica.Text = "Reproductor Musica";
            this.btnReproductorMusica.UseVisualStyleBackColor = true;
            this.btnReproductorMusica.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNavegador
            // 
            this.btnNavegador.Location = new System.Drawing.Point(12, 202);
            this.btnNavegador.Name = "btnNavegador";
            this.btnNavegador.Size = new System.Drawing.Size(147, 53);
            this.btnNavegador.TabIndex = 6;
            this.btnNavegador.Text = "Navegador";
            this.btnNavegador.UseVisualStyleBackColor = true;
            this.btnNavegador.Click += new System.EventHandler(this.btnNavegador_Click);
            // 
            // btnCarpetas
            // 
            this.btnCarpetas.Location = new System.Drawing.Point(13, 261);
            this.btnCarpetas.Name = "btnCarpetas";
            this.btnCarpetas.Size = new System.Drawing.Size(146, 53);
            this.btnCarpetas.TabIndex = 7;
            this.btnCarpetas.Text = "Explorador Archivos";
            this.btnCarpetas.UseVisualStyleBackColor = true;
            this.btnCarpetas.Click += new System.EventHandler(this.btnCarpetas_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1229, 666);
            this.Controls.Add(this.btnCarpetas);
            this.Controls.Add(this.btnNavegador);
            this.Controls.Add(this.btnReproductorMusica);
            this.Controls.Add(this.btnProcesos);
            this.Controls.Add(this.barraTareas);
            this.Controls.Add(this.btnEditorTexto);
            this.Name = "Form1";
            this.Text = "Tayota0S";
            this.barraTareas.ResumeLayout(false);
            this.barraTareas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProcesos;
        private System.Windows.Forms.Button btnEditorTexto;
        private System.Windows.Forms.Panel barraTareas;
        private System.Windows.Forms.Button btnReproductorMusica;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Button btnNavegador;
        private System.Windows.Forms.Button btnCarpetas;
    }
}

