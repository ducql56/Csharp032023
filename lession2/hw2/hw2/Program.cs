// See https://aka.ms/new-console-template for more information
string a = "toi dep trai\ntoi noi gioi\ntoi yeu em";
string[] lst = a.Split('\n');
bool x = lst[0].StartsWith("toi");
bool y = lst[1].StartsWith("toi");
bool z = lst[2].StartsWith("toi");
if (x = y = z = true)
{
    int u = 1;
    int v = 1;
    int o = 1;
    int g = u + v + o;
    Console.WriteLine(" tong la: +g");
}
Console.ReadKey();
