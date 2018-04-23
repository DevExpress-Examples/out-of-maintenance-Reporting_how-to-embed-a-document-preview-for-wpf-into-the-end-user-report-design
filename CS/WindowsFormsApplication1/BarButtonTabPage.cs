using System.Drawing;
using DevExpress.XtraBars;
using DevExpress.XtraReports.Design;
using DevExpress.XtraReports.UserDesigner;

namespace Common {
    class BarButtonTabPage : XtraTabControl.TabPage {
        readonly BarButtonItem barButtonItem;
        private WindowsFormsApplication1.WPF.WpfReportPreviewUserControl wpfReportPreviewUserControl;
        private string Caption;
        private ReportCommand reportCommand;

        public BarButtonTabPage(WindowsFormsApplication1.WPF.WpfReportPreviewUserControl wpfReportPreviewUserControl, string Caption, BarButtonItem button, ReportCommand reportCommand)
            : base(wpfReportPreviewUserControl, Caption, reportCommand) {
            this.wpfReportPreviewUserControl = wpfReportPreviewUserControl;
            this.Caption = Caption;
            this.reportCommand = reportCommand;
            this.barButtonItem = button;
        }
        public override bool Selected {
            get { return base.Selected; }
            set {
                if (base.Selected != value)
                    barButtonItem.Down = value;
                base.Selected = value;
            }
        }
        public override bool Visible {
            get {
                return base.Visible;
            }
            set {
                base.Visible = value;
                barButtonItem.Visibility = value ? BarItemVisibility.Always : BarItemVisibility.Never;
            }
        }
        public override Image Image {
            get { return barButtonItem.Glyph; }
            set { barButtonItem.Glyph = value; }
        }
    }
}