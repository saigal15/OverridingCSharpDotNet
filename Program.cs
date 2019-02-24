using System;



class top{
    protected int a;
    public top(int a){
        this.a = a;
      
    }
      public virtual void display(){
            Console.WriteLine("A:" +a);
        }

}

class subtop : top {
     int b;
     public subtop(int a, int b): base(a){
         this.b = b;
     }
    public override void display(){
        Console.WriteLine("A:" + a);
        Console.WriteLine("B:" +b );
    }

    public void add(int a, int b){
        var addition = a + b;
       Console.WriteLine("AddValue:" + (addition));
    }

    public void sub(int a, int b){
        var subtraction = a - b;
        Console.WriteLine("SubValue:" + (subtraction));
    }

    public void Mul(int a, int b){
        var Multiplication = a * b;
        Console.WriteLine("MulValue:" + (Multiplication));
    }
}

namespace OverridingExample
{
    class Program
    {
        static void Main(string[] args)
        {
           subtop obj = new subtop(5,20);
           obj.display();
           obj.add(20,20);
           obj.sub(100,50);
           obj.Mul(5,5);
        }
    }
}
