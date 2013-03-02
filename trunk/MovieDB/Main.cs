using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieDB
{
    public partial class formMain : Form
    {
        //Member variables
        private float scaleWidth = 1.0f, scaleHeight = 1.0f;
        private int origWidth, origHeight;

        public formMain()
        {
            InitializeComponent();
            this.origHeight = this.Height;
            this.origWidth = this.Width;
        }

        private void formMain_Resize(object sender, EventArgs e)
        {/*
            double scale;
            this.scaleWidth = (float)this.Width / (float)this.origWidth;
            this.scaleHeight = (float)this.Height / (float)this.origHeight;
            if (this.scaleHeight > this.scaleWidth)
            {
                scale = this.scaleHeight;
            }
            else
            {
                scale = this.scaleWidth;
            }

            foreach (Control control in this.Controls)
            {
                control.Height = (int)(control.Height * this.scaleHeight);
                control.Width = (int)(control.Width * this.scaleWidth);
                this.Refresh();
              //  control.Font = new Font("Verdana", control.Font.SizeInPoints * heightRatio * widthRatio);
            }
            //this.Scale(new SizeF(this.scaleWidth, this.scaleHeight));
            //this.Refresh();
          */
        }

        private void lblCurrTime_Click(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
