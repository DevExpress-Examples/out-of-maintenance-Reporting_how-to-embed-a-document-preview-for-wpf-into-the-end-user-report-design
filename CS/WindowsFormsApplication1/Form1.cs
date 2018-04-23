using System.Drawing;
using System.Reflection;
using Common;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.Design;
using DevExpress.XtraReports.UI;
using DevExpress.XtraReports.UserDesigner;
using WindowsFormsApplication1.WPF;

namespace WindowsFormsApplication1 {
    public partial class Form1 : XtraForm {
        ReportTabControl reportTabControl;
        readonly WpfReportPreviewUserControl wpfReportPreviewUserControl = new WpfReportPreviewUserControl();
        public Form1() {
            InitializeComponent();

            // Hanlde the DesignerHostLoaded event of a Design Panel, 
            // to add a new page to the ReportTabControl for showing Document Preview.
            xrDesignPanel1.DesignerHostLoaded += xrDesignPanel1_DesignerHostLoaded;
            xrDesignPanel1.OpenReport(new XtraReport());

        }
        void xrDesignPanel1_DesignerHostLoaded(object sender, DesignerLoadedEventArgs e) {
            reportTabControl = (ReportTabControl)e.DesignerHost.GetService(typeof(ReportTabControl));
            var logic = reportTabControl.GetProperty<TabControlLogic>("Logic");
            var bar = logic.GetProperty<Bar>("StatusBar");
            AddTabPage(bar);
        }

        private void AddTabPage(Bar bar) {
            const string Caption = "WPF Preview";

            var button = new BarButtonItem(bar.Manager, Caption) {
                ButtonStyle = BarButtonStyle.Check,
                PaintStyle = BarItemPaintStyle.CaptionGlyph,
                GroupIndex = 1,
                Glyph = Bitmap.FromStream(Assembly.GetExecutingAssembly().GetManifestResourceStream("WindowsFormsApplication1.WpfPreview.ico"))
            };
            bar.InsertItem(bar.ItemLinks[reportTabControl.Pages.Count], button);

            var page = new BarButtonTabPage(wpfReportPreviewUserControl, Caption, button, ReportCommand.None);
            reportTabControl.AddPage(wpfReportPreviewUserControl, page);

            // Handle the WPF Preview BarButtonItem click event
            button.ItemClick += button_ItemClick;
        }

        void button_ItemClick(object sender, ItemClickEventArgs e) {
            const int WpfPreviewPageIndex = 4;
            reportTabControl.SelectedIndex = WpfPreviewPageIndex;
            if (wpfReportPreviewUserControl.Report != null)
                wpfReportPreviewUserControl.Report.Dispose();
            var report = xrDesignPanel1.Report.Clone();
            report.CreateDocument(true);
            wpfReportPreviewUserControl.Report = report;
        }
    }
}