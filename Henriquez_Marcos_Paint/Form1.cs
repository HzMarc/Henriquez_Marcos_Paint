using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Henriquez_Marcos_Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Width = 940;
            Height = 600;
            bm = new Bitmap(Canva.Width, Canva.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            Canva.Image = bm;
            brochaIm = new TextureBrush(new Bitmap("C:\\Users\\marco\\Downloads\\Henriquez_Marcos_Paint\\Henriquez_Marcos_Paint\\Resources\\bricha3.jpg"));
            brochaIm2 = new TextureBrush(new Bitmap("C:\Users\marco\Downloads\Henriquez_Marcos_Paint\Henriquez_Marcos_Paint\Resources\texturaPriedra.jpeg"));
        }

        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen pencolor = new Pen(Color.Black, 2);
        Pen borrador = new Pen(Color.White, 5);
        Pen Spray = new Pen(Color.Black);
        int index;
        int x, y, sX, sY, cX, cY;
        bool relleno = false;
        Color fillcolor = Color.Transparent;
        Color new_color;

        //Animacion de el texto de la pantalla de inicip
        string text1;
        string text2;
        int len1 = 0;
        int len2 = 0;

        //Spray
        bool isSprayActive = false;
        Random _rnd = new Random();
        int SprayRadius = 15;

        //Brochas adicionales
        HatchStyle entramado = HatchStyle.BackwardDiagonal;
        Color colorEntremado = Color.Black;
        bool isHatchBrushActive = false;
        Color micolor = Color.White;

        bool isTextureActive = false;
        TextureBrush brochaIm;
        string rutaTextura = "C:\\Users\\marco\\Downloads\\Henriquez_Marcos_Paint\\Henriquez_Marcos_Paint\\Resources\\bricha3.jpg";

        bool isTextureActive2 = false;
        TextureBrush brochaIm2;
        string rutaTextura2 = "C:\\Users\\marco\\Downloads\\Henriquez_Marcos_Paint\\Henriquez_Marcos_Paint\\Resources\\texturaPriedra.jpeg";

        private void btnColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            cd.AllowFullOpen = true;
            cd.Color = pic_color.BackColor;
            cd.FullOpen = true;
            cd.AnyColor = true;

            if (cd.ShowDialog() == DialogResult.OK)
            {
                pic_color.BackColor = cd.Color;
                pencolor.Color = cd.Color;
                new_color = cd.Color;
            }
        }
        private void Canva_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;
            cX = e.X;
            cY = e.Y;
            if (isSprayActive)
            {
                SprayPaint(e.Location);
            }
        }
        private void Canva_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (isTextureActive2)
                {
                    using (Graphics g = Graphics.FromImage(bm))
                    {
                        g.FillEllipse(brochaIm2, e.X - 10, e.Y - 10, 20, 20);
                    }
                }
                if (isTextureActive)
                {
                    using (Graphics g = Graphics.FromImage(bm))
                    {
                        g.FillEllipse(brochaIm, e.X - 10, e.Y - 10, 20, 20);
                    }
                }
                if (isHatchBrushActive && index == 11)
                {
                    DrawHatchBrush(e.Location);
                }
                if (index == 10)
                {
                    isSprayActive = true;
                }
                else
                {
                    isSprayActive = false;
                }

                if (isSprayActive)
                {
                    SprayPaint(e.Location);
                }
                else
                {
                    if (index == 1)
                    {
                        px = e.Location;
                        g.DrawLine(pencolor, py, px);
                        py = px;
                    }
                    if (index == 2)
                    {
                        px = e.Location;
                        g.DrawLine(borrador, py, px);
                        py = px;
                    }
                }
            }

            Canva.Invalidate();

            Canva.Refresh();
            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void Canva_MouseUp(object sender, MouseEventArgs e)
        {

            paint = false;

            sX = Math.Abs(x - cX);
            sY = Math.Abs(y - cY);
            int rectX = cX < x ? cX : x;
            int rectY = cY < y ? cY : y;

           
            if (index == 10)
            {
                isSprayActive = true;
            }
            else
            {
                isSprayActive = false;
            }
            if (index == 3)
            {
                if (relleno)
                {
                    g.FillEllipse(new SolidBrush(fillcolor), rectX, rectY, sX, sY);
                }
                else
                {
                    g.DrawEllipse(pencolor, rectX, rectY, sX, sY);
                }
            }
            if (index == 4)
            {
                if (relleno)
                {
                    if (relleno)
                    {
                        g.FillRectangle(new SolidBrush(fillcolor), rectX, rectY, sX, sY);
                    }
                }
                else
                {
                    g.DrawRectangle(pencolor, rectX, rectY, sX, sY);
                }
            }
            if (index == 5)
            {
                g.DrawLine(pencolor, cX, cY, x, y);
            }
            if (index == 6)
            {
                DrawStar(g, pencolor, rectX, rectY, sX, sY, 5, relleno);
            }
            if (index == 7)
            {
                DrawTriangle(g, pencolor, rectX, rectY, sX, sY, relleno);
            }

        }
        private void DrawStar(Graphics g, Pen pen, int x, int y, int width, int height, int numPoints, bool fill)
        {

            PointF[] starPoints = new PointF[numPoints * 2];
            double angle = Math.PI / numPoints;

            for (int i = 0; i < numPoints * 2; i++)
            {
                double radius = (i % 2 == 0) ? width / 2 : height / 4;
                double currAngle = i * angle;

                float px = (float)(x + radius * Math.Cos(currAngle));
                float py = (float)(y + radius * Math.Sin(currAngle));
                starPoints[i] = new PointF(px, py);
            }
            if (fill)
            {
                g.FillPolygon(new SolidBrush(fillcolor), starPoints);
            }
            else
            {
                g.DrawPolygon(pen, starPoints);
            }
        }
        private void DrawTriangle(Graphics g, Pen pen, int x, int y, int width, int height, bool fill)
        {
            Point[] points = new Point[3];
            points[0] = new Point(x + width / 2, y);
            points[1] = new Point(x, y + height);
            points[2] = new Point(x + width, y + height);
            g.DrawPolygon(pen, points);
            if (fill)
            {
                g.FillPolygon(new SolidBrush(fillcolor), points);
            }
            else
            {
                g.DrawPolygon(pen, points);
            }
        }


        private void btnPincel_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            index = 2;
            borrador.Color = Canva.BackColor;
        }
        private void btnCirculo_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void btnLinea_Click(object sender, EventArgs e)
        {
            index = 5;
        }
        private void btnStrella_Click(object sender, EventArgs e)
        {
            index = 6;
        }
        private void btnTriagulo_Click(object sender, EventArgs e)
        {
            index = 7;
        }
        private void Canva_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            sX = Math.Abs(x - cX);
            sY = Math.Abs(y - cY);

            e.Graphics.DrawImage(bm, Point.Empty);
            int rectX = cX < x ? cX : x;
            int rectY = cY < y ? cY : y;
            if (paint)
            {
                if (index == 10)
                {
                    isSprayActive = true;
                }
                else
                {
                    isSprayActive = false;
                }
                if (index == 3)
                {
                    if (relleno)
                    {
                        g.FillEllipse(new SolidBrush(fillcolor), rectX, rectY, sX, sY);
                    }
                    else
                    {
                        g.DrawEllipse(pencolor, rectX, rectY, sX, sY);
                    }
                }
                if (index == 4)
                {
                    if (relleno)
                    {
                        if (relleno)
                        {
                            g.FillRectangle(new SolidBrush(fillcolor), rectX, rectY, sX, sY);
                        }
                    }
                    else
                    {
                        g.DrawRectangle(pencolor, rectX, rectY, sX, sY);
                    }
                }
                if (index == 5)
                {
                    g.DrawLine(pencolor, rectX, rectY, x, y);
                }
                if (index == 6)
                {
                    DrawStar(g, pencolor, rectX, rectY, sX, sY, 5, relleno);
                }

                if (index == 7)
                {
                    DrawTriangle(g, pencolor, rectX, rectY, sX, sY, relleno);
                }
            }
        }
        private void Canva_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 8)
            {
                Point point = set_point(Canva, e.Location);
                Fill(bm, point.X, point.Y, new_color);
            }
            else if (index == 9 && Canva.Image != null)
            {
                Point point = set_point(Canva, e.Location);
                Bitmap bitmap = (Bitmap)Canva.Image;

                if (point.X >= 0 && point.Y >= 0 && point.X < bitmap.Width && point.Y < bitmap.Height)
                {
                    Color pickedColor = bitmap.GetPixel(point.X, point.Y);
                    pic_color.BackColor = pickedColor;
                    new_color = pickedColor;
                    pencolor.Color = pickedColor;
                }
            }
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            Canva.Image = bm;
            index = 0;
        }

        private void btnColorfondo_Click(object sender, EventArgs e)
        {
            Canva.BackColor = pencolor.Color;
            g.Clear(pencolor.Color);
            Canva.Image = bm;
            borrador.Color = Canva.BackColor;
        }

        private void trackSize_Scroll(object sender, EventArgs e)
        {
            pencolor.Width = trackSize.Value;
            borrador.Width = trackSize.Value;
        }
        static Point set_point(PictureBox pb, Point pt)
        {
            float px = 1f * pb.Image.Width / pb.Width;
            float py = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * px), (int)(pt.Y * py));
        }
        private void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color old_color, Color new_color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);
            }
        }
        public void Fill(Bitmap bm, int x, int y, Color new_clr)
        {
            if (new_clr == Color.Empty)
            {
                new_clr = Color.Black;
            }
            Color old_color = bm.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bm.SetPixel(x, y, new_clr);
            if (old_color == new_clr) return;

            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X >= 0 && pt.Y >= 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    validate(bm, pixel, pt.X - 1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y - 1, old_color, new_clr);
                    validate(bm, pixel, pt.X + 1, pt.Y, old_color, new_clr);
                    validate(bm, pixel, pt.X, pt.Y + 1, old_color, new_clr);
                }
            }
        }

        private void btnFull_Click(object sender, EventArgs e)
        {
            index = 8;
        }

        private void btnGotero_Click(object sender, EventArgs e)
        {
            index = 9;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            text1 = lbText1.Text;
            lbText1.Text = "";
            text2 = lbText2.Text;
            lbText2.Text = "";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (len1 < text1.Length)
            {
                lbText1.Text = lbText1.Text + text1.ElementAt(len1);
                len1++;
            }
            if (len2 < text2.Length)
            {
                lbText2.Text = lbText2.Text + text2.ElementAt(len2);
                len2++;
            }
            if (len1 >= text2.Length && len2 >= text2.Length)
            {
                timer1.Stop();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            panelInicio.Location = new System.Drawing.Point(-10000, 50);
        }

        private void inicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelInicio.Location = new System.Drawing.Point(0, 0);
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "JPeg Image|*.jpg|Bitmap Image|*.bmp|Gif Image|*.gif";
            saveFileDialog1.Title = "Guardar una imagen";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog1.FileName != "")
                {
                    using (System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile())
                    {
                        switch (saveFileDialog1.FilterIndex)
                        {
                            case 1:
                                bm.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                                break;

                            case 2:
                                bm.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                                break;

                            case 3:
                                bm.Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                                break;
                        }
                        fs.Close();
                    }
                }
            }
        }

        private void btnSpray_Click(object sender, EventArgs e)
        {
            index = 10;
            isSprayActive = true;
        }
        private void SprayPaint(Point location)
        {
            using (Graphics g = Graphics.FromImage(bm))
            {
                int radius = SprayRadius;
                int radius2 = radius * 2;
                double x, y;

                for (int i = 0; i < 100; ++i)
                {
                    do
                    {
                        x = (_rnd.NextDouble() * radius2) - radius;
                        y = (_rnd.NextDouble() * radius2) - radius;
                    } while ((x * x + y * y) > (radius * radius));

                    x += location.X;
                    y += location.Y;

                    g.DrawEllipse(pencolor, new Rectangle((int)x - 1, (int)y - 1, 1, 1));
                }
            }
            Canva.Invalidate();
        }

        private void trackr_Scroll(object sender, EventArgs e)
        {
            SprayRadius = trackr.Value;
        }

        private void DrawHatchBrush(Point location)
        {
            using (Graphics g = Graphics.FromImage(bm))
            {
                HatchBrush brochaEnt = new HatchBrush(entramado, colorEntremado, Color.Transparent);
                g.FillRectangle(brochaEnt, new Rectangle(location.X - 10, location.Y - 10, 20, 20));
            }
            Canva.Invalidate();
        }

        private void Brocha1_Paint(object sender, PaintEventArgs e)
        {
            HatchBrush brochaEnt = new HatchBrush(entramado, micolor);
            int anchoPanel = Brocha1.Width;
            int altoPanel = Brocha1.Height;
            e.Graphics.FillRectangle(brochaEnt, 0, 0, anchoPanel, altoPanel);
        }

        private void Brocha1_Click(object sender, EventArgs e)
        {
            ColorDialog cc = new ColorDialog();
            if (cc.ShowDialog() == DialogResult.OK)
            {
                colorEntremado = cc.Color;
                isHatchBrushActive = true;
                index = 11;
            }
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            isTextureActive = !isTextureActive;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            isTextureActive2 = !isTextureActive2;
        }
    }
}