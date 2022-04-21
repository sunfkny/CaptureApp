namespace CaptureApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button_start = new System.Windows.Forms.Button();
            this.button_stop = new System.Windows.Forms.Button();
            this.textBox_matchStr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox_result = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_autoexit = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button_start
            // 
            this.button_start.Location = new System.Drawing.Point(450, 37);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(75, 23);
            this.button_start.TabIndex = 0;
            this.button_start.Text = "开始";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // button_stop
            // 
            this.button_stop.Enabled = false;
            this.button_stop.Location = new System.Drawing.Point(531, 37);
            this.button_stop.Name = "button_stop";
            this.button_stop.Size = new System.Drawing.Size(75, 23);
            this.button_stop.TabIndex = 1;
            this.button_stop.Text = "结束";
            this.button_stop.UseVisualStyleBackColor = true;
            this.button_stop.Click += new System.EventHandler(this.button_stop_Click);
            // 
            // textBox_matchStr
            // 
            this.textBox_matchStr.Location = new System.Drawing.Point(77, 10);
            this.textBox_matchStr.Name = "textBox_matchStr";
            this.textBox_matchStr.Size = new System.Drawing.Size(529, 21);
            this.textBox_matchStr.TabIndex = 2;
            this.textBox_matchStr.Text = "mihoyo.com/event/gacha_info/api/getGachaLog";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "url包含";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox_result
            // 
            this.textBox_result.Location = new System.Drawing.Point(15, 66);
            this.textBox_result.Multiline = true;
            this.textBox_result.Name = "textBox_result";
            this.textBox_result.Size = new System.Drawing.Size(591, 283);
            this.textBox_result.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "抓包状态";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(74, 42);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(41, 12);
            this.label_status.TabIndex = 6;
            this.label_status.Text = "未开始";
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(373, 38);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(71, 21);
            this.textBox_port.TabIndex = 7;
            this.textBox_port.Text = "8889";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "端口";
            // 
            // checkBox_autoexit
            // 
            this.checkBox_autoexit.AutoSize = true;
            this.checkBox_autoexit.Checked = true;
            this.checkBox_autoexit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_autoexit.Location = new System.Drawing.Point(140, 40);
            this.checkBox_autoexit.Name = "checkBox_autoexit";
            this.checkBox_autoexit.Size = new System.Drawing.Size(156, 16);
            this.checkBox_autoexit.TabIndex = 9;
            this.checkBox_autoexit.Text = "自动复制到剪贴板并退出";
            this.checkBox_autoexit.UseVisualStyleBackColor = true;
            this.checkBox_autoexit.CheckedChanged += new System.EventHandler(this.checkBox_autoexit_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 361);
            this.Controls.Add(this.checkBox_autoexit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.label_status);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_result);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_matchStr);
            this.Controls.Add(this.button_stop);
            this.Controls.Add(this.button_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CaptureApp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.Button button_stop;
        private System.Windows.Forms.TextBox textBox_matchStr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox_result;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_autoexit;
    }
}

