namespace WindowsFormsDolgozo
{
    partial class FormNyito
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
            this.lbDolgozok = new System.Windows.Forms.ListBox();
            this.btInsert = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btFrissit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDolgozok
            // 
            this.lbDolgozok.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbDolgozok.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbDolgozok.FormattingEnabled = true;
            this.lbDolgozok.ItemHeight = 24;
            this.lbDolgozok.Location = new System.Drawing.Point(0, 0);
            this.lbDolgozok.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lbDolgozok.Name = "lbDolgozok";
            this.lbDolgozok.Size = new System.Drawing.Size(530, 692);
            this.lbDolgozok.TabIndex = 0;
            // 
            // btInsert
            // 
            this.btInsert.Location = new System.Drawing.Point(551, 14);
            this.btInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btInsert.Name = "btInsert";
            this.btInsert.Size = new System.Drawing.Size(201, 49);
            this.btInsert.TabIndex = 1;
            this.btInsert.Text = "Új dolgozó";
            this.btInsert.UseVisualStyleBackColor = true;
            this.btInsert.Click += new System.EventHandler(this.btInsert_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(551, 88);
            this.btUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(201, 49);
            this.btUpdate.TabIndex = 2;
            this.btUpdate.Text = "Adatok módosítása";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(551, 162);
            this.btDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(201, 49);
            this.btDelete.TabIndex = 3;
            this.btDelete.Text = "Dolgozó törlése";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btFrissit
            // 
            this.btFrissit.Location = new System.Drawing.Point(551, 242);
            this.btFrissit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btFrissit.Name = "btFrissit";
            this.btFrissit.Size = new System.Drawing.Size(201, 49);
            this.btFrissit.TabIndex = 4;
            this.btFrissit.Text = "Frissítés";
            this.btFrissit.UseVisualStyleBackColor = true;
            this.btFrissit.Click += new System.EventHandler(this.btFrissit_Click);
            // 
            // FormNyito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 692);
            this.Controls.Add(this.btFrissit);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btInsert);
            this.Controls.Add(this.lbDolgozok);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormNyito";
            this.Text = "Dolgozók nyilvántartása";
            this.Load += new System.EventHandler(this.FormNyito_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btInsert;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btFrissit;
        public System.Windows.Forms.ListBox lbDolgozok;
    }
}

