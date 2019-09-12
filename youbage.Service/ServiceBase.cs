using System;
using youbage.Entities;
using youbage.Interface;

namespace youbage.Service
{
    /// <summary>
    /// 服务基类
    /// </summary>
    /// <typeparam name="T">要操作的实体</typeparam>
    public class ServiceBase<T> : IRepositoriesBase<T> where T : class
    {
        public youbageDBContext _context;
        public ServiceBase(youbageDBContext context)
        {
            _context = context;
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="entity">实体</param>
        /// <param name="isSave">是否立即保存</param>
        /// <returns>添加的记录数[isSave=true]</returns>
        public virtual int Add(T entity, bool isSave = true)
        {
            _context.Set<T>().Add(entity);
            if (isSave) return _context.SaveChanges();
            else return 0;
        }
        /// <summary>
        /// 根据id查找
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual T Find(string id)
        {
         return  _context.Set<T>().Find(id);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="isSave"></param>
        /// <returns></returns>
        public virtual bool Remove(T entity, bool isSave)
        {
            _context.Set<T>().Remove(entity);
            if (isSave) return _context.SaveChanges() > 0;
            else return false;
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="isSave"></param>
        /// <returns></returns>
        public virtual bool Update(T entity, bool isSave)
        {
            _context.Set<T>().Update(entity);
            if (isSave) return _context.SaveChanges() > 0;
            else return false;
        }
    }
}
