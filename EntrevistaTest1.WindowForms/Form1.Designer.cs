namespace EntrevistaTest1.WindowForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtgListado1 = new System.Windows.Forms.DataGridView();
            this.dtgListado2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgListado3 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMover = new System.Windows.Forms.Button();
            this.btnInsertAddress = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListado3)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTADO 1";
            // 
            // dtgListado1
            // 
            this.dtgListado1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListado1.Location = new System.Drawing.Point(27, 59);
            this.dtgListado1.Name = "dtgListado1";
            this.dtgListado1.Size = new System.Drawing.Size(402, 150);
            this.dtgListado1.TabIndex = 1;
            // 
            // dtgListado2
            // 
            this.dtgListado2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListado2.Location = new System.Drawing.Point(469, 59);
            this.dtgListado2.Name = "dtgListado2";
            this.dtgListado2.Size = new System.Drawing.Size(402, 150);
            this.dtgListado2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(637, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "LISTADO 2";
            // 
            // dtgListado3
            // 
            this.dtgListado3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListado3.Location = new System.Drawing.Point(245, 267);
            this.dtgListado3.Name = "dtgListado3";
            this.dtgListado3.Size = new System.Drawing.Size(402, 150);
            this.dtgListado3.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "LISTADO 3";
            // 
            // btnMover
            // 
            this.btnMover.Location = new System.Drawing.Point(738, 319);
            this.btnMover.Name = "btnMover";
            this.btnMover.Size = new System.Drawing.Size(75, 23);
            this.btnMover.TabIndex = 6;
            this.btnMover.Text = "MOVER";
            this.btnMover.UseVisualStyleBackColor = true;
            this.btnMover.Click += new System.EventHandler(this.btnMover_Click);
            // 
            // btnInsertAddress
            // 
            this.btnInsertAddress.Location = new System.Drawing.Point(416, 23);
            this.btnInsertAddress.Name = "btnInsertAddress";
            this.btnInsertAddress.Size = new System.Drawing.Size(75, 23);
            this.btnInsertAddress.TabIndex = 7;
            this.btnInsertAddress.Text = "<<<>>>";
            this.btnInsertAddress.UseVisualStyleBackColor = true;
            this.btnInsertAddress.Click += new System.EventHandler(this.btnInsertAddress_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 450);
            this.Controls.Add(this.btnInsertAddress);
            this.Controls.Add(this.btnMover);
            this.Controls.Add(this.dtgListado3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgListado2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgListado1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgListado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListado3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgListado1;
        private System.Windows.Forms.DataGridView dtgListado2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgListado3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMover;
        private System.Windows.Forms.Button btnInsertAddress;
    }
}

