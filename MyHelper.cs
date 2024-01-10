using System;

public class MyHelper
{
    public MyHelper()
    {


    }

    public void SleepXSec(int time)
    {
        // 睡time秒
        Console.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}] sleep {time} sec..");
        Thread.Sleep(TimeSpan.FromSeconds(time));
    }
}