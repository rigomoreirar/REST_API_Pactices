using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace adventureworks2019_wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        AdventureWorks2019Entities db = new AdventureWorks2019Entities();
        // Este metodo trae las 100 primeras rows
        public List<stpr_DepartmentList_Result> DepartmentLista()
        {
            return db.stpr_DepartmentList().ToList();
        }
        // Este metodo trae una row de las 100 primeras con el ID = CreditCardId
        public stpr_DepartmentList_Result DepartmentDatos(short departmentID)
        {
            return (from c in db.stpr_DepartmentList() where c.DepartmentID.Equals(departmentID) select c).FirstOrDefault();
        }
        // Guarda o Edita una row
        public stpr_DepartmentSave_Result DepartmentSave(int DepartmentID, string Name, string GroupName)
        {
            return db.stpr_DepartmentSave(DepartmentID, Name, GroupName).FirstOrDefault();
        }

        public List<stpr_CreditCardList_Result> CreditCardLista()
        {
            return db.stpr_CreditCardList().ToList();
        }
        // Este metodo trae una row de las 100 primeras con el ID = CreditCardId
        public stpr_CreditCardList_Result CreditCardDatos(int creditCardId)
        {
            return (from c in db.stpr_CreditCardList() where c.CreditCardID.Equals(creditCardId) select c).FirstOrDefault();
        }
        // Guarda o Edita una row
        public stpr_CreditCardSave_Result CreditCardSave(int CreditCardId, string CardType, string CardNumber, int ExpMonth, int ExpYear)
        {
            return db.stpr_CreditCardSave(CreditCardId, CardType, CardNumber, ExpMonth, ExpYear).FirstOrDefault();
        }

        public List<stpr_ProductCategoryList_Result> ProductCategoryLista()
        {
            return db.stpr_ProductCategoryList().ToList();
        }
        // Este metodo trae una row de las 100 primeras con el ID = CreditCardId
        public stpr_ProductCategoryList_Result ProductCategoryDatos(int ProductCategoryId)
        {
            return (from c in db.stpr_ProductCategoryList() where c.ProductCategoryID.Equals(ProductCategoryId) select c).FirstOrDefault();
        }
        // Guarda o Edita una row
        public stpr_ProductCategorySave_Result ProductCategorySave(int ProductCategoryId, string Name)
        {
            return db.stpr_ProductCategorySave(ProductCategoryId, Name).FirstOrDefault();
        }
    }
}
