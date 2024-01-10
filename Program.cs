
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int i = 0;
while(true)
{
    if (i < 10){
        i++;
        Thread th = new Thread(() => new MyHelper().SleepXSec(60));
        th.Start();
        Console.WriteLine($"create a threadId : {th.ManagedThreadId}");
    }
    else{
        i--;
        Console.WriteLine("thread is over 10..");
        Thread.Sleep(TimeSpan.FromSeconds(30));
    }
    
    Thread.Sleep(TimeSpan.FromSeconds(1));
}