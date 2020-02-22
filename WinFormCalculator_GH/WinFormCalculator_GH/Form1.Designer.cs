namespace WinFormCalculator_GH
{
    partial class form
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.number1 = new System.Windows.Forms.Label();
            this.number2 = new System.Windows.Forms.Label();
            this.BoxNumber1 = new System.Windows.Forms.TextBox();
            this.BoxNumber2 = new System.Windows.Forms.TextBox();
            this.Function = new System.Windows.Forms.ComboBox();
            this.Commit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // number1
            // 
            this.number1.AutoSize = true;
            this.number1.Location = new System.Drawing.Point(38, 97);
            this.number1.Name = "number1";
            this.number1.Size = new System.Drawing.Size(53, 12);
            this.number1.TabIndex = 0;
            this.number1.Text = "Nubmer1:";
            // 
            // number2
            // 
            this.number2.AutoSize = true;
            this.number2.Location = new System.Drawing.Point(38, 143);
            this.number2.Name = "number2";
            this.number2.Size = new System.Drawing.Size(53, 12);
            this.number2.TabIndex = 1;
            this.number2.Text = "Number2:";
            // 
            // BoxNumber1
            // 
            this.BoxNumber1.Location = new System.Drawing.Point(102, 94);
            this.BoxNumber1.Name = "BoxNumber1";
            this.BoxNumber1.Size = new System.Drawing.Size(100, 21);
            this.BoxNumber1.TabIndex = 2;
            // 
            // BoxNumber2
            // 
            this.BoxNumber2.Location = new System.Drawing.Point(102, 140);
            this.BoxNumber2.Name = "BoxNumber2";
            this.BoxNumber2.Size = new System.Drawing.Size(100, 21);
            this.BoxNumber2.TabIndex = 3;
            // 
            // Function
            // 
            this.Function.FormattingEnabled = true;
            this.Function.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.Function.Location = new System.Drawing.Point(102, 197);
            this.Function.Name = "Function";
            this.Function.Size = new System.Drawing.Size(84, 20);
            this.Function.TabIndex = 4;
            // 
            // Commit
            // 
            this.Commit.Location = new System.Drawing.Point(102, 239);
            this.Commit.Name = "Commit";
            this.Commit.Size = new System.Drawing.Size(84, 23);
            this.Commit.TabIndex = 5;
            this.Commit.Text = "Commit";
            this.Commit.UseVisualStyleBackColor = true;
            this.Commit.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(167, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "高航 2018302110320";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "WinForm Calculator";
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 353);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Commit);
            this.Controls.Add(this.Function);
            this.Controls.Add(this.BoxNumber2);
            this.Controls.Add(this.BoxNumber1);
            this.Controls.Add(this.number2);
            this.Controls.Add(this.number1);
            this.Name = "form";
            this.Text = "Calculator by GaoHang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label number1;
        private System.Windows.Forms.Label number2;
        private System.Windows.Forms.TextBox BoxNumber1;
        private System.Windows.Forms.TextBox BoxNumber2;
        private System.Windows.Forms.ComboBox Function;
        private System.Windows.Forms.Button Commit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

