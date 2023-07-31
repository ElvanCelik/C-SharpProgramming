namespace Methodlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void HideRadioButtons()
        {
            groupBox1.Visible = false;
        }
        public void ClearAllText()
        {
            textBox1.Clear();
            textBox2.Clear();
        }
        public string FillTextBox()
        {
            string text = textBox1.Text;
            return text;
        }
        string setNumber()
        {
            string age = textBox1.Text;
            return age;
        }
        void getName(string text)
        {
            textBox2.Text = text;
        }
        string GetName()
        {
            string name = "Charles";
            return name;
        }
        int Sum(int x,int y)
        {
            int sumresult;
            sumresult = x + y;
            return sumresult;
        }
        private void btnMethods_Click(object sender, EventArgs e)
        {
            //HideRadioButtons();

            //getName(textBox1.Text);
            //textBox1.Clear();

            //string name = GetName();
            //MessageBox.Show(name);

            int sumresult = Sum(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
            MessageBox.Show(sumresult.ToString());

        }
    }
}