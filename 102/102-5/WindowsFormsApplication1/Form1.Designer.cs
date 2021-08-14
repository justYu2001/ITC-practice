namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.textBoxM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAnswer = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelWrong = new System.Windows.Forms.Label();
            this.labelRight = new System.Windows.Forms.Label();
            this.lblProcess1 = new System.Windows.Forms.Label();
            this.lblProcess3 = new System.Windows.Forms.Label();
            this.lblProcess2 = new System.Windows.Forms.Label();
            this.lblProcess4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F);
            this.label1.Location = new System.Drawing.Point(146, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "被乘數n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F);
            this.label2.Location = new System.Drawing.Point(370, 148);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "乘數n";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(148, 200);
            this.textBoxN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(148, 29);
            this.textBoxN.TabIndex = 2;
            this.textBoxN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxM
            // 
            this.textBoxM.Location = new System.Drawing.Point(374, 200);
            this.textBoxM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxM.Name = "textBoxM";
            this.textBoxM.Size = new System.Drawing.Size(148, 29);
            this.textBoxM.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F);
            this.label3.Location = new System.Drawing.Point(315, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 12F);
            this.label4.Location = new System.Drawing.Point(546, 204);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "=";
            // 
            // textBoxAnswer
            // 
            this.textBoxAnswer.Location = new System.Drawing.Point(579, 204);
            this.textBoxAnswer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAnswer.Name = "textBoxAnswer";
            this.textBoxAnswer.Size = new System.Drawing.Size(148, 29);
            this.textBoxAnswer.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("新細明體", 12F);
            this.button1.Location = new System.Drawing.Point(150, 308);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 57);
            this.button1.TabIndex = 7;
            this.button1.Text = "檢驗答案";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("新細明體", 12F);
            this.button2.Location = new System.Drawing.Point(374, 308);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 57);
            this.button2.TabIndex = 8;
            this.button2.Text = "清除";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labelWrong
            // 
            this.labelWrong.AutoSize = true;
            this.labelWrong.Font = new System.Drawing.Font("新細明體", 12F);
            this.labelWrong.Location = new System.Drawing.Point(759, 213);
            this.labelWrong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWrong.Name = "labelWrong";
            this.labelWrong.Size = new System.Drawing.Size(0, 24);
            this.labelWrong.TabIndex = 9;
            // 
            // labelRight
            // 
            this.labelRight.AutoSize = true;
            this.labelRight.Font = new System.Drawing.Font("新細明體", 12F);
            this.labelRight.Location = new System.Drawing.Point(621, 280);
            this.labelRight.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRight.Name = "labelRight";
            this.labelRight.Size = new System.Drawing.Size(0, 24);
            this.labelRight.TabIndex = 10;
            // 
            // lblProcess1
            // 
            this.lblProcess1.AutoSize = true;
            this.lblProcess1.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblProcess1.Location = new System.Drawing.Point(621, 324);
            this.lblProcess1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProcess1.Name = "lblProcess1";
            this.lblProcess1.Size = new System.Drawing.Size(0, 24);
            this.lblProcess1.TabIndex = 11;
            this.lblProcess1.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblProcess3
            // 
            this.lblProcess3.AutoSize = true;
            this.lblProcess3.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblProcess3.Location = new System.Drawing.Point(621, 404);
            this.lblProcess3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProcess3.Name = "lblProcess3";
            this.lblProcess3.Size = new System.Drawing.Size(0, 24);
            this.lblProcess3.TabIndex = 13;
            // 
            // lblProcess2
            // 
            this.lblProcess2.AutoSize = true;
            this.lblProcess2.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblProcess2.Location = new System.Drawing.Point(621, 362);
            this.lblProcess2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProcess2.Name = "lblProcess2";
            this.lblProcess2.Size = new System.Drawing.Size(0, 24);
            this.lblProcess2.TabIndex = 12;
            // 
            // lblProcess4
            // 
            this.lblProcess4.AutoSize = true;
            this.lblProcess4.Font = new System.Drawing.Font("新細明體", 12F);
            this.lblProcess4.Location = new System.Drawing.Point(621, 445);
            this.lblProcess4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProcess4.Name = "lblProcess4";
            this.lblProcess4.Size = new System.Drawing.Size(0, 24);
            this.lblProcess4.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 778);
            this.Controls.Add(this.lblProcess4);
            this.Controls.Add(this.lblProcess3);
            this.Controls.Add(this.lblProcess2);
            this.Controls.Add(this.lblProcess1);
            this.Controls.Add(this.labelRight);
            this.Controls.Add(this.labelWrong);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxAnswer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxM);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "印度心算";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.TextBox textBoxM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAnswer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelWrong;
        private System.Windows.Forms.Label labelRight;
        private System.Windows.Forms.Label lblProcess1;
        private System.Windows.Forms.Label lblProcess3;
        private System.Windows.Forms.Label lblProcess2;
        private System.Windows.Forms.Label lblProcess4;
    }
}

