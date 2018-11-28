namespace LabFive
{
    partial class addDialog
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
            this._subjectTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._studentTb = new System.Windows.Forms.TextBox();
            this._markNumUD = new System.Windows.Forms.NumericUpDown();
            this._okBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this._markNumUD)).BeginInit();
            this.SuspendLayout();
            // 
            // _subjectTb
            // 
            this._subjectTb.Location = new System.Drawing.Point(12, 32);
            this._subjectTb.Name = "_subjectTb";
            this._subjectTb.Size = new System.Drawing.Size(393, 26);
            this._subjectTb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mark";
            // 
            // _studentTb
            // 
            this._studentTb.Location = new System.Drawing.Point(12, 84);
            this._studentTb.Name = "_studentTb";
            this._studentTb.Size = new System.Drawing.Size(393, 26);
            this._studentTb.TabIndex = 4;
            // 
            // _markNumUD
            // 
            this._markNumUD.Location = new System.Drawing.Point(12, 137);
            this._markNumUD.Name = "_markNumUD";
            this._markNumUD.Size = new System.Drawing.Size(120, 26);
            this._markNumUD.TabIndex = 5;
            // 
            // _okBt
            // 
            this._okBt.Location = new System.Drawing.Point(159, 183);
            this._okBt.Name = "_okBt";
            this._okBt.Size = new System.Drawing.Size(111, 47);
            this._okBt.TabIndex = 6;
            this._okBt.Text = "OK";
            this._okBt.UseVisualStyleBackColor = true;
            // 
            // addDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 242);
            this.Controls.Add(this._okBt);
            this.Controls.Add(this._markNumUD);
            this.Controls.Add(this._studentTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._subjectTb);
            this.Name = "addDialog";
            this.Text = "addDialog";
            ((System.ComponentModel.ISupportInitialize)(this._markNumUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _subjectTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _studentTb;
        private System.Windows.Forms.NumericUpDown _markNumUD;
        private System.Windows.Forms.Button _okBt;
    }
}