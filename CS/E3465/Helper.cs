using System.IO;
using System.Reflection;
using DevExpress.XtraReports.UI;

namespace E3465 {
    public static class Helper {
        public static XtraReport Clone(this XtraReport report){
            using (var ms = new MemoryStream()) {
                report.SaveLayoutToXml(ms);
                ms.Position = 0;
                return XtraReport.FromStream(ms, true);
            }
        }
        public static T GetProperty<T>(this object obj, string propertyName) {
            var field = obj.GetType().GetProperty(propertyName, BindingFlags.Instance | BindingFlags.NonPublic);
            return (T)field.GetValue(obj, null);
        }
    }
}