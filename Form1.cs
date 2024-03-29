using System.Windows.Forms;

namespace Smart_Clip_Board
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            trackBar1.Value = 10;
            trackBar1.Minimum = 4;
           
        }

        private void btn_Copy1_Click(object sender, EventArgs e)
        {
            string s = richTextBox1.Text;
            if(String.IsNullOrEmpty(s))
            {
                MessageBox.Show("field is empty!!");
                return;
            }

            label1.Text = s +" \n is copied";
            Clipboard.SetText(s);
            
        }

      
        private void btn_Paste1_Click(object sender, EventArgs e)
        {
            
            richTextBox1.Paste();
        }

        private void btn_Copy2_Click(object sender, EventArgs e)
        {
            string s = richTextBox2.Text;
            if (String.IsNullOrEmpty(s))
            {
                MessageBox.Show("field is empty!!");
                return;
            }
            label1.Text = s + " \n is copied";
            Clipboard.SetText(s);
        }

        private void btn_Paste2_Click(object sender, EventArgs e)
        {
            richTextBox2.Paste();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //MessageBox.Show((trackBar1.Value / 10.0).ToString());
            this.Opacity = trackBar1.Value / 10.0 ;
        }

        private void btn_Clear1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void btn_Clear2_Click(object sender, EventArgs e)
        {
            richTextBox2.Clear();
        }

        private void btn_Copy3_Click(object sender, EventArgs e)
        {
            string s = richTextBox3.Text;
            if (String.IsNullOrEmpty(s))
            {
                MessageBox.Show("field is empty!!");
                return;
            }
            label1.Text = s + " \n is copied";
            Clipboard.SetText(s);
        }

        private void btn_Paste3_Click(object sender, EventArgs e)
        {
            richTextBox3.Paste();
        }

        private void btn_Clear3_Click(object sender, EventArgs e)
        {
            richTextBox3.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, I'm AHSAN. See my website aaaaaaahsan.github.io for details.");
        }
    }
}