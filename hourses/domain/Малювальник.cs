using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace hourses.domain
{
    class Малювальник
    {       
        public Graphics graphics;
        public Bitmap bitmap;
        public PictureBox pictureBox;

        public Малювальник(PictureBox pictureBox)
        {            
            this.pictureBox = pictureBox;
        }

        public void draw(List<Кінь> horces)
        {
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);            
            graphics = Graphics.FromImage(bitmap);
            
            foreach(Кінь horce in horces)
            {
                this.drawHorce(horce);
            }

            pictureBox.Image = bitmap;
        }

        private void drawHorce(Кінь horce)
        {
            Image source = Properties.Resources.HORCE;
            Size scaledSize = new Size(
                source.Width / 4,
                source.Height / 4
                );
            Image image = (Image)(new Bitmap(source, scaledSize));
            graphics.DrawImage(image, new Point(horce.dx, horce.dy));
        }        
    }
}