using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;

namespace RebuildMMLDoc
{
    class DocParser
    {        
        #region 属性
        private List<string> files;
        private string doc_file;
        #endregion


        //1.声明关于事件的委托；
        public delegate void AlarmEventHandler(string text, int grap);

        //2.声明事件；   
        public event AlarmEventHandler Alarm;

        //3.编写引发事件的函数；
        public void notify_parser_result(string text, int grap)
        {
            if (this.Alarm != null)
            {
                Console.WriteLine("\n狗报警: 有小偷进来了,汪汪~~~~~~~");
                this.Alarm(text, grap);   //发出警报
            }
        }




        #region 构造函数
        public DocParser(string file)
        {
            doc_file = file;
        }
        #endregion

        public int parser_files()
        {
            int result = Helper.ERR_SUCCESS;
            return parser_file_impl(doc_file);            
        }

        private int parser_file_impl(string file)
        {
            //判断是否是excel文件
            if (!Helper.is_docfile(file))
            {
                return Helper.ERR_NOT_DOC_FILE;
            }

            //打开word应用
            Microsoft.Office.Interop.Word.Application word_app = new Microsoft.Office.Interop.Word.Application();
            if (word_app == null)
            {
                return Helper.ERR_OPEN_DOC_FAIL;
            }

            //基本属性
            word_app.Visible = false;

            Microsoft.Office.Interop.Word.Document doc = word_app.Documents.Open(file);
            int all_graps = doc.Paragraphs.Count;
            for (int graph = 1; graph <= all_graps; graph++)
            {
                string temp = doc.Paragraphs[graph].Range.Text.Trim();//变量i为第i段
                notify_parser_result(temp, graph);
            }

            return Helper.ERR_SUCCESS;
        }

        private int _to_text(string text, int i)
        {

            return 0;
        }
    }
}
