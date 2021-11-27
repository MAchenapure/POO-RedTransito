
namespace SegundoParcial
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdVehiculos = new System.Windows.Forms.DataGridView();
            this.btnSemaRojo = new System.Windows.Forms.Button();
            this.btnSemaVerde = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdVehiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // grdVehiculos
            // 
            this.grdVehiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdVehiculos.Location = new System.Drawing.Point(14, 16);
            this.grdVehiculos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grdVehiculos.Name = "grdVehiculos";
            this.grdVehiculos.RowHeadersWidth = 51;
            this.grdVehiculos.RowTemplate.Height = 25;
            this.grdVehiculos.Size = new System.Drawing.Size(443, 412);
            this.grdVehiculos.TabIndex = 0;
            // 
            // btnSemaRojo
            // 
            this.btnSemaRojo.ForeColor = System.Drawing.Color.Red;
            this.btnSemaRojo.Location = new System.Drawing.Point(105, 435);
            this.btnSemaRojo.Name = "btnSemaRojo";
            this.btnSemaRojo.Size = new System.Drawing.Size(121, 36);
            this.btnSemaRojo.TabIndex = 1;
            this.btnSemaRojo.Text = "Semáforo rojo";
            this.btnSemaRojo.UseVisualStyleBackColor = true;
            this.btnSemaRojo.Click += new System.EventHandler(this.btnSemaRojo_Click);
            // 
            // btnSemaVerde
            // 
            this.btnSemaVerde.ForeColor = System.Drawing.Color.Green;
            this.btnSemaVerde.Location = new System.Drawing.Point(232, 435);
            this.btnSemaVerde.Name = "btnSemaVerde";
            this.btnSemaVerde.Size = new System.Drawing.Size(128, 36);
            this.btnSemaVerde.TabIndex = 2;
            this.btnSemaVerde.Text = "Semáforo verde";
            this.btnSemaVerde.UseVisualStyleBackColor = true;
            this.btnSemaVerde.Click += new System.EventHandler(this.btnSemaVerde_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 478);
            this.Controls.Add(this.btnSemaVerde);
            this.Controls.Add(this.btnSemaRojo);
            this.Controls.Add(this.grdVehiculos);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Tránsito";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdVehiculos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdVehiculos;
        private System.Windows.Forms.Button btnSemaRojo;
        private System.Windows.Forms.Button btnSemaVerde;
    }
}

