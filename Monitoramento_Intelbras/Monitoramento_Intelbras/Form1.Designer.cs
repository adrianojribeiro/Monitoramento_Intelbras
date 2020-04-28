namespace Monitoramento_Intelbras
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axVLCPlugin21 = new AxAXVLC.AxVLCPlugin2();
            this.btnstart = new System.Windows.Forms.Button();
            this.txtcamera = new System.Windows.Forms.TextBox();
            this.btnstop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).BeginInit();
            this.SuspendLayout();
            // 
            // axVLCPlugin21
            // 
            this.axVLCPlugin21.Enabled = true;
            this.axVLCPlugin21.Location = new System.Drawing.Point(12, 12);
            this.axVLCPlugin21.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.axVLCPlugin21.Name = "axVLCPlugin21";
            this.axVLCPlugin21.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVLCPlugin21.OcxState")));
            this.axVLCPlugin21.Size = new System.Drawing.Size(731, 469);
            this.axVLCPlugin21.TabIndex = 0;
            // 
            // btnstart
            // 
            this.btnstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstart.Location = new System.Drawing.Point(11, 485);
            this.btnstart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(81, 28);
            this.btnstart.TabIndex = 1;
            this.btnstart.Text = "Start";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // txtcamera
            // 
            this.txtcamera.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcamera.Location = new System.Drawing.Point(96, 487);
            this.txtcamera.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcamera.Name = "txtcamera";
            this.txtcamera.Size = new System.Drawing.Size(76, 26);
            this.txtcamera.TabIndex = 2;
            // 
            // btnstop
            // 
            this.btnstop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstop.Location = new System.Drawing.Point(11, 519);
            this.btnstop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnstop.Name = "btnstop";
            this.btnstop.Size = new System.Drawing.Size(81, 28);
            this.btnstop.TabIndex = 3;
            this.btnstop.Text = "Stop";
            this.btnstop.UseVisualStyleBackColor = true;
            this.btnstop.Click += new System.EventHandler(this.btnstop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 553);
            this.Controls.Add(this.btnstop);
            this.Controls.Add(this.txtcamera);
            this.Controls.Add(this.btnstart);
            this.Controls.Add(this.axVLCPlugin21);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axVLCPlugin21)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxAXVLC.AxVLCPlugin2 axVLCPlugin21;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.TextBox txtcamera;
        private System.Windows.Forms.Button btnstop;
    }
}

