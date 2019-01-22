using MSEWDataBase.Base.Manager.PDF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSEWDataBase.Manager.PDF
{
    public class PdfSharpDataManager : IPdfDataManager
    {
        public string GetAllPages(string path)
        {
            throw new NotImplementedException();
        }

        public string GetSinglePage(string path, int page)
        {
            /*
                    using(var document = PdfReader.Open(file, PdfDocumentOpenMode.ReadOnly))
                    {
                        var a = document.Pages[0];

                        var content=ContentReader.ReadContent(a);
                        var sb = new StringBuilder();
                        foreach(var el in content)
                        {


                            if(el is COperator)
                            {
                                var oper = (COperator)el;
                                if (oper.OpCode.OpCodeName == OpCodeName.Tj || oper.OpCode.OpCodeName == OpCodeName.TJ)
                                {

                                    foreach (var seq in oper.Operands)
                                    {
                                        if (seq is CSequence)
                                        {
                                            var seq1 = (CSequence)seq;
                                            foreach (var str in seq1)
                                            {
                                                if (str is CString)
                                                {
                                                    var str1 = (CString)str;
                                                    sb.Append(str1.Value);

                                                }
                                            }
                                        }
                                    }
                                }


                                //
                            }

                        }
                        Console.WriteLine(sb);
                    }*/

            return "";
        }
    }
}
