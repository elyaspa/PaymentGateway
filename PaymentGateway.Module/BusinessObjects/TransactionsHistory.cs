using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.ComponentModel;
using System.Linq;

namespace PaymentGateway.Module.BusinessObjects
{
    
    public class TransactionsHistory : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).



        DateTime expirationDate;
        string cardCode;
        string cardNumber;
        DateTime payedDate;
        TransactionsManager transaction;

        public TransactionsHistory(Session session)
            : base(session)
        {
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        [ModelDefault("AllowEdit ", "alse")]
        [Association("PaymentHistory-ListOfPayments")]
        public TransactionsManager Transaction
        {
            get => transaction;
            set => SetPropertyValue(nameof(Transaction), ref transaction, value);
        }

        [ModelDefault("AllowEdit", "False")]
        public DateTime PayedDate
        {
            get => payedDate;
            set => SetPropertyValue(nameof(PayedDate), ref payedDate, value);
        }
        [ModelDefault("AllowEdit", "False")]
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
        decimal amountPayed;
       
        public decimal AmountPayed
        {
            get => totalDue;
            set => SetPropertyValue(nameof(AmountPayed), ref amountPayed, value);
        }
    }
}