using System;
using System.Collections.Generic;
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
            parser.Alarm += new DocParser.AlarmEventHandler(handle_parser_result);
        }
    }
}
