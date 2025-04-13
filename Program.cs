Console.Clear();
Console.WriteLine("-- Conversor Hexadecimal e Base64 --\n");

Console.Write("Escreva algo: ");
string resposta = Console.ReadLine()!;

char[] arrayResposta = resposta.ToArray();
byte[] respostaByte = new byte[resposta.Length];

for (int i = 0; i < arrayResposta.Length; i++){
    respostaByte[i] = (byte)arrayResposta[i];
}

string linkHexadecimal = Convert.ToHexString(respostaByte);
string linkBase64 = Convert.ToBase64String(respostaByte);

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Magenta;
Console.WriteLine(linkHexadecimal);
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(linkBase64);
Console.ResetColor();
Console.WriteLine();

// byte[] respostaByte = Encoding.UTF8.GetBytes(resposta);
// forma 15 vezes mais facil de fazer o que fiz da linha 3 à 7 