namespace PPAI_G7_2024.Interfaces
{
    partial class PantallaPrincipal
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
            this.btnGenRankVinos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenRankVinos
            // 
            this.btnGenRankVinos.Location = new System.Drawing.Point(112, 159);
            this.btnGenRankVinos.Name = "btnGenRankVinos";
            this.btnGenRankVinos.Size = new System.Drawing.Size(124, 66);
            this.btnGenRankVinos.TabIndex = 0;
            this.btnGenRankVinos.Text = "Generar Ranking Vinos";
            this.btnGenRankVinos.UseVisualStyleBackColor = true;
            this.btnGenRankVinos.Click += new System.EventHandler(this.opcGenerarRankingVinos);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 434);
            this.Controls.Add(this.btnGenRankVinos);
            this.Name = "PantallaPrincipal";
            this.Text = "PantallaPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenRankVinos;
    }
}