using System;
using System.Windows.Forms;
using System.Drawing;


namespace WindowsFormsApplication6
{
    class Rondje
    {
        private int x, y, dx, dy;
        private Brush brush;
    public Rondje(Brush brush, int x, int y, int dx, int dy)
        {
           
            
        }
        public void Veranderkleur(Size hok)
        {   
           


        }
    public void TekenRondje(Graphics gr)
        {
            gr.FillEllipse(this.brush, this.x - 4, this.y - 4, 9, 9);
        }
    }

}
