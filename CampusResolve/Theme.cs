using System.Drawing;

namespace CampusResolve
{
    public static class Theme
    {
        public static readonly Color DeepNavy = ColorTranslator.FromHtml("#02000D");
        public static readonly Color DarkBlue = ColorTranslator.FromHtml("#07203F");
        public static readonly Color LightBeige = ColorTranslator.FromHtml("#EBDED4");
        public static readonly Color SoftPeach = ColorTranslator.FromHtml("#D9AA90");
        public static readonly Color MutedBrown = ColorTranslator.FromHtml("#A65E46");

        public static readonly Font HeaderFont = new Font("Segoe UI", 16, FontStyle.Bold);
        public static readonly Font SubHeaderFont = new Font("Segoe UI", 12, FontStyle.Bold);
        public static readonly Font ContentFont = new Font("Segoe UI", 10, FontStyle.Regular);
        public static readonly Font ButtonFont = new Font("Segoe UI", 10, FontStyle.Bold);
    }
}
