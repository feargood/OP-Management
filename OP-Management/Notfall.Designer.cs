namespace OP_Management
{
    partial class Notfall
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
            this.babschicken = new System.Windows.Forms.Button();
            this.bannehmen = new System.Windows.Forms.Button();
            this.bverwerfen = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lantwort = new System.Windows.Forms.Label();
            this.oPKategorienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projekt1DataSet = new OP_Management.Projekt1DataSet();
            this.oP_KategorienTableAdapter = new OP_Management.Projekt1DataSetTableAdapters.OP_KategorienTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbart = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbzeit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fKPatientendatenOPKategorienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientendatenTableAdapter = new OP_Management.Projekt1DataSetTableAdapters.PatientendatenTableAdapter();
            this.fKPatientendatenOPKategorienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oPKategorienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt1DataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKPatientendatenOPKategorienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPatientendatenOPKategorienBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // babschicken
            // 
            this.babschicken.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.babschicken.Location = new System.Drawing.Point(113, 139);
            this.babschicken.Name = "babschicken";
            this.babschicken.Size = new System.Drawing.Size(162, 32);
            this.babschicken.TabIndex = 4;
            this.babschicken.Text = "Anfrage Senden";
            this.babschicken.UseVisualStyleBackColor = true;
            this.babschicken.Click += new System.EventHandler(this.babschicken_Click);
            // 
            // bannehmen
            // 
            this.bannehmen.Enabled = false;
            this.bannehmen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bannehmen.Location = new System.Drawing.Point(25, 396);
            this.bannehmen.Name = "bannehmen";
            this.bannehmen.Size = new System.Drawing.Size(99, 31);
            this.bannehmen.TabIndex = 5;
            this.bannehmen.Text = "Annehmen";
            this.bannehmen.UseVisualStyleBackColor = true;
            this.bannehmen.Click += new System.EventHandler(this.bannehmen_Click);
            // 
            // bverwerfen
            // 
            this.bverwerfen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bverwerfen.Location = new System.Drawing.Point(257, 396);
            this.bverwerfen.Name = "bverwerfen";
            this.bverwerfen.Size = new System.Drawing.Size(99, 31);
            this.bverwerfen.TabIndex = 6;
            this.bverwerfen.Text = "Verwerfen";
            this.bverwerfen.UseVisualStyleBackColor = true;
            this.bverwerfen.Click += new System.EventHandler(this.bverwerfen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lantwort);
            this.groupBox1.Location = new System.Drawing.Point(25, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 151);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Antwort";
            // 
            // lantwort
            // 
            this.lantwort.AutoSize = true;
            this.lantwort.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lantwort.Location = new System.Drawing.Point(13, 58);
            this.lantwort.Name = "lantwort";
            this.lantwort.Size = new System.Drawing.Size(114, 31);
            this.lantwort.TabIndex = 0;
            this.lantwort.Text = "Antwort";
            this.lantwort.Visible = false;
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
            // oP_KategorienTableAdapter
            // 
            this.oP_KategorienTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbart);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbzeit);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(13, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 109);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Notfallerfassung";
            // 
            // cbart
            // 
            this.cbart.DataSource = this.oPKategorienBindingSource;
            this.cbart.DisplayMember = "OP_Art";
            this.cbart.FormattingEnabled = true;
            this.cbart.Location = new System.Drawing.Point(171, 66);
            this.cbart.Name = "cbart";
            this.cbart.Size = new System.Drawing.Size(100, 21);
            this.cbart.TabIndex = 17;
            this.cbart.ValueMember = "OP_Dauer";
            this.cbart.SelectedIndexChanged += new System.EventHandler(this.cbart_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(97, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "OP-Art";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(277, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 15);
            this.label6.TabIndex = 15;
            this.label6.Text = "Minuten";
            // 
            // tbzeit
            // 
            this.tbzeit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbzeit.Location = new System.Drawing.Point(171, 19);
            this.tbzeit.Name = "tbzeit";
            this.tbzeit.Size = new System.Drawing.Size(100, 21);
            this.tbzeit.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Zeit bis Ankunft";
            // 
            // fKPatientendatenOPKategorienBindingSource
            // 
            this.fKPatientendatenOPKategorienBindingSource.DataMember = "FK_Patientendaten_OP_Kategorien";
            this.fKPatientendatenOPKategorienBindingSource.DataSource = this.oPKategorienBindingSource;
            // 
            // patientendatenTableAdapter
            // 
            this.patientendatenTableAdapter.ClearBeforeFill = true;
            // 
            // fKPatientendatenOPKategorienBindingSource1
            // 
            this.fKPatientendatenOPKategorienBindingSource1.DataMember = "FK_Patientendaten_OP_Kategorien";
            this.fKPatientendatenOPKategorienBindingSource1.DataSource = this.oPKategorienBindingSource;
            // 
            // Notfall
            // 
            this.ClientSize = new System.Drawing.Size(383, 442);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bverwerfen);
            this.Controls.Add(this.bannehmen);
            this.Controls.Add(this.babschicken);
            this.Name = "Notfall";
            this.Load += new System.EventHandler(this.Notfall_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oPKategorienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt1DataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fKPatientendatenOPKategorienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPatientendatenOPKategorienBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button babschicken;
        private System.Windows.Forms.Button bannehmen;
        private System.Windows.Forms.Button bverwerfen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lantwort;
        private Projekt1DataSet projekt1DataSet;
        private System.Windows.Forms.BindingSource oPKategorienBindingSource;
        private Projekt1DataSetTableAdapters.OP_KategorienTableAdapter oP_KategorienTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbart;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbzeit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource fKPatientendatenOPKategorienBindingSource;
        private Projekt1DataSetTableAdapters.PatientendatenTableAdapter patientendatenTableAdapter;
        private System.Windows.Forms.BindingSource fKPatientendatenOPKategorienBindingSource1;
    }
}