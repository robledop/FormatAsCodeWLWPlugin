using System.Windows.Forms;
using WindowsLive.Writer.Api;

namespace FormatAsCodeWLWPlugin
{
    [WriterPlugin("EA4F0284-6C79-4D86-B556-A2029CB577D4", "Format as Code",PublisherUrl = "http://pazotto.com")]
    [InsertableContentSource("Format as Code")]
    public class Plugin : ContentSource
    {
        public override DialogResult CreateContent(IWin32Window dialogOwner, ref string content)
        {
            string end = null;
            if (content.EndsWith(" "))
            {
                end = " ";
            }

            string start = null;
            if (content.StartsWith(" "))
            {
                start = " ";
            }

            if (!string.IsNullOrEmpty(content))
                content = string.Format(start + "<code>{0}</code>" + end, content.Trim());
            return DialogResult.OK;
        }
    }
}
