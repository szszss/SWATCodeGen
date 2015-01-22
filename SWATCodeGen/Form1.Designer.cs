//#define CHINESE

namespace SWATCodeGen
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkedListBoxXZ = new System.Windows.Forms.CheckedListBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.labelPlayerName = new System.Windows.Forms.Label();
            this.listBoxSk2 = new System.Windows.Forms.ListBox();
            this.listBoxSk1 = new System.Windows.Forms.ListBox();
            this.listBoxArmour = new System.Windows.Forms.ListBox();
            this.listBoxWeapon = new System.Windows.Forms.ListBox();
            this.listBoxTal = new System.Windows.Forms.ListBox();
            this.listBoxType = new System.Windows.Forms.ListBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(12, 379);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 19);
            this.label11.TabIndex = 47;
#if CHINESE
            this.label11.Text = "输出信息:";
#else
            this.label11.Text = "Output:";
#endif
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 570);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 15);
            this.label10.TabIndex = 46;
#if CHINESE
            this.label10.Text = "辐射废墟算号器 1.2";
#else
            this.label10.Text = "SWAT:AM CodeGen 1.2";
#endif
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(276, 562);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 41);
            this.button1.TabIndex = 45;
            this.button1.Text = "算号";
#if CHINESE
            this.button1.Text = "算号";
#else
            this.button1.Text = "Generate";
#endif
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 401);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(392, 153);
            this.richTextBox1.TabIndex = 44;
            this.richTextBox1.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(427, 379);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 19);
            this.label9.TabIndex = 43;
#if CHINESE
            this.label9.Text = "勋章";
#else
            this.label9.Text = "Medals";
#endif
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(697, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 19);
            this.label7.TabIndex = 40;
#if CHINESE
            this.label7.Text = "特技:";
#else
            this.label7.Text = "Talents:";
#endif
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(560, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 39;
#if CHINESE
            this.label6.Text = "天赋2:";
#else
            this.label6.Text = "Specs:";
#endif
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(427, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 19);
            this.label5.TabIndex = 38;
#if CHINESE
            this.label5.Text = "天赋1:";
#else
            this.label5.Text = "Traits:";
#endif
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(286, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 19);
            this.label4.TabIndex = 37;
#if CHINESE
            this.label4.Text = "装甲:";
#else
            this.label4.Text = "Armors:";
#endif
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(149, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 19);
            this.label3.TabIndex = 36;
#if CHINESE
            this.label3.Text = "武器:";
#else
            this.label3.Text = "Weapons:";
#endif
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 35;
#if CHINESE
            this.label2.Text = "兵种:";
#else
            this.label2.Text = "Classes:";
#endif
            // 
            // checkedListBoxXZ
            // 
            this.checkedListBoxXZ.FormattingEnabled = true;
            this.checkedListBoxXZ.Location = new System.Drawing.Point(431, 401);
            this.checkedListBoxXZ.Name = "checkedListBoxXZ";
            this.checkedListBoxXZ.Size = new System.Drawing.Size(401, 184);
            this.checkedListBoxXZ.TabIndex = 34;
            this.checkedListBoxXZ.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxXZ_ItemCheck);
            this.checkedListBoxXZ.Click += new System.EventHandler(this.checkedListBoxXZ_Click);
            this.checkedListBoxXZ.MouseDown += new System.Windows.Forms.MouseEventHandler(this.checkedListBoxXZ_MouseDown);
            this.checkedListBoxXZ.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBoxType_MouseMove);
            this.checkedListBoxXZ.MouseUp += new System.Windows.Forms.MouseEventHandler(this.checkedListBoxXZ_MouseUp);
            this.checkedListBoxXZ.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.checkedListBoxXZ_PreviewKeyDown);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(108, 61);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(98, 25);
            this.numericUpDown1.TabIndex = 27;
#if CHINESE
            this.toolTip1.SetToolTip(this.numericUpDown1, "范围1~12");
#else
            this.toolTip1.SetToolTip(this.numericUpDown1, "Range: 1~12");
#endif
            this.numericUpDown1.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(44, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 26;
#if CHINESE
            this.label1.Text = "等级:";
#else
            this.label1.Text = "Rank:";
#endif
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Location = new System.Drawing.Point(107, 17);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(222, 25);
            this.textBoxPlayerName.TabIndex = 25;
#if CHINESE
            this.toolTip1.SetToolTip(this.textBoxPlayerName, "你的ID!\r\n注意,算号器对中文ID的支持不是很好,请谨慎使用中文ID.");
#else
            this.toolTip1.SetToolTip(this.textBoxPlayerName, "Your ID!");
#endif
            //this.toolTip1.SetToolTip(this.textBoxPlayerName, "你的ID!\r\n注意,算号器对中文ID的支持不是很好,请谨慎使用中文ID.");
            // 
            // labelPlayerName
            // 
            this.labelPlayerName.AutoSize = true;
            this.labelPlayerName.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelPlayerName.Location = new System.Drawing.Point(24, 18);
            this.labelPlayerName.Name = "labelPlayerName";
            this.labelPlayerName.Size = new System.Drawing.Size(77, 19);
            this.labelPlayerName.TabIndex = 24;
#if CHINESE
            this.labelPlayerName.Text = "玩家ID:";
#else
            this.labelPlayerName.Text = "PlayerID:";
#endif
            // 
            // listBoxSk2
            // 
            this.listBoxSk2.FormattingEnabled = true;
            this.listBoxSk2.ItemHeight = 15;
            this.listBoxSk2.Location = new System.Drawing.Point(564, 130);
            this.listBoxSk2.Name = "listBoxSk2";
            this.listBoxSk2.Size = new System.Drawing.Size(131, 229);
            this.listBoxSk2.TabIndex = 32;
            this.listBoxSk2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBoxType_MouseMove);
            // 
            // listBoxSk1
            // 
            this.listBoxSk1.FormattingEnabled = true;
            this.listBoxSk1.ItemHeight = 15;
            this.listBoxSk1.Location = new System.Drawing.Point(427, 130);
            this.listBoxSk1.Name = "listBoxSk1";
            this.listBoxSk1.Size = new System.Drawing.Size(131, 229);
            this.listBoxSk1.TabIndex = 31;
            this.listBoxSk1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBoxType_MouseMove);
            // 
            // listBoxArmour
            // 
            this.listBoxArmour.FormattingEnabled = true;
            this.listBoxArmour.ItemHeight = 15;
            this.listBoxArmour.Location = new System.Drawing.Point(290, 130);
            this.listBoxArmour.Name = "listBoxArmour";
            this.listBoxArmour.Size = new System.Drawing.Size(131, 229);
            this.listBoxArmour.TabIndex = 30;
            this.listBoxArmour.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBoxType_MouseMove);
            // 
            // listBoxWeapon
            // 
            this.listBoxWeapon.FormattingEnabled = true;
            this.listBoxWeapon.ItemHeight = 15;
            this.listBoxWeapon.Location = new System.Drawing.Point(153, 130);
            this.listBoxWeapon.Name = "listBoxWeapon";
            this.listBoxWeapon.Size = new System.Drawing.Size(131, 229);
            this.listBoxWeapon.TabIndex = 29;
            this.listBoxWeapon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBoxType_MouseMove);
            // 
            // listBoxTal
            // 
            this.listBoxTal.FormattingEnabled = true;
            this.listBoxTal.ItemHeight = 15;
            this.listBoxTal.Location = new System.Drawing.Point(701, 130);
            this.listBoxTal.Name = "listBoxTal";
            this.listBoxTal.Size = new System.Drawing.Size(131, 229);
            this.listBoxTal.TabIndex = 33;
            this.listBoxTal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBoxType_MouseMove);
            // 
            // listBoxType
            // 
            this.listBoxType.FormattingEnabled = true;
            this.listBoxType.ItemHeight = 15;
            this.listBoxType.Location = new System.Drawing.Point(16, 130);
            this.listBoxType.Name = "listBoxType";
            this.listBoxType.Size = new System.Drawing.Size(131, 229);
            this.listBoxType.TabIndex = 28;
            this.listBoxType.SelectedIndexChanged += new System.EventHandler(this.listBoxType_SelectedIndexChanged);
            this.listBoxType.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBoxType_MouseMove);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 100000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(222, 65);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(225, 15);
            this.linkLabel1.TabIndex = 48;
            this.linkLabel1.TabStop = true;
#if CHINESE
            this.linkLabel1.Text = "点此进入官方的在线军衔管理器!";
#else
            this.linkLabel1.Text = "Click here to access online code manager!";
#endif
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(90, 588);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(79, 15);
            this.linkLabel2.TabIndex = 49;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "by szszss";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(259, 376);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(149, 19);
            this.checkBox1.TabIndex = 50;
#if CHINESE
            this.checkBox1.Text = "自动复制入剪切板";
#else
            this.checkBox1.Text = "Auto copy";
#endif
            //this.checkBox1.Text = "自动复制入剪切板";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(185, 562);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 41);
            this.button2.TabIndex = 51;
#if CHINESE
            this.button2.Text = "关于...";
#else
            this.button2.Text = "About";
#endif
            //this.button2.Text = "关于...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 620);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBoxXZ);
            this.Controls.Add(this.listBoxTal);
            this.Controls.Add(this.listBoxSk2);
            this.Controls.Add(this.listBoxSk1);
            this.Controls.Add(this.listBoxArmour);
            this.Controls.Add(this.listBoxWeapon);
            this.Controls.Add(this.listBoxType);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.labelPlayerName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
#if CHINESE
            this.Text = "辐射废墟算号器";
#else
            this.Text = "SWAT Aftermath Code Generator";
#endif
            //this.Text = "辐射废墟算号器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox checkedListBoxXZ;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.Label labelPlayerName;
        private System.Windows.Forms.ListBox listBoxSk2;
        private System.Windows.Forms.ListBox listBoxSk1;
        private System.Windows.Forms.ListBox listBoxArmour;
        private System.Windows.Forms.ListBox listBoxWeapon;
        private System.Windows.Forms.ListBox listBoxTal;
        private System.Windows.Forms.ListBox listBoxType;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

