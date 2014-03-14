using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FilesRecorder
{
    public partial class FilesRecorder : Form
    {
        public FilesRecorder()
        {
            InitializeComponent();
            try
            {
                txtOutputPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            }
            catch { }
        }

        private void btnSelectInput_Click(object sender, EventArgs e)
        {
            ChooseFolder(txtInputPath);
        }

        private void btnSelectOutput_Click(object sender, EventArgs e)
        {
            ChooseFolder(txtOutputPath);
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtInputPath.Text) || string.IsNullOrWhiteSpace(txtOutputPath.Text))
            {
                MessageBox.Show("路径不能留空！");
                return;
            }
            if (!Directory.Exists(txtInputPath.Text) || !Directory.Exists(txtOutputPath.Text))
            {
                MessageBox.Show("指定路径不存在！");
                return;
            }
            btnRecord.Enabled = false;
            List<string> Files = GetFiles(txtInputPath.Text, GetSearchPattern(txtFileNameLimit.Text, txtFileTypeLimit.Text), chkRecordSub.Checked, chkFullPath.Checked);
            if (SaveFiles(txtOutputPath.Text, Files))
                MessageBox.Show("执行成功！");
            else
                MessageBox.Show("执行过程出错！");
            btnRecord.Enabled = true;
        }

        private void ChooseFolder(TextBox Target)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择目标文件夹路径";
            if (dialog.ShowDialog() == DialogResult.OK)
                Target.Text = dialog.SelectedPath;
        }

        private List<string> GetSearchPattern(string NameLimit, string TypeLimits)
        {
            List<string> Result = new List<string>();
            string[] Types = null;
            if (!string.IsNullOrWhiteSpace(TypeLimits))
            {
                char[] sp = { ',' };
                Types = TypeLimits.Replace(".", "").Split(sp);
            }
            NameLimit = string.IsNullOrWhiteSpace(NameLimit) ? "*" : string.Format("*{0}*", NameLimit);
            if (Types == null || Types.Length == 0)
                Result.Add(NameLimit);
            else
            {
                int i = 0;
                string limit;
                while (i < Types.Length)
                {
                    limit = NameLimit + (string.IsNullOrWhiteSpace(Types[i]) ? null : "." + Types[i]);
                    if (!Result.Contains(limit))
                        Result.Add(limit);
                    i++;
                }
            }
            return Result;
        }

        private List<string> GetFiles(string Path, List<string> Limits, bool IsSubContented, bool IsFullPath)
        {
            List<string> Result = new List<string>();
            SearchOption Opinion = IsSubContented ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;
            try
            {
                if (!IsFullPath && Path.LastIndexOf('\\') != Path.Length - 1)
                    Path += '\\';
                int i;
                foreach (string limit in Limits)
                {
                    string[] files = Directory.GetFiles(Path, limit, Opinion);
                    if (files == null || files.Length == 0)
                        continue;
                    i = 0;
                    while (i < files.Length)
                    {
                        if (!IsFullPath)
                            files[i] = files[i].Remove(0, Path.Length);
                        if (!Result.Contains(files[i]))
                            Result.Add(files[i]);
                        i++;
                    }
                }
            }
            catch
            {
                return null;
            }
            return Result;
        }

        private bool SaveFiles(string Path, List<string> Files)
        {
            Path += "\\FilesRecord" + DateTime.Now.ToString("yyyyMMddHHmmssfff") + ".txt";
            FileStream fs = null;
            try
            {
                fs = new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter m_streamWriter = new StreamWriter(fs, Encoding.UTF8);
                m_streamWriter.BaseStream.Seek(0, SeekOrigin.End);
                foreach (string file in Files)
                {
                    m_streamWriter.WriteLine(file);
                }
                m_streamWriter.Flush();
                m_streamWriter.Close();
            }
            catch
            {
                return false;
            }
            if (fs != null)
                fs.Close();
            return true;
        }
    }
}
