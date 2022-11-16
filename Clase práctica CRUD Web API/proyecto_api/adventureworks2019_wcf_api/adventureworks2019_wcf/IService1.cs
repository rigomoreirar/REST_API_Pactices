using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace adventureworks2019_wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        List<stpr_DepartmentList_Result> DepartmentLista();

        [OperationContract]
        stpr_DepartmentList_Result DepartmentDatos(short DepartmentID);

        [OperationContract]
        stpr_DepartmentSave_Result DepartmentSave(int DepartmentID, string Name, string GroupName);
        [OperationContract]
        List<stpr_CreditCardList_Result> CreditCardLista();

        [OperationContract]
        stpr_CreditCardList_Result CreditCardDatos(int creditCardId);

        [OperationContract]
        stpr_CreditCardSave_Result CreditCardSave(int CreditCardId, string CardType, string CardNumber, int ExpMonth, int ExpYear);
        [OperationContract]
        List<stpr_ProductCategoryList_Result> ProductCategoryLista();

        [OperationContract]
        stpr_ProductCategoryList_Result ProductCategoryDatos(int ProductCategoryId);

        [OperationContract]
        stpr_ProductCategorySave_Result ProductCategorySave(int ProductCategoryId, string Name);
    }
}
