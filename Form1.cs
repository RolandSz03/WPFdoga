namespace WPFdoga
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Btnkoszonj.Click += Btnkoszonj_Click;
            lblPiros.Click += LblPiros_Click;
            lblKek.Click += LblKek_Click;
            lblZold.Click += LblZold_Click;
            btnPlusz.Click += kijeloltgomb;
            btnMinusz.Click += kijeloltgomb;
            btnOsztas.Click += kijeloltgomb;
            btnSzorzas.Click += kijeloltgomb;

        }

        private void kijeloltgomb(object? sender, EventArgs e)
        {
            var selectcheck = false;
            if (kijeloltgomb() is true))
            {

            }
        }

        private void LblZold_Click(object? sender, EventArgs e)
        {
            BackColor = lblZold.BackColor;
        }

        private void LblKek_Click(object? sender, EventArgs e)
        {
            BackColor = lblKek.BackColor;
        }

        private void LblPiros_Click(object? sender, EventArgs e)
        {
            BackColor = lblPiros.BackColor;
        }

        private void Btnkoszonj_Click(object? sender, EventArgs e)
        {
            if (!(TxtNev.Text == string.Empty))
            {
                lbludvozles.Text = $"Szia, {TxtNev.Text}";
            }
            else
            {
                MessageBox.Show("ures a mezo teso");
            }
        }

        private void TxtNev_TextChanged(object sender, EventArgs e)
        {

        }
    }
}