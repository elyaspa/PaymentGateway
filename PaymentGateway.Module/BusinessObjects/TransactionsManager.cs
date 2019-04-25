using DevExpress.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
//using AuthorizeNet_Payments;
//using AuthorizeNet_Payments.Api.Controllers;
//using AuthorizeNet_Payments.Api.Contracts.V1;
//using AuthorizeNet_Payments.Api.Controllers.Bases;
using System;
using DevExpress.ExpressApp.Model;
using System.ComponentModel;

namespace PaymentGateway.Module.BusinessObjects
{
    [DefaultClassOptions] 
    [DefaultProperty("CardNumber")]
    public class TransactionsManager : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public TransactionsManager(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            PayedDate=System.DateTime.UtcNow;
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        DateTime expirationDate;
        string cardCode;
        string cardNumber;
        DateTime payedDate;
        [Association("PaymentHistory-ListOfPayments")]
        public XPCollection<TransactionsHistory> TransactionHistory
        {
            get
            {
                return GetCollection<TransactionsHistory>(nameof(TransactionHistory));
            }
        }
     
        [ModelDefault("AllowEdit", "False")]
        public DateTime PayedDate
        {
            get => payedDate;
            set => SetPropertyValue(nameof(PayedDate), ref payedDate, value);
        }
        
        public DateTime ExpirationDate
        {
            get => expirationDate;
            set => SetPropertyValue(nameof(ExpirationDate), ref expirationDate, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string CardCode
        {
            get => cardCode;
            set => SetPropertyValue(nameof(CardCode), ref cardCode, value);
        }
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string CardNumber
        {
            get => cardNumber;
            set => SetPropertyValue(nameof(CardNumber), ref cardNumber, value);
        }

        PaymentType type;
        public PaymentType Type
        {
            get
            {
                return type;
            }
            set
            {
                SetPropertyValue(nameof(Type), ref type, value);
            }
        }
       
        decimal totalDue;

        public decimal TotalDue
        {
            get => totalDue;
            set => SetPropertyValue(nameof(TotalDue), ref totalDue, value);
        }
        //TODO How to use Authorize CreditCardInfo 
        
        //public void DoPayment(CreditCardInfo cardData)
        //{
        //    var LoginId = "8AN32zkc";
        //    var TransactionKey = "796crqw5ESA5T92s";

        //   var cardInfo = new AuthorizeNet_Payments.CreditCardInfo()
        //    {
        //        CardCode = cardData.CardCode,
        //        CardNumber = cardData.CardNumber,
        //        ExpirationDate = cardData.ExpirationDate
        //    };
        //    var transactionId = string.Empty;
        //    Tuple<ANetApiResponse, createTransactionController> response = null;
        //    response = CreateChasePayTransaction.Run(LoginId, TransactionKey, cardInfo, TotalDue, AuthorizeNet_Payments.Environment.SANDBOX);

        //}
        //TODO How to use Authorize CreditCardInfo
        //[Action(Caption = "Make a Refund")]
        //public void RefundPayment(CreditCardInfo cardData, string TransId)
        //{
        //    var LoginId = "8AN32zkc";
        //    var TransactionKey = "796crqw5ESA5T92s";
        //    var TransactionID = TransId;
        //    var cardInfo = new AuthorizeNet_Payments.CreditCardInfo()
        //    {
        //        CardCode = cardData.CardCode,
        //        CardNumber = cardData.CardNumber,
        //        ExpirationDate = cardData.ExpirationDate
        //    };
           
        //    Tuple<ANetApiResponse, createTransactionController> response = null;
        //    response = RefundTransaction.Run(LoginId, TransactionKey, TotalDue, TransactionID, AuthorizeNet_Payments.Environment.SANDBOX, cardInfo);
        //}

        //[Action(Caption = "Cancel Transaction")]
        //public void VoidTransact(string TransactionId)
        //{
        //    var LoginId = "8AN32zkc";
        //    var TransactionKey = "796crqw5ESA5T92s";
        //    Tuple<ANetApiResponse, createTransactionController> response = null;
        //    response = VoidTransaction.Run(LoginId, TransactionKey, TransactionId, AuthorizeNet_Payments.Environment.SANDBOX);

        //}


    }
    public enum PaymentType
    {
        Full = 1,
        Partial = 2,
    }
    
}

