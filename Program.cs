int i = 0;
string link = "https://youtu.be/GhN3iw0YLWQ?si=jGIVlPh44wPYNIgH";
byte[] linkBinario = new byte[link.Length];
char[] array = link.ToArray();

foreach (char item in array){
    linkBinario[i] = (byte)item;
    i++;
}

string linkHexadecimal = Convert.ToHexString(linkBinario);
string linkBase64 = Convert.ToBase64String(linkBinario);

Console.WriteLine(linkHexadecimal);
Console.WriteLine(linkBase64);