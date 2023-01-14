using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronicle
{
    public static class IconExtension
    {
        public static string ToFontAwesome(this ListIconType type)
        {
            switch (type)
            {
                // Return notes icon for list item
                case ListIconType.Notes:
                    return "\uf56b";

                // Return books icon for list item
                case ListIconType.Books:
                    return "\uf02a";

                // If there's nothing to do, return null
                default:
                    return null;
            }
        }
    }
}
