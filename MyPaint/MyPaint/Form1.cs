using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class Form1 : Form
    {
        Color brushColor = Color.Black;
        Brush brush;
        bool brushDown;
        int brushSize;
        Graphics g;
        //bool isYellow = false;   // First I set up some boolean values as triggers.
        //bool isRed = false;      // It worked but I wanted to find a better way. 
        //bool isBlue = false;     // Then I came up with a List<> to achieve it.
        //bool isGreen = false;
        //bool isPink = false;
        List<Color> MyColor = new List<Color>();
          
        public Form1()
        {
            InitializeComponent();
            g = pnlCanvas.CreateGraphics();
            pnlCanvas.BackColor = Color.White;
            cboBrushSize.SelectedIndex = 0;
            brushSize = Convert.ToInt32(cboBrushSize.SelectedItem);
            MyColor.Add(Color.White);//set default color as white
        }

        private void pnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            brushDown = true;
        }

        private void pnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            brushDown = false;
        }

        private void pnlCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (brushDown)
            {
                brush = new SolidBrush(brushColor);
                g.FillEllipse(brush, e.X, e.Y, brushSize, brushSize);
            }
        }

        private void btnEraseAll_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
        }

        private void btnYellow_Click(object sender, EventArgs e)
        {
            //pnlCanvas.BackColor = Color.Yellow;
            //isYellow = true;
            //isRed = false;
            //isGreen = false;
            //isPink = false;
            //isBlue = false;
            MyColor.Clear();
            MyColor.Add(Color.Yellow);
            pnlCanvas.BackColor = MyColor[0];
        }

        private void btnYellow_MouseHover(object sender, EventArgs e)
        {
            pnlCanvas.BackColor = Color.Yellow;
        }

        private void btnYellow_MouseLeave(object sender, EventArgs e)
        {
            //setColor();
            pnlCanvas.BackColor = MyColor[0];
        }

        private void btnBlue_Click(object sender, EventArgs e)
        {
            //pnlCanvas.BackColor = Color.Blue;
            //isYellow = false;
            //isRed = false;
            //isGreen = false;
            //isPink = false;
            //isBlue = true;
            MyColor.Clear();
            MyColor.Add(Color.Blue);
            pnlCanvas.BackColor = MyColor[0];
        }

        private void btnBlue_MouseHover(object sender, EventArgs e)
        {
            pnlCanvas.BackColor = Color.Blue;
        }

        private void btnRed_Click(object sender, EventArgs e)
        {
            //pnlCanvas.BackColor = Color.Red;
            //isYellow = false;
            //isRed = true;
            //isGreen = false;
            //isPink = false;
            //isBlue = false;
            MyColor.Clear();
            MyColor.Add(Color.Red);
            pnlCanvas.BackColor = MyColor[0];
        }

        private void btnRed_MouseHover(object sender, EventArgs e)
        {
            pnlCanvas.BackColor = Color.Red;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            //pnlCanvas.BackColor = Color.Green;
            //isYellow = false;
            //isRed = false;
            //isGreen = true;
            //isPink = false;
            //isBlue = false;
            MyColor.Clear();
            MyColor.Add(Color.Green);
            pnlCanvas.BackColor = MyColor[0];
        }

        private void btnGreen_MouseHover(object sender, EventArgs e)
        {
            pnlCanvas.BackColor = Color.Green;
        }

        private void btnPink_Click(object sender, EventArgs e)
        {
            //pnlCanvas.BackColor = Color.Pink;
            //isYellow = false;
            //isRed = false;
            //isGreen = false;
            //isPink = true;
            //isBlue = false;
            MyColor.Clear();
            MyColor.Add(Color.Pink);
            pnlCanvas.BackColor = MyColor[0];
        }

        private void btnPink_MouseHover(object sender, EventArgs e)
        {
            pnlCanvas.BackColor = Color.Pink;
        }

        private void btnBlue_MouseLeave(object sender, EventArgs e)
        {
            //setColor();
            pnlCanvas.BackColor = MyColor[0];
        }

        private void btnGreen_MouseLeave(object sender, EventArgs e)
        {
            //setColor();
            pnlCanvas.BackColor = MyColor[0];
        }

        private void btnRed_MouseLeave(object sender, EventArgs e)
        {
            //setColor();
            pnlCanvas.BackColor = MyColor[0];
        }

        private void btnPink_MouseLeave(object sender, EventArgs e)
        {
            //setColor();
            pnlCanvas.BackColor = MyColor[0];
        }

        //private void setColor()
        //{
        //    if (isYellow)
        //        pnlCanvas.BackColor = Color.Yellow;
        //    else if (isBlue)
        //        pnlCanvas.BackColor = Color.Blue;
        //    else if (isRed)
        //        pnlCanvas.BackColor = Color.Red;
        //    else if (isGreen)
        //        pnlCanvas.BackColor = Color.Green;
        //    else if (isPink)
        //        pnlCanvas.BackColor = Color.Pink;
        //    else
        //        pnlCanvas.BackColor = Color.White;
        //}

        private void btnFontColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = brushColor;
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                brushColor = colorDialog1.Color;
            }
        }
    }
}
