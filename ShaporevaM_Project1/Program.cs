namespace helloworld_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What grade do you expect to get?");
            int grade = Int32.Parse(Console.ReadLine());
            string gradeLetter = "";
            if (grade >= 98)
                gradeLetter = "A+";
            if (grade >= 92 && grade <= 97)
                gradeLetter = "A";
            if (grade >= 90 && grade <= 91)
                gradeLetter = "A-";
            if (grade >= 88 && grade <= 89)
                gradeLetter = "B+";
            if (grade >= 82 && grade <= 87)
                gradeLetter = "B";
            if (grade >= 80 && grade <= 81)
                gradeLetter = "B-";
            if (grade >= 78 && grade <= 79)
                gradeLetter = "C+";
            if (grade >= 72 && grade <= 77)
                gradeLetter = "C";
            if (grade >= 70 && grade <= 71)
                gradeLetter = "C-";
            if (grade >= 68 && grade <= 69)
                gradeLetter = "D+";
            if (grade >= 62 && grade <= 67)
                gradeLetter = "D";
            if (grade >= 60 && grade <= 61)
                gradeLetter = "D-";
            if (grade < 60)
                gradeLetter = "F";
            Console.WriteLine(gradeLetter);
            
        }
    }
}
