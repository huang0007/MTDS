//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace MTDS.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public System.Guid UserID { get; set; }
        public string loginName { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string mobile { get; set; }
        public string telephone { get; set; }
        public Nullable<int> provinceID { get; set; }
        public Nullable<int> AreaID { get; set; }
        public Nullable<int> CountyID { get; set; }
        public string address { get; set; }
        public string remark { get; set; }
        public Nullable<System.DateTime> lastlogintime { get; set; }
        public Nullable<System.Guid> ParentID { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> ModifyTime { get; set; }
        public string ModifyBy { get; set; }
    }
}
