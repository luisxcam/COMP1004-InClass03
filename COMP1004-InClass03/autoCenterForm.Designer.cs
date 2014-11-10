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
            this.label1 = new System.Windows.Forms.Label();
            this.packageComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fraganceComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.carPictureBox = new System.Windows.Forms.PictureBox();
            this.interiorListBox = new System.Windows.Forms.ListBox();
            this.exteriorListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).BeginInit();
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
            this.packageComboBox.FormattingEnabled = true;
            this.packageComboBox.Location = new System.Drawing.Point(12, 56);
            this.packageComboBox.Name = "packageComboBox";
            this.packageComboBox.Size = new System.Drawing.Size(276, 21);
            this.packageComboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
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
            this.label5.Location = new System.Drawing.Point(12, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "&Fragance:";
            // 
            // fraganceComboBox
            // 
            this.fraganceComboBox.FormattingEnabled = true;
            this.fraganceComboBox.Location = new System.Drawing.Point(12, 106);
            this.fraganceComboBox.Name = "fraganceComboBox";
            this.fraganceComboBox.Size = new System.Drawing.Size(276, 21);
            this.fraganceComboBox.TabIndex = 8;
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
            // carPictureBox
            // 
            this.carPictureBox.Image = global::COMP1004_InClass03.Properties.Resources.lamborghini2;
            this.carPictureBox.Location = new System.Drawing.Point(15, 137);
            this.carPictureBox.Name = "carPictureBox";
            this.carPictureBox.Size = new System.Drawing.Size(273, 235);
            this.carPictureBox.TabIndex = 11;
            this.carPictureBox.TabStop = false;
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
            // autoCenterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 400);
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
            this.Text = "JJ Auto Center";
            ((System.ComponentModel.ISupportInitialize)(this.carPictureBox)).EndInit();
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
    }
}

