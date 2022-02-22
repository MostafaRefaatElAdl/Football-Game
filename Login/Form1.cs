namespace Login
{
    public partial class Form1 : Form
    {
        public static string? Username { get; set; }
        public static string Password { get; set; }
        public bool Auth { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Login Form";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Are you sure?","Confirmation", MessageBoxButtons.YesNo)==DialogResult.No)
                e.Cancel = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Username = txtUsername.Text;
            Password = txtPassword.Text;
            if (Username.Length < 3 || Password.Length < 8) 
            {
                MessageBox.Show("Please enter a valid data\n\nCuation\n(Username must be 3 or more Chars)\n(Password must be 8 or more Chars)", "Cuation");
                //return;
            }
            //if (MessageBox.Show($"Username: {Username} || Password: {Password}\n\nAre these data true?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{
            //    MessageBox.Show("You're logged in!");
            //    this.Text = $"Hi {Username}";
            //}
            else 
            {
                this.Close();
                //Auth =true;
                NotePad note=new ();
                note.ShowDialog();
            }
        }
    }
}