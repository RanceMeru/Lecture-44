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


        int add;
        int multi;
        AddanddMulti(5,10, out add, out multi); 
        Console.WriteLine(add);
        Console.WriteLine(multi);

    }
    static void ExtraCreditRef( out int studentGrade)
    {
        //have to give the original  value
            studentGrade = 0;
            studentGrade +=3;

    }

     public static void AddanddMulti(int a, int b, out int added, out int multi)
    {

        added = a + b;
        multi = a * b;
    }


}