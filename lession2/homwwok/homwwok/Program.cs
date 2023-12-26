// See https://aka.ms/new-console-template for more information
string a;
int demThuong = 0, demHoa = 0, demSo = 0;
Console.WriteLine("moi ban nhap xhuoi:");
a = Console.ReadLine();
char[] lst = a.ToCharArray();
foreach (char c in lst)
{
    if (char.IsDigit(c))
        demSo++;
    else if (char.IsUpper(c))
        demHoa++;
    else if (char.IsLower(c))
        demThuong++;

}
int chieuDaia = a.Length;
string chuoiso = a.Substring(chieuDaia - demSo, demSo);
string chuoichu = a.Substring(0, chieuDaia - demSo);
Console.WriteLine(chuoichu);
Console.WriteLine(chuoiso);