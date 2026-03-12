using System.Media;

namespace CatchButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GameButton_MouseEnter(object sender, EventArgs e)
        {
            // 1. 난수생성기준비
            Random rd = new Random();

            // 2. 가용 영역 계산(버튼이 폼테두리에 걸리지 않게 보호)
            // ClientSize는타이틀바와테두리를제외한실제흰도화지영역임
            int maxX = this.ClientSize.Width;
            int maxY = this.ClientSize.Height;

            // 3. 랜덤좌표추출(0 ~ 최대가용치사이, 버튼 사이즈 고려하였음)
            int nextX = rd.Next(0, maxX - GameButton.Width);
            int nextY = rd.Next(0, maxY - GameButton.Height);

            // 4. 위치할당(새로운Point 객체생성)
            GameButton.Location = new Point(nextX, nextY);

            // 5. 시각적피드백(폼 제목 표시줄에 좌표출력)
            this.Text = $"버튼위치: ({nextX}, {nextY})";
        }


        private void GameButton_MouseClick(object sender, MouseEventArgs e)
        {
            // 1) 시스템 기본 '삑' 소리
            SystemSounds.Beep.Play();

            // 클릭 성공 확인을 위한 메시지
            MessageBox.Show("버튼을 잡았습니다!", "성공");
        }
    }
}
