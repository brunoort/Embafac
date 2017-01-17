using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Embafac.Pcp.Entidades.Interfaces
{
    /// <summary>
    /// Defines the methods that are required for a Repository
    /// </summary>
    /// <typeparam name="T">Any type of class available in the <see cref="OpendeskDb.Models"/> namespace.</see>
    public interface IRepository<T> : IDisposable where T : class
    {
        bool Create(T entity);
        bool Update(T entity);
        T Read(int id);
        IEnumerable<T> Read();
        IEnumerable<T> Read(Expression<Func<T, bool>> predicate);
        bool Delete(T entity);
    }
}
