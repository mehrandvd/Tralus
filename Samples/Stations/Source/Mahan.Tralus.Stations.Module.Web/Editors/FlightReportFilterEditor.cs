using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Utils;
using DevExpress.ExpressApp.Web;
using DevExpress.ExpressApp.Web.Editors.ASPx;
using DevExpress.Web;
using Mahan.Tralus.Infrastructure.BusinessModel;
using Mahan.Tralus.Stations.BusinessModel;
using Mahan.Tralus.Stations.BusinessModel;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;


namespace Mahan.Tralus.Stations.Module.Web.Editors
{
    [ListEditor(typeof( FlightReport),true)]
    public class FlightReportFilterEditor : ASPxGridListEditor
    {
        private FlightReportFilter flightReportFilter;

        public FlightReportFilterEditor (IModelListView info) : base(info)
        {
            
        }

        public FlightReportFilter FlightReportFilter
        {
            get
            {
                return flightReportFilter;
            }
        }

        protected override object CreateControlsCore()
        {
            
            var grid = base.CreateControlsCore();
            var objectSapce = ObjectSpace.CreateNestedObjectSpace();
            flightReportFilter = objectSapce.CreateObject<FlightReportFilter>();
            //flightReportFilter = new FlightReportFilter();
            
            string detailViewId = Application.FindDetailViewId(typeof(FlightReportFilter));
            var view = Application.CreateDetailView(objectSapce, flightReportFilter, false);
            
            view.ViewEditMode = ViewEditMode.Edit;
            view.CreateControls();

            //var editor = new DevExpress.ExpressApp.Web.Editors.WebLookupEditorHelper(Application, objectSapce, XafTypesInfo.CastTypeToTypeInfo(typeof(AircraftRegister)),null);
          //  var editor = new ASPxLookupPropertyEditor(typeof(Aircraft), null);
          //  editor.CreateControl();

            var table = RenderHelper.CreateTable();
            var mainViewRow = new TableRow();
            var filterViewRow = new TableRow();
            var mainViewTableCell = new TableCell();
            var filterTableCell = new TableCell();

            mainViewTableCell.Controls.Add((System.Web.UI.Control)grid);
            filterTableCell.Controls.Add((System.Web.UI.Control)view.Control);
            //filterTableCell.Controls.Add((System.Web.UI.Control)editor.Control);

            mainViewRow.Cells.Add(filterTableCell);
            filterViewRow.Cells.Add(mainViewTableCell);

            
            table.Rows.Add(mainViewRow);
            table.Rows.Add(filterViewRow);

            table.Style.Add("width", "auto");
            table.Style.Add("border-spacing", "1px");

            return table;
        }

        
    }
}
