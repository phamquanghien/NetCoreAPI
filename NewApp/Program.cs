using System.Diagnostics;
using System.Collections;
using NewApp.Models;

public class Program
{
    public static void Main(string[] args)
    {
        ArrayList arrList = new ArrayList();
        for(int i = 0; i < 3; i++)
        {
            Person ps = new Person();
            ps.EnterData();
            arrList.Add(ps);
        }
        // foreach(Person ps in arrList)
        // {
        //     ps.Display();
        // }
        for(int i = 0; i < 3; i++)
        {
            Person ps = (Person) arrList[i];
            ps.Display();
        }
        // List<Person> list = new List<Person>();
        // for(int i = 0; i < 3; i++)
        // {
        //     Person ps = new Person();
        //     ps.EnterData();
        //     list.Add(ps);
        // }
        // foreach(Person ps in list)
        // {
        //     ps.Display();
        // }
        List<int> intList = new List<int>();
        intList.Add(1);
    }
}