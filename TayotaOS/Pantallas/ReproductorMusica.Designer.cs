namespace TayotaOS.Pantallas
{
    partial class ReproductorMusica
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReproductorMusica));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridViewCanciones = new System.Windows.Forms.DataGridView();
            this.MUSICA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AUTOR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DURACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCanciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCanciones
            // 
            this.dataGridViewCanciones.AllowUserToAddRows = false;
            this.dataGridViewCanciones.AllowUserToDeleteRows = false;
            this.dataGridViewCanciones.AllowUserToResizeColumns = false;
            this.dataGridViewCanciones.AllowUserToResizeRows = false;
            this.dataGridViewCanciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewCanciones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewCanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCanciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MUSICA,
            this.AUTOR,
            this.DURACION});
            this.dataGridViewCanciones.Location = new System.Drawing.Point(204, 43);
            this.dataGridViewCanciones.Name = "dataGridViewCanciones";
            this.dataGridViewCanciones.ReadOnly = true;
            this.dataGridViewCanciones.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridViewCanciones.RowTemplate.Height = 24;
            this.dataGridViewCanciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCanciones.Size = new System.Drawing.Size(427, 99);
            this.dataGridViewCanciones.TabIndex = 1;
            this.dataGridViewCanciones.DoubleClick += new System.EventHandler(this.dataGridViewCanciones_DoubleClick);
            // 
            // MUSICA
            // 
            this.MUSICA.Frozen = true;
            this.MUSICA.HeaderText = "MUSICA";
            this.MUSICA.MinimumWidth = 6;
            this.MUSICA.Name = "MUSICA";
            this.MUSICA.ReadOnly = true;
            this.MUSICA.Width = 87;
            // 
            // AUTOR
            // 
            this.AUTOR.Frozen = true;
            this.AUTOR.HeaderText = "AUTOR";
            this.AUTOR.MinimumWidth = 6;
            this.AUTOR.Name = "AUTOR";
            this.AUTOR.ReadOnly = true;
            this.AUTOR.Width = 84;
            // 
            // DURACION
            // 
            this.DURACION.Frozen = true;
            this.DURACION.HeaderText = "DURACION";
            this.DURACION.MinimumWidth = 6;
            this.DURACION.Name = "DURACION";
            this.DURACION.ReadOnly = true;
            this.DURACION.Width = 107;
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(204, 165);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(427, 45);
            this.MediaPlayer.TabIndex = 0;
            // 
            // ReproductorMusica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 363);
            this.Controls.Add(this.dataGridViewCanciones);
            this.Controls.Add(this.MediaPlayer);
            this.Name = "ReproductorMusica";
            this.Text = "ReproductorMusica";
            this.Load += new System.EventHandler(this.ReproductorMusica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCanciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.DataGridView dataGridViewCanciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn MUSICA;
        private System.Windows.Forms.DataGridViewTextBoxColumn AUTOR;
        private System.Windows.Forms.DataGridViewTextBoxColumn DURACION;
    }
}