namespace OP_Management
{
    partial class OPBearbeiten
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
            this.button_verwerf = new System.Windows.Forms.Button();
            this.button_Anlegen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.OP_Art_TextBox = new System.Windows.Forms.TextBox();
            this.ListePatient = new System.Windows.Forms.ComboBox();
            this.lbPatient = new System.Windows.Forms.Label();
            this.ListeAnaes = new System.Windows.Forms.ComboBox();
            this.ListeKrankens2 = new System.Windows.Forms.ComboBox();
            this.ListeKrankens = new System.Windows.Forms.ComboBox();
            this.ListeChirurg2 = new System.Windows.Forms.ComboBox();
            this.ListeChirurg = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMinuten = new System.Windows.Forms.ComboBox();
            this.cbStunden = new System.Windows.Forms.ComboBox();
            this.lbUhrzeit = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Raum_Combo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_verwerf
            // 
            this.button_verwerf.Location = new System.Drawing.Point(304, 456);
            this.button_verwerf.Margin = new System.Windows.Forms.Padding(4);
            this.button_verwerf.Name = "button_verwerf";
            this.button_verwerf.Size = new System.Drawing.Size(187, 43);
            this.button_verwerf.TabIndex = 24;
            this.button_verwerf.Text = "Verwerfen";
            this.button_verwerf.UseVisualStyleBackColor = true;
            this.button_verwerf.Click += new System.EventHandler(this.button_verwerf_Click_1);
            // 
            // button_Anlegen
            // 
            this.button_Anlegen.Location = new System.Drawing.Point(12, 456);
            this.button_Anlegen.Margin = new System.Windows.Forms.Padding(4);
            this.button_Anlegen.Name = "button_Anlegen";
            this.button_Anlegen.Size = new System.Drawing.Size(185, 43);
            this.button_Anlegen.TabIndex = 23;
            this.button_Anlegen.Text = "Änderung speichern";
            this.button_Anlegen.UseVisualStyleBackColor = true;
            this.button_Anlegen.Click += new System.EventHandler(this.button_Anlegen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.OP_Art_TextBox);
            this.groupBox1.Controls.Add(this.ListePatient);
            this.groupBox1.Controls.Add(this.lbPatient);
            this.groupBox1.Controls.Add(this.ListeAnaes);
            this.groupBox1.Controls.Add(this.ListeKrankens2);
            this.groupBox1.Controls.Add(this.ListeKrankens);
            this.groupBox1.Controls.Add(this.ListeChirurg2);
            this.groupBox1.Controls.Add(this.ListeChirurg);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 292);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OP-Bearbeiten";
            // 
            // OP_Art_TextBox
            // 
            this.OP_Art_TextBox.Enabled = false;
            this.OP_Art_TextBox.Location = new System.Drawing.Point(191, 69);
            this.OP_Art_TextBox.Name = "OP_Art_TextBox";
            this.OP_Art_TextBox.ReadOnly = true;
            this.OP_Art_TextBox.Size = new System.Drawing.Size(160, 20);
            this.OP_Art_TextBox.TabIndex = 41;
            // 
            // ListePatient
            // 
            this.ListePatient.FormattingEnabled = true;
            this.ListePatient.Location = new System.Drawing.Point(191, 41);
            this.ListePatient.Margin = new System.Windows.Forms.Padding(4);
            this.ListePatient.Name = "ListePatient";
            this.ListePatient.Size = new System.Drawing.Size(160, 21);
            this.ListePatient.TabIndex = 36;
            this.ListePatient.SelectedIndexChanged += new System.EventHandler(this.ListePatient_SelectedIndexChanged);
            // 
            // lbPatient
            // 
            this.lbPatient.AutoSize = true;
            this.lbPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPatient.Location = new System.Drawing.Point(93, 41);
            this.lbPatient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPatient.Name = "lbPatient";
            this.lbPatient.Size = new System.Drawing.Size(49, 16);
            this.lbPatient.TabIndex = 35;
            this.lbPatient.Text = "Patient";
            // 
            // ListeAnaes
            // 
            this.ListeAnaes.FormattingEnabled = true;
            this.ListeAnaes.Location = new System.Drawing.Point(191, 245);
            this.ListeAnaes.Margin = new System.Windows.Forms.Padding(4);
            this.ListeAnaes.Name = "ListeAnaes";
            this.ListeAnaes.Size = new System.Drawing.Size(160, 21);
            this.ListeAnaes.TabIndex = 34;
            // 
            // ListeKrankens2
            // 
            this.ListeKrankens2.FormattingEnabled = true;
            this.ListeKrankens2.Location = new System.Drawing.Point(191, 204);
            this.ListeKrankens2.Margin = new System.Windows.Forms.Padding(4);
            this.ListeKrankens2.Name = "ListeKrankens2";
            this.ListeKrankens2.Size = new System.Drawing.Size(160, 21);
            this.ListeKrankens2.TabIndex = 33;
            // 
            // ListeKrankens
            // 
            this.ListeKrankens.FormattingEnabled = true;
            this.ListeKrankens.Location = new System.Drawing.Point(191, 171);
            this.ListeKrankens.Margin = new System.Windows.Forms.Padding(4);
            this.ListeKrankens.Name = "ListeKrankens";
            this.ListeKrankens.Size = new System.Drawing.Size(160, 21);
            this.ListeKrankens.TabIndex = 32;
            // 
            // ListeChirurg2
            // 
            this.ListeChirurg2.FormattingEnabled = true;
            this.ListeChirurg2.Location = new System.Drawing.Point(191, 130);
            this.ListeChirurg2.Margin = new System.Windows.Forms.Padding(4);
            this.ListeChirurg2.Name = "ListeChirurg2";
            this.ListeChirurg2.Size = new System.Drawing.Size(160, 21);
            this.ListeChirurg2.TabIndex = 31;
            // 
            // ListeChirurg
            // 
            this.ListeChirurg.FormattingEnabled = true;
            this.ListeChirurg.Location = new System.Drawing.Point(191, 96);
            this.ListeChirurg.Margin = new System.Windows.Forms.Padding(4);
            this.ListeChirurg.Name = "ListeChirurg";
            this.ListeChirurg.Size = new System.Drawing.Size(160, 21);
            this.ListeChirurg.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 245);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Anästhesist";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "Krankenschwester";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Chirurg";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 73);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "OP-Art";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 18);
            this.label2.TabIndex = 40;
            this.label2.Text = ":";
            // 
            // cbMinuten
            // 
            this.cbMinuten.FormattingEnabled = true;
            this.cbMinuten.Items.AddRange(new object[] {
            "00",
            "30",});
            this.cbMinuten.Location = new System.Drawing.Point(246, 50);
            this.cbMinuten.Margin = new System.Windows.Forms.Padding(4);
            this.cbMinuten.Name = "cbMinuten";
            this.cbMinuten.Size = new System.Drawing.Size(55, 21);
            this.cbMinuten.TabIndex = 39;
            // 
            // cbStunden
            // 
            this.cbStunden.FormattingEnabled = true;
            this.cbStunden.Items.AddRange(new object[] {
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17"});
            this.cbStunden.Location = new System.Drawing.Point(162, 50);
            this.cbStunden.Margin = new System.Windows.Forms.Padding(4);
            this.cbStunden.Name = "cbStunden";
            this.cbStunden.Size = new System.Drawing.Size(55, 21);
            this.cbStunden.TabIndex = 38;
            // 
            // lbUhrzeit
            // 
            this.lbUhrzeit.AutoSize = true;
            this.lbUhrzeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUhrzeit.Location = new System.Drawing.Point(64, 53);
            this.lbUhrzeit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUhrzeit.Name = "lbUhrzeit";
            this.lbUhrzeit.Size = new System.Drawing.Size(49, 16);
            this.lbUhrzeit.TabIndex = 37;
            this.lbUhrzeit.Text = "Uhrzeit";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(162, 20);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 20);
            this.dateTimePicker1.TabIndex = 28;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(64, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Datum";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Raum_Combo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.cbMinuten);
            this.groupBox2.Controls.Add(this.lbUhrzeit);
            this.groupBox2.Controls.Add(this.cbStunden);
            this.groupBox2.Location = new System.Drawing.Point(13, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(478, 139);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            // 
            // Raum_Combo
            // 
            this.Raum_Combo.FormattingEnabled = true;
            this.Raum_Combo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.Raum_Combo.Location = new System.Drawing.Point(162, 86);
            this.Raum_Combo.Margin = new System.Windows.Forms.Padding(4);
            this.Raum_Combo.Name = "Raum_Combo";
            this.Raum_Combo.Size = new System.Drawing.Size(55, 21);
            this.Raum_Combo.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(64, 86);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 16);
            this.label6.TabIndex = 41;
            this.label6.Text = "Raum";
            // 
            // OPBearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 516);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_verwerf);
            this.Controls.Add(this.button_Anlegen);
            this.Name = "OPBearbeiten";
            this.Text = "OPBearbeiten";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_verwerf;
        private System.Windows.Forms.Button button_Anlegen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMinuten;
        private System.Windows.Forms.ComboBox cbStunden;
        private System.Windows.Forms.Label lbUhrzeit;
        private System.Windows.Forms.ComboBox ListePatient;
        private System.Windows.Forms.Label lbPatient;
        private System.Windows.Forms.ComboBox ListeAnaes;
        private System.Windows.Forms.ComboBox ListeKrankens2;
        private System.Windows.Forms.ComboBox ListeKrankens;
        private System.Windows.Forms.ComboBox ListeChirurg2;
        private System.Windows.Forms.ComboBox ListeChirurg;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox OP_Art_TextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox Raum_Combo;
        private System.Windows.Forms.Label label6;

    }
}