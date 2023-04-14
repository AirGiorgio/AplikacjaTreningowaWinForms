using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKSFD
{
    class RoundButtons : Button
    {
        protected override void OnPaint(PaintEventArgs pevent) //feature na okrągłe przyciski w forms
        {
            GraphicsPath GP = new GraphicsPath();
            GP.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(GP);
            base.OnPaint(pevent);
        }
    }
}
