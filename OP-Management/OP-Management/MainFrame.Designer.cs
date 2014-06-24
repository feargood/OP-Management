namespace OP_Management
{
    partial class MainFrame
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_Notfall = new System.Windows.Forms.Button();
            this.FensterAusw_Combo = new System.Windows.Forms.ComboBox();
            this.oPKategorienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projekt1DataSet = new OP_Management.Projekt1DataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.operationAnlegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalverwaltungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opertionenVerwaltenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.oP_KategorienTableAdapter = new OP_Management.Projekt1DataSetTableAdapters.OP_KategorienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.oPKategorienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt1DataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Notfall
            // 
            this.button_Notfall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Notfall.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_Notfall.Location = new System.Drawing.Point(462, 31);
            this.button_Notfall.Margin = new System.Windows.Forms.Padding(6);
            this.button_Notfall.Name = "button_Notfall";
            this.button_Notfall.Size = new System.Drawing.Size(150, 42);
            this.button_Notfall.TabIndex = 0;
            this.button_Notfall.Text = "NOTFALL";
            this.button_Notfall.UseVisualStyleBackColor = false;
            this.button_Notfall.Click += new System.EventHandler(this.button_Notfall_Click);
            // 
            // FensterAusw_Combo
            // 
            this.FensterAusw_Combo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FensterAusw_Combo.FormattingEnabled = true;
            this.FensterAusw_Combo.Items.AddRange(new object[] {
            "Gesamtübersicht",
            "Raum 1",
            "Raum 2",
            "Raum 3",
            "Raum 4"});
            this.FensterAusw_Combo.Location = new System.Drawing.Point(12, 40);
            this.FensterAusw_Combo.Name = "FensterAusw_Combo";
            this.FensterAusw_Combo.Size = new System.Drawing.Size(173, 28);
            this.FensterAusw_Combo.TabIndex = 1;
            this.FensterAusw_Combo.SelectedIndexChanged += new System.EventHandler(this.FensterAusw_Combo_SelectedIndexChanged);
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
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationAnlegenToolStripMenuItem,
            this.personalverwaltungToolStripMenuItem,
            this.opertionenVerwaltenToolStripMenuItem});
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(53, 21);
            this.toolStripMenuItem1.Text = "Menü";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // operationAnlegenToolStripMenuItem
            // 
            this.operationAnlegenToolStripMenuItem.Name = "operationAnlegenToolStripMenuItem";
            this.operationAnlegenToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.operationAnlegenToolStripMenuItem.Text = "Operation anlegen";
            this.operationAnlegenToolStripMenuItem.Click += new System.EventHandler(this.operationAnlegenToolStripMenuItem_Click);
            // 
            // personalverwaltungToolStripMenuItem
            // 
            this.personalverwaltungToolStripMenuItem.Name = "personalverwaltungToolStripMenuItem";
            this.personalverwaltungToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.personalverwaltungToolStripMenuItem.Text = "Personalverwaltung";
            this.personalverwaltungToolStripMenuItem.Click += new System.EventHandler(this.personalverwaltungToolStripMenuItem_Click);
            // 
            // opertionenVerwaltenToolStripMenuItem
            // 
            this.opertionenVerwaltenToolStripMenuItem.Name = "opertionenVerwaltenToolStripMenuItem";
            this.opertionenVerwaltenToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.opertionenVerwaltenToolStripMenuItem.Text = "Opertionen verwalten";
            this.opertionenVerwaltenToolStripMenuItem.Click += new System.EventHandler(this.opertionenVerwaltenToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Location = new System.Drawing.Point(12, 82);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(600, 347);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // oP_KategorienTableAdapter
            // 
            this.oP_KategorienTableAdapter.ClearBeforeFill = true;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.FensterAusw_Combo);
            this.Controls.Add(this.button_Notfall);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "MainFrame";
            this.ShowIcon = false;
            this.Text = "OP-Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.oPKategorienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projekt1DataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Notfall;
        private System.Windows.Forms.ComboBox FensterAusw_Combo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem operationAnlegenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalverwaltungToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private Projekt1DataSet projekt1DataSet;
        private System.Windows.Forms.BindingSource oPKategorienBindingSource;
        private Projekt1DataSetTableAdapters.OP_KategorienTableAdapter oP_KategorienTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem opertionenVerwaltenToolStripMenuItem;
    }
}

