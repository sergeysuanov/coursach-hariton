using System.IO;


namespace hariton1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            saveFileDialog1.Filter = "text file (*.txt) | *.txt| tim notepad file (*.tnf)| *.tnf ";
          
                
                
                }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            File.WriteAllText(filename, richTextBox1.Text);
            MessageBox.Show("���� ��������");





        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog1.FileName;
            string filtext = File.ReadAllText(filename);
            richTextBox1.Text = filtext;
            MessageBox.Show("���� ������ ");




        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Copy();
            }
        }

        private void ���������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Paste();
            }
        }

        private void ��������ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (richTextBox1.TextLength > 0)
            {
                richTextBox1.Cut();
            }
        }

        private void ���������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            richTextBox1.Font = fontDialog1.Font;
        }

        private void �������������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            richTextBox1.BackColor = colorDialog1.Color; 
        }
    }
}