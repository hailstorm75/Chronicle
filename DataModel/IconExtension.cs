using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronicle
{
    public static class IconExtension
    {
        public static string ToFontAwesome(this IconType type)
        {
            switch (type)
            {
                // Return notes icon
                case IconType.Notes:
                    return "\uf249";

                // Return books icon
                case IconType.Books:
                    return "\uf02d";

                // Return picture icon
                case IconType.Calendar:
                    return "\uf783";

                // Return share icon
                case IconType.Share:
                    return "\uf1e0";

                // Return settings icon
                case IconType.Settings:
                    return "\uf013";

                // Return trash icon
                case IconType.Trash:
                    return "\uf2ed";

                // If there's nothing to do, return null
                default:
                    return null;
            }
        }
    }
}
