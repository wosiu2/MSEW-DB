
namespace MSEWDataBase.Base.Manager.PDF
{
    public interface IPdfDataManager
    {
        string GetSinglePage(string path,int page);
        string GetAllPages(string path);
                    
    }
}
