namespace LabFive
{
    partial class MainForm
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
            this.mainTable = new System.Windows.Forms.DataGridView();
            this._sortByNameBt = new System.Windows.Forms.Button();
            this._sortBySubjectBt = new System.Windows.Forms.Button();
            this._filterCb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._addBt = new System.Windows.Forms.Button();
            this._deleteBt = new System.Windows.Forms.Button();
            this._saveBt = new System.Windows.Forms.Button();
            this._loadBt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTable
            // 
            this.mainTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mainTable.Location = new System.Drawing.Point(12, 12);
            this.mainTable.Name = "mainTable";
            this.mainTable.RowTemplate.Height = 28;
            this.mainTable.Size = new System.Drawing.Size(1000, 506);
            this.mainTable.TabIndex = 0;
            // 
            // _sortByNameBt
            // 
            this._sortByNameBt.Location = new System.Drawing.Point(1018, 68);
            this._sortByNameBt.Name = "_sortByNameBt";
            this._sortByNameBt.Size = new System.Drawing.Size(150, 50);
            this._sortByNameBt.TabIndex = 1;
            this._sortByNameBt.Text = "Sort by name";
            this._sortByNameBt.UseVisualStyleBackColor = true;
            // 
            // _sortBySubjectBt
            // 
            this._sortBySubjectBt.Location = new System.Drawing.Point(1018, 12);
            this._sortBySubjectBt.Name = "_sortBySubjectBt";
            this._sortBySubjectBt.Size = new System.Drawing.Size(150, 50);
            this._sortBySubjectBt.TabIndex = 2;
            this._sortBySubjectBt.Text = "Sort by subject";
            this._sortBySubjectBt.UseVisualStyleBackColor = true;
            // 
            // _filterCb
            // 
            this._filterCb.FormattingEnabled = true;
            this._filterCb.Location = new System.Drawing.Point(1018, 144);
            this._filterCb.Name = "_filterCb";
            this._filterCb.Size = new System.Drawing.Size(150, 28);
            this._filterCb.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1018, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter by student";
            // 
            // _addBt
            // 
            this._addBt.Location = new System.Drawing.Point(1018, 300);
            this._addBt.Name = "_addBt";
            this._addBt.Size = new System.Drawing.Size(150, 50);
            this._addBt.TabIndex = 5;
            this._addBt.Text = "Add new";
            this._addBt.UseVisualStyleBackColor = true;
            // 
            // _deleteBt
            // 
            this._deleteBt.Location = new System.Drawing.Point(1018, 356);
            this._deleteBt.Name = "_deleteBt";
            this._deleteBt.Size = new System.Drawing.Size(150, 50);
            this._deleteBt.TabIndex = 7;
            this._deleteBt.Text = "Delete";
            this._deleteBt.UseVisualStyleBackColor = true;
            // 
            // _saveBt
            // 
            this._saveBt.Location = new System.Drawing.Point(1018, 468);
            this._saveBt.Name = "_saveBt";
            this._saveBt.Size = new System.Drawing.Size(150, 50);
            this._saveBt.TabIndex = 8;
            this._saveBt.Text = "Save";
            this._saveBt.UseVisualStyleBackColor = true;
            // 
            // _loadBt
            // 
            this._loadBt.Location = new System.Drawing.Point(1018, 412);
            this._loadBt.Name = "_loadBt";
            this._loadBt.Size = new System.Drawing.Size(150, 50);
            this._loadBt.TabIndex = 9;
            this._loadBt.Text = "Load";
            this._loadBt.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 530);
            this.Controls.Add(this._loadBt);
            this.Controls.Add(this._saveBt);
            this.Controls.Add(this._deleteBt);
            this.Controls.Add(this._addBt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._filterCb);
            this.Controls.Add(this._sortBySubjectBt);
            this.Controls.Add(this._sortByNameBt);
            this.Controls.Add(this.mainTable);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.mainTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView mainTable;
        private System.Windows.Forms.Button _sortByNameBt;
        private System.Windows.Forms.Button _sortBySubjectBt;
        private System.Windows.Forms.ComboBox _filterCb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button _addBt;
        private System.Windows.Forms.Button _deleteBt;
        private System.Windows.Forms.Button _saveBt;
        private System.Windows.Forms.Button _loadBt;
    }
}

