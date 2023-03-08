using objectorintedDemo;

public class Program
{
    public static void Main()
    {
        Doctor doctor1 = new Doctor();
        Console.WriteLine("doctor1 object");
        doctor1.Getdata();
        doctor1.putData();

        Doctor doctor2 = new Doctor();
        Console.WriteLine("doctor2 object");
        doctor2= new Doctor();
        doctor2.Getdata();


        // Doctor,TypeCastingDemo(); 
    }
}