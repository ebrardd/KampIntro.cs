

using Metotlar.cs;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //metotlar tekrar tekrar kullanılabilirligi saglar

        Mark mark1 = new Mark();
        mark1.Lesson = "math";
        mark1.classNo = 8;
        mark1.Teacher = "mustafa";

        Mark mark2 = new Mark();
        mark2.Lesson = "phy";
        mark2.classNo = 2;
        mark2.Teacher = "tom";

        Mark mark3 = new Mark();
        mark3.Lesson = "comp";
        mark3.classNo = 5;
        mark3.Teacher = "elizabeth";

        Mark[] marks = new Mark[] { mark1, mark2, mark3 };
        //type safety - tip güvenli
        foreach (var mark in marks)
        {
            Console.WriteLine(mark.Teacher + ":" + mark.Lesson);
        }
        // ID bir datayı digerinden ayırt etmek icin kullandigimiz essiz degeri anlatir
       
        //instance - örnek
        StudentManager studentManager = new StudentManager();
        studentManager.Add(mark1);
        studentManager.Add(mark2);
        studentManager.Add(mark3);













    }
}