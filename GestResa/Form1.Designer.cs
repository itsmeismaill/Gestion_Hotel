namespace GestResa
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbresult = new System.Windows.Forms.Label();
            this.room9 = new GestResa.UC.Room();
            this.room6 = new GestResa.UC.Room();
            this.room3 = new GestResa.UC.Room();
            this.room8 = new GestResa.UC.Room();
            this.room5 = new GestResa.UC.Room();
            this.room2 = new GestResa.UC.Room();
            this.room7 = new GestResa.UC.Room();
            this.room4 = new GestResa.UC.Room();
            this.room1 = new GestResa.UC.Room();
            this.nomtext = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorlabel = new System.Windows.Forms.Label();
            this.dureelabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(467, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date de Reservation\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(436, 37);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 22);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lbresult
            // 
            this.lbresult.AutoSize = true;
            this.lbresult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbresult.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbresult.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lbresult.Location = new System.Drawing.Point(425, 79);
            this.lbresult.Name = "lbresult";
            this.lbresult.Size = new System.Drawing.Size(0, 19);
            this.lbresult.TabIndex = 3;
            this.lbresult.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbresult.Click += new System.EventHandler(this.label2_Click);
            // 
            // room9
            // 
            this.room9.BackColor = System.Drawing.Color.Red;
            this.room9.DateTimePicker1 = null;
            this.room9.LabelResult = null;
            this.room9.Location = new System.Drawing.Point(267, 151);
            this.room9.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.room9.Name = "room9";
            this.room9.Number = 3;
            this.room9.Size = new System.Drawing.Size(129, 68);
            this.room9.TabIndex = 0;
            // 
            // room6
            // 
            this.room6.BackColor = System.Drawing.Color.Yellow;
            this.room6.DateTimePicker1 = null;
            this.room6.LabelResult = null;
            this.room6.Location = new System.Drawing.Point(134, 151);
            this.room6.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.room6.Name = "room6";
            this.room6.Number = 2;
            this.room6.Size = new System.Drawing.Size(129, 68);
            this.room6.TabIndex = 0;
            // 
            // room3
            // 
            this.room3.BackColor = System.Drawing.Color.Red;
            this.room3.DateTimePicker1 = null;
            this.room3.LabelResult = null;
            this.room3.Location = new System.Drawing.Point(9, 151);
            this.room3.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.room3.Name = "room3";
            this.room3.Number = 1;
            this.room3.Size = new System.Drawing.Size(121, 68);
            this.room3.TabIndex = 0;
            // 
            // room8
            // 
            this.room8.BackColor = System.Drawing.Color.Yellow;
            this.room8.DateTimePicker1 = null;
            this.room8.LabelResult = null;
            this.room8.Location = new System.Drawing.Point(267, 79);
            this.room8.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.room8.Name = "room8";
            this.room8.Number = 6;
            this.room8.Size = new System.Drawing.Size(129, 68);
            this.room8.TabIndex = 0;
            // 
            // room5
            // 
            this.room5.BackColor = System.Drawing.Color.Red;
            this.room5.DateTimePicker1 = null;
            this.room5.LabelResult = null;
            this.room5.Location = new System.Drawing.Point(134, 79);
            this.room5.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.room5.Name = "room5";
            this.room5.Number = 5;
            this.room5.Size = new System.Drawing.Size(129, 68);
            this.room5.TabIndex = 0;
            // 
            // room2
            // 
            this.room2.BackColor = System.Drawing.Color.Yellow;
            this.room2.DateTimePicker1 = null;
            this.room2.LabelResult = null;
            this.room2.Location = new System.Drawing.Point(9, 79);
            this.room2.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.room2.Name = "room2";
            this.room2.Number = 4;
            this.room2.Size = new System.Drawing.Size(121, 68);
            this.room2.TabIndex = 0;
            // 
            // room7
            // 
            this.room7.BackColor = System.Drawing.Color.Red;
            this.room7.DateTimePicker1 = null;
            this.room7.LabelResult = null;
            this.room7.Location = new System.Drawing.Point(267, 7);
            this.room7.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.room7.Name = "room7";
            this.room7.Number = 9;
            this.room7.Size = new System.Drawing.Size(129, 68);
            this.room7.TabIndex = 0;
            // 
            // room4
            // 
            this.room4.BackColor = System.Drawing.Color.Yellow;
            this.room4.DateTimePicker1 = null;
            this.room4.LabelResult = null;
            this.room4.Location = new System.Drawing.Point(134, 7);
            this.room4.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.room4.Name = "room4";
            this.room4.Number = 8;
            this.room4.Size = new System.Drawing.Size(129, 68);
            this.room4.TabIndex = 0;
            // 
            // room1
            // 
            this.room1.BackColor = System.Drawing.Color.Red;
            this.room1.DateTimePicker1 = null;
            this.room1.LabelResult = null;
            this.room1.Location = new System.Drawing.Point(9, 7);
            this.room1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.room1.Name = "room1";
            this.room1.Number = 7;
            this.room1.Size = new System.Drawing.Size(121, 68);
            this.room1.TabIndex = 0;
            this.room1.Load += new System.EventHandler(this.room1_Load);
            // 
            // nomtext
            // 
            this.nomtext.Location = new System.Drawing.Point(421, 254);
            this.nomtext.Name = "nomtext";
            this.nomtext.Size = new System.Drawing.Size(146, 22);
            this.nomtext.TabIndex = 4;
            this.nomtext.TextChanged += new System.EventHandler(this.nomtext_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(454, 235);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nom Complet";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // errorlabel
            // 
            this.errorlabel.AutoSize = true;
            this.errorlabel.ForeColor = System.Drawing.Color.Red;
            this.errorlabel.Location = new System.Drawing.Point(106, 247);
            this.errorlabel.Name = "errorlabel";
            this.errorlabel.Size = new System.Drawing.Size(0, 16);
            this.errorlabel.TabIndex = 6;
            this.errorlabel.Click += new System.EventHandler(this.errorlabel_Click);
            // 
            // dureelabel
            // 
            this.dureelabel.AutoSize = true;
            this.dureelabel.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dureelabel.Location = new System.Drawing.Point(597, 235);
            this.dureelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dureelabel.Name = "dureelabel";
            this.dureelabel.Size = new System.Drawing.Size(38, 16);
            this.dureelabel.TabIndex = 7;
            this.dureelabel.Text = "Duree";
            this.dureelabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(600, 254);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(35, 22);
            this.numericUpDown1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(656, 288);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.dureelabel);
            this.Controls.Add(this.errorlabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomtext);
            this.Controls.Add(this.lbresult);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.room9);
            this.Controls.Add(this.room6);
            this.Controls.Add(this.room3);
            this.Controls.Add(this.room8);
            this.Controls.Add(this.room5);
            this.Controls.Add(this.room2);
            this.Controls.Add(this.room7);
            this.Controls.Add(this.room4);
            this.Controls.Add(this.room1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UC.Room room1;
        private UC.Room room2;
        private UC.Room room3;
        private UC.Room room4;
        private UC.Room room5;
        private UC.Room room6;
        private UC.Room room7;
        private UC.Room room8;
        private UC.Room room9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbresult;
        private System.Windows.Forms.TextBox nomtext;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label errorlabel;
        private System.Windows.Forms.Label dureelabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

