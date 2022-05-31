namespace NameGenerator
{
    partial class NameGen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFirst = new System.Windows.Forms.Label();
            this.FirstBox = new System.Windows.Forms.TextBox();
            this.lblSur = new System.Windows.Forms.Label();
            this.SurBox = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.chkMale = new System.Windows.Forms.CheckBox();
            this.chkFemale = new System.Windows.Forms.CheckBox();
            this.btnToClip = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFirst.Location = new System.Drawing.Point(135, 40);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(160, 38);
            this.lblFirst.TabIndex = 0;
            this.lblFirst.Text = "First name: ";
            // 
            // FirstBox
            // 
            this.FirstBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstBox.Location = new System.Drawing.Point(45, 85);
            this.FirstBox.Name = "FirstBox";
            this.FirstBox.ReadOnly = true;
            this.FirstBox.Size = new System.Drawing.Size(335, 45);
            this.FirstBox.TabIndex = 2;
            // 
            // lblSur
            // 
            this.lblSur.AutoSize = true;
            this.lblSur.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSur.Location = new System.Drawing.Point(145, 140);
            this.lblSur.Name = "lblSur";
            this.lblSur.Size = new System.Drawing.Size(133, 38);
            this.lblSur.TabIndex = 2;
            this.lblSur.Text = "Surname:";
            // 
            // SurBox
            // 
            this.SurBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SurBox.Location = new System.Drawing.Point(45, 180);
            this.SurBox.Name = "SurBox";
            this.SurBox.ReadOnly = true;
            this.SurBox.Size = new System.Drawing.Size(335, 45);
            this.SurBox.TabIndex = 3;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerate.Location = new System.Drawing.Point(95, 265);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(227, 49);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // chkMale
            // 
            this.chkMale.AutoSize = true;
            this.chkMale.Location = new System.Drawing.Point(15, 410);
            this.chkMale.Name = "chkMale";
            this.chkMale.Size = new System.Drawing.Size(136, 29);
            this.chkMale.TabIndex = 4;
            this.chkMale.Text = "Male Names";
            this.chkMale.UseVisualStyleBackColor = true;
            this.chkMale.CheckedChanged += new System.EventHandler(this.chkMale_CheckedChanged);
            // 
            // chkFemale
            // 
            this.chkFemale.AutoSize = true;
            this.chkFemale.Location = new System.Drawing.Point(160, 410);
            this.chkFemale.Name = "chkFemale";
            this.chkFemale.Size = new System.Drawing.Size(154, 29);
            this.chkFemale.TabIndex = 5;
            this.chkFemale.Text = "Female Names";
            this.chkFemale.UseVisualStyleBackColor = true;
            this.chkFemale.CheckedChanged += new System.EventHandler(this.chkFemale_CheckedChanged);
            // 
            // btnToClip
            // 
            this.btnToClip.Location = new System.Drawing.Point(125, 330);
            this.btnToClip.Name = "btnToClip";
            this.btnToClip.Size = new System.Drawing.Size(175, 35);
            this.btnToClip.TabIndex = 6;
            this.btnToClip.Text = "Copy to clipboard";
            this.btnToClip.UseVisualStyleBackColor = true;
            this.btnToClip.Click += new System.EventHandler(this.btnToClip_Click);
            // 
            // NameGen
            // 
            this.ClientSize = new System.Drawing.Size(427, 448);
            this.Controls.Add(this.btnToClip);
            this.Controls.Add(this.chkFemale);
            this.Controls.Add(this.chkMale);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.SurBox);
            this.Controls.Add(this.lblSur);
            this.Controls.Add(this.FirstBox);
            this.Controls.Add(this.lblFirst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NameGen";
            this.Text = "Name Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.TextBox FirstBox;
        private System.Windows.Forms.Label lblSur;
        private System.Windows.Forms.TextBox SurBox;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.CheckBox chkMale;
        private System.Windows.Forms.CheckBox chkFemale;
        private System.Windows.Forms.Button btnToClip;
    }
}
