using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using Mahan.Tralus.Stations.BusinessModel;

namespace Mahan.Tralus.Stations.Module.Controllers
{
    // For more typical usage scenarios, be sure to check out http://documentation.devexpress.com/#Xaf/clsDevExpressExpressAppViewControllertopic.
    public partial class ReportViewListFilter : ViewController<ListView>
    {
        //private FlightReportFilter flightReportFilter;
        public ReportViewListFilter()
        {
            InitializeComponent();
            TargetObjectType = typeof(FlightReport);
            popupWindowShowAction.ActionMeaning = ActionMeaning.Unknown;
            popupWindowShowAction.ConfirmationMessage = string.Empty;
            //popupWindowShowAction.Executing += PopupWindowShowAction_Executing;
            //TargetViewType = ViewType.ListView;
            // Target required Views (via the TargetXXX properties) and create their Actions.
        }

        private void PopupWindowShowAction_Executing(object sender, System.ComponentModel.CancelEventArgs e)
        {
           // e.Cancel = true;
            //var filter = (FlightReportFilter)e.;
           // View.CollectionSource.Criteria["TestCriteria"] = new BinaryOperator("FlightLeg.FlightNumber.FullFlightNumber", "W5 1033", BinaryOperatorType.Equal);
        }

        protected override void OnActivated()
        {
            base.OnActivated();
            
            //flightReportFilter = ObjectSpace.CreateObject<FlightReportFilter>();
            

            
            
            
            //View.InsertItem(0, view.Items);  
            //var layoutControl = View.LayoutManager.Container as LayoutControl;
            
            // Perform various tasks depending on the target View.
        }

        private void PopupWindowShowAction_ProcessCreatedView(object sender, ActionBaseEventArgs e)
        {
            
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

        private void popupWindowShowAction_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            PopupWindowShowAction action = (PopupWindowShowAction)sender;
            IObjectSpace objectSpace = action.Application.CreateObjectSpace(typeof(FlightReportFilter));
            string detailViewId = action.Application.FindDetailViewId(typeof(FlightReportFilter));

            FlightReportFilter flightReportFilter = objectSpace.FindObject<FlightReportFilter>(null);
            if (flightReportFilter == null)
            {
                //flightReportFilter = new FlightReportFilter();
                flightReportFilter = objectSpace.CreateObject<FlightReportFilter>();
                
            }

            //if (flightReportFilter == null)
            //{
            //    flightReportFilter = objectSpace.CreateObject<FlightReportFilter>();
            //    //message.Text = ActionsDemoStrings.LogTraceHeader + e.Action.Caption + ActionsDemoStrings.LogTraceTail;
            //}
            e.View = action.Application.CreateDetailView(objectSpace, flightReportFilter);
            
            
        }

        private void PopupWindowShowAction_ExecuteCanceled(object sender, DevExpress.ExpressApp.Actions.ActionBaseEventArgs e)
        {
            
        }

        private void PopupWindowShowAction_Cancel(object sender, System.EventArgs e)
        {
            
        }


        private void popupWindowShowAction_Execute(object sender, PopupWindowShowActionExecuteEventArgs e)
        {
            var filter = (FlightReportFilter)e.PopupWindowViewCurrentObject;
            if (!string.IsNullOrWhiteSpace(filter.FlightNumber))
            {
                View.CollectionSource.Criteria["FlightNumber"] = new BinaryOperator("FlightLeg.FlightNumber.FullFlightNumber", string.Format("%{0}%", filter.FlightNumber), BinaryOperatorType.Like);
            }
            else
            {
                View.CollectionSource.Criteria["FlightNumber"] = null;
            }

            if (filter.StartDate.DateTimeUtc != null && filter.EndDate.DateTimeUtc != null)
            {
                View.CollectionSource.Criteria["FlightDate"] = new BetweenOperator("FlightLeg.ScheduledDepartureDateTime.DateTimeUtc", filter.StartDate.DateTimeUtc, filter.EndDate.DateTimeUtc);
            }
            else
            {
                View.CollectionSource.Criteria["FlightDate"] = null;
            }

            if(filter.AircraftRegister != null)
            {
                View.CollectionSource.Criteria["AircraftRegister"] = new BinaryOperator("FlightLeg.AircraftRegister", filter.AircraftRegister, BinaryOperatorType.Equal);
            }
            else
            {
                View.CollectionSource.Criteria["AircraftRegister"] = null;
            }

            if (filter.DepartureAirport != null)
            {
                View.CollectionSource.Criteria["DepartureAirport"] = new BinaryOperator("FlightLeg.AircraftRegister", filter.DepartureAirport, BinaryOperatorType.Equal);
            }
            else
            {
                View.CollectionSource.Criteria["DepartureAirport"] = null;
            }

            if (filter.ArrivalAirport != null)
            {
                View.CollectionSource.Criteria["ArrivalAirport"] = new BinaryOperator("FlightLeg.ArrivalAirport", filter.ArrivalAirport, BinaryOperatorType.Equal);
            }
            else
            {
                View.CollectionSource.Criteria["ArrivalAirport"] = null;
            }

            
        }
    }
}
