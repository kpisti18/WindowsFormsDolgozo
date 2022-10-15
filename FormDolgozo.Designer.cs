namespace WindowsFormsDolgozo
{
    partial class FormDolgozo
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
            this.tbID = new System.Windows.Forms.TextBox();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerSzuletett = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownFizetes = new System.Windows.Forms.NumericUpDown();
            this.btMuvelet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFizetes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Azonosító";
            // 
            // tbID
            // 
            this.tbID.Location = new System.Drawing.Point(163, 34);
            this.tbID.Name = "tbID";
            this.tbID.ReadOnly = true;
            this.tbID.Size = new System.Drawing.Size(224, 26);
            this.tbID.TabIndex = 1;
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(163, 122);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(224, 26);
            this.tbNev.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Név";
            // 
            // dateTimePickerSzuletett
            // 
            this.dateTimePickerSzuletett.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerSzuletett.Location = new System.Drawing.Point(163, 219);
            this.dateTimePickerSzuletett.Name = "dateTimePickerSzuletett";
            this.dateTimePickerSzuletett.Size = new System.Drawing.Size(224, 26);
            this.dateTimePickerSzuletett.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Született";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 317);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fizetés";
            // 
            // numericUpDownFizetes
            // 
            this.numericUpDownFizetes.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownFizetes.Location = new System.Drawing.Point(163, 316);
            this.numericUpDownFizetes.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDownFizetes.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownFizetes.Name = "numericUpDownFizetes";
            this.numericUpDownFizetes.Size = new System.Drawing.Size(224, 26);
            this.numericUpDownFizetes.TabIndex = 7;
            this.numericUpDownFizetes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numericUpDownFizetes.ThousandsSeparator = true;
            this.numericUpDownFizetes.Value = new decimal(new int[] {
            240000,
            0,
            0,
            0});
            // 
            // btMuvelet
            // 
            this.btMuvelet.Location = new System.Drawing.Point(58, 401);
            this.btMuvelet.Name = "btMuvelet";
            this.btMuvelet.Size = new System.Drawing.Size(329, 34);
            this.btMuvelet.TabIndex = 8;
            this.btMuvelet.Text = "button1";
            this.btMuvelet.UseVisualStyleBackColor = true;
            this.btMuvelet.Click += new System.EventHandler(this.btMuvelet_Click);
            // 
            // FormDolgozo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 692);
            this.Controls.Add(this.btMuvelet);
            this.Controls.Add(this.numericUpDownFizetes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerSzuletett);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbID);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormDolgozo";
            this.Text = "FormDolgozo";
            this.Load += new System.EventHandler(this.FormDolgozo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFizetes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbID;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerSzuletett;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownFizetes;
        private System.Windows.Forms.Button btMuvelet;
    }
}