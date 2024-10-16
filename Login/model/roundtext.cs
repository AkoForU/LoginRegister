using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

public class RoundTextBox : TextBox
{
    [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
    private static extern IntPtr CreateRoundRectRgn(
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

    public RoundTextBox()
    {
        this.BorderStyle = BorderStyle.None; // Hide the default border
        this.Padding = new Padding(10, 5, 10, 5); // Add padding to avoid text clipping
        //this.SetStyle(ControlStyles.UserPaint, true);
    }

    protected override void OnResize(EventArgs e)
    {
        base.OnResize(e);
        this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, _borderRadius, _borderRadius));
        this.Invalidate(); // Trigger a repaint to redraw the border
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        DrawBorder(e.Graphics);
    }

    private void DrawBorder(Graphics g)
    {
        Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
        using (Pen pen = new Pen(_borderColor, _borderWidth))
        using (GraphicsPath path = new GraphicsPath())
        {
            path.AddArc(0, 0, _borderRadius, _borderRadius, 180, 90); // Top left corner
            path.AddArc(this.Width - _borderRadius, 0, _borderRadius-1, _borderRadius, 270, 90); // Top right corner
            path.AddArc(this.Width - _borderRadius-1, this.Height - _borderRadius-10, _borderRadius, _borderRadius, 0, 90); // Bottom right corner
            path.AddArc(0, this.Height - _borderRadius-10, _borderRadius, _borderRadius, 90, 90); // Bottom left corner
            path.CloseFigure();

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.DrawPath(pen, path);
        }
    }
    protected override void WndProc(ref Message m)
    {
        base.WndProc(ref m);
        using (Graphics g = this.CreateGraphics())
        {
            DrawBorder(g);
        }
    }
}
