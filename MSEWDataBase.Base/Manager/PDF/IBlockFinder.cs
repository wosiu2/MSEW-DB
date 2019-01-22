
using System.Collections.Generic;

namespace MSEWDataBase.Base.Manager.PDF
{
    public interface IBlockFinder
    {
        IDictionary<string, IEnumerable<string>> ResolveBlocks(string data,string[] headers);
    }
}
