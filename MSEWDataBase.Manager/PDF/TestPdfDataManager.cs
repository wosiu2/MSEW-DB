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
            var buldier = new StringBuilder();

            using (var reader = new PdfReader(path))
            {
                for(int i = 0; i < reader.NumberOfPages; i++)
                {
                    buldier.Append(PdfTextExtractor.GetTextFromPage(reader, i+1));
                }

                reader.Close();
            }

            return buldier.ToString();
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
