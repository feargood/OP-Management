namespace OP_Management
{
    partial class OPverwalten
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
            this.button__Bearb = new System.Windows.Forms.Button();
            this.button_Loesch = new System.Windows.Forms.Button();
            this.button_schliess = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operationAnlegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalverwaltungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Raum_1 = new System.Windows.Forms.ListView();
            this.Raum_2 = new System.Windows.Forms.ListView();
            this.Raum_3 = new System.Windows.Forms.ListView();
            this.Raum_4 = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button__Bearb
            // 
            this.button__Bearb.Location = new System.Drawing.Point(25, 670);
            this.button__Bearb.Name = "button__Bearb";
            this.button__Bearb.Size = new System.Drawing.Size(103, 37);
            this.button__Bearb.TabIndex = 1;
            this.button__Bearb.Text = "Bearbeiten";
            this.button__Bearb.UseVisualStyleBackColor = true;
            this.button__Bearb.Click += new System.EventHandler(this.button__Bearb_Click);
            // 
            // button_Loesch
            // 
            this.button_Loesch.Location = new System.Drawing.Point(134, 670);
            this.button_Loesch.Name = "button_Loesch";
            this.button_Loesch.Size = new System.Drawing.Size(103, 37);
            this.button_Loesch.TabIndex = 2;
            this.button_Loesch.Text = "Löschen";
            this.button_Loesch.UseVisualStyleBackColor = true;
            this.button_Loesch.Click += new System.EventHandler(this.button_Loesch_Click);
            // 
            // button_schliess
            // 
            this.button_schliess.Location = new System.Drawing.Point(628, 670);
            this.button_schliess.Name = "button_schliess";
            this.button_schliess.Size = new System.Drawing.Size(103, 37);
            this.button_schliess.TabIndex = 3;
            this.button_schliess.Text = "Schließen";
            this.button_schliess.UseVisualStyleBackColor = true;
            this.button_schliess.Click += new System.EventHandler(this.button_schliess_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 48);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 27;
            this.label7.Text = "Datum";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "DD.MM.YYYY";
            this.dateTimePicker1.Location = new System.Drawing.Point(77, 48);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 20);
            this.dateTimePicker1.TabIndex = 29;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(755, 24);
            this.menuStrip1.TabIndex = 33;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operationAnlegenToolStripMenuItem,
            this.personalverwaltungToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // operationAnlegenToolStripMenuItem
            // 
            this.operationAnlegenToolStripMenuItem.Name = "operationAnlegenToolStripMenuItem";
            this.operationAnlegenToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.operationAnlegenToolStripMenuItem.Text = "Operation anlegen";
            this.operationAnlegenToolStripMenuItem.Click += new System.EventHandler(this.operationAnlegenToolStripMenuItem_Click_1);
            // 
            // personalverwaltungToolStripMenuItem
            // 
            this.personalverwaltungToolStripMenuItem.Name = "personalverwaltungToolStripMenuItem";
            this.personalverwaltungToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.personalverwaltungToolStripMenuItem.Text = "Personalverwaltung";
            this.personalverwaltungToolStripMenuItem.Click += new System.EventHandler(this.personalverwaltungToolStripMenuItem_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 34;
            this.label1.Text = "Raum 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 216);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Raum 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 361);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Raum 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 504);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Raum 4";
            // 
            // Raum_1
            // 
            this.Raum_1.Location = new System.Drawing.Point(25, 95);
            this.Raum_1.Name = "Raum_1";
            this.Raum_1.Size = new System.Drawing.Size(706, 118);
            this.Raum_1.TabIndex = 41;
            this.Raum_1.UseCompatibleStateImageBehavior = false;
            // 
            // Raum_2
            // 
            this.Raum_2.Location = new System.Drawing.Point(25, 235);
            this.Raum_2.Name = "Raum_2";
            this.Raum_2.Size = new System.Drawing.Size(706, 118);
            this.Raum_2.TabIndex = 42;
            this.Raum_2.UseCompatibleStateImageBehavior = false;
            // 
            // Raum_3
            // 
            this.Raum_3.Location = new System.Drawing.Point(25, 380);
            this.Raum_3.Name = "Raum_3";
            this.Raum_3.Size = new System.Drawing.Size(706, 118);
            this.Raum_3.TabIndex = 43;
            this.Raum_3.UseCompatibleStateImageBehavior = false;
            // 
            // Raum_4
            // 
            this.Raum_4.Location = new System.Drawing.Point(25, 523);
            this.Raum_4.Name = "Raum_4";
            this.Raum_4.Size = new System.Drawing.Size(706, 118);
            this.Raum_4.TabIndex = 44;
            this.Raum_4.UseCompatibleStateImageBehavior = false;
            // 
            // OPverwalten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 719);
            this.Controls.Add(this.Raum_4);
            this.Controls.Add(this.Raum_3);
            this.Controls.Add(this.Raum_2);
            this.Controls.Add(this.Raum_1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_schliess);
            this.Controls.Add(this.button_Loesch);
            this.Controls.Add(this.button__Bearb);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OPverwalten";
            this.Text = "OPverwalten";
            this.Load += new System.EventHandler(this.OPverwalten_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button__Bearb;
        private System.Windows.Forms.Button button_Loesch;
        private System.Windows.Forms.Button button_schliess;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem operationAnlegenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalverwaltungToolStripMenuItem;
        private System.Windows.Forms.ListView Raum_1;
        private System.Windows.Forms.ListView Raum_2;
        private System.Windows.Forms.ListView Raum_3;
        private System.Windows.Forms.ListView Raum_4;
    }
}