namespace MySales
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void frmStart_Load(object sender, EventArgs e) 
        { 
            try
            {
                this.Icon = Icon.ExtractAssociatedIcon("MySales.exe");
                frmLogin frm = new frmLogin();
                frm.Icon = this.Icon;
                frm.Show();

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
