using System.Windows.Controls;
using DevExpress.XtraReports;

namespace WindowsFormsApplication1.WPF {
    public partial class WpfReportPreviewControl : UserControl {
        public IReport Report { 
            get { return ((ReportPreviewModel)preview.Model).Report; }
            set { ((ReportPreviewModel)preview.Model).Report = value; }
        }
        public WpfReportPreviewControl() {
            InitializeComponent();
        }
    }
}
