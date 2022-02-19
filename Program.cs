// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

class Employee<T>
{
public void GetTransaction(T i){
    Console.WriteLine(i);
}
}
class HCL:Employee<double>{
public static void Main(){
  HCL obj=new HCL();
    obj.GetTransaction(10.5);
}
}
