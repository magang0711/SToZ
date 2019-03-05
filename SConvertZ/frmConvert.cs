using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SConvertZ
{
    public partial class frmConvert : Form
    {
        public frmConvert()
        {
            InitializeComponent();
        }


        private string dwgPath = string.Empty;
        /// <summary>
        /// 文件的路径
        /// </summary>
        public string DwgPath
        {
            get { return dwgPath; }
            set { dwgPath = value; }
        }
        private string proDes = string.Empty;
        /// <summary>
        /// 施工图属性
        /// </summary>
        public string ProDes
        {
            get { return proDes; }
            set { proDes = value; }
        }

        private string valDes = string.Empty;
        /// <summary>
        /// 竣工图的值
        /// </summary>
        public string ValDes
        {
            get { return valDes; }
            set { valDes = value; }
        }

        private string proNo = string.Empty;
        /// <summary>
        /// 图号属性
        /// </summary>
        public string ProNo
        {
            get { return proNo; }
            set { proNo = value; }
        }
        private string oldVal = string.Empty;
        /// <summary>
        /// 图号上原始值
        /// </summary>
        public string OldVal
        {
            get { return oldVal; }
            set { oldVal = value; }
        }
        private string newVal = string.Empty;
        /// <summary>
        /// 图号上要替换的新值
        /// </summary>
        public string NewVal
        {
            get { return newVal; }
            set { newVal = value; }
        }

        private List<string> listFiles = null;
        /// <summary>
        /// 所有dwg的路径
        /// </summary>
        public List<string> ListFiles
        {
            get { return listFiles; }
            set { listFiles = value; }
        }


        private bool isMultiple = false;
        /// <summary>
        /// 是否一张图纸一个图框
        /// </summary>
        public bool IsMultiple
        {
            get { return isMultiple; }
            set { isMultiple = value; }
        }

        /// <summary>
        /// 转化按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            string msg = ChekedData();
            if (msg.Length > 0)
            {
                System.Windows.Forms.MessageBox.Show(msg);
                this.DialogResult = System.Windows.Forms.DialogResult.None;
            }
            else
            {
                this.dwgPath = txtPath.Text;
                this.proDes = txtDesign.Text;
                this.proNo = txtDwgNo.Text;
                this.valDes = txtFinish.Text;
                this.oldVal = txtOld.Text;
                this.newVal = txtNew.Text;
                this.isMultiple = rdMultiple.Checked;
                if (Directory.Exists(dwgPath))
                {
                    listFiles = GetDwgFileByPath(dwgPath);
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("请输入正确的施工图文件夹路径!");
                    this.DialogResult = System.Windows.Forms.DialogResult.None;
                }
            }
        }
        /// <summary>
        /// 数据校验
        /// </summary>
        /// <returns></returns>
        private string ChekedData()
        {
            string msg = "";
            foreach (Control cn in this.Controls)
            {
                if (cn is TextBox)
                {
                    TextBox txt = cn as TextBox;
                    if (txt.Text.Length <= 0)
                    {
                        msg = txt.Tag + " 不能为空!";
                        break;
                    }
                }
            }
            return msg;
        }
        /// <summary>
        /// 获取指定路径下的所有dwg文件
        /// </summary>
        /// <param name="txtPath"></param>
        /// <returns></returns>
        private List<string> GetDwgFileByPath(string txtPath)
        {
            List<string> ls = new List<string>();
            DirectoryInfo root = new DirectoryInfo(txtPath);
            FileInfo[] files = root.GetFiles();
            foreach (FileInfo file in files)
            {
                if(file.Extension.ToLower().Equals(".dwg"))
                {
                    ls.Add(file.FullName);
                }
            }
            return ls;
        }
        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEsc_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// 获取指定的路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOpen_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.Description = "请选择施工图所在文件夹";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(dialog.SelectedPath))
                {
                    this.txtPath.Text = dialog.SelectedPath;
                }
            }
        }

        private void frmConvert_Load(object sender, EventArgs e)
        {
            SetValue(dwgPath, txtPath);
            SetValue(proDes, txtDesign);
            SetValue(valDes, txtFinish);
            SetValue(proNo, txtDwgNo);
            SetValue(oldVal, txtOld);
            SetValue(newVal, txtNew);
            rdSigle.Checked = IsMultiple ? false : true;
        }

        private void SetValue(string value, TextBox txt)
        {
            if (value.Length > 0)
            {
                txt.Text = value;
            }
        }
    }
}
