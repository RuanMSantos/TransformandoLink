string link = "https://youtu.be/GhN3iw0YLWQ?si=jGIVlPh44wPYNIgH";
byte[] linkBinario = new byte[link.Length];
char[] array = link.ToArray();

for (int i = 0; i < array.Length; i++){
    linkBinario[i] = (byte)array[i];
}

string linkHexadecimal = Convert.ToHexString(linkBinario);
string linkBase64 = Convert.ToBase64String(linkBinario);

Console.WriteLine(linkHexadecimal);
Console.WriteLine(linkBase64);