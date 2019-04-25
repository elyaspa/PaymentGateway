using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AuthorizeNet.Api.Contracts.V1;
using AuthorizeNet.Api.Controllers;
using AuthorizeNet_Payments;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using PaymentGateway.Module.BusinessObjects;

namespace PaymentGateway.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out https://documentation.devexpress.com/eXpressAppFramework/clsDevExpressExpressAppViewControllertopic.aspx.
    public partial class PaymentController : ViewController
    {
        public PaymentController()
        {
            InitializeComponent();
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }
        protected override void OnActivated()
        {
            base.OnActivated();
            // Perform various tasks depending on the target View.
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
            // Access and customize the target View control.
        }
        protected override void OnDeactivated()
        {
            // Unsubscribe from previously subscribed events and release other references and resources.
            base.OnDeactivated();
        }

        private void SaDoPayment_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
           TransactionsManager Transaction = (TransactionsManager)View.CurrentObject;
            var LoginId = "8AN32zkc";
            var TransactionKey = "796crqw5ESA5T92s";
            var TotalDue=Transaction.TotalDue;
               var cardInfo = new AuthorizeNet_Payments.CreditCardInfo()
               {
                   CardCode = Transaction.CardCode,
                   CardNumber = Transaction.CardNumber,
                   ExpirationDate = Transaction.ExpirationDate
               };            

            Tuple<ANetApiResponse, createTransactionController> response = null;
            response = CreateChasePayTransaction.Run(LoginId, TransactionKey, cardInfo, TotalDue, AuthorizeNet_Payments.Environment.SANDBOX);

        }
    }
}
