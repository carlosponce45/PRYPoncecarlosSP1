namespace PRYPonceSP1
{
    partial class frmPRYPonceSP1
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
            this.lblbienvenido = new System.Windows.Forms.Label();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblbienvenido
            // 
            this.lblbienvenido.AutoSize = true;
            this.lblbienvenido.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblbienvenido.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblbienvenido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblbienvenido.Location = new System.Drawing.Point(142, 59);
            this.lblbienvenido.Name = "lblbienvenido";
            this.lblbienvenido.Size = new System.Drawing.Size(141, 15);
            this.lblbienvenido.TabIndex = 0;
            this.lblbienvenido.Text = "BIENVENIDO AL SISTEMA";
            this.lblbienvenido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(158, 170);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 1;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            // 
            // frmPRYPonceSP1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 221);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.lblbienvenido);
            this.Name = "frmPRYPonceSP1";
            this.Text = "PRYPonceSP1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblbienvenido;
        private System.Windows.Forms.Button btnaceptar;
    }
}