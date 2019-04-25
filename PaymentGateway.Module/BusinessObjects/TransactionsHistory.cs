using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;
using System;
using System.ComponentModel;
using System.Linq;

namespace PaymentGateway.Module.BusinessObjects
{
    [DefaultClassOptions]
    [DefaultProperty("Name")]
    public class TransactionsHistory : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).



        string name;
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

        [ModelDefault("AllowEdit ","False")]
        [Association("PaymentHistory-ListOfPayments")]
        public TransactionsManager Transaction
        {
            get => transaction;
            set => SetPropertyValue(nameof(Transaction), ref transaction, value);
        }
        
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Name
        {
            get => name;
            set => SetPropertyValue(nameof(Name), ref name, value);
        }
    }
}