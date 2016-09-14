//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EFTest
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public Customer()
        {
            this.OrderInfoes = new HashSet<OrderInfo>();
        }
    
        public int ID { get; set; }
        public int CustomerType { get; set; }
        public Nullable<int> CustomerBelong { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public Nullable<int> Area { get; set; }
        public string AreaInfo { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string Fax { get; set; }
        public string ZipCode { get; set; }
        public string Industry { get; set; }
        public string CustomerSource { get; set; }
        public string ContactPerson { get; set; }
        public string ContactPhone { get; set; }
        public string ContactMobile { get; set; }
        public string ReceivePerson { get; set; }
        public string ReceivePhone { get; set; }
        public string ReceiveMobile { get; set; }
        public string ReceiveAddr { get; set; }
        public string ReceiveZip { get; set; }
        public Nullable<int> AppointedCardPerson { get; set; }
        public string CustomerRemark { get; set; }
        public int IsDel { get; set; }
        public string Creator { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string Revisor { get; set; }
        public Nullable<System.DateTime> ReviseTime { get; set; }
    
        public virtual CustomerType CustomerType1 { get; set; }
        public virtual ICollection<OrderInfo> OrderInfoes { get; set; }
    }
}
