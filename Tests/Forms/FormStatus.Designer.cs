namespace Tests.Forms
{
    partial class FormStatus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStatus));
            this.statTab = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.statTab)).BeginInit();
            this.SuspendLayout();
            // 
            // statTab
            // 
            this.statTab.AllowUserToAddRows = false;
            this.statTab.AllowUserToDeleteRows = false;
            this.statTab.AllowUserToResizeColumns = false;
            this.statTab.AllowUserToResizeRows = false;
            this.statTab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statTab.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.result,
            this.time});
            this.statTab.Location = new System.Drawing.Point(-2, -1);
            this.statTab.Name = "statTab";
            this.statTab.ReadOnly = true;
            this.statTab.Size = new System.Drawing.Size(349, 267);
            this.statTab.TabIndex = 0;
            // 
            // name
            // 
            this.name.HeaderText = "Имя";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // result
            // 
            this.result.HeaderText = "Результат";
            this.result.Name = "result";
            this.result.ReadOnly = true;
            // 
            // time
            // 
            this.time.HeaderText = "Время";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.Red;
            this.buttonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonClear.Location = new System.Drawing.Point(-2, 263);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(349, 32);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Очистить статистику";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // FormStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 299);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.statTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика";
            ((System.ComponentModel.ISupportInitialize)(this.statTab)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView statTab;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn result;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.Button buttonClear;



    }
}