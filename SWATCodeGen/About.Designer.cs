//#define CHINESE

namespace SWATCodeGen
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SWATCodeGen.Properties.Resources.jiecao;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(234, 201);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(265, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 285);
            this.label1.TabIndex = 1;
#if CHINESE
            this.label1.Text = "★这是啥:\r\n一个算号器,可以生成辐射的军衔号.\r\n继\"直刷11级的刷分图\"后,作者的又一力作.\r\n\r\n★使用方法:\r\n1.填入你的ID\r\n2.选择你要刷的等级(" +
    "默认12级)\r\n3.配置你的人物\r\n4.选择勋章\r\n5.算号吧\r\n\r\n★作者友情提示:\r\n刷的同时也别忘了提高自己的技术.\r\n不要让自己的技术对不起自己的军衔." +
    "\r\n另外本体熊是个喷子,进了辐射群要习惯他.\r\n";
#else
            this.label1.Text = "★What's this:\r\nA code generator, which can generate \r\na code with any ranks, any classes, \r\nany talents(Anyway,restricted by \r\nclass) and any medals!\r\n\r\n★How to use:\r\n1.Enter your ID\r\n2.Choose your rank(" +
    "Default:12)\r\n3.Configure your actor\r\n4.Choose your medals\r\n5.GENERATE\r\n\r\n★This is a little bug that \r\nyou can only get one REM medal. \r\nHowever, if you like this software, \r\nplz follow my twitter: @szszss10032\r\nIt's very discomfiting that having \r\nonly several followers... :P";
#endif
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(74, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 48);
            this.button1.TabIndex = 2;
#if CHINESE
            this.button1.Text = "关闭";
#else
            this.button1.Text = "Close";
#endif
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 381);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
#if CHINESE
            this.Text = "辐射废墟算号器";
#else
            this.Text = "SWAT Aftermath Code Generator";
#endif
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}