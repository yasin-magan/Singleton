// See https://aka.ms/new-console-template for more information
using Singleton;

Console.WriteLine("Hello, World!");
// access singleton via static property
LogManager.Instance.WriteLog("Test Writing");
Console.ReadKey();
