using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace FControls
{
    class Design
    {
        public static GraphicsPath RoundedRectanglePath(Rectangle bounds, int radius)
        {
            GraphicsPath path = new GraphicsPath();

            // Top Left Arc
            path.AddArc(0, 0, radius, radius, 180, 90);

            // Top Line
            path.AddLine(radius, 0, bounds.Width - radius, 0);

            // Top Right Arc
            path.AddArc(bounds.Width - radius - 1, 0, radius, radius, -90, 90);

            // Right Line
            path.AddLine(bounds.Width - 1, radius, bounds.Width - 1, bounds.Height - radius);

            // Bottom Right Arc
            path.AddArc(bounds.Width - radius - 1, bounds.Height - radius - 1, radius, radius, 0, 90);

            // Bottom Line
            path.AddLine(radius, bounds.Height - 1, bounds.Width - radius, bounds.Height - 1);

            // Bottom Left Arc
            path.AddArc(0, bounds.Height - radius - 1, radius, radius, 90, 90);

            // Left Line
            path.AddLine(0, radius/2, 0, bounds.Height - radius);

            return path;
        }
    }
}
