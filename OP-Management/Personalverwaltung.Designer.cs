namespace OP_Management
{
    partial class Personalverwaltung
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPersonalArbeitszeit = new System.Windows.Forms.TextBox();
            this.comboBoxPersonalFunktion = new System.Windows.Forms.ComboBox();
            this.textBoxPersonalName = new System.Windows.Forms.TextBox();
            this.textBoxPersonalVorname = new System.Windows.Forms.TextBox();
            this.buttonAnlegen = new System.Windows.Forms.Button();
            this.buttonLoeschen = new System.Windows.Forms.Button();
            this.buttonAendern = new System.Windows.Forms.Button();
            this.gbPersonalverwaltung = new System.Windows.Forms.GroupBox();
            this.gbPersonalverwaltung2 = new System.Windows.Forms.GroupBox();
            this.listViewPersonal = new System.Windows.Forms.ListView();
            this.gbPersonalverwaltung.SuspendLayout();
            this.gbPersonalverwaltung2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vorname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Funktion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Arbeitszeit";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(253, 159);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stunden/ Woche";
            // 
            // textBoxPersonalArbeitszeit
            // 
            this.textBoxPersonalArbeitszeit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxPersonalArbeitszeit.Location = new System.Drawing.Point(125, 156);
            this.textBoxPersonalArbeitszeit.MaxLength = 2;
            this.textBoxPersonalArbeitszeit.Name = "textBoxPersonalArbeitszeit";
            this.textBoxPersonalArbeitszeit.Size = new System.Drawing.Size(121, 22);
            this.textBoxPersonalArbeitszeit.TabIndex = 5;
            this.textBoxPersonalArbeitszeit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPersonalArbeitszeit_KeyPress);
            // 
            // comboBoxPersonalFunktion
            // 
            this.comboBoxPersonalFunktion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPersonalFunktion.FormattingEnabled = true;
            this.comboBoxPersonalFunktion.Items.AddRange(new object[] {
            "Chirurg",
            "Anästhesist",
            "Krankenschwester"});
            this.comboBoxPersonalFunktion.Location = new System.Drawing.Point(126, 111);
            this.comboBoxPersonalFunktion.Name = "comboBoxPersonalFunktion";
            this.comboBoxPersonalFunktion.Size = new System.Drawing.Size(120, 24);
            this.comboBoxPersonalFunktion.TabIndex = 6;
            // 
            // textBoxPersonalName
            // 
            this.textBoxPersonalName.Location = new System.Drawing.Point(127, 37);
            this.textBoxPersonalName.Name = "textBoxPersonalName";
            this.textBoxPersonalName.Size = new System.Drawing.Size(119, 22);
            this.textBoxPersonalName.TabIndex = 7;
            // 
            // textBoxPersonalVorname
            // 
            this.textBoxPersonalVorname.Location = new System.Drawing.Point(126, 73);
            this.textBoxPersonalVorname.Name = "textBoxPersonalVorname";
            this.textBoxPersonalVorname.Size = new System.Drawing.Size(120, 22);
            this.textBoxPersonalVorname.TabIndex = 8;
            // 
            // buttonAnlegen
            // 
            this.buttonAnlegen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnlegen.Location = new System.Drawing.Point(12, 406);
            this.buttonAnlegen.Name = "buttonAnlegen";
            this.buttonAnlegen.Size = new System.Drawing.Size(139, 44);
            this.buttonAnlegen.TabIndex = 9;
            this.buttonAnlegen.Text = "Neu anlegen";
            this.buttonAnlegen.UseVisualStyleBackColor = true;
            this.buttonAnlegen.Click += new System.EventHandler(this.buttonAnlegen_Click);
            // 
            // buttonLoeschen
            // 
            this.buttonLoeschen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLoeschen.Location = new System.Drawing.Point(169, 405);
            this.buttonLoeschen.Name = "buttonLoeschen";
            this.buttonLoeschen.Size = new System.Drawing.Size(140, 45);
            this.buttonLoeschen.TabIndex = 10;
            this.buttonLoeschen.Text = "Löschen";
            this.buttonLoeschen.UseVisualStyleBackColor = true;
            this.buttonLoeschen.Click += new System.EventHandler(this.buttonLoeschen_Click);
            // 
            // buttonAendern
            // 
            this.buttonAendern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAendern.Location = new System.Drawing.Point(315, 406);
            this.buttonAendern.Name = "buttonAendern";
            this.buttonAendern.Size = new System.Drawing.Size(146, 45);
            this.buttonAendern.TabIndex = 11;
            this.buttonAendern.Text = "Änderungen speichern";
            this.buttonAendern.UseVisualStyleBackColor = true;
            this.buttonAendern.Click += new System.EventHandler(this.buttonAendern_Click);
            // 
            // gbPersonalverwaltung
            // 
            this.gbPersonalverwaltung.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPersonalverwaltung.Controls.Add(this.textBoxPersonalArbeitszeit);
            this.gbPersonalverwaltung.Controls.Add(this.label1);
            this.gbPersonalverwaltung.Controls.Add(this.label2);
            this.gbPersonalverwaltung.Controls.Add(this.label3);
            this.gbPersonalverwaltung.Controls.Add(this.label4);
            this.gbPersonalverwaltung.Controls.Add(this.label5);
            this.gbPersonalverwaltung.Controls.Add(this.textBoxPersonalVorname);
            this.gbPersonalverwaltung.Controls.Add(this.comboBoxPersonalFunktion);
            this.gbPersonalverwaltung.Controls.Add(this.textBoxPersonalName);
            this.gbPersonalverwaltung.Location = new System.Drawing.Point(12, 12);
            this.gbPersonalverwaltung.Name = "gbPersonalverwaltung";
            this.gbPersonalverwaltung.Size = new System.Drawing.Size(449, 190);
            this.gbPersonalverwaltung.TabIndex = 12;
            this.gbPersonalverwaltung.TabStop = false;
            this.gbPersonalverwaltung.Text = "Personalverwaltung";
            // 
            // gbPersonalverwaltung2
            // 
            this.gbPersonalverwaltung2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPersonalverwaltung2.Controls.Add(this.listViewPersonal);
            this.gbPersonalverwaltung2.Location = new System.Drawing.Point(12, 209);
            this.gbPersonalverwaltung2.Name = "gbPersonalverwaltung2";
            this.gbPersonalverwaltung2.Size = new System.Drawing.Size(449, 191);
            this.gbPersonalverwaltung2.TabIndex = 13;
            this.gbPersonalverwaltung2.TabStop = false;
            this.gbPersonalverwaltung2.Text = "Personalliste";
            // 
            // listViewPersonal
            // 
            this.listViewPersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPersonal.FullRowSelect = true;
            this.listViewPersonal.GridLines = true;
            this.listViewPersonal.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewPersonal.HideSelection = false;
            this.listViewPersonal.Location = new System.Drawing.Point(3, 18);
            this.listViewPersonal.MultiSelect = false;
            this.listViewPersonal.Name = "listViewPersonal";
            this.listViewPersonal.Size = new System.Drawing.Size(443, 170);
            this.listViewPersonal.TabIndex = 0;
            this.listViewPersonal.UseCompatibleStateImageBehavior = false;
            this.listViewPersonal.View = System.Windows.Forms.View.List;
            this.listViewPersonal.Click += new System.EventHandler(this.listViewPersonal_Click);
            // 
            // Personalverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 463);
            this.Controls.Add(this.gbPersonalverwaltung2);
            this.Controls.Add(this.gbPersonalverwaltung);
            this.Controls.Add(this.buttonAendern);
            this.Controls.Add(this.buttonLoeschen);
            this.Controls.Add(this.buttonAnlegen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(474, 306);
            this.Name = "Personalverwaltung";
            this.ShowIcon = false;
            this.Text = "Personalverwaltung";
            this.TopMost = true;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Personalverwaltung_KeyPress);
            this.gbPersonalverwaltung.ResumeLayout(false);
            this.gbPersonalverwaltung.PerformLayout();
            this.gbPersonalverwaltung2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPersonalArbeitszeit;
        private System.Windows.Forms.ComboBox comboBoxPersonalFunktion;
        private System.Windows.Forms.TextBox textBoxPersonalName;
        private System.Windows.Forms.TextBox textBoxPersonalVorname;
        private System.Windows.Forms.Button buttonAnlegen;
        private System.Windows.Forms.Button buttonLoeschen;
        private System.Windows.Forms.Button buttonAendern;
        private System.Windows.Forms.GroupBox gbPersonalverwaltung;
        private System.Windows.Forms.GroupBox gbPersonalverwaltung2;
        private System.Windows.Forms.ListView listViewPersonal;
    }
}