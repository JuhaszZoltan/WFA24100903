namespace WFA24100903
{
    public partial class FrmQuadratic : Form
    {
        public FrmQuadratic()
        {
            InitializeComponent();
            nudSD.ValueChanged += Nud_ValueChanged;
            nudFD.ValueChanged += Nud_ValueChanged;
            nudConst.ValueChanged += Nud_ValueChanged;
        }

        private void Nud_ValueChanged(object? sender, EventArgs e)
        {
            decimal a = nudSD.Value;
            decimal b = nudFD.Value;
            decimal c = nudConst.Value;

            if (a == 0)
            {
                rtbSol.Text = 
                    "The equation is not quadratic!\n" +
                    $"X = {-b/c:0.0000}";
                return;
            }

            decimal d = (b * b) - (4 * a * c);
        }
    }
}
