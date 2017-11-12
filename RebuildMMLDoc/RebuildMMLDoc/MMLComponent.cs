using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RebuildMMLDoc
{

    public interface IParser
    {
        void handle_parser_result(string text, int grap);
    }

    class MMLRichTextBox : RichTextBox, IParser
    {
        public void handle_parser_result(string text, int grap)
        {
            AppendText(text + "\n");
        }

        public void register(DocParser parser)
        {
            parser.ParserEvt += new DocParser.ParserEventHandler(handle_parser_result);
        }
    }

    class MMLProgressBar : ProgressBar, IParser
    {
        public void handle_parser_result(string text, int grap)
        {
            this.Value = grap;
        }

        public void register(DocParser parser)
        {
            parser.ParserEvt += new DocParser.ParserEventHandler(handle_parser_result);
        }
    }

    class MMLOutputTxt : IParser
    {
        private string path;
        public void init(string path)
        {
            this.path = path;
        }

        public void handle_parser_result(string text, int grap)
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.BaseStream.Seek(0, SeekOrigin.End);
                    sw.WriteLine("{0}", text, DateTime.Now);
                    sw.Flush();
                }
            }
        }

        public void register(DocParser parser)
        {
            parser.ParserEvt += new DocParser.ParserEventHandler(handle_parser_result);
        }
    }
}
