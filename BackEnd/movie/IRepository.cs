using System.Collections.Generic;
using System.Threading.Tasks;

public interface IRepository<T>
{
    Task<IEnumerable<T>> GetAll();
    Task Delete(long id);
    Task<T> Get(long id);
    Task<T> Update(T t);
    Task<T> Insert(T t);
}