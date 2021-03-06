using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Core.DataAccess
{
    // interface'ler new'lenemez.
    // kısıtlama getirdik. ==> tip olarak sadece entities katmanının concrete klasöründeki referansları almalarını sağladık.
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        // filter = null ==> filtrelemeden tüm datalar gelir.
        // filtre parametresi verilirse filtrelenmiş datalar gelir.
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);        // tek data getirmek için
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
