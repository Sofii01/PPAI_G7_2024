namespace PPAI_G7_2024.Interfaces
{
    partial class PantallaGenRanking
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
            this.dtpckFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaReseñaDesde = new System.Windows.Forms.Label();
            this.lblFechaReseñaHasta = new System.Windows.Forms.Label();
            this.dtpckFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.brBox_Resenia = new System.Windows.Forms.GroupBox();
            this.chBoxFechaHasta = new System.Windows.Forms.CheckBox();
            this.chBoxFechaDesde = new System.Windows.Forms.CheckBox();
            this.cmbReseña = new System.Windows.Forms.ComboBox();
            this.lblReseña = new System.Windows.Forms.Label();
            this.btnTomarReseña = new System.Windows.Forms.Button();
            this.btnFormaDeVisualizacion = new System.Windows.Forms.Button();
            this.lblForamaDeVisualizacion = new System.Windows.Forms.Label();
            this.cmbFormaDeVisualizacion = new System.Windows.Forms.ComboBox();
            this.btnConfirmarGeneracion = new System.Windows.Forms.Button();
            this.brBox_Resenia.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpckFechaDesde
            // 
            this.dtpckFechaDesde.Location = new System.Drawing.Point(191, 30);
            this.dtpckFechaDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpckFechaDesde.Name = "dtpckFechaDesde";
            this.dtpckFechaDesde.Size = new System.Drawing.Size(265, 22);
            this.dtpckFechaDesde.TabIndex = 0;
            // 
            // lblFechaReseñaDesde
            // 
            this.lblFechaReseñaDesde.AutoSize = true;
            this.lblFechaReseñaDesde.Location = new System.Drawing.Point(8, 36);
            this.lblFechaReseñaDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaReseñaDesde.Name = "lblFechaReseñaDesde";
            this.lblFechaReseñaDesde.Size = new System.Drawing.Size(141, 16);
            this.lblFechaReseñaDesde.TabIndex = 1;
            this.lblFechaReseñaDesde.Text = "Fecha Reseña desde:";
            // 
            // lblFechaReseñaHasta
            // 
            this.lblFechaReseñaHasta.AutoSize = true;
            this.lblFechaReseñaHasta.Location = new System.Drawing.Point(8, 70);
            this.lblFechaReseñaHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaReseñaHasta.Name = "lblFechaReseñaHasta";
            this.lblFechaReseñaHasta.Size = new System.Drawing.Size(135, 16);
            this.lblFechaReseñaHasta.TabIndex = 3;
            this.lblFechaReseñaHasta.Text = "Fecha Reseña hasta:";
            // 
            // dtpckFechaHasta
            // 
            this.dtpckFechaHasta.Location = new System.Drawing.Point(191, 64);
            this.dtpckFechaHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpckFechaHasta.Name = "dtpckFechaHasta";
            this.dtpckFechaHasta.Size = new System.Drawing.Size(265, 22);
            this.dtpckFechaHasta.TabIndex = 2;
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Location = new System.Drawing.Point(337, 11);
            this.lbl_Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(111, 16);
            this.lbl_Titulo.TabIndex = 4;
            this.lbl_Titulo.Text = "Ranking de vinos";
            // 
            // brBox_Resenia
            // 
            this.brBox_Resenia.Controls.Add(this.chBoxFechaHasta);
            this.brBox_Resenia.Controls.Add(this.chBoxFechaDesde);
            this.brBox_Resenia.Controls.Add(this.lblFechaReseñaDesde);
            this.brBox_Resenia.Controls.Add(this.dtpckFechaDesde);
            this.brBox_Resenia.Controls.Add(this.lblFechaReseñaHasta);
            this.brBox_Resenia.Controls.Add(this.dtpckFechaHasta);
            this.brBox_Resenia.Location = new System.Drawing.Point(63, 44);
            this.brBox_Resenia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.brBox_Resenia.Name = "brBox_Resenia";
            this.brBox_Resenia.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.brBox_Resenia.Size = new System.Drawing.Size(672, 105);
            this.brBox_Resenia.TabIndex = 5;
            this.brBox_Resenia.TabStop = false;
            this.brBox_Resenia.Text = "groupBox1";
            // 
            // chBoxFechaHasta
            // 
            this.chBoxFechaHasta.AutoSize = true;
            this.chBoxFechaHasta.Location = new System.Drawing.Point(465, 70);
            this.chBoxFechaHasta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chBoxFechaHasta.Name = "chBoxFechaHasta";
            this.chBoxFechaHasta.Size = new System.Drawing.Size(147, 20);
            this.chBoxFechaHasta.TabIndex = 5;
            this.chBoxFechaHasta.Text = "Confirmar seleccion";
            this.chBoxFechaHasta.UseVisualStyleBackColor = true;
            this.chBoxFechaHasta.CheckedChanged += new System.EventHandler(this.tomarFechaHasta);
            this.chBoxFechaHasta.Click += new System.EventHandler(this.tomarConfirmarGenReport);
            // 
            // chBoxFechaDesde
            // 
            this.chBoxFechaDesde.AutoSize = true;
            this.chBoxFechaDesde.Location = new System.Drawing.Point(465, 32);
            this.chBoxFechaDesde.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chBoxFechaDesde.Name = "chBoxFechaDesde";
            this.chBoxFechaDesde.Size = new System.Drawing.Size(147, 20);
            this.chBoxFechaDesde.TabIndex = 4;
            this.chBoxFechaDesde.Text = "Confirmar seleccion";
            this.chBoxFechaDesde.UseVisualStyleBackColor = true;
            this.chBoxFechaDesde.CheckedChanged += new System.EventHandler(this.tomarFechaDesde);
            // 
            // cmbReseña
            // 
            this.cmbReseña.FormattingEnabled = true;
            this.cmbReseña.Location = new System.Drawing.Point(125, 156);
            this.cmbReseña.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbReseña.Name = "cmbReseña";
            this.cmbReseña.Size = new System.Drawing.Size(423, 24);
            this.cmbReseña.TabIndex = 6;
            // 
            // lblReseña
            // 
            this.lblReseña.AutoSize = true;
            this.lblReseña.Location = new System.Drawing.Point(59, 160);
            this.lblReseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReseña.Name = "lblReseña";
            this.lblReseña.Size = new System.Drawing.Size(55, 16);
            this.lblReseña.TabIndex = 7;
            this.lblReseña.Text = "Reseña";
            // 
            // btnTomarReseña
            // 
            this.btnTomarReseña.Location = new System.Drawing.Point(557, 156);
            this.btnTomarReseña.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTomarReseña.Name = "btnTomarReseña";
            this.btnTomarReseña.Size = new System.Drawing.Size(177, 28);
            this.btnTomarReseña.TabIndex = 8;
            this.btnTomarReseña.Text = "Tomar Reseña";
            this.btnTomarReseña.UseVisualStyleBackColor = true;
            this.btnTomarReseña.Click += new System.EventHandler(this.tomarTipoDeReseña);
            // 
            // btnFormaDeVisualizacion
            // 
            this.btnFormaDeVisualizacion.Location = new System.Drawing.Point(557, 197);
            this.btnFormaDeVisualizacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFormaDeVisualizacion.Name = "btnFormaDeVisualizacion";
            this.btnFormaDeVisualizacion.Size = new System.Drawing.Size(177, 28);
            this.btnFormaDeVisualizacion.TabIndex = 11;
            this.btnFormaDeVisualizacion.Text = "Tomar Forma ";
            this.btnFormaDeVisualizacion.UseVisualStyleBackColor = true;
            this.btnFormaDeVisualizacion.Click += new System.EventHandler(this.tomarFormaDeVisualizacion);
            // 
            // lblForamaDeVisualizacion
            // 
            this.lblForamaDeVisualizacion.AutoSize = true;
            this.lblForamaDeVisualizacion.Location = new System.Drawing.Point(59, 203);
            this.lblForamaDeVisualizacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblForamaDeVisualizacion.Name = "lblForamaDeVisualizacion";
            this.lblForamaDeVisualizacion.Size = new System.Drawing.Size(145, 16);
            this.lblForamaDeVisualizacion.TabIndex = 10;
            this.lblForamaDeVisualizacion.Text = "Forma de visualizacion";
            // 
            // cmbFormaDeVisualizacion
            // 
            this.cmbFormaDeVisualizacion.FormattingEnabled = true;
            this.cmbFormaDeVisualizacion.Location = new System.Drawing.Point(219, 199);
            this.cmbFormaDeVisualizacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbFormaDeVisualizacion.Name = "cmbFormaDeVisualizacion";
            this.cmbFormaDeVisualizacion.Size = new System.Drawing.Size(329, 24);
            this.cmbFormaDeVisualizacion.TabIndex = 9;
            // 
            // btnConfirmarGeneracion
            // 
            this.btnConfirmarGeneracion.Location = new System.Drawing.Point(63, 260);
            this.btnConfirmarGeneracion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConfirmarGeneracion.Name = "btnConfirmarGeneracion";
            this.btnConfirmarGeneracion.Size = new System.Drawing.Size(157, 28);
            this.btnConfirmarGeneracion.TabIndex = 12;
            this.btnConfirmarGeneracion.Text = "Confirmar generacion";
            this.btnConfirmarGeneracion.UseVisualStyleBackColor = true;
            this.btnConfirmarGeneracion.Click += new System.EventHandler(this.tomarConfirmarGenReport);
            // 
            // PantallaGenRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 554);
            this.Controls.Add(this.btnConfirmarGeneracion);
            this.Controls.Add(this.btnFormaDeVisualizacion);
            this.Controls.Add(this.lblForamaDeVisualizacion);
            this.Controls.Add(this.cmbFormaDeVisualizacion);
            this.Controls.Add(this.btnTomarReseña);
            this.Controls.Add(this.lblReseña);
            this.Controls.Add(this.cmbReseña);
            this.Controls.Add(this.brBox_Resenia);
            this.Controls.Add(this.lbl_Titulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PantallaGenRanking";
            this.Text = "Pantalla Generar Ranking";
            this.brBox_Resenia.ResumeLayout(false);
            this.brBox_Resenia.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpckFechaDesde;
        private System.Windows.Forms.Label lblFechaReseñaDesde;
        private System.Windows.Forms.Label lblFechaReseñaHasta;
        private System.Windows.Forms.DateTimePicker dtpckFechaHasta;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.GroupBox brBox_Resenia;
        private System.Windows.Forms.CheckBox chBoxFechaHasta;
        private System.Windows.Forms.CheckBox chBoxFechaDesde;
        private System.Windows.Forms.ComboBox cmbReseña;
        private System.Windows.Forms.Label lblReseña;
        private System.Windows.Forms.Button btnTomarReseña;
        private System.Windows.Forms.Button btnFormaDeVisualizacion;
        private System.Windows.Forms.Label lblForamaDeVisualizacion;
        private System.Windows.Forms.ComboBox cmbFormaDeVisualizacion;
        private System.Windows.Forms.Button btnConfirmarGeneracion;
    }
}