namespace NewApp.Models
{
    public class Student : Person
    {
        public string StudentCode { get; set; }
        public void EnterData()
        {
            //ke thua lai phuong thuc o class Person
            base.EnterData();
            //phat trien them nhap thong tin Student code
            System.Console.Write("Student Code = ");
            StudentCode = Console.ReadLine();
        }
        public void Display()
        {
            //ke thua lai phuong thuc o class Person
            base.Display();
            //phat trien hien thi nhap thong tin Student code
            System.Console.Write("- Ma sinh vien: {0}\n", StudentCode);
        }
    }
}