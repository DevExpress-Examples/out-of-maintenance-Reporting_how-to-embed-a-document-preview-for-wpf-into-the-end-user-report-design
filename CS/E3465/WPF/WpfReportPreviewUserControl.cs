using System.Windows.Forms;
using DevExpress.XtraReports;

namespace E3465.WPF {
    public partial class WpfReportPreviewUserControl : UserControl {
        public IReport Report {
            get { return wpfReportPreviewControl1.Report; }
            set { wpfReportPreviewControl1.Report = value; }
        }
        public WpfReportPreviewUserControl() {
            InitializeComponent();
        }
    }
}
