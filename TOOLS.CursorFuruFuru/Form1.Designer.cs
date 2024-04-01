namespace TOOLS.CursorFuruFuru
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.intervalInputBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.intervalUpdateButton = new System.Windows.Forms.Button();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "スタート";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(440, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "ストップ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(253, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 40);
            this.label1.TabIndex = 2;
            this.label1.Text = "カーソル移動くん";
            // 
            // intervalInputBox
            // 
            this.intervalInputBox.Location = new System.Drawing.Point(198, 272);
            this.intervalInputBox.Name = "intervalInputBox";
            this.intervalInputBox.Size = new System.Drawing.Size(100, 19);
            this.intervalInputBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "秒に設定します。";
            // 
            // intervalUpdateButton
            // 
            this.intervalUpdateButton.Location = new System.Drawing.Point(440, 258);
            this.intervalUpdateButton.Name = "intervalUpdateButton";
            this.intervalUpdateButton.Size = new System.Drawing.Size(83, 33);
            this.intervalUpdateButton.TabIndex = 6;
            this.intervalUpdateButton.Text = "セット";
            this.intervalUpdateButton.UseVisualStyleBackColor = true;
            this.intervalUpdateButton.Click += new System.EventHandler(this.intervalUpdateButton_Click);
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.intervalLabel.Location = new System.Drawing.Point(287, 349);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(51, 16);
            this.intervalLabel.TabIndex = 7;
            this.intervalLabel.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(344, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "秒に設定されています。";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.intervalLabel);
            this.Controls.Add(this.intervalUpdateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.intervalInputBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox intervalInputBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button intervalUpdateButton;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.Label label4;
    }
}

