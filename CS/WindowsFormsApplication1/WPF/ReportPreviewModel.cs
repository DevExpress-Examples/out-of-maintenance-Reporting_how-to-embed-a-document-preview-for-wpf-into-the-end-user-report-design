using DevExpress.Xpf.Printing;

namespace WindowsFormsApplication1.WPF {
    public class ReportPreviewModel : XtraReportPreviewModel {
        protected override bool CanPageSetup(object parameter) {
            return false;
        }
        protected override bool CanScale(object parameter) {
            return false;
        }
    }
}
