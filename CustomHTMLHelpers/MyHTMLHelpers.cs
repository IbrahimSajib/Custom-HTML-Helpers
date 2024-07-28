using Microsoft.AspNetCore.Mvc.Rendering;

namespace Project_01.CustomHTMLHelpers
{
    public static class MyHTMLHelpers
    {
        public static string ToDateddMMMyyyy(this IHtmlHelper html, DateTime? date)
        {
            return date.HasValue ? date.Value.ToString("dd/MMM/yyyy") : string.Empty;
        }
        
        public static string ToDateddMMyyyy(this IHtmlHelper html, DateTime? date)
        {
            return date.HasValue ? date.Value.ToString("dd/MM/yyyy") : string.Empty;
        }

        public static string ToTimehhmmss(this IHtmlHelper html, DateTime? date)
        {
            return date.HasValue ? date.Value.ToString("hh:mm:ss") : string.Empty;
        }
    }
}
