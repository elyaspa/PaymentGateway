namespace PaymentGateway.Module.Controllers
{
    partial class PaymentController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.SaDoPayment = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            // 
            // SaDoPayment
            // 
            this.SaDoPayment.ActionMeaning = DevExpress.ExpressApp.Actions.ActionMeaning.Accept;
            this.SaDoPayment.Caption = "Do Payment";
            this.SaDoPayment.ConfirmationMessage = "You are about to make a payment";
            this.SaDoPayment.Id = "SaDoPayment";
            this.SaDoPayment.TargetObjectType = typeof(PaymentGateway.Module.BusinessObjects.TransactionsManager);
            this.SaDoPayment.TargetViewType = DevExpress.ExpressApp.ViewType.DetailView;
            this.SaDoPayment.ToolTip = null;
            this.SaDoPayment.TypeOfView = typeof(DevExpress.ExpressApp.DetailView);
            this.SaDoPayment.Execute += new DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(this.SaDoPayment_Execute);
            // 
            // PaymentController
            // 
            this.Actions.Add(this.SaDoPayment);

        }

        #endregion

        private DevExpress.ExpressApp.Actions.SimpleAction SaDoPayment;
    }
}
