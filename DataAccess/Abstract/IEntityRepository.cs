using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    // IEntity veya IEntity den implement edilen bir sınıfla type T kısıtlanır
    // new  () ile T type yerine IEntity yazılamaz.
    public interface IEntityRepository<T> where T:class,IEntity,new ()
    {
        List<T> GetAll(Expression< Func<T,bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);// kategoriye veya urune gore elemanları geri dondurur.
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity); 
    }
}
