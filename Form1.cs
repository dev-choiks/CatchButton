using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace CatchButton
{
    public partial class Form1 : Form
    {
        //실습 과제 핵심 변수
        private int score = 1000;      //초기 점수 1000점
        private int missCount = 0;     //놓친 횟수 카운트
        private Size initialSize;      //리셋을 위한 초기 버튼 크기 저장

        public Form1()
        {
            InitializeComponent();
            // 초기 설정 저장 및 표시
            initialSize = GameButton.Size;
            UpdateStatus(GameButton.Location.X, GameButton.Location.Y);
        }

        //점수와 위치를 폼 제목에 표시
        private void UpdateStatus(int x, int y)
        {
            this.Text = $"점수: {score} | 위치: ({x}, {y})";
        }

        //버튼 도망 및 게임 종료 로직
        private void GameButton_MouseEnter(object sender, EventArgs e)
        {
            //도망 시 10점 감점 / 카운트 증가
            score -= 10;
            missCount++;
            SystemSounds.Asterisk.Play(); //도망 소리

            //20번 놓치거나 점수가 0 이하일 때 게임 오버
            if (missCount >= 20 || score <= 0)
            {
                if (score < 0) score = 0;
                UpdateStatus(GameButton.Location.X, GameButton.Location.Y);

                //버튼 대신 MessageBox를 이용한 다시하기 구현
                DialogResult result = MessageBox.Show(
                    "Game Over! 다시 도전하시겠습니까?",
                    "게임 종료",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    ResetGame(); //다시하기 선택 시 리셋 함수 호출
                }
                else
                {
                    Application.Exit(); //아니오 선택 시 종료
                }
                return;
            }

            //랜덤 위치 이동
            Random rd = new Random();
            int maxX = this.ClientSize.Width;
            int maxY = this.ClientSize.Height;

            int nextX = rd.Next(0, Math.Max(1, maxX - GameButton.Width));
            int nextY = rd.Next(0, Math.Max(1, maxY - GameButton.Height));

            GameButton.Location = new Point(nextX, nextY);
            UpdateStatus(nextX, nextY);
        }

        //버튼 클릭 성공 시
        private void GameButton_MouseClick(object sender, MouseEventArgs e)
        {
            score += 100; // 100점 추가
            SystemSounds.Hand.Play(); // 잡았을 때 소리
            MessageBox.Show("축하합니다~!");

            //난이도 조절 (10% 축소)
            int newWidth = (int)(GameButton.Width * 0.9);
            int newHeight = (int)(GameButton.Height * 0.9);

            if (newWidth > 5 && newHeight > 5)
            {
                GameButton.Size = new Size(newWidth, newHeight);
            }

            UpdateStatus(GameButton.Location.X, GameButton.Location.Y);
        }

        //리셋 기능을 수행하는 함수
        private void ResetGame()
        {
            score = 1000;
            missCount = 0;
            GameButton.Size = initialSize;

            //버튼을 처음 위치(중앙)로 이동
            GameButton.Location = new Point(
                (this.ClientSize.Width - GameButton.Width) / 2,
                (this.ClientSize.Height - GameButton.Height) / 2
            );

            UpdateStatus(GameButton.Location.X, GameButton.Location.Y);
        }
    }
}