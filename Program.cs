string link = "https://youtu.be/GhN3iw0YLWQ?si=jGIVlPh44wPYNIgH";
char[] array = link.ToArray();
byte[] linkBinario = new byte[link.Length];

for (int i = 0; i < array.Length; i++){
    linkBinario[i] = (byte)array[i];
}

string linkHexadecimal = Convert.ToHexString(linkBinario);
string linkBase64 = Convert.ToBase64String(linkBinario);

Console.WriteLine(linkHexadecimal);
Console.WriteLine(linkBase64);

//byte[] linkBinario = Encoding.UTF8.GetBytes(link);
// forma 15 vezes mais facil de fazer o que fiz da linha 3 à 7 