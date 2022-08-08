using System;
using System.Windows.Forms;
namespace _20220808
{
    class MyArea : Form
    {
        public MyArea()
        {

            // 이 부분은 당분간 무시.(무명메서드 참조)
            // 예제를 테스트하기 위한 용도임.
            this.MouseClick += delegate { MyAreaFlicked(); };
        }
        public delegate void ClickEvent(object sender);

        // event 필드
        public event ClickEvent MyClick;

        //예제를 단순화 하기 위해
        // MyArea가 클릭되면 아래 함수가 호출된다고 가정
        void MyAreaClicked()
        {
            if (MyClick != null)
            {
                MyClick(this);
            }
        }
    }

    class Program
    {
        static MyArea area;
        static void Main(string[] args)
        {
            
            area = new MyArea();

            area.MyClick += Area_Click;
            area.MyClick += AfterClick;

            area.MyClick -= Area_Click;

            area.ShowDialog();
            
        }

        static void Area_Click(object sender)
        {
            area.Text += "MyArea 클릭!";
        }
        static void AfterClick(object sender)
        {
            area.Text += "AfterClick 클릭";
        }

        void myfunc(int x)
        {
            printf("%d\n", x);
        }

        void main()
        {
            // 함수포인터 f정의
            void(*f)(int);

            //함수포인터에 함수 지정
            f = &myfunc;

            //함수실행
            f(2);
        }

        // C++ Pointer to member 예제
        
        class Cls
        {
        public:
                //클래스 메서드 멤버
            void myfunce(std::string str)
            {
                std::cout << str << std::endl;
            }
        };

        void main()
        {
            // pointer to member function 정의
            void(Cls::* fp)(std::string);

            //Pointer to member 지정
            fp = &Cls::myfunc;

            //Cls 객체 생성 및 객체 포인터 지정
            Cls obj;
            Cls* pObj = &obj;

            //Cls 객체에서 함수포인터 사용
            (pObj-> * fp)("Hello");
        }
    }


}
