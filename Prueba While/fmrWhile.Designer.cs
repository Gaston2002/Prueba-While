namespace Prueba_While
{
    partial class fmrWhile
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.actorRojo = new System.Windows.Forms.Label();
            this.actorAzul = new System.Windows.Forms.Label();
            this.btPosicion = new System.Windows.Forms.Button();
            this.btMover = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // actorRojo
            // 
            this.actorRojo.BackColor = System.Drawing.Color.Red;
            this.actorRojo.Location = new System.Drawing.Point(12, 90);
            this.actorRojo.Name = "actorRojo";
            this.actorRojo.Size = new System.Drawing.Size(40, 40);
            this.actorRojo.TabIndex = 0;
            this.actorRojo.Visible = false;
            // 
            // actorAzul
            // 
            this.actorAzul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.actorAzul.Location = new System.Drawing.Point(418, 21);
            this.actorAzul.Name = "actorAzul";
            this.actorAzul.Size = new System.Drawing.Size(100, 28);
            this.actorAzul.TabIndex = 1;
            this.actorAzul.Visible = false;
            // 
            // btPosicion
            // 
            this.btPosicion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPosicion.Location = new System.Drawing.Point(93, 6);
            this.btPosicion.Name = "btPosicion";
            this.btPosicion.Size = new System.Drawing.Size(100, 40);
            this.btPosicion.TabIndex = 2;
            this.btPosicion.Text = "Acomodar";
            this.btPosicion.UseVisualStyleBackColor = true;
            this.btPosicion.Click += new System.EventHandler(this.btPosicion_Click);
            // 
            // btMover
            // 
            this.btMover.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMover.Location = new System.Drawing.Point(300, 6);
            this.btMover.Name = "btMover";
            this.btMover.Size = new System.Drawing.Size(100, 40);
            this.btMover.TabIndex = 3;
            this.btMover.Text = "Mover";
            this.btMover.UseVisualStyleBackColor = true;
            this.btMover.Click += new System.EventHandler(this.btMover_Click);
            // 
            // fmrWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 189);
            this.Controls.Add(this.btMover);
            this.Controls.Add(this.btPosicion);
            this.Controls.Add(this.actorAzul);
            this.Controls.Add(this.actorRojo);
            this.Name = "fmrWhile";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label actorRojo;
        private System.Windows.Forms.Label actorAzul;
        private System.Windows.Forms.Button btPosicion;
        private System.Windows.Forms.Button btMover;
    }
}

