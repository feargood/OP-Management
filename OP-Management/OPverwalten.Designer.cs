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
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // button__Bearb
            // 
            this.button__Bearb.Location = new System.Drawing.Point(25, 400);
            this.button__Bearb.Name = "button__Bearb";
            this.button__Bearb.Size = new System.Drawing.Size(103, 37);
            this.button__Bearb.TabIndex = 1;
            this.button__Bearb.Text = "Bearbeiten";
            this.button__Bearb.UseVisualStyleBackColor = true;
            this.button__Bearb.Click += new System.EventHandler(this.button__Bearb_Click);
            // 
            // button_Loesch
            // 
            this.button_Loesch.Location = new System.Drawing.Point(161, 400);
            this.button_Loesch.Name = "button_Loesch";
            this.button_Loesch.Size = new System.Drawing.Size(103, 37);
            this.button_Loesch.TabIndex = 2;
            this.button_Loesch.Text = "Löschen";
            this.button_Loesch.UseVisualStyleBackColor = true;
            this.button_Loesch.Click += new System.EventHandler(this.button_Loesch_Click);
            // 
            // button_schliess
            // 
            this.button_schliess.Location = new System.Drawing.Point(628, 400);
            this.button_schliess.Name = "button_schliess";
            this.button_schliess.Size = new System.Drawing.Size(103, 37);
            this.button_schliess.TabIndex = 3;
            this.button_schliess.Text = "Schließen";
            this.button_schliess.UseVisualStyleBackColor = true;
            this.button_schliess.Click += new System.EventHandler(this.button_schliess_Click);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(25, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(706, 355);
            this.listBox.TabIndex = 4;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // OPverwalten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 461);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.button_schliess);
            this.Controls.Add(this.button_Loesch);
            this.Controls.Add(this.button__Bearb);
            this.Name = "OPverwalten";
            this.Text = "OPverwalten";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button__Bearb;
        private System.Windows.Forms.Button button_Loesch;
        private System.Windows.Forms.Button button_schliess;
        private System.Windows.Forms.ListBox listBox;
    }
}