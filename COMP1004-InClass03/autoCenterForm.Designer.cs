namespace COMP1004_InClass03
{
    partial class autoCenterForm
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
            this.packageComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fraganceComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.interiorListBox = new System.Windows.Forms.ListBox();
            this.exteriorListBox = new System.Windows.Forms.ListBox();
            this.carPictureBox = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "JJ Auto Center";
            // 
            // packageComboBox
            // 
            this.packageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.packageComboBox.FormattingEnabled = true;
            this.packageComboBox.Items.AddRange(new object[] {
            "Standard",
            "Deluxe",
            "Executive",
            "Luxury"});
            this.packageComboBox.Location = new System.Drawing.Point(12, 56);
            this.packageComboBox.Name = "packageComboBox";
            this.packageComboBox.Size = new System.Drawing.Size(276, 21);
            this.packageComboBox.TabIndex = 1;
            this.packageComboBox.SelectedIndexChanged += new System.EventHandler(this.packageSelectedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "&Package:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Interior:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Exterior:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "&Fragance:";
            // 
            // fraganceComboBox
            // 
            this.fraganceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fraganceComboBox.FormattingEnabled = true;
            this.fraganceComboBox.Items.AddRange(new object[] {
            "Hawaiian Mist",
            "Baby Powder",
            "Pine",
            "Country Floral",
            "Pina Colada",
            "Vanilla"});
            this.fraganceComboBox.Location = new System.Drawing.Point(12, 350);
            this.fraganceComboBox.Name = "fraganceComboBox";
            this.fraganceComboBox.Size = new System.Drawing.Size(276, 21);
            this.fraganceComboBox.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(467, 376);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Luis Acevedo";
            // 
            // interiorListBox
            // 
            this.interiorListBox.FormattingEnabled = true;
            this.interiorListBox.Location = new System.Drawing.Point(301, 56);
            this.interiorListBox.Name = "interiorListBox";
            this.interiorListBox.Size = new System.Drawing.Size(238, 147);
            this.interiorListBox.TabIndex = 12;
            this.interiorListBox.TabStop = false;
            this.interiorListBox.UseTabStops = false;
            // 
            // exteriorListBox
            // 
            this.exteriorListBox.FormattingEnabled = true;
            this.exteriorListBox.Location = new System.Drawing.Point(301, 224);
            this.exteriorListBox.Name = "exteriorListBox";
            this.exteriorListBox.Size = new System.Drawing.Size(238, 147);
            this.exteriorListBox.TabIndex = 13;
            this.exteriorListBox.TabStop = false;
            this.exteriorListBox.UseTabStops = false;
            // 
            // carPictureBox
            // 
            this.carPictureBox.Image = global::COMP1004_InClass03.Properties.Resources.lamborghini2;
            this.carPictureBox.Location = new System.Drawing.Point(15, 184);
            this.carPictureBox.Name = "carPictureBox";
            this.carPictureBox.Size = new System.Drawing.Size(273, 147);
            this.carPictureBox.TabIndex = 11;
            this.carPictureBox.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 70);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "A&bout";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearToolStripMenuItem.Text = "C&lear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // autoCenterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 400);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.exteriorListBox);
            this.Controls.Add(this.interiorListBox);
            this.Controls.Add(this.carPictureBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.fraganceComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.packageComboBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "autoCenterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JJ Auto Center";
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox packageComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox fraganceComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox carPictureBox;
        private System.Windows.Forms.ListBox interiorListBox;
        private System.Windows.Forms.ListBox exteriorListBox;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}

