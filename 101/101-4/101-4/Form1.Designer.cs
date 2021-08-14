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
            this.txtCoordinate3 = new System.Windows.Forms.TextBox();
            this.txtCoordinate2 = new System.Windows.Forms.TextBox();
            this.txtCoordinate4 = new System.Windows.Forms.TextBox();
            this.txtCoordinate1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtresult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIntersectionCoordinate = new System.Windows.Forms.TextBox();
            this.btndraw = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.pic1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 18F);
            this.label1.Location = new System.Drawing.Point(514, 754);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "第1條線座標:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 18F);
            this.label2.Location = new System.Drawing.Point(514, 812);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "第2條線座標:";
            // 
            // txtCoordinate3
            // 
            this.txtCoordinate3.Font = new System.Drawing.Font("新細明體", 18F);
            this.txtCoordinate3.Location = new System.Drawing.Point(743, 812);
            this.txtCoordinate3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCoordinate3.Name = "txtCoordinate3";
            this.txtCoordinate3.Size = new System.Drawing.Size(148, 51);
            this.txtCoordinate3.TabIndex = 1;
            // 
            // txtCoordinate2
            // 
            this.txtCoordinate2.Font = new System.Drawing.Font("新細明體", 18F);
            this.txtCoordinate2.Location = new System.Drawing.Point(899, 751);
            this.txtCoordinate2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCoordinate2.Name = "txtCoordinate2";
            this.txtCoordinate2.Size = new System.Drawing.Size(148, 51);
            this.txtCoordinate2.TabIndex = 1;
            // 
            // txtCoordinate4
            // 
            this.txtCoordinate4.Font = new System.Drawing.Font("新細明體", 18F);
            this.txtCoordinate4.Location = new System.Drawing.Point(899, 812);
            this.txtCoordinate4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCoordinate4.Name = "txtCoordinate4";
            this.txtCoordinate4.Size = new System.Drawing.Size(148, 51);
            this.txtCoordinate4.TabIndex = 1;
            // 
            // txtCoordinate1
            // 
            this.txtCoordinate1.Font = new System.Drawing.Font("新細明體", 18F);
            this.txtCoordinate1.Location = new System.Drawing.Point(743, 751);
            this.txtCoordinate1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCoordinate1.Name = "txtCoordinate1";
            this.txtCoordinate1.Size = new System.Drawing.Size(148, 51);
            this.txtCoordinate1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 18F);
            this.label3.Location = new System.Drawing.Point(576, 904);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "兩條線段";
            // 
            // txtresult
            // 
            this.txtresult.Font = new System.Drawing.Font("新細明體", 18F);
            this.txtresult.Location = new System.Drawing.Point(743, 901);
            this.txtresult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtresult.Name = "txtresult";
            this.txtresult.ReadOnly = true;
            this.txtresult.Size = new System.Drawing.Size(148, 51);
            this.txtresult.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 18F);
            this.label4.Location = new System.Drawing.Point(1075, 904);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 36);
            this.label4.TabIndex = 0;
            this.label4.Text = "相交點座標:";
            // 
            // txtIntersectionCoordinate
            // 
            this.txtIntersectionCoordinate.Font = new System.Drawing.Font("新細明體", 18F);
            this.txtIntersectionCoordinate.Location = new System.Drawing.Point(1287, 901);
            this.txtIntersectionCoordinate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIntersectionCoordinate.Name = "txtIntersectionCoordinate";
            this.txtIntersectionCoordinate.ReadOnly = true;
            this.txtIntersectionCoordinate.Size = new System.Drawing.Size(148, 51);
            this.txtIntersectionCoordinate.TabIndex = 1;
            // 
            // btndraw
            // 
            this.btndraw.Font = new System.Drawing.Font("新細明體", 18F);
            this.btndraw.Location = new System.Drawing.Point(1071, 751);
            this.btndraw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndraw.Name = "btndraw";
            this.btndraw.Size = new System.Drawing.Size(225, 64);
            this.btndraw.TabIndex = 2;
            this.btndraw.Text = "重畫及判斷";
            this.btndraw.UseVisualStyleBackColor = true;
            this.btndraw.Click += new System.EventHandler(this.btndraw_Click);
            // 
            // btnclear
            // 
            this.btnclear.Font = new System.Drawing.Font("新細明體", 18F);
            this.btnclear.Location = new System.Drawing.Point(1304, 751);
            this.btnclear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(208, 64);
            this.btnclear.TabIndex = 2;
            this.btnclear.Text = "清除";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // pic1
            // 
            this.pic1.Location = new System.Drawing.Point(530, 12);
            this.pic1.Name = "pic1";
            this.pic1.Size = new System.Drawing.Size(953, 697);
            this.pic1.TabIndex = 3;
            this.pic1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "label5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1673, 1050);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pic1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndraw);
            this.Controls.Add(this.txtCoordinate1);
            this.Controls.Add(this.txtCoordinate2);
            this.Controls.Add(this.txtCoordinate4);
            this.Controls.Add(this.txtIntersectionCoordinate);
            this.Controls.Add(this.txtresult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCoordinate3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCoordinate3;
        private System.Windows.Forms.TextBox txtCoordinate2;
        private System.Windows.Forms.TextBox txtCoordinate4;
        private System.Windows.Forms.TextBox txtCoordinate1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtresult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIntersectionCoordinate;
        private System.Windows.Forms.Button btndraw;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.PictureBox pic1;
        private System.Windows.Forms.Label label5;
    }
}

