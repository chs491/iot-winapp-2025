namespace SyntaxWinApp2
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void BtnMsg_Click(object sender, EventArgs e)
        {
            // ������ : =, +, -, *, /, %, +=, -=, *=
            // &&, ||, &, |, ^, !
            // C, C++ �� ����
            int val = 2 ^ 10;

            MessageBox.Show(((3>2) && (10<9)).ToString(), "�˸�!", MessageBoxButtons.OK);
        }
    }
}
