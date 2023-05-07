using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace regexRename
{
    public partial class Form1 : Form
    {
        List<FileInfo> fileList = new List<FileInfo>();
        List<string> newNameList = new List<string>();
        List<int> nowState = new List<int>();
        string[] stateList = { "", "成功", "失败", "目标文件(夹)名已存在", "具有只读属性", "目标路径不合法" };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Link;
            else
                e.Effect = DragDropEffects.None;
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            Array inputfilelist = (System.Array)e.Data.GetData(DataFormats.FileDrop);
            foreach (string i in inputfilelist)
            {
                if (!Directory.Exists(i) || (Directory.Exists(i) && checkBox_includeDir.Checked ))
                {
                    FileInfo newfile = new FileInfo(i);
                    if (!fileList.Exists(file => file.FullName.Equals(newfile.FullName, StringComparison.OrdinalIgnoreCase)))
                    {
                        fileList.Add(newfile);
                        newNameList.Add("");

                        nowState.Add(0);
                    }
                }
                if (Directory.Exists(i) && checkBox_includeSubFiles.Checked )
                {
                    if(checkBox_includeDir.Checked)
                    {
                        DirectoryInfo[] Directories = new DirectoryInfo(i).GetDirectories("*", SearchOption.AllDirectories);
                        foreach (DirectoryInfo newfile in Directories)
                        {
                            if (!fileList.Exists(file => file.FullName.Equals(newfile.FullName, StringComparison.OrdinalIgnoreCase)))
                            {
                                fileList.Add(new FileInfo(newfile.FullName));
                                newNameList.Add("");

                                nowState.Add(0);
                            }
                        }
                    }

                    FileInfo[] files = new DirectoryInfo(i).GetFiles("*", SearchOption.AllDirectories);
                    foreach (FileInfo newfile in files)
                    {
                        if (!fileList.Exists(file => file.FullName.Equals(newfile.FullName, StringComparison.OrdinalIgnoreCase)))
                        {
                            fileList.Add(new FileInfo(newfile.FullName));
                            newNameList.Add("");

                            nowState.Add(0);
                        }

                    }

                }
            }

            ShowFileList();
            button_rename.Enabled = false;
        }

        public void ShowFileList()
        {
            listView1.Items.Clear();

            for (int i = 0; i < fileList.Count; i++ )
            {
                ListViewItem item;

                if (checkBox_ShowDir.Checked)
                {
                    item = new ListViewItem(fileList[i].FullName, 0);
                    item.SubItems.Add(newNameList[i]);
                }
                else
                {
                    item = new ListViewItem(fileList[i].Name, 0);
                    item.SubItems.Add(Regex.Replace(newNameList[i],".*\\\\",""));
                }
                
                item.SubItems.Add(stateList[nowState[i]]);
                listView1.Items.Add(item);
            }

            toolStripStatusLabel1.Text = "当前有 " + fileList.Count.ToString() + " 个文件(夹)";
        }

        private void button_clearAll_Click(object sender, EventArgs e)
        {
            fileList.Clear();
            newNameList.Clear();
            nowState.Clear();
            button_rename.Enabled = false;
            ShowFileList();
        }

        private void button_test_Click(object sender, EventArgs e)
        {
            string pattern = textBox1.Text;
            textBox1.Text = pattern;
            string replaceStr = textBox2.Text;
            textBox2.Text = replaceStr;

            toolStripStatusLabel1.Text = "";
            button_rename.Enabled = false;

            //测试正则表达式是否合法
            if (radioButton1.Checked)
            {
                try
                {
                    Regex test = new Regex(pattern);
                }
                catch
                {
                    toolStripStatusLabel1.Text = "输入的正则表达式格式错误，请重新检查";
                    textBox1.SelectAll();
                    textBox1.Focus();
                    return;
                }
            }

            int normalNum = 0;
            for (int i = 0; i < fileList.Count; i++)
            {
                string name = fileList[i].Name;
                string extensionName = "";
                if (!checkBox_includeExtensionName.Checked)
                {
                    Match matchresult = Regex.Match(name, "^(.*)(\\.[^.]*)$");
                    if (matchresult.Success)
                    {
                        name = matchresult.Groups[1].ToString();
                        extensionName = matchresult.Groups[2].ToString();
                    }
                }

                if (radioButton1.Checked)
                {
                    if (checkBox_IncludePath.Checked)
                        newNameList[i] = Regex.Replace(fileList[i].Directory + "\\" + name, pattern, replaceStr) + extensionName;
                    else
                        newNameList[i] = fileList[i].Directory + "\\" + Regex.Replace(name, pattern, replaceStr) + extensionName;
                }
                else
                {
                    if (checkBox_IncludePath.Checked)
                        newNameList[i] = (fileList[i].Directory + "\\" + name).Replace(pattern, replaceStr) + extensionName;
                    else
                        newNameList[i] = fileList[i].Directory + "\\" + name.Replace(pattern, replaceStr) + extensionName;
                }

                newNameList[i] = newNameList[i].Replace("{INDEX}", (i + 1).ToString("D3"));

                if (!fileList[i].FullName.Equals(newNameList[i], StringComparison.OrdinalIgnoreCase) && File.Exists(newNameList[i]))
                    nowState[i] = 3;
                else if (fileList[i].IsReadOnly)
                    nowState[i] = 4;
                else if (!Regex.Match(newNameList[i], "^[A-Za-z]:\\\\").Success)
                    nowState[i] = 5;
                else
                {
                    nowState[i] = 0;
                    normalNum++;
                }
            }

            if (fileList.Count > 0)
                button_rename.Enabled = true;

            ShowFileList();
            if(fileList.Count != normalNum)
                toolStripStatusLabel1.Text = "可能会有 " + (fileList.Count - normalNum).ToString() + " 个文件(夹)无法更名";
        }

        private void button_rename_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = "";
            int failednum = 0;
            for (int i = 0; i < fileList.Count; i++)
            {
                try
                {
                    string path = Regex.Replace(newNameList[i], "\\\\[^\\\\]*$", "");
                    if (!Regex.Match(path, "^[A-Za-z]:\\\\").Success)
                        throw new Exception();
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    fileList[i].MoveTo(newNameList[i]);
                    nowState[i] = 1;
                }
                catch
                {
                    nowState[i] = 2;
                    failednum++;
                }
            }

            ShowFileList();

            if(failednum == 0)
                toolStripStatusLabel1.Text = "改名成功";
            else
                toolStripStatusLabel1.Text = "改名失败的文件(夹)个数：" + failednum.ToString() + " 个";
        }

        private void button_clearSuccessful_Click(object sender, EventArgs e)
        {
            for (int i = fileList.Count - 1; i >= 0; i--)
            {
                if (nowState[i] == 1)
                {
                    fileList.RemoveAt(i);
                    newNameList.RemoveAt(i);
                    nowState.RemoveAt(i);
                }
            }
            ShowFileList();
        }

        private void button_clearFailed_Click(object sender, EventArgs e)
        {
            for (int i = fileList.Count - 1; i >= 0; i--)
            {
                if (nowState[i] == 2)
                {
                    fileList.RemoveAt(i);
                    newNameList.RemoveAt(i);
                    nowState.RemoveAt(i);
                }
            }
            ShowFileList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            button_rename.Enabled = false;
            button_test.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            button_rename.Enabled = false;
        }

        private void checkBox_includeExtensionName_CheckedChanged(object sender, EventArgs e)
        {
            button_rename.Enabled = false;
        }

        private void checkBox_ShowDir_CheckedChanged(object sender, EventArgs e)
        {
            ShowFileList();
        }

        private void checkBox_IncludePath_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_IncludePath.Checked == true)
            {
                checkBox_ShowDir.Checked = true;
                checkBox_ShowDir.Enabled = false;
            }
            else
            {
                checkBox_ShowDir.Enabled = true;
            }
            button_rename.Enabled = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            button_rename.Enabled = false;
        }

    }
}
