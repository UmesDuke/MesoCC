namespace MesoCC
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenuSlider = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.panelSubMenuEstudiante = new System.Windows.Forms.Panel();
            this.buttonDBCarne = new System.Windows.Forms.Button();
            this.buttonValidarCarne = new System.Windows.Forms.Button();
            this.buttonEstudiante = new System.Windows.Forms.Button();
            this.panelIcono = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelMenuSlider.SuspendLayout();
            this.panelSubMenuEstudiante.SuspendLayout();
            this.panelIcono.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenuSlider
            // 
            this.panelMenuSlider.AutoScroll = true;
            this.panelMenuSlider.BackColor = System.Drawing.Color.White;
            this.panelMenuSlider.Controls.Add(this.button3);
            this.panelMenuSlider.Controls.Add(this.panelSubMenuEstudiante);
            this.panelMenuSlider.Controls.Add(this.buttonEstudiante);
            this.panelMenuSlider.Controls.Add(this.panelIcono);
            this.panelMenuSlider.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuSlider.Location = new System.Drawing.Point(0, 0);
            this.panelMenuSlider.Name = "panelMenuSlider";
            this.panelMenuSlider.Size = new System.Drawing.Size(250, 519);
            this.panelMenuSlider.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(0, 255);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(250, 45);
            this.button3.TabIndex = 3;
            this.button3.Text = "Sallir";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panelSubMenuEstudiante
            // 
            this.panelSubMenuEstudiante.BackColor = System.Drawing.Color.White;
            this.panelSubMenuEstudiante.Controls.Add(this.buttonDBCarne);
            this.panelSubMenuEstudiante.Controls.Add(this.buttonValidarCarne);
            this.panelSubMenuEstudiante.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenuEstudiante.Location = new System.Drawing.Point(0, 170);
            this.panelSubMenuEstudiante.Name = "panelSubMenuEstudiante";
            this.panelSubMenuEstudiante.Size = new System.Drawing.Size(250, 85);
            this.panelSubMenuEstudiante.TabIndex = 2;
            // 
            // buttonDBCarne
            // 
            this.buttonDBCarne.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDBCarne.FlatAppearance.BorderSize = 0;
            this.buttonDBCarne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDBCarne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDBCarne.ForeColor = System.Drawing.Color.Black;
            this.buttonDBCarne.Location = new System.Drawing.Point(0, 40);
            this.buttonDBCarne.Name = "buttonDBCarne";
            this.buttonDBCarne.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonDBCarne.Size = new System.Drawing.Size(250, 40);
            this.buttonDBCarne.TabIndex = 1;
            this.buttonDBCarne.Text = "Tester Carné";
            this.buttonDBCarne.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDBCarne.UseVisualStyleBackColor = true;
            this.buttonDBCarne.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonValidarCarne
            // 
            this.buttonValidarCarne.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonValidarCarne.FlatAppearance.BorderSize = 0;
            this.buttonValidarCarne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonValidarCarne.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonValidarCarne.ForeColor = System.Drawing.Color.Black;
            this.buttonValidarCarne.Location = new System.Drawing.Point(0, 0);
            this.buttonValidarCarne.Name = "buttonValidarCarne";
            this.buttonValidarCarne.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonValidarCarne.Size = new System.Drawing.Size(250, 40);
            this.buttonValidarCarne.TabIndex = 0;
            this.buttonValidarCarne.Text = "Validar Carné";
            this.buttonValidarCarne.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonValidarCarne.UseVisualStyleBackColor = true;
            this.buttonValidarCarne.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonEstudiante
            // 
            this.buttonEstudiante.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonEstudiante.FlatAppearance.BorderSize = 0;
            this.buttonEstudiante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEstudiante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEstudiante.ForeColor = System.Drawing.Color.Black;
            this.buttonEstudiante.Location = new System.Drawing.Point(0, 125);
            this.buttonEstudiante.Name = "buttonEstudiante";
            this.buttonEstudiante.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonEstudiante.Size = new System.Drawing.Size(250, 45);
            this.buttonEstudiante.TabIndex = 1;
            this.buttonEstudiante.Text = "Estudiante";
            this.buttonEstudiante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEstudiante.UseVisualStyleBackColor = true;
            this.buttonEstudiante.Click += new System.EventHandler(this.buttonEstudiante_Click);
            // 
            // panelIcono
            // 
            this.panelIcono.Controls.Add(this.pictureBox1);
            this.panelIcono.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIcono.Location = new System.Drawing.Point(0, 0);
            this.panelIcono.Name = "panelIcono";
            this.panelIcono.Size = new System.Drawing.Size(250, 125);
            this.panelIcono.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(55, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(250, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(735, 519);
            this.panelContainer.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 519);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelMenuSlider);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MesoCC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenuSlider.ResumeLayout(false);
            this.panelSubMenuEstudiante.ResumeLayout(false);
            this.panelIcono.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenuSlider;
        private System.Windows.Forms.Panel panelIcono;
        private System.Windows.Forms.Button buttonEstudiante;
        private System.Windows.Forms.Panel panelSubMenuEstudiante;
        private System.Windows.Forms.Button buttonDBCarne;
        private System.Windows.Forms.Button buttonValidarCarne;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelContainer;
    }
}

