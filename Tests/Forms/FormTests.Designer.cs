namespace Tests
{
    partial class FormTests
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTests));
            this.buttonAnswer = new System.Windows.Forms.Button();
            this.panelQuestion = new System.Windows.Forms.Panel();
            this.timerLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.labelQuestion = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timerQuest = new System.Windows.Forms.Timer(this.components);
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.identPanel = new System.Windows.Forms.Panel();
            this.panelQuestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowPanel.SuspendLayout();
            this.identPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAnswer
            // 
            this.buttonAnswer.BackColor = System.Drawing.Color.Lime;
            this.buttonAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAnswer.Location = new System.Drawing.Point(463, 616);
            this.buttonAnswer.Name = "buttonAnswer";
            this.buttonAnswer.Size = new System.Drawing.Size(187, 26);
            this.buttonAnswer.TabIndex = 4;
            this.buttonAnswer.Text = "Ответить";
            this.buttonAnswer.UseVisualStyleBackColor = false;
            this.buttonAnswer.Click += new System.EventHandler(this.buttonAnswer_Click);
            // 
            // panelQuestion
            // 
            this.panelQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelQuestion.Controls.Add(this.timerLabel);
            this.panelQuestion.Controls.Add(this.pictureBox1);
            this.panelQuestion.Controls.Add(this.labelCount);
            this.panelQuestion.Controls.Add(this.flowPanel);
            this.panelQuestion.Controls.Add(this.labelQuestion);
            this.panelQuestion.Controls.Add(this.buttonAnswer);
            this.panelQuestion.Location = new System.Drawing.Point(12, 12);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Size = new System.Drawing.Size(653, 642);
            this.panelQuestion.TabIndex = 5;
            this.panelQuestion.Visible = false;
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Location = new System.Drawing.Point(348, 623);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(109, 13);
            this.timerLabel.TabIndex = 12;
            this.timerLabel.Text = "Осталось 59 секунд";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(653, 238);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelCount.Location = new System.Drawing.Point(57, 623);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(110, 13);
            this.labelCount.TabIndex = 8;
            this.labelCount.Text = "Осталось вопросов:";
            // 
            // flowPanel
            // 
            this.flowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowPanel.Controls.Add(this.radioButton2);
            this.flowPanel.Location = new System.Drawing.Point(0, 313);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(653, 297);
            this.flowPanel.TabIndex = 7;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.flowPanel.SetFlowBreak(this.radioButton2, true);
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(20, 20);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(20, 20, 20, 0);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(119, 21);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // labelQuestion
            // 
            this.labelQuestion.AutoSize = true;
            this.labelQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQuestion.Location = new System.Drawing.Point(3, 241);
            this.labelQuestion.MaximumSize = new System.Drawing.Size(650, 0);
            this.labelQuestion.Name = "labelQuestion";
            this.labelQuestion.Size = new System.Drawing.Size(122, 20);
            this.labelQuestion.TabIndex = 6;
            this.labelQuestion.Text = "Текст вопроса:";
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.Lime;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStart.Location = new System.Drawing.Point(45, 113);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(218, 29);
            this.buttonStart.TabIndex = 5;
            this.buttonStart.Text = "Начать тест";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // timerQuest
            // 
            this.timerQuest.Interval = 1000;
            this.timerQuest.Tick += new System.EventHandler(this.timerQuest_Tick);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(77, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(152, 16);
            this.nameLabel.TabIndex = 6;
            this.nameLabel.Text = "Введите Ваше имя: ";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(80, 63);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(149, 20);
            this.nameBox.TabIndex = 7;
            // 
            // identPanel
            // 
            this.identPanel.Controls.Add(this.nameBox);
            this.identPanel.Controls.Add(this.buttonStart);
            this.identPanel.Controls.Add(this.nameLabel);
            this.identPanel.Location = new System.Drawing.Point(196, 231);
            this.identPanel.Name = "identPanel";
            this.identPanel.Size = new System.Drawing.Size(304, 163);
            this.identPanel.TabIndex = 8;
            // 
            // FormTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 659);
            this.Controls.Add(this.panelQuestion);
            this.Controls.Add(this.identPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormTests";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестирование";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTests_FormClosed);
            this.panelQuestion.ResumeLayout(false);
            this.panelQuestion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowPanel.ResumeLayout(false);
            this.flowPanel.PerformLayout();
            this.identPanel.ResumeLayout(false);
            this.identPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAnswer;
        private System.Windows.Forms.Panel panelQuestion;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
        private System.Windows.Forms.Label labelQuestion;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerQuest;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Panel identPanel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label nameLabel;
    }
}

