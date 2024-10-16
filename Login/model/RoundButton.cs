using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Login.model
{
    public class RoundButton : Button
    {
        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern nint CreateRoundRectRgn(
        int nLeftRect, // X-coordinate of upper-left corner or padding at start
        int nTopRect,  // Y-coordinate of upper-left corner or padding at the top of the textbox
        int nRightRect, // X-coordinate of lower-right corner or Width of the object
        int nBottomRect, // Y-coordinate of lower-right corner or Height of the object
        int nheightRect, // height of ellipse 
        int nweightRect // width of ellipse
    );
        private int _borderRadius = 45; // Radius for the rounded corners
        private Color _borderColor = Color.Gray; // Color for the border
        private int _borderWidth = 2; // Width of the border

        public RoundButton()
        {
            Padding = new Padding(10, 5, 10, 5); // Add padding to avoid text clipping
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, _borderRadius, _borderRadius));
            Invalidate(); // Trigger a repaint to redraw the border
        }
    }
}
