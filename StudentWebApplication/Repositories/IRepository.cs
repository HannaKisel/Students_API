using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
  public interface IRepository<T> where T : class
  {
    IEnumerable<T> GetAll(System.Predicate<T> match);
    IEnumerable<T> GetAll();
    T Find(int id);
    int Add(T obj);
    void Update(T obj);
    void Delete(System.Predicate<T> match);
    //void Delete(T obj);
  }
}
