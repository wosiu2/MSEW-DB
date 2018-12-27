using System;
using PdfSharp.Pdf.Content;
using PdfSharp.Pdf.Content.Objects;
using PdfSharp.Pdf.IO;
using System.Linq;
using System.Text;
using MSEWDataBase.Base.Model;
using MSEWDataBase.Manager.PDF;
using MSEWDataBase.Manager.CalculationData;

namespace MSEWDataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = @"D:\Projekty\MSEW DB\471.pdf";

            var pdf =new TestPdfDataManager();

            var s = pdf.GetSinglePage(file, 10).Split('\n');


            var list = new[]{"PROJECT IDENTIFICATION",
                             "SOIL DATA",
                             "Geometry and Surcharge loads",
                             "ANALYSIS: CALCULATED FACTORS",
                             "BEARING CAPACITY for GIVEN LAYOUT",
                             "RESULTS for STRENGTH",
                             "RESULTS for PULLOUT"
                             };

            var e = s.Where(x => list.Any(y=>x.Contains(y)));
            var ed = list.Where(x => s.Any(y => y.Contains(x)));
            foreach (var ee in ed)
            {
                Console.Write(ee);
            }
            Console.WriteLine("------------------------------------------");

            foreach (var ee in s)
            {
                Console.WriteLine(ee);
            }

            var ll = new LayersFactorsManager();
            var layer=ll.ResovleSingle("");
            var ddasd = ll.Resolve(s);
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

            Console.ReadKey();
        }
    }
}
