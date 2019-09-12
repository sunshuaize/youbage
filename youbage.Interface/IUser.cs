using System;
using System.Collections.Generic;
using System.Text;
using youbage.Entities.Entities;

namespace youbage.Interface
{
    /// <summary>
    /// 在这里继承父类接口，当前接口已经具有父类接口的动作（普通的增删改查），在这里可以自己【自定义】其他方法复杂一点的逻辑方法
    /// </summary>
    public interface IUser:IRepositoriesBase<user>
    {

    }
}
