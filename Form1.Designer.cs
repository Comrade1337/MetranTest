namespace MetranTest
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.id_l = new System.Windows.Forms.Label();
            this.id_tb = new System.Windows.Forms.TextBox();
            this.choiceTest_l = new System.Windows.Forms.Label();
            this.choiceTest_cb = new System.Windows.Forms.ComboBox();
            this.choiceTest_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 99);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(424, 22);
            this.statusStrip.TabIndex = 0;
            this.statusStrip.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(95, 17);
            this.statusLabel.Text = "Ожидается ввод";
            // 
            // id_l
            // 
            this.id_l.AutoSize = true;
            this.id_l.Location = new System.Drawing.Point(13, 13);
            this.id_l.Name = "id_l";
            this.id_l.Size = new System.Drawing.Size(132, 13);
            this.id_l.TabIndex = 1;
            this.id_l.Text = "Идентификатор изделия";
            // 
            // id_tb
            // 
            this.id_tb.Location = new System.Drawing.Point(151, 13);
            this.id_tb.Name = "id_tb";
            this.id_tb.Size = new System.Drawing.Size(258, 20);
            this.id_tb.TabIndex = 2;
            // 
            // choiceTest_l
            // 
            this.choiceTest_l.AutoSize = true;
            this.choiceTest_l.Location = new System.Drawing.Point(74, 42);
            this.choiceTest_l.Name = "choiceTest_l";
            this.choiceTest_l.Size = new System.Drawing.Size(71, 13);
            this.choiceTest_l.TabIndex = 3;
            this.choiceTest_l.Text = "Выбор теста";
            // 
            // choiceTest_cb
            // 
            this.choiceTest_cb.FormattingEnabled = true;
            this.choiceTest_cb.Location = new System.Drawing.Point(151, 39);
            this.choiceTest_cb.Name = "choiceTest_cb";
            this.choiceTest_cb.Size = new System.Drawing.Size(177, 21);
            this.choiceTest_cb.TabIndex = 4;
            // 
            // choiceTest_btn
            // 
            this.choiceTest_btn.Location = new System.Drawing.Point(334, 39);
            this.choiceTest_btn.Name = "choiceTest_btn";
            this.choiceTest_btn.Size = new System.Drawing.Size(75, 23);
            this.choiceTest_btn.TabIndex = 5;
            this.choiceTest_btn.Text = "Запустить";
            this.choiceTest_btn.UseVisualStyleBackColor = true;
            this.choiceTest_btn.Click += new System.EventHandler(this.choiceTest_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Отмена";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 121);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.choiceTest_btn);
            this.Controls.Add(this.choiceTest_cb);
            this.Controls.Add(this.choiceTest_l);
            this.Controls.Add(this.id_tb);
            this.Controls.Add(this.id_l);
            this.Controls.Add(this.statusStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximumSize = new System.Drawing.Size(440, 160);
            this.MinimumSize = new System.Drawing.Size(440, 160);
            this.Name = "Form1";
            this.Text = "Тестовое задание";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Label id_l;
        private System.Windows.Forms.TextBox id_tb;
        private System.Windows.Forms.Label choiceTest_l;
        private System.Windows.Forms.ComboBox choiceTest_cb;
        private System.Windows.Forms.Button choiceTest_btn;
        private System.Windows.Forms.Button button1;
    }
}

