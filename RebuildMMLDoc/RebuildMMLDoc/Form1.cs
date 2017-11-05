using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office;
using Microsoft.Office.Interop.Word;

namespace RebuildMMLDoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_choose_mmldoc(object sender, EventArgs e)
        {
            OpenFileDialog file_dialog = new OpenFileDialog();
            file_dialog.Multiselect = true;
            file_dialog.Title = "选择文件";
            file_dialog.Filter = "所有文件(*.*)|*.*";
            if (file_dialog.ShowDialog() == DialogResult.OK)
            {
                string file = file_dialog.FileName;
                selected_doc = file;
                rtb_dumpinfo.AppendText(selected_doc + "\n");
//                tb_dumpinfo.AppendText(file + "\n");
//                MessageBox.Show("已选择文件:" + file, "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rtb_dumpinfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_parse_mmldoc_Click(object sender, EventArgs e)
        {
            //解析doc文档
//            DialogResult result = MessageBox.Show("请确保:" + selected_doc + " 文件已备份！！！", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            
            if (DialogResult.Yes == DialogResult.Yes)
            {
                DocParser parser = new DocParser(selected_doc);
                rtb_dumpinfo.register(parser);
                int ret = parser.parser_files();
                rtb_dumpinfo.AppendText(Helper.get_errinfo(ret) + "\n");
//                MessageBox.Show("处理结果：" + Helper.get_errinfo(ret) + "。", "结果", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }

        }
    }
}
