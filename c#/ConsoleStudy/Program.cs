using ConsoleStudy;

internal class Program
{
    private static void Main(string[] args)
    {
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



    }
}