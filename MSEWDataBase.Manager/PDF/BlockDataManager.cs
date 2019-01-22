using MSEWDataBase.Base.Manager.PDF;
using System.Collections.Generic;
using System.Linq;


namespace MSEWDataBase.Manager.PDF
{
    public class BlockDataManager : IBlockFinder
    {

        public IDictionary<string, IEnumerable<string>> ResolveBlocks(string data,string[] headers)
        {
            var table = new Dictionary<string,IEnumerable<string>>();
            var queue = new Queue<string>();

            var splitedData = data.Split('\n');

            foreach(var line in splitedData)
            {
                if(headers.Any(x=>line.Contains(x)))
                {
                    if (queue.Count != 0)
                    {
                        table.Add(queue.Dequeue(), queue.ToArray());
                        queue.Clear();
                    }
                    queue.Enqueue(headers.Where(x => line.Contains(x)).Single());
                }
                else
                {
                    if(queue.Count != 0) queue.Enqueue(line);
                } 
            }

            if (queue.Count != 0) table.Add(queue.Dequeue(), queue.ToArray());

            return table;
        }
    }
}
