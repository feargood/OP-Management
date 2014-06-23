namespace OP_Management
{
    partial class OPeingabe
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
            this.button_Anlegen = new System.Windows.Forms.Button();
            this.button_verwerf = new System.Windows.Forms.Button();
            this.button_anlegen_u_weit = new System.Windows.Forms.Button();
            this.oPKategorienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projekt1DataSet = new OP_Management.Projekt1DataSet();
            this.oPDatenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oP_DatenTableAdapter = new OP_Management.Projekt1DataSetTableAdapters.OP_DatenTableAdapter();
            this.oP_KategorienTableAdapter = new OP_Management.Projekt1DataSetTableAdapters.OP_KategorienTableAdapter();
            this.oPKategorienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMinuten = new System.Windows.Forms.ComboBox();
            this.cbStunden = new System.Windows.Forms.ComboBox();
            this.lbUhrzeit = new System.Windows.Forms.Label();
            this.ListePatient = new System.Windows.Forms.ComboBox();
            this.lbPatient = new System.Windows.Forms.Label();
            this.ListeAnaes = new System.Windows.Forms.ComboBox();
            this.ListeKrankens2 = new System.Windows.Forms.ComboBox();
            this.ListeKrankens = new System.Windows.Forms.ComboBox();
            this.ListeChirurg2 = new System.Windows.Forms.ComboBox();
            this.ListeChirurg = new System.Windows.Forms.ComboBox();
            this.OP_Art_Combo = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.patientendatenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientendatenTableAdapter = new OP_Management.Projekt1DataSetTableAdapters.PatientendatenTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.oPKategorienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPDatenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPKategorienBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientendatenBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Anlegen
            // 
            this.button_Anlegen.Location = new System.Drawing.Point(13, 435);
            this.button_Anlegen.Margin = new System.Windows.Forms.Padding(4);
            this.button_Anlegen.Name = "button_Anlegen";
            this.button_Anlegen.Size = new System.Drawing.Size(185, 43);
            this.button_Anlegen.TabIndex = 0;
            this.button_Anlegen.Text = "Anlegen";
            this.button_Anlegen.UseVisualStyleBackColor = true;
            this.button_Anlegen.Click += new System.EventHandler(this.button_Anlegen_Click);
            // 
            // button_verwerf
            // 
            this.button_verwerf.Location = new System.Drawing.Point(398, 435);
            this.button_verwerf.Margin = new System.Windows.Forms.Padding(4);
            this.button_verwerf.Name = "button_verwerf";
            this.button_verwerf.Size = new System.Drawing.Size(187, 43);
            this.button_verwerf.TabIndex = 1;
            this.button_verwerf.Text = "Verwerfen";
            this.button_verwerf.UseVisualStyleBackColor = true;
            this.button_verwerf.Click += new System.EventHandler(this.button_verwerf_Click);
            // 
            // button_anlegen_u_weit
            // 
            this.button_anlegen_u_weit.Location = new System.Drawing.Point(206, 435);
            this.button_anlegen_u_weit.Margin = new System.Windows.Forms.Padding(4);
            this.button_anlegen_u_weit.Name = "button_anlegen_u_weit";
            this.button_anlegen_u_weit.Size = new System.Drawing.Size(184, 43);
            this.button_anlegen_u_weit.TabIndex = 2;
            this.button_anlegen_u_weit.Text = "Anlegen u. weitere OP anlegen";
            this.button_anlegen_u_weit.UseVisualStyleBackColor = true;
            this.button_anlegen_u_weit.Click += new System.EventHandler(this.button_anlegen_u_weit_Click);
            // 
            // oPKategorienBindingSource
            // 
            this.oPKategorienBindingSource.DataMember = "OP_Kategorien";
            this.oPKategorienBindingSource.DataSource = this.projekt1DataSet;
            // 
            // projekt1DataSet
            // 
            this.projekt1DataSet.DataSetName = "Projekt1DataSet";
            this.projekt1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oPDatenBindingSource
            // 
            this.oPDatenBindingSource.DataMember = "OP_Daten";
            this.oPDatenBindingSource.DataSource = this.projekt1DataSet;
            // 
            // oP_DatenTableAdapter
            // 
            this.oP_DatenTableAdapter.ClearBeforeFill = true;
            // 
            // oP_KategorienTableAdapter
            // 
            this.oP_KategorienTableAdapter.ClearBeforeFill = true;
            // 
            // oPKategorienBindingSource1
            // 
            this.oPKategorienBindingSource1.DataMember = "OP_Kategorien";
            this.oPKategorienBindingSource1.DataSource = this.projekt1DataSet;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbMinuten);
            this.groupBox1.Controls.Add(this.cbStunden);
            this.groupBox1.Controls.Add(this.lbUhrzeit);
            this.groupBox1.Controls.Add(this.ListePatient);
            this.groupBox1.Controls.Add(this.lbPatient);
            this.groupBox1.Controls.Add(this.ListeAnaes);
            this.groupBox1.Controls.Add(this.ListeKrankens2);
            this.groupBox1.Controls.Add(this.ListeKrankens);
            this.groupBox1.Controls.Add(this.ListeChirurg2);
            this.groupBox1.Controls.Add(this.ListeChirurg);
            this.groupBox1.Controls.Add(this.OP_Art_Combo);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(572, 415);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OP-Erfassung";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(301, 115);
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
            "15",
            "30",
            "45"});
            this.cbMinuten.Location = new System.Drawing.Point(322, 112);
            this.cbMinuten.Margin = new System.Windows.Forms.Padding(4);
            this.cbMinuten.Name = "cbMinuten";
            this.cbMinuten.Size = new System.Drawing.Size(55, 24);
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
            this.cbStunden.Location = new System.Drawing.Point(238, 112);
            this.cbStunden.Margin = new System.Windows.Forms.Padding(4);
            this.cbStunden.Name = "cbStunden";
            this.cbStunden.Size = new System.Drawing.Size(55, 24);
            this.cbStunden.TabIndex = 38;
            // 
            // lbUhrzeit
            // 
            this.lbUhrzeit.AutoSize = true;
            this.lbUhrzeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUhrzeit.Location = new System.Drawing.Point(140, 115);
            this.lbUhrzeit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUhrzeit.Name = "lbUhrzeit";
            this.lbUhrzeit.Size = new System.Drawing.Size(49, 16);
            this.lbUhrzeit.TabIndex = 37;
            this.lbUhrzeit.Text = "Uhrzeit";
            // 
            // ListePatient
            // 
            this.ListePatient.FormattingEnabled = true;
            this.ListePatient.Location = new System.Drawing.Point(238, 42);
            this.ListePatient.Margin = new System.Windows.Forms.Padding(4);
            this.ListePatient.Name = "ListePatient";
            this.ListePatient.Size = new System.Drawing.Size(160, 24);
            this.ListePatient.TabIndex = 36;
            this.ListePatient.SelectedIndexChanged += new System.EventHandler(this.Patient_Combo_SelectedIndexChanged);
            // 
            // lbPatient
            // 
            this.lbPatient.AutoSize = true;
            this.lbPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPatient.Location = new System.Drawing.Point(140, 42);
            this.lbPatient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPatient.Name = "lbPatient";
            this.lbPatient.Size = new System.Drawing.Size(49, 16);
            this.lbPatient.TabIndex = 35;
            this.lbPatient.Text = "Patient";
            // 
            // ListeAnaes
            // 
            this.ListeAnaes.FormattingEnabled = true;
            this.ListeAnaes.Location = new System.Drawing.Point(238, 302);
            this.ListeAnaes.Margin = new System.Windows.Forms.Padding(4);
            this.ListeAnaes.Name = "ListeAnaes";
            this.ListeAnaes.Size = new System.Drawing.Size(160, 24);
            this.ListeAnaes.TabIndex = 34;
            // 
            // ListeKrankens2
            // 
            this.ListeKrankens2.FormattingEnabled = true;
            this.ListeKrankens2.Location = new System.Drawing.Point(238, 261);
            this.ListeKrankens2.Margin = new System.Windows.Forms.Padding(4);
            this.ListeKrankens2.Name = "ListeKrankens2";
            this.ListeKrankens2.Size = new System.Drawing.Size(160, 24);
            this.ListeKrankens2.TabIndex = 33;
            // 
            // ListeKrankens
            // 
            this.ListeKrankens.FormattingEnabled = true;
            this.ListeKrankens.Location = new System.Drawing.Point(238, 228);
            this.ListeKrankens.Margin = new System.Windows.Forms.Padding(4);
            this.ListeKrankens.Name = "ListeKrankens";
            this.ListeKrankens.Size = new System.Drawing.Size(160, 24);
            this.ListeKrankens.TabIndex = 32;
            // 
            // ListeChirurg2
            // 
            this.ListeChirurg2.FormattingEnabled = true;
            this.ListeChirurg2.Location = new System.Drawing.Point(238, 187);
            this.ListeChirurg2.Margin = new System.Windows.Forms.Padding(4);
            this.ListeChirurg2.Name = "ListeChirurg2";
            this.ListeChirurg2.Size = new System.Drawing.Size(160, 24);
            this.ListeChirurg2.TabIndex = 31;
            // 
            // ListeChirurg
            // 
            this.ListeChirurg.FormattingEnabled = true;
            this.ListeChirurg.Location = new System.Drawing.Point(238, 153);
            this.ListeChirurg.Margin = new System.Windows.Forms.Padding(4);
            this.ListeChirurg.Name = "ListeChirurg";
            this.ListeChirurg.Size = new System.Drawing.Size(160, 24);
            this.ListeChirurg.TabIndex = 30;
            // 
            // OP_Art_Combo
            // 
            this.OP_Art_Combo.DataSource = this.oPKategorienBindingSource;
            this.OP_Art_Combo.DisplayMember = "OP_Art";
            this.OP_Art_Combo.FormattingEnabled = true;
            this.OP_Art_Combo.Location = new System.Drawing.Point(238, 74);
            this.OP_Art_Combo.Margin = new System.Windows.Forms.Padding(4);
            this.OP_Art_Combo.Name = "OP_Art_Combo";
            this.OP_Art_Combo.Size = new System.Drawing.Size(160, 24);
            this.OP_Art_Combo.TabIndex = 29;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(238, 349);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(140, 349);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 26;
            this.label7.Text = "Datum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(110, 302);
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
            this.label4.Location = new System.Drawing.Point(70, 228);
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
            this.label3.Location = new System.Drawing.Point(137, 153);
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
            this.label1.Location = new System.Drawing.Point(140, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "OP-Art";
            // 
            // patientendatenBindingSource
            // 
            this.patientendatenBindingSource.DataMember = "Patientendaten";
            this.patientendatenBindingSource.DataSource = this.projekt1DataSet;
            // 
            // patientendatenTableAdapter
            // 
            this.patientendatenTableAdapter.ClearBeforeFill = true;
            // 
            // OPeingabe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 491);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_anlegen_u_weit);
            this.Controls.Add(this.button_verwerf);
            this.Controls.Add(this.button_Anlegen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OPeingabe";
            this.Text = "OPeingabe";
            this.Load += new System.EventHandler(this.OPeingabe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oPKategorienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPDatenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oPKategorienBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientendatenBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Anlegen;
        private System.Windows.Forms.Button button_verwerf;
        private System.Windows.Forms.Button button_anlegen_u_weit;
        private Projekt1DataSet projekt1DataSet;
        private System.Windows.Forms.BindingSource oPDatenBindingSource;
        private Projekt1DataSetTableAdapters.OP_DatenTableAdapter oP_DatenTableAdapter;
        private System.Windows.Forms.BindingSource oPKategorienBindingSource;
        private Projekt1DataSetTableAdapters.OP_KategorienTableAdapter oP_KategorienTableAdapter;
        private System.Windows.Forms.BindingSource oPKategorienBindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ListeAnaes;
        private System.Windows.Forms.ComboBox ListeKrankens2;
        private System.Windows.Forms.ComboBox ListeKrankens;
        private System.Windows.Forms.ComboBox ListeChirurg2;
        private System.Windows.Forms.ComboBox ListeChirurg;
        private System.Windows.Forms.ComboBox OP_Art_Combo;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ListePatient;
        private System.Windows.Forms.Label lbPatient;
        private System.Windows.Forms.BindingSource patientendatenBindingSource;
        private Projekt1DataSetTableAdapters.PatientendatenTableAdapter patientendatenTableAdapter;
        private System.Windows.Forms.ComboBox cbMinuten;
        private System.Windows.Forms.ComboBox cbStunden;
        private System.Windows.Forms.Label lbUhrzeit;
        private System.Windows.Forms.Label label2;
    }
}