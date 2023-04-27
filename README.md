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
7. class Method
- C#에선 ClassLibrary가 Java의 packige 역할을함
- public, private , internal(어셈블리 코드에서만 사용가능)
# ASP.NET MVC
---
## 0.MSSQL

## 1.ASP.NET
1. Web Form
- WinForm : 웹페이지 내에 소스 코드 존재할 수 있다.
- 유지보수 어려움.

2. ASP.NET MVC
- View -> HTML CSS Javascript
- Controller -> DB 통신
- Model -> User 데이터를 담을수 있는 객체

3. SignalR
- 실시간 채팅 서비스

4. Web API
- DB 에서 나온 정보를 XML JSON 형식 송출해주는 서비스

---
## 2.lay out과 주소매칭
- Header와 footer등 layout으로 고정하고 body부분을 
@RenderBody() 를 통해 삽입한다.
- 주소매칭 : 기본적으로 Program.cs 쪽에 pattern 설정 되어있다 
- 1. Controller 를만들고 메서드 이름을 매칭시킬 폴더의 html 이름과 똑같이한다.

## 3.Razor Syntax
- JSP 와 똑같이 html 파일내에서 코드 작성을 가능하게 한다.
- 1. @{} 로시작한다 
- 2. if, for, foreach 사용가능
- 3. 타입 캐스팅 (string) -> (int), ToString(); 사용가능 
- Ex)
~~~html
@{var name = "홍길동"}
<h1>@name</h1>
~~~
~~~C#
@{
    var num == 10;
}
@if(num == 10)
{
    <h2>@num 이 10 입니다.</h2>
}
else
{
    <h2>@num 이 10 이 아닙니다.</h2>
}
~~~

## 4.Model 정보를 View로 넘기기
1. 객체를 만들어서 View(객체) 던지기
~~~C#
var User = new User{
    No = 1;
    Name = "홍길동";
    return View(User);

    <view>
    <h1>@Model.No</h1>
    <h1>@Model.Name</h1>
}
~~~
2. ViewBag 사용
~~~C#
var User = new User{
    No = 1;
    Name = "홍길동";

    ViewBag.명칭 = User;
    return View();
    
    <view>
    <h1>@ViewBag.명칭.No</h1>
    <h1>@ViewBag.명칭.Name</h1>
~~~
3. ViewData
~~~C#
var User = new User{
    No = 1;
    Name = "홍길동";

    ViewData["명칭"] = User.No;
    ViewData["명칭"] = User.Name;
    
    return Vies();

    <view>
    <h1>@ViewData["명칭"]</h1>
    <h1>@ViewData["명칭"]</h1>
~~~
---
# DataBase
## MS SQL
1. 
## ASP.NET MVC 로 DB 통신
1. ADO.NET 
- OJDBC 랑 비슷

2. EnterPrise Library 5
- 쿼리문 직접 작성 -> 값을 받아 처리 (Ado.NET 보다 core기능이 좋다고함)
- Logging


3. ORM 기법
- 쿼리문을 직접 작성 -> 오류 발생의 소지가높음 따라서 ORM 등장
- 객체 관계 매핑 (Object-relational mapping)
- 객체 지향 프로그래밍 언어 간의 호환되지 않는 데이터를 변환하는 프로그래밍 기법이다. 객체 관계 매핑 이라고도 부름
- Java : JPA,Mybatis,ibatais,하이버네이트
- C# : Entityframwork 1.0 ~ 7.0 Mapper

4. EntityFrameWork (개발 방식 2가지)
- Database First 방식
   - Database DBA(데이터베이스 관리자)
   - 설계 완료, 물리적 데이터베이스도 모두 완성된 상태
- Code First 방식
   - Code -> Database 생성해 제작
---
## SET UP
1. ASP.NET MVC CORE

2. EntityFramework Core 설치
- core, tool , sqlserver 설치

3. dbContext 생성 -> Table 생성할 수 있는 코드 작성

4. DbContext -> 실제 테이블 생성

## Code First

Model Class - > DbContext -> 실제 테이블생성
