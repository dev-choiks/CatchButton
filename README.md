# 버튼잡기게임(C# 코딩)


-이름: 최경서(25017084)


## 개요


-C# 프로그래밍학습


-핵심기능: UI구성, 버튼 이동 기능, 버튼 위치 정보 표시, 버튼 이동 범위 제한, 시각적/청각적피드백, 점수 표시와 점수별 난이도 조정, 게임오버 및 리셋


## 실행화면


-1단계



-UI 구성


<img width="724" height="474" alt="image" src="https://github.com/user-attachments/assets/1fcdf655-5075-4091-9c76-6dacb713fd74" />

-버튼 이동 기능 구현


<img width="726" height="477" alt="image" src="https://github.com/user-attachments/assets/4b7d1d9c-c5bd-4a7f-97e0-0568d26d9e25" />


폼 제목에 현재 버튼의 X, Y 좌표를 실시간으로 표시(위 사진 참고)


-2단계



-메시지 박스 띄우기


<img width="727" height="479" alt="image" src="https://github.com/user-attachments/assets/4566e394-231d-458f-a3fe-7ab9c9ce35da" />


-버튼이 도망쳤을때, 잡았을때 소리 출력


-3단계



-점수 계산(폼에 나타냄)


<img width="729" height="476" alt="image" src="https://github.com/user-attachments/assets/35e87369-8129-4cd3-b2a7-1be40bd8cf6a" />

-버튼을 놓친경우 -10


<img width="722" height="472" alt="image" src="https://github.com/user-attachments/assets/32255562-c01b-406b-81be-77c3908d1eef" />


-버튼을 잡은경우 +100(테스트를 위해 버튼 사이즈를 임시로 키움)


<img width="723" height="476" alt="image" src="https://github.com/user-attachments/assets/11ccd22d-1c1f-40fd-8f42-e6482869f87b" />


-난이도 조절(클릭에 성공할 때마다 버튼의 크기를 10%씩작게 크기를 축소)


<img width="783" height="489" alt="image" src="https://github.com/user-attachments/assets/51b1a628-901e-4be9-affe-bb5611c0e1ac" />



-4단계



-게임 오버시 메시지 출력 및 다시시작 기능 구현


<img width="874" height="472" alt="image" src="https://github.com/user-attachments/assets/e93e9deb-a819-4e86-b6a5-e7d7d44217f8" />



## 구현시어려웠던점


- 효과음 적용 방법을 몰라 인터넷 서칭 및 AI를 사용하여, "SystemSounds.Hand.Play();"를 사용해야한다는 것을 알게 되어 문제를 해결함
- 메시지 창 띄우는 법을 몰라 AI의 도움을 받아 띄우는 법을 알게 되었으며, 창에서 선택지를 구현하였음

