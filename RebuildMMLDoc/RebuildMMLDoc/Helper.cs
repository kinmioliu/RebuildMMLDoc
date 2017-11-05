using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebuildMMLDoc
{
    class ERRCODE
    {
        public static int errcode;
        public static string errinfo;
    };

    class Helper
    {
        public static bool is_docfile(string path)
        {
            if (path.Contains("doc") || path.Contains("docx"))
            {
                return true;
            }
            return false;
        }


        public static bool IS_DIR = true;
        public static bool IS_FILE = false;


        public static int ERR_SUCCESS = 0;
        public static int ERR_NOT_DOC_FILE = 1;        
        public static int ERR_PARSER_ERR = 3;
        public static int ERR_OPEN_DOC_FAIL = 4;
        public static int ERR_OPEN_FILE_FAIL = 5;        

        public static ERRCODE[] ERR_CODES =
        {
            new ERRCODE()
        };
        public static Dictionary<int, string> errcode_info = new Dictionary<int, string>();

        public static bool init_errinfo()
        {
            errcode_info[ERR_SUCCESS] = "处理成功！";
            errcode_info[ERR_NOT_DOC_FILE] = "文件不是work文件，重新选择";            
            errcode_info[ERR_PARSER_ERR] = "解析过程发生了错误。";
            errcode_info[ERR_OPEN_DOC_FAIL] = "打开文件失败";            
            return true;
        }

        public static string get_errinfo(int err_code)
        {
            return errcode_info[err_code];
        }
    }
}
