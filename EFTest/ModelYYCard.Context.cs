﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class YYCardEntitiesTwo : DbContext
    {
        public YYCardEntitiesTwo()
            : base("name=YYCardEntitiesTwo")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AreaInfo> AreaInfoes { get; set; }
        public virtual DbSet<Card> Cards { get; set; }
        public virtual DbSet<CardInfo> CardInfoes { get; set; }
        public virtual DbSet<CardStock> CardStocks { get; set; }
        public virtual DbSet<CardType> CardTypes { get; set; }
        public virtual DbSet<CompanyInfo> CompanyInfoes { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<CustomerType> CustomerTypes { get; set; }
        public virtual DbSet<DeliveryInfo> DeliveryInfoes { get; set; }
        public virtual DbSet<Flow> Flows { get; set; }
        public virtual DbSet<FlowNode> FlowNodes { get; set; }
        public virtual DbSet<InvoiceInfo> InvoiceInfoes { get; set; }
        public virtual DbSet<ONCardRelation> ONCardRelations { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
        public virtual DbSet<OrderInfo> OrderInfoes { get; set; }
        public virtual DbSet<PayInfo> PayInfoes { get; set; }
        public virtual DbSet<ProcLog> ProcLogs { get; set; }
        public virtual DbSet<RoleUserRelation> RoleUserRelations { get; set; }
        public virtual DbSet<SiteMail> SiteMails { get; set; }
        public virtual DbSet<StockProc> StockProcs { get; set; }
        public virtual DbSet<StockProcDetail> StockProcDetails { get; set; }
        public virtual DbSet<Task> Tasks { get; set; }
        public virtual DbSet<TaskHandle> TaskHandles { get; set; }
        public virtual DbSet<UserInfo> UserInfoes { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }
    
        public virtual ObjectResult<Proc_TestInqCustomer_Result> Proc_TestInqCustomer()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Proc_TestInqCustomer_Result>("Proc_TestInqCustomer");
        }
    
        public virtual int Proc_TestWithInputOutPut(Nullable<int> customerId, ObjectParameter rowCount)
        {
            var customerIdParameter = customerId.HasValue ?
                new ObjectParameter("customerId", customerId) :
                new ObjectParameter("customerId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_TestWithInputOutPut", customerIdParameter, rowCount);
        }
    
        public virtual int Proc_TestWithReturnValue(Nullable<int> customerId)
        {
            var customerIdParameter = customerId.HasValue ?
                new ObjectParameter("customerId", customerId) :
                new ObjectParameter("customerId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_TestWithReturnValue", customerIdParameter);
        }
    
        public virtual int Proc_TestWithReturnValue2(Nullable<int> customerId)
        {
            var customerIdParameter = customerId.HasValue ?
                new ObjectParameter("customerId", customerId) :
                new ObjectParameter("customerId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_TestWithReturnValue2", customerIdParameter);
        }
    
        public virtual int Proc_TestAreaInfoIns(string name, string creator)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var creatorParameter = creator != null ?
                new ObjectParameter("Creator", creator) :
                new ObjectParameter("Creator", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_TestAreaInfoIns", nameParameter, creatorParameter);
        }
    
        public virtual int Proc_TestAreInfoDel(Nullable<int> areaId)
        {
            var areaIdParameter = areaId.HasValue ?
                new ObjectParameter("areaId", areaId) :
                new ObjectParameter("areaId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_TestAreInfoDel", areaIdParameter);
        }
    
        public virtual int Proc_TestAreInfoUpd(Nullable<int> areaId, string updName)
        {
            var areaIdParameter = areaId.HasValue ?
                new ObjectParameter("areaId", areaId) :
                new ObjectParameter("areaId", typeof(int));
    
            var updNameParameter = updName != null ?
                new ObjectParameter("updName", updName) :
                new ObjectParameter("updName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Proc_TestAreInfoUpd", areaIdParameter, updNameParameter);
        }
    }
}
