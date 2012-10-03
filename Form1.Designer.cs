namespace regexRename
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.oldName = new System.Windows.Forms.ColumnHeader();
            this.newName = new System.Windows.Forms.ColumnHeader();
            this.info = new System.Windows.Forms.ColumnHeader();
            this.checkBox_ShowDir = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button_rename = new System.Windows.Forms.Button();
            this.button_clearAll = new System.Windows.Forms.Button();
            this.button_clearSuccessful = new System.Windows.Forms.Button();
            this.button_clearFailed = new System.Windows.Forms.Button();
            this.checkBox_includeSubFiles = new System.Windows.Forms.CheckBox();
            this.button_test = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.checkBox_includeExtensionName = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox_IncludePath = new System.Windows.Forms.CheckBox();
            this.checkBox_includeDir = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.AllowColumnReorder = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.oldName,
            this.newName,
            this.info});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 24);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(664, 244);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // oldName
            // 
            this.oldName.Text = "原文件名";
            this.oldName.Width = 260;
            // 
            // newName
            // 
            this.newName.Text = "目标文件名";
            this.newName.Width = 260;
            // 
            // info
            // 
            this.info.Text = "当前状态";
            this.info.Width = 130;
            // 
            // checkBox_ShowDir
            // 
            this.checkBox_ShowDir.AutoSize = true;
            this.checkBox_ShowDir.Location = new System.Drawing.Point(28, 278);
            this.checkBox_ShowDir.Name = "checkBox_ShowDir";
            this.checkBox_ShowDir.Size = new System.Drawing.Size(72, 16);
            this.checkBox_ShowDir.TabIndex = 1;
            this.checkBox_ShowDir.Text = "显示路径";
            this.checkBox_ShowDir.UseVisualStyleBackColor = true;
            this.checkBox_ShowDir.CheckedChanged += new System.EventHandler(this.checkBox_ShowDir_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(109, 343);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 21);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "待匹配模式：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "目的模式：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(109, 370);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(297, 21);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button_rename
            // 
            this.button_rename.Enabled = false;
            this.button_rename.Location = new System.Drawing.Point(564, 346);
            this.button_rename.Name = "button_rename";
            this.button_rename.Size = new System.Drawing.Size(99, 39);
            this.button_rename.TabIndex = 6;
            this.button_rename.Text = "更改文件名";
            this.button_rename.UseVisualStyleBackColor = true;
            this.button_rename.Click += new System.EventHandler(this.button_rename_Click);
            // 
            // button_clearAll
            // 
            this.button_clearAll.Location = new System.Drawing.Point(439, 274);
            this.button_clearAll.Name = "button_clearAll";
            this.button_clearAll.Size = new System.Drawing.Size(75, 23);
            this.button_clearAll.TabIndex = 7;
            this.button_clearAll.Text = "清空列表";
            this.button_clearAll.UseVisualStyleBackColor = true;
            this.button_clearAll.Click += new System.EventHandler(this.button_clearAll_Click);
            // 
            // button_clearSuccessful
            // 
            this.button_clearSuccessful.Location = new System.Drawing.Point(520, 274);
            this.button_clearSuccessful.Name = "button_clearSuccessful";
            this.button_clearSuccessful.Size = new System.Drawing.Size(75, 23);
            this.button_clearSuccessful.TabIndex = 8;
            this.button_clearSuccessful.Text = "清空已成功";
            this.button_clearSuccessful.UseVisualStyleBackColor = true;
            this.button_clearSuccessful.Click += new System.EventHandler(this.button_clearSuccessful_Click);
            // 
            // button_clearFailed
            // 
            this.button_clearFailed.Location = new System.Drawing.Point(601, 274);
            this.button_clearFailed.Name = "button_clearFailed";
            this.button_clearFailed.Size = new System.Drawing.Size(75, 23);
            this.button_clearFailed.TabIndex = 9;
            this.button_clearFailed.Text = "清空失败";
            this.button_clearFailed.UseVisualStyleBackColor = true;
            this.button_clearFailed.Click += new System.EventHandler(this.button_clearFailed_Click);
            // 
            // checkBox_includeSubFiles
            // 
            this.checkBox_includeSubFiles.AutoSize = true;
            this.checkBox_includeSubFiles.Checked = true;
            this.checkBox_includeSubFiles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_includeSubFiles.Location = new System.Drawing.Point(109, 311);
            this.checkBox_includeSubFiles.Name = "checkBox_includeSubFiles";
            this.checkBox_includeSubFiles.Size = new System.Drawing.Size(132, 16);
            this.checkBox_includeSubFiles.TabIndex = 10;
            this.checkBox_includeSubFiles.Text = "包括文件夹中的文件";
            this.toolTip1.SetToolTip(this.checkBox_includeSubFiles, "在此项选中的状态下增加新的文件夹时程序会自动包括其下的文件和所有子文件夹下的文件。\r\n注意：是否包含文件夹和子文件夹并不由该项控制。");
            this.checkBox_includeSubFiles.UseVisualStyleBackColor = true;
            // 
            // button_test
            // 
            this.button_test.Location = new System.Drawing.Point(439, 346);
            this.button_test.Name = "button_test";
            this.button_test.Size = new System.Drawing.Size(106, 39);
            this.button_test.TabIndex = 11;
            this.button_test.Text = "预览改名效果";
            this.toolTip1.SetToolTip(this.button_test, "由于批量更改文件名极易出错，且本程序没有撤销机制，\r\n所以设定每次更改前必须要先对改名结果进行预览。");
            this.button_test.UseVisualStyleBackColor = true;
            this.button_test.Click += new System.EventHandler(this.button_test_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(688, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // checkBox_includeExtensionName
            // 
            this.checkBox_includeExtensionName.AutoSize = true;
            this.checkBox_includeExtensionName.Location = new System.Drawing.Point(118, 278);
            this.checkBox_includeExtensionName.Name = "checkBox_includeExtensionName";
            this.checkBox_includeExtensionName.Size = new System.Drawing.Size(108, 16);
            this.checkBox_includeExtensionName.TabIndex = 13;
            this.checkBox_includeExtensionName.Text = "扩展名参与匹配";
            this.toolTip1.SetToolTip(this.checkBox_includeExtensionName, "选中时扩展名会参与匹配和替换。\r\n如果你不想更改文件扩展名的话请不要选此项。");
            this.checkBox_includeExtensionName.UseVisualStyleBackColor = true;
            this.checkBox_includeExtensionName.CheckedChanged += new System.EventHandler(this.checkBox_includeExtensionName_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "增加文件时：";
            // 
            // checkBox_IncludePath
            // 
            this.checkBox_IncludePath.AutoSize = true;
            this.checkBox_IncludePath.Location = new System.Drawing.Point(251, 278);
            this.checkBox_IncludePath.Name = "checkBox_IncludePath";
            this.checkBox_IncludePath.Size = new System.Drawing.Size(132, 16);
            this.checkBox_IncludePath.TabIndex = 15;
            this.checkBox_IncludePath.Text = "路径参与匹配(慎用)";
            this.toolTip1.SetToolTip(this.checkBox_IncludePath, "选中时路径名会参与匹配与替换。\r\n如果替换后的路径不在原目录，文件会被移动到新目录，如果新目录不存在，程序会自动建立新目录。\r\n标记慎用是因为此命令容易被误用，除" +
                    "非你确实需要此功能，否则请不要选此项。");
            this.checkBox_IncludePath.UseVisualStyleBackColor = true;
            this.checkBox_IncludePath.CheckedChanged += new System.EventHandler(this.checkBox_IncludePath_CheckedChanged);
            // 
            // checkBox_includeDir
            // 
            this.checkBox_includeDir.AutoSize = true;
            this.checkBox_includeDir.Location = new System.Drawing.Point(251, 311);
            this.checkBox_includeDir.Name = "checkBox_includeDir";
            this.checkBox_includeDir.Size = new System.Drawing.Size(84, 16);
            this.checkBox_includeDir.TabIndex = 16;
            this.checkBox_includeDir.Text = "包括文件夹";
            this.toolTip1.SetToolTip(this.checkBox_includeDir, "在此项选中的状态下，程序会接受文件夹。\r\n注意：只有在此项和“包括文件夹中的文件”都被选中时程序才会包含包含 子文件夹。");
            this.checkBox_includeDir.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 17;
            this.label4.Text = "匹配模式类型：";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(118, 399);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(83, 16);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "1";
            this.radioButton1.Text = "正则表达式";
            this.toolTip1.SetToolTip(this.radioButton1, "正则表达式的实现采用.net的正则库。\r\n如果你不知道什么是正则表达式，请选择“纯文本”。");
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(240, 399);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 16);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.Tag = "1";
            this.radioButton2.Text = "纯文本";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 10000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ReshowDelay = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(257, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "请把要改名的文件(夹)用鼠标拖入下面的窗口：";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 446);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBox_includeDir);
            this.Controls.Add(this.checkBox_IncludePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox_includeExtensionName);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.button_test);
            this.Controls.Add(this.checkBox_includeSubFiles);
            this.Controls.Add(this.button_clearFailed);
            this.Controls.Add(this.button_clearSuccessful);
            this.Controls.Add(this.button_clearAll);
            this.Controls.Add(this.button_rename);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox_ShowDir);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "批量改名";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader oldName;
        private System.Windows.Forms.ColumnHeader newName;
        private System.Windows.Forms.ColumnHeader info;
        private System.Windows.Forms.CheckBox checkBox_ShowDir;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button_rename;
        private System.Windows.Forms.Button button_clearAll;
        private System.Windows.Forms.Button button_clearSuccessful;
        private System.Windows.Forms.Button button_clearFailed;
        private System.Windows.Forms.CheckBox checkBox_includeSubFiles;
        private System.Windows.Forms.Button button_test;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.CheckBox checkBox_includeExtensionName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox_IncludePath;
        private System.Windows.Forms.CheckBox checkBox_includeDir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label5;

    }
}

