// See https://aka.ms/new-console-template for more information

class Program
{
    private static IEnumerable<string> colors;

    static void Main(string[] args)
    {
        string color1 = "blue";
        string color2 = "pink";
        string color3 = "white";
        //array- dizi
        string[] color = new string[] { color1, color2, color3 };
        for (int i = 0; i < color.Length; i++)
        { Console.WriteLine(color[i]); }
        foreach (string color in colors)
        { 
            Console.WriteLine(color);
        }

        for (int i = 1; i < 10; i++)
        {
            Console.WriteLine(i);
        }
    }
}
 









 

