using System.Threading.Tasks;

namespace StoreOfBuild.Domain
{
    public interface IUnitOfWork
    {
         //Task Commit();
         Task Commit();
    }
}