using System;
using System.Collections.Generic;
using System.Text;
using youbage.Entities;
using youbage.Entities.Entities;
using youbage.Interface;

namespace youbage.Service
{
    /// <summary>
    /// 这里是User的具体实现，SeriveBase已经实现了大部分方法，传入实体即可实现，
    /// 在这里还可以具体实现一些IUser中自定义的动作
    /// </summary>
    public class UserSerive : ServiceBase<user>, IUser
    {
        public UserSerive(youbageDBContext context):base(context)
        {
        }
    }
}
