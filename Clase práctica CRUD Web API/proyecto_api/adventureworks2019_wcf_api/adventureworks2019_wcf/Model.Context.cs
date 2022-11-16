﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace adventureworks2019_wcf
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class AdventureWorks2019Entities : DbContext
    {
        public AdventureWorks2019Entities()
            : base("name=AdventureWorks2019Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<stpr_DepartmentList_Result> stpr_DepartmentList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<stpr_DepartmentList_Result>("stpr_DepartmentList");
        }
    
        public virtual ObjectResult<stpr_DepartmentSave_Result> stpr_DepartmentSave(Nullable<int> departmentId, string name, string group)
        {
            var departmentIdParameter = departmentId.HasValue ?
                new ObjectParameter("DepartmentId", departmentId) :
                new ObjectParameter("DepartmentId", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var groupParameter = group != null ?
                new ObjectParameter("Group", group) :
                new ObjectParameter("Group", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<stpr_DepartmentSave_Result>("stpr_DepartmentSave", departmentIdParameter, nameParameter, groupParameter);
        }
    
        public virtual ObjectResult<stpr_ProductCategoryList_Result> stpr_ProductCategoryList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<stpr_ProductCategoryList_Result>("stpr_ProductCategoryList");
        }
    
        public virtual ObjectResult<stpr_ProductCategorySave_Result> stpr_ProductCategorySave(Nullable<int> productCategoryId, string name)
        {
            var productCategoryIdParameter = productCategoryId.HasValue ?
                new ObjectParameter("ProductCategoryId", productCategoryId) :
                new ObjectParameter("ProductCategoryId", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<stpr_ProductCategorySave_Result>("stpr_ProductCategorySave", productCategoryIdParameter, nameParameter);
        }
    
        public virtual ObjectResult<stpr_CreditCardList_Result> stpr_CreditCardList()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<stpr_CreditCardList_Result>("stpr_CreditCardList");
        }
    
        public virtual ObjectResult<stpr_CreditCardSave_Result> stpr_CreditCardSave(Nullable<int> creditCardId, string cardType, string cardNumber, Nullable<int> expMonth, Nullable<int> expYear)
        {
            var creditCardIdParameter = creditCardId.HasValue ?
                new ObjectParameter("CreditCardId", creditCardId) :
                new ObjectParameter("CreditCardId", typeof(int));
    
            var cardTypeParameter = cardType != null ?
                new ObjectParameter("CardType", cardType) :
                new ObjectParameter("CardType", typeof(string));
    
            var cardNumberParameter = cardNumber != null ?
                new ObjectParameter("CardNumber", cardNumber) :
                new ObjectParameter("CardNumber", typeof(string));
    
            var expMonthParameter = expMonth.HasValue ?
                new ObjectParameter("ExpMonth", expMonth) :
                new ObjectParameter("ExpMonth", typeof(int));
    
            var expYearParameter = expYear.HasValue ?
                new ObjectParameter("ExpYear", expYear) :
                new ObjectParameter("ExpYear", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<stpr_CreditCardSave_Result>("stpr_CreditCardSave", creditCardIdParameter, cardTypeParameter, cardNumberParameter, expMonthParameter, expYearParameter);
        }
    }
}
