using System;
using PdfSharp.Pdf.Content;
using PdfSharp.Pdf.Content.Objects;
using PdfSharp.Pdf.IO;
using System.Linq;
using System.Text;
using MSEWDataBase.Base.Model;
using MSEWDataBase.Manager.PDF;
using MSEWDataBase.Manager.CalculationData;
using MSEWDataBase.Repository;
using MongoDB.Driver;
using MSEWDataBase.Manager;

namespace MSEWDataBase
{
    class Program
    {
        static void Main(string[] args)
        {
            var file = @"D:\Projekty\MSEW DB\471.pdf";

            var pdf =new TestPdfDataManager();

            var s = pdf.GetSinglePage(file, 10).Split('\n');

            var sa =pdf.GetAllPages(file);
            var saSplited = sa.Split('\n');
            var list = new[]{"PROJECT IDENTIFICATION",
                             "SOIL DATA",
                             "Geometry and Surcharge loads",
                             "U N I F O R M   S U R C H A R G E",
                             "OTHER EXTERNAL LOAD(S)",
                             "ANALYSIS: CALCULATED FACTORS",
                             "BEARING CAPACITY for GIVEN LAYOUT",
                             "RESULTS for STRENGTH",
                             "RESULTS for PULLOUT",
                             "REINFORCED SOIL",
                             "RETAINED SOIL",
                             "FOUNDATION SOIL",
                             "LATERAL EARTH PRESSURE COEFFICIENTS"
                             };


            var projectList = new[]{"Title:",
                             "Project Number:",
                             "Designer:"
                             };

            var globalFactors = new[]{"factored bearing load",
                                        "Bearing capacity, CDR =",
                                        "Factored bearing resistance",
                                        "Factored bearing load",
                                     };

            BlockDataManager block = new BlockDataManager();

            var dict = block.ResolveBlocks(sa, list);

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

            var pull= new LayersPulloutManager();
            var factors = new LayersFactorsManager();
            var strength = new LayersStrengthManager();

            var layers = factors.Resolve(dict["ANALYSIS: CALCULATED FACTORS"]);
            layers = pull.Resolve(dict["RESULTS for PULLOUT"], layers);
            layers = strength.Resolve(dict["RESULTS for STRENGTH"], layers);

            var abc = new ProjectDataManager();
            var abcList = abc.GetValidLines(dict["PROJECT IDENTIFICATION"]);

            var asas = new SoilDataManager();

           var rf= asas.Resolve(dict["REINFORCED SOIL"]);
           var ff = asas.Resolve(dict["FOUNDATION SOIL"]);
           var rs = asas.Resolve(dict["RETAINED SOIL"]);

            var dda = new WallGeometryManager();

            var sd=dda.Resolve(dict["Geometry and Surcharge loads"]);

            Console.ReadKey();
        }
    }
}
