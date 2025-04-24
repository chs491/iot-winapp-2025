namespace SyntaxWinApp03
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        // async 비동기로 동작하는 메서드라고 선언
        // async, await는 항상 같이 사용
        private async void BtnStart_Click(object sender, EventArgs e)
        {
            LblCurrState.Text = "현재상태 : 진행"; // ui처리
            BtnStart.Text = "진행중"; // ui처리
            BtnStart.Enabled = false; // 못쓰게함 // ui처리

            // 엄청난 시간이 걸리는 연산을 수행
            long MaxVal = 200;
            long total = 0;
            PrgProcess.Minimum = 0; // ui처리
            PrgProcess.Maximum = 100; // ui처리


            // await로 비동기 대기
            await Task.Run(() =>
            {
                for (int i = 0; i < MaxVal; i++)
                {
                    total += i % 3;

                    int progress = (int)((i * 100) / MaxVal) + 1;
                    Console.WriteLine(progress.ToString());
                    // Task.Run 내 들어있는 UI처리 로직은
                    this.Invoke(new Action(() =>
                    {
                        TxtLog.Text += i.ToString() + "\r\n";
                        TxtLog.SelectionStart = TxtLog.Text.Length;
                        TxtLog.ScrollToCaret();
                        PrgProcess.Value = progress;
                    }));


                    Thread.Sleep(50);
                    //Application.DoEvents(); // 권장X
                }
            });


            LblCurrState.Text = "현재상태 : 중지";
            BtnStart.Text = "시작";
            BtnStart.Enabled = true;
        }
    }
}
