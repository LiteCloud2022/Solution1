using ClassLibrary;
class Exersice
{ 
    static void Main()
    {
        int N = 0;
        Console.WriteLine("Enter N: ");
        N = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Exercise #1:");
        ClassLibrary.Exercise1 exercise1 = new ClassLibrary.Exercise1();
        exercise1.DoSequence(N);
        Console.WriteLine("Exercise #2:");
        ClassLibrary.Exercise2 exercise2 = new ClassLibrary.Exercise2();
        exercise2.DoRectangle(N);
    }
}