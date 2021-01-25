using Douyu.ID;
using System;

namespace DouyuID_ConsoleApp
{
    public class Program
    {
        static DouyuID douyuID = new DouyuID();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("开始进行速度测试...");
            DateTime startTime = DateTime.Now;
            Console.WriteLine($"ID: 824 礼物名称: {douyuID.ParseGiftId(824)}");
            TimeSpan timeConsumed = DateTime.Now - startTime;
            Console.WriteLine($"转换耗时: {timeConsumed.TotalMilliseconds}ms");
        }
    }
}
