//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace HelloWordMvc.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClassInfo
    {
        public ClassInfo()
        {
            this.StudentInfo = new HashSet<StudentInfo>();
        }
    
        public int ClassId { get; set; }
        public string ClassName { get; set; }
    
        public virtual ICollection<StudentInfo> StudentInfo { get; set; }
    }
}
