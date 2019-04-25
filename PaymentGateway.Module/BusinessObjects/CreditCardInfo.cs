//using System;
//using System.Linq;
//using System.Text;
//using DevExpress.Xpo;
//using DevExpress.ExpressApp;
//using System.ComponentModel;
//using DevExpress.ExpressApp.DC;
//using DevExpress.Data.Filtering;
//using DevExpress.Persistent.Base;
//using System.Collections.Generic;
//using DevExpress.ExpressApp.Model;
//using DevExpress.Persistent.BaseImpl;
//using DevExpress.Persistent.Validation;

//namespace PaymentGateway.Module.BusinessObjects
//{ 
//    [DefaultClassOptions]
//    //[ImageName("BO_Contact")]
//    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
//    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
//    //[Persistent("DatabaseTableName")]
//    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
//    public class CreditCardInfo : BaseObject
//    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
//        public CreditCardInfo(Session session)
//            : base(session)
//        {
//        }
//        public override void AfterConstruction()
//        {
//            base.AfterConstruction();
//            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
//        }

//        string number;
//        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
//        [RuleRequiredField(DefaultContexts.Save)]
//        public string Number
//        {
//            get
//            {
//                return number;
//            }
//            set
//            {
//                SetPropertyValue(nameof(Number), ref number, value);
//            }
//        }

//        CardType type;
//        public CardType Type
//        {
//            get
//            {
//                return type;
//            }
//            set
//            {
//                SetPropertyValue(nameof(Type), ref type, value);
//            }
//        }

//        DateTime expDate;
//        [RuleRequiredField(DefaultContexts.Save)]
//        public DateTime ExpDate
//        {
//            get
//            {
//                return expDate;
//            }
//            set
//            {
//                SetPropertyValue(nameof(ExpDate), ref expDate, value);
//            }
//        }



//        private string cardCode;
//        //[XafDisplayName("My display name"), ToolTip("My hint message")]
//        //[ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)]
//        [RuleRequiredField(DefaultContexts.Save)]
//        public string CardCode
//        {
//            get { return cardCode; }
//            set { SetPropertyValue("CardCode", ref cardCode, value); }
//        }

//        //[Action(Caption = "My UI Action", ConfirmationMessage = "Are you sure?", ImageName = "Attention", AutoCommit = true)]
//        //public void ActionMethod() {
//        //    // Trigger a custom business logic for the current record in the UI (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112619.aspx).
//        //    this.PersistentProperty = "Paid";
//        //}
//    }

//    public enum CardType
//    {
//        VISA = 1,
//        MASTERCARD = 2
//    }
//}