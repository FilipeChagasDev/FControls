using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace FControls
{

    public class FButton : Control
    {
        public FButton()
        {
            this.FillBrush = new SolidBrush(Color.White);
            this.Width = 100;
            this.Height = 30;
            this.Font = new Font("Verdana", 10);
            this.ForeColor = Color.White;
            this.BorderRadius = 10;

            this.TopColor = Color.FromArgb(250,100,100,100);
            this.BottomColor = Color.FromArgb(250, 50, 50, 50);
            this.MouseEnterTopColor = Color.FromArgb(250, 150, 150, 150);
            this.MouseEnterBottomColor = Color.FromArgb(250, 100, 100, 100);
            this.ClickContourColor = Color.White;
            this.MouseEnterLightness = 50;
            this.GradientFill = true;
            this.MouseEnterMutate = true;
            this.MouseEnterMutation = MouseEnterMutationEnum.ChangeLightness;
        }

        public int BorderRadius { get; set; }

        // ----------------- Colors --------------------

        protected Color _TopColor;
        public Color TopColor
        {
            get { return this._TopColor; }
            set
            {
                this._TopColor = value;
                this.UpdateFillBrush();
            }
        }

        protected Color _BottomColor;
        public Color BottomColor
        {
            get { return this._BottomColor; }
            set
            {
                this._BottomColor = value;
                this.UpdateFillBrush();
            }
        }

        public Color ClickContourColor { get; set; } 

        // ------------- Mouse Enter Colors ---------------
        public Color MouseEnterTopColor { get; set; }
        public Color MouseEnterBottomColor { get; set; }
        public Byte MouseEnterLightness { get; set; }

        public bool MouseEnterMutate { get; set; }
        public enum MouseEnterMutationEnum { ChangeLightness, ChangeColor };
        public MouseEnterMutationEnum MouseEnterMutation { get; set; }

        // -------------- Brush ----------------

        protected Brush FillBrush;
        public Brush MouseEnterFillBrush;

        protected void CreateFillBrush(bool gradient)
        {
            if (gradient == true)
            {
                FillBrush = new LinearGradientBrush(this.DisplayRectangle, this.TopColor, this.BottomColor, 90);
            }
            else
            {
                FillBrush = new SolidBrush(this.TopColor);
            }
        }

        protected void CreateMouseEnterFillBrush(bool gradient)
        {
            Color top, bottom;

            //set colors
            if(this.MouseEnterMutation == MouseEnterMutationEnum.ChangeLightness)
            {
                top = Color.FromArgb(255, this.TopColor.R + this.MouseEnterLightness,
                                          this.TopColor.G + this.MouseEnterLightness,
                                          this.TopColor.B + this.MouseEnterLightness );

                bottom = Color.FromArgb(255, this.BottomColor.R + this.MouseEnterLightness,
                                             this.BottomColor.G + this.MouseEnterLightness,
                                             this.BottomColor.B + this.MouseEnterLightness );
            }
            else
            {
                top = this.MouseEnterTopColor;
                bottom = this.MouseEnterBottomColor;
            }

            //set brush
            if(gradient == true)
            {
                this.MouseEnterFillBrush = new LinearGradientBrush(this.DisplayRectangle, top, bottom, 90);
            }
            else
            {
                this.MouseEnterFillBrush = new SolidBrush(this.MouseEnterTopColor);
            }
        }

        public bool GradientFill
        {
            get
            {
                if (FillBrush is LinearGradientBrush) return true;
                else return false;
            }

            set
            {
                this.CreateFillBrush(value);
                this.CreateMouseEnterFillBrush(value);
            }
        }

        protected void UpdateFillBrush()
        {
            this.CreateFillBrush(this.GradientFill);
        }

        protected void UpdateMouseEnterFillBrush()
        {
            this.CreateMouseEnterFillBrush(this.GradientFill);
        }

        // ------------- Event Callbacks --------------

        protected void DrawIt(Graphics g, Brush brush)
        {
            Pen border_pen = new Pen(Color.Red, 1);

            GraphicsPath path = Design.RoundedRectanglePath(this.DisplayRectangle, this.BorderRadius);
            //pe.Graphics.DrawPath(border_pen, path);

            g.FillPath(brush, path);
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            g.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), this.DisplayRectangle, sf);
        }

        protected void DrawContour(Graphics g, Pen pen)
        {
            GraphicsPath path = Design.RoundedRectanglePath(this.DisplayRectangle, this.BorderRadius);
            g.DrawPath(pen, path);
        }

        protected bool MouseIn, MouseClicked;

        protected override void OnPaint(PaintEventArgs pe)
        {
           // base.OnPaint(pe);

            //Activate antialiasing
            pe.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.UpdateFillBrush();
            this.UpdateMouseEnterFillBrush();

            if (this.Enabled == true)
            {
                this.DrawIt(pe.Graphics, MouseIn == false ? this.FillBrush : this.MouseEnterFillBrush);
                if (MouseClicked == true) this.DrawContour(pe.Graphics, new Pen(this.ClickContourColor, 2));
            }
            else
            {
                this.DrawIt(pe.Graphics, new SolidBrush(this.TopColor));
            }

        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            MouseIn = true;
            this.Invalidate();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            MouseIn = false;
            this.Invalidate();
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            MouseClicked = true;
            this.Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            MouseClicked = false;
            this.Invalidate(); 
        }
    }
}
