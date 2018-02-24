namespace HoroscopoChino
{
    partial class frmPrincipal
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
            this.lblArchivoTexto = new System.Windows.Forms.Label();
            this.txtArchivoTexto = new System.Windows.Forms.TextBox();
            this.btnArchivoTexto = new System.Windows.Forms.Button();
            this.btnArchivoXml = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnArchivoJson = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblArchivoTexto
            // 
            this.lblArchivoTexto.AutoSize = true;
            this.lblArchivoTexto.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArchivoTexto.Location = new System.Drawing.Point(13, 16);
            this.lblArchivoTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblArchivoTexto.Name = "lblArchivoTexto";
            this.lblArchivoTexto.Size = new System.Drawing.Size(173, 16);
            this.lblArchivoTexto.TabIndex = 0;
            this.lblArchivoTexto.Text = "Ruta de archivo de texto";
            // 
            // txtArchivoTexto
            // 
            this.txtArchivoTexto.Location = new System.Drawing.Point(16, 35);
            this.txtArchivoTexto.Name = "txtArchivoTexto";
            this.txtArchivoTexto.ReadOnly = true;
            this.txtArchivoTexto.Size = new System.Drawing.Size(420, 23);
            this.txtArchivoTexto.TabIndex = 1;
            // 
            // btnArchivoTexto
            // 
            this.btnArchivoTexto.Location = new System.Drawing.Point(442, 35);
            this.btnArchivoTexto.Name = "btnArchivoTexto";
            this.btnArchivoTexto.Size = new System.Drawing.Size(35, 23);
            this.btnArchivoTexto.TabIndex = 2;
            this.btnArchivoTexto.Text = "...";
            this.btnArchivoTexto.UseVisualStyleBackColor = true;
            this.btnArchivoTexto.Click += new System.EventHandler(this.btnArchivoTexto_Click);
            // 
            // btnArchivoXml
            // 
            this.btnArchivoXml.Location = new System.Drawing.Point(90, 76);
            this.btnArchivoXml.Name = "btnArchivoXml";
            this.btnArchivoXml.Size = new System.Drawing.Size(100, 54);
            this.btnArchivoXml.TabIndex = 3;
            this.btnArchivoXml.Text = "Guardar como XML";
            this.btnArchivoXml.UseVisualStyleBackColor = true;
            this.btnArchivoXml.Click += new System.EventHandler(this.btnArchivoXml_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "Archivos de texto|*.txt";
            // 
            // btnArchivoJson
            // 
            this.btnArchivoJson.Location = new System.Drawing.Point(257, 76);
            this.btnArchivoJson.Name = "btnArchivoJson";
            this.btnArchivoJson.Size = new System.Drawing.Size(100, 54);
            this.btnArchivoJson.TabIndex = 4;
            this.btnArchivoJson.Text = "Guardar como JSON";
            this.btnArchivoJson.UseVisualStyleBackColor = true;
            this.btnArchivoJson.Click += new System.EventHandler(this.btnArchivoJson_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 154);
            this.Controls.Add(this.btnArchivoJson);
            this.Controls.Add(this.btnArchivoXml);
            this.Controls.Add(this.btnArchivoTexto);
            this.Controls.Add(this.txtArchivoTexto);
            this.Controls.Add(this.lblArchivoTexto);
            this.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Horóscopo Chino";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblArchivoTexto;
        private System.Windows.Forms.TextBox txtArchivoTexto;
        private System.Windows.Forms.Button btnArchivoTexto;
        private System.Windows.Forms.Button btnArchivoXml;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button btnArchivoJson;
    }
}

