using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using MSEWDataBase.Base.Manager.PDF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSEWDataBase.Manager.PDF
{
    public class TestPdfDataManager : IPdfDataManager
    {

        public string GetAllPages(string path)
        {

            return "";
        }

        public string GetSinglePage(string path,int page)
        {
            string res = string.Empty;
            using (var reader = new PdfReader(path))
            {
                res = PdfTextExtractor.GetTextFromPage(reader, page);

                reader.Close();
            }

            return res;
        }
    }
}
