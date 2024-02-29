namespace task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double n1, n2, opcode, result;
            result = 0;
            opcode = comboBox1.SelectedIndex;
            n1 = double.Parse(Number1.Text);
            n2 = double.Parse(Number2.Text);
            if (opcode == 0 ) { result = n1 + n2; }
            else if (opcode == 1 ) {  result = n1 - n2; }
            else if (opcode == 2 ) {  result = n1 * n2; }
            else if (opcode == 3 ) {  result = n1 / n2; }
            Result.Text = result.ToString();
        }
    }
}
