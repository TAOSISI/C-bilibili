﻿namespace WinFormHelloWorld
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
            this.textBoxShowHello = new System.Windows.Forms.TextBox();
            this.buttonSayHello = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxShowHello
            // 
            this.textBoxShowHello.Location = new System.Drawing.Point(32, 37);
            this.textBoxShowHello.Name = "textBoxShowHello";
            this.textBoxShowHello.Size = new System.Drawing.Size(220, 21);
            this.textBoxShowHello.TabIndex = 0;
            // 
            // buttonSayHello
            // 
            this.buttonSayHello.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSayHello.Location = new System.Drawing.Point(104, 73);
            this.buttonSayHello.Name = "buttonSayHello";
            this.buttonSayHello.Size = new System.Drawing.Size(75, 23);
            this.buttonSayHello.TabIndex = 1;
            this.buttonSayHello.Text = "click me";
            this.buttonSayHello.UseVisualStyleBackColor = true;
            this.buttonSayHello.Click += new System.EventHandler(this.buttonSayHello_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonSayHello);
            this.Controls.Add(this.textBoxShowHello);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxShowHello;
        private System.Windows.Forms.Button buttonSayHello;
    }
}

