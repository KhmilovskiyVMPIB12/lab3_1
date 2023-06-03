using System.Windows.Forms;

namespace LaboratornayaRabota3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateBlank (pictureBox1.Width, pictureBox1.Height);
        }
        Color DefaultColor { get { return Color.LightGray; } }

        void CreateBlank(int width, int height)
        {
            var oldImage = pictureBox1.Image;
            var bmp = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    bmp.SetPixel(i, j, DefaultColor);
                }
            }
            pictureBox1.Image = bmp;
            if (oldImage != null)
            {
                oldImage.Dispose();
            }
            Brush.W = width;
            Brush.H = height;
        }

        int _x, _y;
        bool _mouseClicked = false;
        Color SelectedColor { get { return Color.Black; } }
        int SelectedSize { get { return trackBar1.Value; } }
        Brush _selectedBrush;

        private void button3_Click(object sender, EventArgs e)
        {
            _selectedBrush = new CircleBrush(SelectedColor, SelectedSize);
        }

        private void drawPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _selectedBrush = new QuadBrush(SelectedColor, SelectedSize);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (_selectedBrush == null) { return; }

            _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
            pictureBox1.Refresh();
            _mouseClicked = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            _selectedBrush = new SprayBrush(SelectedColor, SelectedSize);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            _x = e.X > 0 ? e.X : 0;
            _y = e.Y > 0 ? e.Y : 0;
            if (_mouseClicked)
            {
                _selectedBrush.Draw(pictureBox1.Image as Bitmap, _x, _y);
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            { _mouseClicked = false; }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            _selectedBrush = new ClearBrush(DefaultColor, SelectedSize);
        }

        private void ÒÓÁ‰‡Ú¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new —ÓÁ‰‡Ú¸();
            form.ShowDialog();
            if (form.Canceled == false)
            {
                CreateBlank(form.W, form.H);
            }
        }

        private void ‚˚ıÓ‰ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ÓœÓ„‡ÏÏÂToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var from = new oprogramms();
            from.ShowDialog();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}