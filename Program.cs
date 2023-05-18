class Program
{
    static void Main(string[] args)
    {
        //can only use the ref keyword if your variable has an initial value
      int studentGrade = 75;
        //passes location of memory by reference and not by memory
        ExtraCreditRef(ref studentGrade);
        Console.WriteLine(studentGrade);
    //for this example it would be the same with or without the ref keyword
    }
    static void ExtraCreditRef( ref int studentGrade)
    {
            studentGrade +=3;

    }
}