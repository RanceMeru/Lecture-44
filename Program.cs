class Program
{
    static void Main(string[] args)
    {
        //can only use the ref keyword if your variable has an initial value
      //int studentGrade = 75;
      //to use with no value needs the out keyword
      int studentGrade;
        //passes location of memory by reference and not by memory
        ExtraCreditRef(out studentGrade);
        Console.WriteLine(studentGrade);
    //for this example it would be the same with or without the ref keyword
    }
    static void ExtraCreditRef( out int studentGrade)
    {
        //have to give the original  value
            studentGrade = 0;
            studentGrade +=3;

    }
}