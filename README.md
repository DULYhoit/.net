# C# 기본
1. C# 에 대한 역사 개요는 나무위키 참조바람 : https://namu.wiki/w/C%23
---
## C# 으로 할수있는것들
1. 윈도우 콘솔.
2. 윈도우 Form(윈도우 응용프로그램)
3. WPF(Windows Presentation Foundation) = 윈도우 응용 프로그램 개발
4. xamarin(자마린) = ios,Andriod,win 개발
5. ASP.NET webform
6. ASP.NET MVC == spring MVC 비슷
7. unity 3d
- c# << c++
- WPF를 unity 3d 로 제작

## C# 기본문법
0. 전체적으로 Java 와 비슷한 맥락
1. 데이터형
~~~C#
        //정수형 데이터
        short shortNum = 0;

        int intNum = 0;

        long longNum = 0;

        float floatNum = 0;

        //문자형 데이터 : C# 변수명은 소문자
        string stringText = "";

        char charText = 'a';

        //논리데이터
        bool boolval = false;

        //.net framwork 변수 굳이 .net 변수를 쓸이유가없음

        Int16 dotNetShort = 0;
        Int32 dotNetInt = 0;
        Int64 dotNetLong = 0;
        String dotNetString = "";

        //다이나믹 타입 :JavaScript 참조변수 선언과같이 들어온값에 알아서 데이터 참조된다
        var dynamicType = 0;
~~~
2. if
~~~C#
    var num = "1";

        Console.WriteLine("0 ~ 9 사이의 값을 입력 : ");
        var input = Console.ReadLine();
        
        
        if(num == input)
        {
            Console.WriteLine("입력한 값 : " + input);
        }
~~~
3. while
~~~C#
var num = 1;
        while (num < 10)
        {
            Console.WriteLine(num2++);
        }
        //무한반복
var num = 1;
        while (true)
        {
           num++;
           if(num == 10)
           {
            break;
           }
        }
~~~
4. for
~~~C#
    for ( int i = 0; i< 10; i++ )
        {
            Console.WriteLine(i);
        }
~~~
5. List
~~~C#
    List<string> list = new List<string>();
        list.Add("kim");
        list.Add("park");
        list.Add("chun");
//ms에서 지원하는 문법 : 선언과동시에 값입력
    List<string> list = new List<string>(){
        "test1",
        "test2",
        "test3",
        "test4",
        "test5",
    }
~~~

6. prop (getter,setter)
~~~C#
User
        public int No { get; set; }
        public int Name { get; set; }
        public int Age { get; set; }
        public int Phone { get; set; }  
~~~
~~~C#
Main
        var user1 = new User();

        user1.No = 1;
        user1.Name = "임똘똘";

        var user2 = new User();
        user2.No = 2;
        user2.Name = "김복순";

        var list = new List<User>();
        list.Add(user1);
        list.Add(user2);

        foreach (var item in list)
        {
            Console.WriteLine(item.No);
            Console.WriteLine(item.Name);
        }
~~~