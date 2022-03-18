namespace MathServiceTestApp
{
    public partial class Form1 : Form
    {
        private readonly MathService.MathService _client = new MathService.MathService();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(textBox1.Text);
            int number2 = Convert.ToInt32(textBox2.Text);

            int result = _client.Add(new MathService.MyNumbers() { Number1 = number1, Number2 = number2 });     
            textBox3.Text = result.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int number1 = Convert.ToInt32(textBox1.Text);
            int number2 = Convert.ToInt32(textBox2.Text);

            int result = _client.Substract(new MathService.MyNumbers() { Number1 = number1, Number2 = number2 });
            textBox3.Text = result.ToString();
        }
    }
}