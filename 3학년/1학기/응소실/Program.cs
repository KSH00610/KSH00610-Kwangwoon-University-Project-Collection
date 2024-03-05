using System;
namespace Day01{
    public class Program{
        static async void Main(string[] args)
        {
           //if 1번예제
            int num1=Convert.ToInt32(Console.ReadLine());
            if (num1 %2==0){
                System.Console.WriteLine("짝수");
            }
            else{
                System.Console.WriteLine("홀수");
            }

           //if 2번예제
            int num2 =Convert.ToInt32(Console.ReadLine());
            int cnt1=0, cnt2=0;
            for(int i=1; i <=num2; i++){
                if(i %2==0) {
                    cnt1++;
                }
                else 
                {
                    cnt2++;
                }
            }
            System.Console.WriteLine("1 ~ "+num2+" 사이 짝수 : "+cnt1+"개, 홀수 : "+cnt2+"개");

           //if 3번예제
            System.Console.Write("이차항의 계수 : ");
            int a=Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine();
            System.Console.Write("일차항의 계수 : ");
            int b=Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine();
            System.Console.Write("상수항의 계수 : ");
            int c=Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine();
            if(b*b-4*a*c >=0){
                System.Console.WriteLine("실근");
            }
            else{
                System.Console.WriteLine("허근");
            }
            //if 4번예제
            System.Console.Write("학생 성적 입력 : ");
            int score1=Convert.ToInt32(Console.ReadLine());
            if (score1 >=90){
                System.Console.Write("A");
            }
            else if (score1 >=80){
                System.Console.Write("B");
            }
            else if (score1 >=70){
                System.Console.Write("C");
            }
            else if (score1 >=60){
                System.Console.Write("D");
            }
            else{
                System.Console.WriteLine("F");
            }


            //if 5번예제
            System.Console.Write("학생 성적 입력 : ");
            int score=Convert.ToInt32(Console.ReadLine());
            if (score >=90){
                System.Console.Write("A");
                if(score>=95){
                    System.Console.WriteLine("+");
                }
            }
            else if (score >=80){
                System.Console.Write("B");
                if(score>=85){
                    System.Console.WriteLine("+");
                }
            }
            else if (score >=70){
                System.Console.Write("C");
                if(score>=75){
                    System.Console.WriteLine("+");
                }
            }
            else if (score >=60){
                System.Console.Write("D");
                if(score>=65){
                    System.Console.WriteLine("+");
                }
            }
            else{
                System.Console.WriteLine("F");
            }

            //if 예제6번
            System.Console.WriteLine(" 구구단 출력 ");
            System.Console.Write("몇 단을 출력 : ");
            int num3=Convert.ToInt32(Console.ReadLine());
            if(num3 <=0 || num3 >9){
                System.Console.WriteLine("잘못된 입력");
            }
            else{
                for(int i=1; i<=9; i++){
                    System.Console.WriteLine(num3+" X "+i+" = "+(num3*i));
                }
            }

            //if 예제7번
            System.Console.WriteLine("숫자 입력 : ");
            int num4=Convert.ToInt32(Console.ReadLine());
            int div_cnt=2;
            for(int i =2; i<num4; i++)
            {
                if(num4 %i==0)
                {
                    div_cnt++;
                }
            }
            if(div_cnt==2)
            {
                System.Console.WriteLine(num4+" : 소수");
            }
            else{
                System.Console.WriteLine(num4+" : 합성수");
                System.Console.WriteLine("약수의 갯수 : "+div_cnt);
            }

            //if 예제8번
            System.Console.WriteLine("메뉴 : 짜장면, 짬뽕, 탕수육, 양장피, 볶음밥");
            System.Console.Write("중국음식 선택 : ");
            string food = Console.ReadLine();
            System.Console.WriteLine(food+"가 주문이 들어왔습니다.");
            if(food == "양장피" || food == "탕수육"){
                System.Console.WriteLine("군만두 서비스가 있습니다.");
            }

            //if 예제9번
            System.Console.Write("키 입력 : ");
            int height = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine();
            System.Console.Write("몸무게 입력 : ");
            int weight = Convert.ToInt32(Console.ReadLine());
            double bmi = (double)weight/(height*height);
            bmi=bmi*1000;
            if(bmi<18.5){
                System.Console.WriteLine("저체중");
            }
            else if (bmi>=18.5 && bmi<23.0){
                System.Console.WriteLine("정상체중");
            }
            else if (bmi>=23.0 && bmi<25.0){
                System.Console.WriteLine("과체중");
            }
            else{
                System.Console.WriteLine("비만");
            }

            //if 예제 10번
            int recommend_sleep=8;
            System.Console.Write("자신의 수면 시간 : ");
            int self_sleep=Convert.ToInt32(Console.ReadLine());
            if(self_sleep<recommend_sleep)
            {
                System.Console.WriteLine("수면부족");
            }
            else if(self_sleep==recommend_sleep){
                System.Console.WriteLine("적절한 수면시간");
            }
            else{
                System.Console.WriteLine("충분한 수면시간");
            }

            //if 예제 11번
            System.Console.Write("이차항의 계수 : ");
            int second_order=Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine();
            System.Console.Write("일차항의 계수 : ");
            int first_order=Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine();
            System.Console.Write("상수항의 계수 : ");
            int order=Convert.ToInt32(Console.ReadLine());
            int d=first_order*first_order - 4*first_order*order;
            System.Console.WriteLine("판별식 : "+d);
            if(d>=0){
                System.Console.WriteLine("판별식의 제곱근 : "+Math.Sqrt(d));
            }
            else{
                d=Math.Abs(d);
                System.Console.WriteLine("판별식의 제곱근 : "+Math.Sqrt(d)+" i");
            }

            //if 예제 12번
            System.Console.Write("주당 근무시간을 입력하라 : ");
            int work_time=Convert.ToInt32(Console.ReadLine());
            int pay;
            if(work_time<=40){
                pay=work_time*9000;
            }
            else{
                int over=work_time-40;
                pay=(int)(work_time*9000 + 9000*1.5*over);
            }
            System.Console.WriteLine("주급 : "+pay);

            //if 예제 13번
            System.Console.Write("두 개의 정수를 입력하라 : ");
            int n1=Convert.ToInt32(Console.ReadLine());
            int n2=Convert.ToInt32(Console.ReadLine());
            if (n1>n2){
                System.Console.WriteLine(n2*n2);
            }
            else{
                System.Console.WriteLine((double)n1/n2);
            }

            //if 예제 14번
            System.Console.Write("x : ");
            int x_num=Convert.ToInt32(Console.ReadLine());
            int f_x;
            if(x_num<=-1){
                f_x=2-x_num;
            }
            else if(x_num>-1 && x_num<2){
                f_x=3;
            }
            else{
                f_x=1+x_num;
            }
            System.Console.WriteLine("f("+x_num+") = "+f_x);

            //if 예제 15번
            System.Console.Write("세 개의 정수를 입력하라 : ");
            int number1=Convert.ToInt32(Console.ReadLine());
            int number2=Convert.ToInt32(Console.ReadLine());
            int number3=Convert.ToInt32(Console.ReadLine());
            int max_val;
            if(number1<number2){
                if(number3<number1){
                    max_val=number2;
                }
                else{
                    if(number2<number3){
                        max_val=number3;
                    }
                    else{
                        max_val=number2;
                    }
                }
            }
            else{
                if(number3<number2){
                    max_val=number1;
                }
                else{
                    if(number3<number1){
                        max_val=number1;
                    }
                    else{
                        max_val=number3;
                    }
                }
            }
            System.Console.WriteLine("최대수 : "+max_val);

            //if 예제 16번
            System.Console.WriteLine("2000m까지 주행비행 : 3500원, 초과 시 100m마다 추가요금 100원");
            System.Console.Write("주행거리를 입력하라 : ");
            int distance=Convert.ToInt32(Console.ReadLine());
            int payment;
            if(distance<=2000){
                payment=3500;
            }
            else{
                int over_dist=distance-2000;
                payment=3500+(over_dist/190+1)*100;
            }
            System.Console.WriteLine(distance+" m --> 요금 = "+payment);

            //if 예제 17번
            System.Console.WriteLine("계산기 프로그램");
            System.Console.Write("두 정수를 입력하세요 : ");
            int int1=Convert.ToInt32(Console.ReadLine());
            int int2=Convert.ToInt32(Console.ReadLine());
            System.Console.Write("연산자를 입력하세요 : ");
            string oper=Console.ReadLine();
            if(oper=="+"){
                System.Console.WriteLine(int1+int2);
            }
            else if(oper=="-"){
                System.Console.WriteLine(int1-int2);
            }
            else if (oper=="*"){
                System.Console.WriteLine(int1*int2);
            }
            else if(oper=="/"){
                System.Console.WriteLine(int1/int2);
            }
            else{
                System.Console.WriteLine("end");
            }

            //if 예제 18번
            System.Console.Write("두 정수를 입력하세요 : ");
            num1=Convert.ToInt32(Console.ReadLine());
            num2=Convert.ToInt32(Console.ReadLine());
            int bigger;
            int biggest_common=1;
            if(num1>num2){
                bigger=num2;
            }
            else{
                bigger=num1;
            }
            for(int i=1; i<=bigger; i++){
                if(num1 %i==0 && num2 %i==0){
                    biggest_common=i;
                }
            }
            System.Console.WriteLine("최대공약수 : "+biggest_common);

            //if 예제 19번
            System.Console.WriteLine("1부터 값을 더해서 처음으로 1000을 초과하는 수 찾기");
            int result=1;
            int tot=0;
            while(tot<=1000){
                tot+=result;
                result++;
            }
            System.Console.WriteLine("총합 : "+tot);
            System.Console.WriteLine("값 : "+result);

            //if 예제 20번
           int i=1;
           while(i<=10){
               int tot_val=1;
               for(int j=1; j<=i; j++){
                   tot_val*=j;
               }
               System.Console.WriteLine(i+" ! = "+tot_val);
               i++;
           }

            //if 예제 21번
            restart:
            System.Console.Write("삼각형 밑변과 높이 입력 : ");
            height=Convert.ToInt32(Console.ReadLine());
            int width=Convert.ToInt32(Console.ReadLine());
            if(height <=0 || width <=0){
                System.Console.WriteLine("잘못된 입력!!");
                goto restart;
            }
            double side=Math.Sqrt(width*width+height*height);
            System.Console.WriteLine("빗변의 길이 : "+side);

            //if 예제 22번
            System.Console.WriteLine("도형의 넓이 계산기");
            System.Console.Write("도형 입력 (1.원, 2.삼각형, 3.사각형) : ");
            string shape=Console.ReadLine();
            if(shape=="원"){
                System.Console.Write("반지름 입력 : ");
                int radius=Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("넓이 : "+radius*radius*3.14);
            }
            else if (shape=="삼각형"){
                System.Console.Write("밑변, 높이 입력 : ");
                height=Convert.ToInt32(Console.ReadLine());
                width=Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("넓이 : "+height*width/2.0);
            }
            else{
                System.Console.WriteLine("사각형 계형 선택 (1.사다리꼴, 2.평행사변형, 3.직사각형, 4.정사각형");
                string name=Console.ReadLine();
                if(name == "사다리꼴"){
                    System.Console.Write("윗변, 아랫변, 높이 입력 : ");
                    int top=Convert.ToInt32(Console.ReadLine());
                    int bottom=Convert.ToInt32(Console.ReadLine());
                    height=Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("넓이 : "+(top+bottom)*height/2.0);
                }
                else if(name=="평행사변형"){
                    System.Console.Write("밑변, 높이 입력 : ");
                    height=Convert.ToInt32(Console.ReadLine());
                    width=Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("넓이 : "+height*width);
                }
                else{
                     System.Console.Write("가로, 세로 입력 : ");
                    height=Convert.ToInt32(Console.ReadLine());
                    width=Convert.ToInt32(Console.ReadLine());
                    System.Console.WriteLine("넓이 : "+height*width);
                }
            }

            //if 예제 23번
            System.Console.WriteLine("기상 예보");
            System.Console.Write("금일 강수여부 : ");
            bool rain=Convert.ToBoolean(Console.ReadLine());
            if(rain==true){
                System.Console.WriteLine("외출 시 우산을 챙기세요");
            }

            //if 예제 24번
            System.Console.WriteLine("서로 다른 두 점 거리 구하기");
            System.Console.Write("1번째 점의 좌표 입력 : ");
            int x1=Convert.ToInt32(Console.ReadLine());
            int y1=Convert.ToInt32(Console.ReadLine());
            System.Console.Write("2번째 점의 좌표 입력 : ");
            int x2=Convert.ToInt32(Console.ReadLine());
            int y2=Convert.ToInt32(Console.ReadLine());
            if(x1==x2){
                System.Console.WriteLine("두 점 사이 거리 : "+Math.Abs(y1-y2));
            }
            else if(y1==y2){
                System.Console.WriteLine("두 점 사이 거리 : "+Math.Abs(x1-x2));
            }
            else{
                double dis=Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1));
                System.Console.WriteLine("두 점 사이 거리 : "+dis);
            }

            //if 예제 25번
            System.Console.WriteLine("서로 다른 두 일차 함수의 관계");
            System.Console.WriteLine("1번째 일차 함수의 기울기, y절편 입력 : ");
            double angle1=Convert.ToDouble(Console.ReadLine());
            double meet_y1=Convert.ToDouble(Console.ReadLine());
            System.Console.WriteLine("2번째 일차 함수의 기울기, y절편 입력 : ");
            double angle2=Convert.ToDouble(Console.ReadLine());
            double meet_y2=Convert.ToDouble(Console.ReadLine());
            if(angle1==angle2){
                if(meet_y1==meet_y2){
                    System.Console.WriteLine("두 일차함수는 일치한다.");
                }
                else{
                    System.Console.WriteLine("두 일차함수는 평행한다");
                }
            }
            else{
                System.Console.WriteLine("두 일차함수는 한 점에서 만난다.");
            }

            //if 예제 26번
            System.Console.Write("길이 입력 : ");
            int len=Convert.ToInt32(Console.ReadLine());
            System.Console.Write("단위 입력 : ");
            string unit=Console.ReadLine();
            if(unit =="inch"){
                System.Console.WriteLine(len+"inch = "+len*2.54+"cm");
            }
            else{
                System.Console.WriteLine(len+"cm = "+len/2.54+"inch");
            }

            //if 예제 27번
            System.Console.Write("직각 삼각형의 한 각을 입력 : ");
            int angle=Convert.ToInt32(Console.ReadLine());
            if(angle <=0 || angle >=90){
                System.Console.WriteLine("잘못된 입력!!");
            }
            System.Console.Write("sin, cos, tan 중 1개 선택 : ");
            string tri_func=Console.ReadLine();
            if(tri_func=="sin"){
                System.Console.WriteLine("sin("+angle+") = "+Math.Sin(angle));
            }
            else if (tri_func=="cos"){
                System.Console.WriteLine("cos("+angle+") = "+Math.Cos(angle));
            }
            else{
                System.Console.WriteLine("tan("+angle+") = "+Math.Tan(angle));
            } 

            //if 예제 28번
            System.Console.Write("서로 다른 두 정수 입력 :");
            num1=Convert.ToInt32(Console.ReadLine());
            num2=Convert.ToInt32(Console.ReadLine());
            int least_common_multi;
            if(num1>num2){
                least_common_multi=num1;
            }
            else{
                least_common_multi=num2;
            }
            while(true){
                if(least_common_multi%num1==0 && least_common_multi%num2==0){
                    System.Console.WriteLine("두 수의 최소공배수 : "+least_common_multi);
                }
                least_common_multi++;
            }

            //if 예제 29번
            System.Console.WriteLine("100이하 자연수 중 8과 9의 최소공배수 전까지의 각각의 수 구하기");
            int cnt_8=0;
            int cnt_9=0;
            for(int i=1; i<=100; i++)
            {
                if(i%8==0 && i%9==0){
                    cnt_8++;
                    cnt_9++;
                    break;
                }
                if(i%8==0){
                    cnt_8++;
                }
                if(i%9==0){
                    cnt_9++;
                }
            }
            System.Console.WriteLine("8의 배수 : "+cnt_8+"개");
            System.Console.WriteLine("9의 배수 : "+cnt_9+"개");

            //if 예제 30번
            string correct_num="98061012";
            System.Console.WriteLine("로또 번호 입력(8자리) : ");
            string user_num=Console.ReadLine();
            bool correct=true;
            System.Console.WriteLine("금주 로또 당첨 번호 : "+correct_num);
            for(int i=0; i<8; i++){
                if(correct_num[i]!=user_num[i]){
                    correct=false;
                    break;
                }
            }
            if(correct==true){
                System.Console.WriteLine("축하드립니다. 로또 당첨되셨습니다!!!");
            }
            else{
                System.Console.WriteLine("이번에 당첨되지 못하셨습니다.");
            }

            //if 예제 31번
            System.Console.WriteLine("광운대 소프트웨어학부 필수 수강 과목 확인");
            System.Console.Write("입학년도 : ");
            int year=Convert.ToInt32(Console.ReadLine());
            if(year>=2016){
                System.Console.WriteLine("광운인되기 - 필수교양");
                if(year>=2017){
                    System.Console.WriteLine("C프로그래밍, 컴퓨팅사고 - 필수교양");
                    if(year >=2019){
                        System.Console.WriteLine("대학영어 - 필수교양");
                        if(year>=2020){
                            System.Console.WriteLine("융합적사고와 글쓰기 - 필수교양");
                        }
                    }
                }
            }

            //if 예제 32번
            System.Console.Write("자연수 입력 : ");
            int num=Convert.ToInt32(Console.ReadLine());
            System.Console.Write("소인수 : ");
            for(int i=2; i<num; i++){
                re:
                if(num%i==0){
                    System.Console.Write(i+" ");
                    num=num/i;
                    goto re;
                }
            }

            //if 예제 33번
            System.Console.Write("철사의 길이 : ");
            int length=Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("삼각형의 종류");
            int tot_cnt=0;
            for(int side1=1; side1<=length; side1++){
                for(int side2=1; side2<=length; side2++){
                    int side3=length-side1-side2;
                    if(side3 >=side1 && side3>=side2 && side3<side1+side2){
                        System.Console.WriteLine(side1+" "+side2+" "+side3);
                        tot_cnt++;
                    }
                }
            }
            System.Console.WriteLine("총 "+tot_cnt+"개의 삼각형을 만들 수 있다.");

            //if 예제 34번
            int wei1=2, wei2=3, wei3=5;
            System.Console.WriteLine("추의 무게가 2g, 3g, 5g 인 추들이 각각 10개씩 있다.");
            System.Console.WriteLine("무게 총합이 80g 이상 82이하를 맞추기 위해 각각 몇 개씩 써야되는가?? (단 무게마다 1개이상은 사용한다.)");
            for(int i=1; i<=10;i++){
                for(int j=1; j<=10; j++){
                    for(int k=1; k<=10; k++){
                        int tot_wei = wei1 * i + wei2 * j +wei3 * k;
                        if(tot_wei>=80 && tot_wei<=82){
                            System.Console.WriteLine(i+" "+j+" "+k);
                        }
                    }
                }
            }

            //if 예제 35번
            System.Console.WriteLine("반올림 계산기");
            System.Console.WriteLine("유리수 입력 : ");
            double rati=Convert.ToDouble(Console.ReadLine());
            int temp=(int)rati;
            if(rati-temp<0.5){
                System.Console.WriteLine(rati+"의 반올림 : "+temp);
            }
            else{
                temp+=1;
                System.Console.WriteLine(rati+"의 반올림 : "+temp);

            }

            //if 예제 36번
            System.Console.Write("년도 입력 : ");
            year=Convert.ToInt32(Console.ReadLine());
            if(year%4==0 && year%100 !=100 || year%400==0){
                System.Console.WriteLine(year+"년은 윤년입니다.");
            }
            else{
                System.Console.WriteLine(year+"년은 평년입니다.");
            }

            //if 예제 37번
            System.Console.WriteLine("시침과 분침이 만나는 시간");
            System.Console.WriteLine("시작 시간 : 오후 1시, 종료 시간 : 오후 5시");
            double hour=1;
            double minute=0;
            for(int i=0; i<=240; i++){
                hour+=(1/60)*i;
                if(hour==12){
                    hour=0;
                }
                minute+=(1/5)*i;
                if(minute == 12){
                    minute=0;
                }
                if(hour==minute){
                    System.Console.WriteLine(hour+"시 "+minute+"분");
                }
            }

            //if 예제 38번
            int[] dice_cnt= new int[]{0,0,0,0,0,0};
            System.Console.WriteLine("주사위 3000번 던져 나온 눈의 수");
            Random rand = new Random();
            for(int i=0; i<3000; i++){
                int rand_num=rand.Next(1,7);
                if(rand_num==1){
                    dice_cnt[0]++;
                }
                else if(rand_num==2){
                    dice_cnt[1]++;
                }
                else if(rand_num==3){
                    dice_cnt[2]++;
                }
                else if(rand_num==4){
                    dice_cnt[3]++;
                }
                else if(rand_num==5){
                    dice_cnt[4]++;
                }
                else{
                    dice_cnt[5]++;
                }
            }
            for(int i=0; i<6; i++){
                System.Console.WriteLine("주사위 "+(i+1)+"의 갯수 : "+dice_cnt[i]);
            }

            //if 예제 39번
           System.Console.WriteLine("1인 입장료 : 3000원");
           System.Console.WriteLine("30명 이상 입장 시 입장료 10% 할인");
           System.Console.WriteLine("몇 명 이상 입장 시 30명치 입장료를 사는게 더 이득인가??");
           int tot_price=3000*30*9/10;
           for(int i=1; i<=30; i++){
               if(3000*i>tot_price){
                   System.Console.WriteLine(i+"명 이상 입장시 30명치 입장료 사는게 더 이득이다.");
                   break;
               }
           }

           //if 예제 40번
            System.Console.WriteLine("Up & Down 게임");
            System.Console.WriteLine("1~100 사이 정수를 맞추어라");
            System.Console.WriteLine("기회는 5번");
            int limit=0;
            Random ran=new Random();
            int random_num=ran.Next(1,101);
            while(true){
                if(limit >5){
                    System.Console.WriteLine("실패!!");
                }
                System.Console.Write("정수 입력 : ");
                num=Convert.ToInt32(Console.ReadLine());
                limit++;
                if(num<random_num){
                    System.Console.WriteLine("Up"); 
                }
                else if(num > random_num){
                    System.Console.WriteLine("Down");
                }
                else{
                    System.Console.WriteLine("정답!!!");
                    System.Console.WriteLine(limit+"번만에 정답을 맞추셨습니다.");
                    break;
                }
            }

            //if 예제 41번
            System.Console.Write("문자열 입력 : ");
            string str=Console.ReadLine();
            System.Console.WriteLine("찾고자하는 문자 입력 : ");
            char ch=Convert.ToChar(Console.Read());
            for(int i=0; i<str.Length; i++){
                if(str[i]==ch){
                    System.Console.WriteLine((i+1)+"위치에 해당 문자 존재");
                }
            }

            //if 예제 42번
            System.Console.Write("문자열1 입력 : ");
            string str1=Console.ReadLine();
            System.Console.Write("문자열2 입력 : ");
            string str2=Console.ReadLine();
            bool is_same=true;
            if(str1.Length==str2.Length){
                is_same=false;
            }
            goto jump;
            for(int i=0; i<str.Length; i++){
                if(str1[i] != str2[i]){
                    is_same=false;
                    break;
                }
            }
            jump:
            if(is_same==true){
                System.Console.WriteLine("두 문자열은 같습니다.");
            }
            else{
                System.Console.WriteLine("두 문자열은 다릅니다.");
            }

            //if 예제 43번
            System.Console.Write("나이 입력 : ");
            int age=Convert.ToInt32(Console.ReadLine());
            int money=10000;
            if(age>=7 && age <=12){
                System.Console.WriteLine("교통 요금 : 450원");
                money-=450;
            }
            else if(age >=13 && age <=18){
                System.Console.WriteLine("교통 요금 : 720원");
                money-=720;
            }
            else{
                System.Console.WriteLine("교통 요금 : 1200원");
                money-=1200;
            }
            System.Console.WriteLine("잔액 : "+money);
            
            //if 예제 44번
            System.Console.WriteLine("현재 시간");
            System.Console.WriteLine("시 : ");
            hour=Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("분 : ");
            minute=Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("몇 분 뒤에 시간을 구하시오 : ");
            System.Console.Write("경과된 시간 입력 : ");
            int min=Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<min; i++){
                minute++;
                if(minute==60){
                    minute=0;
                    hour++;
                }
            }
            System.Console.WriteLine("경과된 시간 "+hour+"시 "+minute+"분");

            //if 예제 45번
            System.Console.WriteLine("쪽지시험 점수 계산");
            System.Console.WriteLine("1 ~ 3번 : 1점");
            System.Console.WriteLine("4 ~ 6번 : 2점");
            System.Console.WriteLine("7 ~ 9번 : 3점");
            System.Console.WriteLine("10번 : 5점");
            int tot_score=0;
            for(int i=0; i<10; i++){
                System.Console.WriteLine((i+1)+"번 문제 맞췄습니까? (Yes/No)");
                string is_correct=Console.ReadLine();
                if(is_correct=="Yes"){
                    if(i>=0 && i<=2){
                        tot_score+=1;
                    }
                    else if(i >=3 && i<=5){
                        tot_score+=2;
                    }
                    else if(i>=6 && i<=8){
                        tot_score+=3;
                    }
                    else{
                        tot_score+=5;
                    }
                }
            }
            System.Console.WriteLine("총점 : "+tot_score);

            //if 예제 46번
            System.Console.WriteLine("각 달마다 날짜");
            for(int i=1; i<=12; i++){
                if(i==1 || i==3 || i==5 || i==7 || i==8 || i==10 || i==12){
                    System.Console.WriteLine(i+"월은 31일입니다.");
                }
                else if(i==4 || i==6 || i==9 || i==11){
                    System.Console.WriteLine(i+"월은 30일입니다.");
                }
                else{
                    System.Console.WriteLine(i+"월은 28입니다.");
                }
            }

            //if 예제 47번
            string[] book_name = new string[100];
            int book_cnt =0;
            while(true){
                System.Console.WriteLine("원하시는 기능을 선택하세요");
                System.Console.WriteLine("1. 도서 추가");
                System.Console.WriteLine("2. 도서 찾기");
                System.Console.WriteLine("3. 종료");
                System.Console.WriteLine();
                int num = Convert.ToInt32(Console.ReadLine());
                if(num==1){
                    System.Console.Write("추가할 책 이름: ");
                    string name = Console.ReadLine();
                    book_name[book_cnt]=name;
                    book_cnt++;
                }
                else if(num==2){
                    System.Console.Write("찾으실 책 이름: ");
                    string name = Console.ReadLine();
                    for(int i = 0; i < book_cnt; i++){
                        if(name == book_name[i]){
                            System.Console.WriteLine("찾으시는 책은 "+(i+1)+"번 째에 위치했습니다.");
                        }
                    }
                }
                else{
                    System.Console.WriteLine("프로그램을 종료합니다.");
                    break;

                }
            }

            //if 예제 48번
            System.Console.Write("정수 입력 : ");
            num=Convert.ToInt32(Console.ReadLine());
            temp=num;
            int pali_num=0;
            while(temp>0){
                int temp_num=temp%10;
                temp/=10;
                pali_num=pali_num*10+temp_num;
            }
            if(pali_num==num){
                System.Console.WriteLine(num+"은 회문수입니다.");
            }
            else{
                System.Console.WriteLine(num+"은 회문수가 아닙니다.");
            }

            //if 예제 49번
            System.Console.Write("출생년도 : ");
            int born_year=Convert.ToInt32(Console.ReadLine());
            System.Console.Write("성별 (남/여) : ");
            string gender=Console.ReadLine();
            if(born_year<2000){
                if(gender=="남"){
                    System.Console.WriteLine("주민번호 뒷자리 처음이 1로 시작");
                }
                else{
                    System.Console.WriteLine("주민번호 뒷자리 처음이 2로 시작");
                }
            }
            else{
                 if(gender=="남"){
                    System.Console.WriteLine("주민번호 뒷자리 처음이 3로 시작");
                }
                else{
                    System.Console.WriteLine("주민번호 뒷자리 처음이 4로 시작");
                }
            }

            //if 예제 50번
            System.Console.Write("숫자: ");
            string s = Console.ReadLine();
            for(int i=0; i<s.Length; i++){
                if(s[k]<'0' || s[k]>'9'){
                    System.Console.WriteLine("잘못된 입력, 숫자안에 문자가 끼어 있음.");
                    break;
                }
            }

            //for, while 예제 1번
            System.Console.WriteLine("1 ~ 100까지 자연수의 합");
            int sum=0;
            for(int i=1; i<=100; i++){
                sum+=i;
            }
            System.Console.WriteLine(sum);


            //for, while 예제 2번
            System.Console.WriteLine("구구단 출력");
            for(int i=1; i<10; i++){
                for(int j=1; j<10; j++){
                    System.Console.Write(i+" X "+j+" = "+(i*j));
                }
                System.Console.WriteLine();
            }

            //for, while 예제 3번
            System.Console.WriteLine("펙토리얼(!) 구하기");
            System.Console.Write("정수 입력 : ");
            num=Convert.ToInt32(Console.ReadLine());
            int tot_fac=1;
            for(int i=1; i<=num; i++){
                tot_fac*=i;
            }
            System.Console.WriteLine(num+"! = "+tot_fac);

            //for, while 예제 4번
            System.Console.WriteLine("피라미드 계형 만들기");
            for(int i=0; i<5;i++){
                for(int j=i; j<=4; j++){
                    System.Console.Write(" ");
                }
                for(int k=0;k<=(2*i); k++){
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }

            //for, while 예제 5번
            System.Console.WriteLine("다이아몬드 계형 만들기");
            for(int i=0; i<5;i++){
                for(int j=i; j<=4; j++){
                    System.Console.Write(" ");
                }
                for(int k=0;k<=(2*i); k++){
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }

            for(int i=5; i>0; i--){
                for(int j=i; j<=5; j++){
                    System.Console.Write(" ");
                }
                for(int k=0; k<=((i-1)*2); k++){
                    System.Console.Write("*");
                }
                System.Console.WriteLine();
            }

            //for, while 예제 6번
            System.Console.WriteLine(" AB");
            System.Console.WriteLine(" BA");
            System.Console.WriteLine("+ ");
            System.Console.WriteLine("----");
            System.Console.WriteLine(" 99");
            System.Console.WriteLine("다음 조건을 만족하는 A,B의 순서쌍을 고르시오");
            for(int a=0; a<=9; a++){
                for(int b=0; b<=9; b++){
                    int sum1=10*a+b;
                    int sum2=10*b+a;
                    if((sum1+sum2) == 99 ){
                        System.Console.WriteLine("("+a+", "+b+")");
                    }
                }
            }

            //for, while 예제 7번
            System.Console.WriteLine("1부터 100까지 제곱근이 자연수인 자연수");
            for(int i=1; i<=100; i++){
                double sqrt=Math.Sqrt(i);
                int to_int=(int)sqrt;
                if(sqrt-to_int ==0){
                    System.Console.WriteLine(i);
                }
            }

            //for, while 예제 8번
            System.Console.Write("괄호의 개수를 입력하라 : ");
            int par_num=Convert.ToInt32(Console.ReadLine());
            for(int i=1; i<=par_num; i++){
                int tot_num=0;
                for(int j=1; j<=i; j++){
                    tot_num+=j;
                }
                System.Console.WriteLine(" "+i+"\t"+tot_num);
            }

           //for, while 예제 9번
           System.Console.Write("알파벳 입력 : ");
           char alpha=Convert.ToChar(Console.Read());
           int apha_cnt=0;
           for(char ch='a'; ch<=alpha; ch++){
               apha_cnt++;
           }
           System.Console.WriteLine(alpha+"은 알파벳 "+apha_cnt+"번째 알파벳이다.");

            //for, while 예제 10번
            System.Console.WriteLine("섭씨 0도 부터 섭씨 100도 까지 화씨온도를 구해라");
            System.Console.WriteLine("-----------------------------------------------");
            System.Console.WriteLine("\t섭씨\t화씨");
            System.Console.WriteLine("-----------------------------");
            for(int i=0; i<=100; i+=10){
                double fire=1.8*i+32;
                System.Console.WriteLine(i+"\t"+fire);
            }

            //for, while 예제 11번
            System.Console.WriteLine("x의 범위 1~100");
            System.Console.WriteLine("이차방정식의 최대값을 찾아라");
            System.Console.Write("이차항의 계수 : ");
            x2=Convert.ToInt32(Console.ReadLine());
            System.Console.Write("일차항의 계수 : ");
            x1=Convert.ToInt32(Console.ReadLine());
            System.Console.Write("상수항의 계수 : ");
            num=Convert.ToInt32(Console.ReadLine());
            int maximum=-2147483648;
            for(int i=1; i<=100; i++){
                int temp_val = x2*i*i + x1*i + num;
                if(maximum< temp_val){
                    maximum=temp_val;
                }
            }
            System.Console.WriteLine("이차방정식의 최대값 : "+maximum);

            //for, while 예제 12번
            const double PI = 3.1415926;
            System.Console.WriteLine("\tsin\t cos\t tan");
            System.Console.WriteLine();
            for(int i=0; i<=90; i+=5){
                radius=(i*PI)/180;
                System.Console.WriteLine(i+"\t"+Math.Sin(radius)+"\t"+Math.Cos(radius)+"\t"+Math.Tan(radius));
            }

            //for, while 예제 13번
            System.Console.WriteLine("하나의 정수를 입력하라 : ");
            num=Convert.ToInt32(Console.ReadLine());
            int fin_val=0;
            for(int i=1; i<=num; i++){
                int fac=1;
                for(int j=0; j<=i; j++){
                    fac*=i;
                }
                fin_val+=fac;
                if(i !=num){
                    System.Console.Write(i+"! +");
                }
                else{
                    System.Console.WriteLine(i+"! = "+fin_val);
                }
            }

            //for, while 예제 14번
            System.Console.Write("십진수 입력 : ");
            int ten_int=Convert.ToInt32(Console.ReadLine());
            int two_int=0;
            int i=0;
            while(ten_int>0){
                two_int+=Math.Pow(10,i)*(ten_int%2);
                ten_int/=2;
            }
            System.Console.WriteLine("이진수 변환 : "+two_int);

            //for, while 예제 15번
            System.Console.Write("2진수 입력");
            two_int=Convert.ToInt32(Console.ReadLine());
            ten_int=0;
            i=0;
            while(two_int>0){
                ten_int+=Math.Pow(2,i)*(two_int%10);
                two_int/=10;
            }
            System.Console.WriteLine("십진수 변환 : "+ten_int);

            //for, while 예제 16번
            System.Console.Write("10개의 수 입력");
            int[] arr= new int[10];
            for(int i=0; i<10; i++){
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0; i<10; i++){
                for(int j=i; j<10; j++){
                    if(arr[i]>arr[j]){
                        temp=arr[j];
                        arr[j]=arr[i];
                        arr[i]=temp;
                    }
                }
            }
            System.Console.WriteLine("정렬 후 ");
            for(int i=0; i<10; i++){
                System.Console.Write(arr[i]+" ");
            }
            System.Console.WriteLine();

            //for, while 예제 17번
            System.Console.WriteLine("별 모양 그림 그리기");
            for(int i = 0 ; i < 9; i++){
                for(int j = 0; j<9;j++){
                    if(i==j || k==8-i){
                        System.Console.Write("*");
                    }
                    else{
                        System.Console.Write(" ");
                    }
                }
                System.Console.WriteLine();
            }

            //for, while 예제 18번
            System.Console.WriteLine("5 X 5 Matrix");
            num=1;
            for(int i=0; i<5; i++){
                for(int j=0; j<5; j++){
                    System.Console.Write(num+" ");
                    num++;
                }
                System.Console.WriteLine();
            }

            //for, while 예제 19번
            System.Console.Write("n과 r을 입력하라 : ");
            int n=Convert.ToInt32(Console.ReadLine());
            int r=Convert.ToInt32(Console.ReadLine());
            int combination=1;
            for(int i=n; i>n-r; i--){
                combination*=i;
            }
            for(int i=r; i>0; i--){
                combination/=i;
            }
            System.Console.WriteLine("n combination r : "+combination);

            //for, while 예제 20번
            System.Console.Write("a 와 b를 입력 : ");
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            int power_num=1;
            for(int i=0; i<b; i++){
                power_num*=a;
            }
            System.Console.WriteLine(a+"의 "+b+"제곱 : "+power_num);

        }
    }
}