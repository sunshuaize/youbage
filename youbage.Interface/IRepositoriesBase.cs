using System;

namespace youbage.Interface
{
    /// <summary>
    ///  服务基础接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepositoriesBase<T> where T: class
    {
        int Add(T entity,bool isSave=true);

        T Find(string id);

        bool Remove(T entity,bool isSave);

        bool Update(T entity,bool isSave);
    }
}
