using System;

namespace youbage.Entities.Entities
{
    public class user
    {
        /// <summary>
        /// 
        /// </summary>
        public user()
        {
        }

        private string _Id;
        /// <summary>
        /// id
        /// </summary>
        public string Id { get { return this._Id; } set { this._Id = value; } }

        private string _Name;
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get { return this._Name; } set { this._Name = value; } }

        private string _Sex;
        /// <summary>
        /// 年龄
        /// </summary>
        public string Sex { get { return this._Sex; } set { this._Sex = value; } }

        private DateTime? _CreateTime;
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? CreateTime { get { return this._CreateTime; } set { this._CreateTime = value; } }

        private DateTime? _LoginTime;
        /// <summary>
        /// 登录时间
        /// </summary>
        public DateTime? LoginTime { get { return this._LoginTime; } set { this._LoginTime = value; } }
    }
}
