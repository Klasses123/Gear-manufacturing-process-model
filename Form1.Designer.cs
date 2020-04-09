namespace Gear
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SecProcLabel = new System.Windows.Forms.Label();
            this.SecHardLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProcessedLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RoundProcessingTimeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "ускорить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(160, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "замедлить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Location = new System.Drawing.Point(108, 384);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(71, 13);
            this.SpeedLabel.TabIndex = 2;
            this.SpeedLabel.Text = "скорость: х1";
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(602, 385);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(114, 38);
            this.startBtn.TabIndex = 3;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Location = new System.Drawing.Point(108, 31);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(46, 13);
            this.TimeLabel.TabIndex = 4;
            this.TimeLabel.Text = "0 минут";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Время:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "На повторную обработку направлено:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "На повторную закалку направлено:";
            // 
            // SecProcLabel
            // 
            this.SecProcLabel.AutoSize = true;
            this.SecProcLabel.Location = new System.Drawing.Point(241, 85);
            this.SecProcLabel.Name = "SecProcLabel";
            this.SecProcLabel.Size = new System.Drawing.Size(13, 13);
            this.SecProcLabel.TabIndex = 8;
            this.SecProcLabel.Text = "0";
            // 
            // SecHardLabel
            // 
            this.SecHardLabel.AutoSize = true;
            this.SecHardLabel.Location = new System.Drawing.Point(241, 117);
            this.SecHardLabel.Name = "SecHardLabel";
            this.SecHardLabel.Size = new System.Drawing.Size(13, 13);
            this.SecHardLabel.TabIndex = 9;
            this.SecHardLabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Обработано деталей:";
            // 
            // ProcessedLabel
            // 
            this.ProcessedLabel.AutoSize = true;
            this.ProcessedLabel.Location = new System.Drawing.Point(241, 146);
            this.ProcessedLabel.Name = "ProcessedLabel";
            this.ProcessedLabel.Size = new System.Drawing.Size(13, 13);
            this.ProcessedLabel.TabIndex = 11;
            this.ProcessedLabel.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Среднее время обработки:";
            // 
            // RoundProcessingTimeLabel
            // 
            this.RoundProcessingTimeLabel.AutoSize = true;
            this.RoundProcessingTimeLabel.Location = new System.Drawing.Point(596, 85);
            this.RoundProcessingTimeLabel.Name = "RoundProcessingTimeLabel";
            this.RoundProcessingTimeLabel.Size = new System.Drawing.Size(36, 13);
            this.RoundProcessingTimeLabel.TabIndex = 13;
            this.RoundProcessingTimeLabel.Text = "0 мин";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RoundProcessingTimeLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProcessedLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SecHardLabel);
            this.Controls.Add(this.SecProcLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeLabel);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.SpeedLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Gear";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label SecProcLabel;
        private System.Windows.Forms.Label SecHardLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ProcessedLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label RoundProcessingTimeLabel;
    }
}

