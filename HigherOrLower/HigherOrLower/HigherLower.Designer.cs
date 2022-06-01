namespace HigherOrLower
{
    partial class HigherLower
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
            this.MainCountlbl = new System.Windows.Forms.Label();
            this.btnHigher = new System.Windows.Forms.Button();
            this.btnLower = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.stsText = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MainCountlbl
            // 
            this.MainCountlbl.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainCountlbl.Location = new System.Drawing.Point(20, 35);
            this.MainCountlbl.Name = "MainCountlbl";
            this.MainCountlbl.Size = new System.Drawing.Size(500, 260);
            this.MainCountlbl.TabIndex = 0;
            this.MainCountlbl.Text = "100";
            this.MainCountlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHigher
            // 
            this.btnHigher.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHigher.Location = new System.Drawing.Point(25, 485);
            this.btnHigher.Name = "btnHigher";
            this.btnHigher.Size = new System.Drawing.Size(225, 80);
            this.btnHigher.TabIndex = 1;
            this.btnHigher.Text = "Higher";
            this.btnHigher.UseVisualStyleBackColor = true;
            this.btnHigher.Click += new System.EventHandler(this.btnHigher_Click);
            // 
            // btnLower
            // 
            this.btnLower.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLower.Location = new System.Drawing.Point(285, 485);
            this.btnLower.Name = "btnLower";
            this.btnLower.Size = new System.Drawing.Size(225, 80);
            this.btnLower.TabIndex = 2;
            this.btnLower.Text = "Lower";
            this.btnLower.UseVisualStyleBackColor = true;
            this.btnLower.Click += new System.EventHandler(this.btnLower_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReset.Location = new System.Drawing.Point(190, 590);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(160, 50);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // stsText
            // 
            this.stsText.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stsText.Location = new System.Drawing.Point(95, 310);
            this.stsText.Name = "stsText";
            this.stsText.Size = new System.Drawing.Size(335, 50);
            this.stsText.TabIndex = 4;
            this.stsText.Text = "This should be hidden";
            this.stsText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblScore.Location = new System.Drawing.Point(150, 425);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(125, 50);
            this.lblScore.TabIndex = 5;
            this.lblScore.Text = "Score:";
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtScore.Location = new System.Drawing.Point(265, 425);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(125, 50);
            this.txtScore.TabIndex = 6;
            this.txtScore.Text = "0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HigherLower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 665);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.stsText);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLower);
            this.Controls.Add(this.btnHigher);
            this.Controls.Add(this.MainCountlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "HigherLower";
            this.Text = "Higher or lower";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MainCountlbl;
        private System.Windows.Forms.Button btnHigher;
        private System.Windows.Forms.Button btnLower;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label stsText;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label txtScore;
    }
}
