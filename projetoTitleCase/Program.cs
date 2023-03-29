using System.Xml;

namespace projetoTitleCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string texto = "";
            Console.WriteLine("Digite o texto que deseja modificar: ");
            texto = Console.ReadLine();

            string textoMinusculo = texto.ToLower();
            string[] textoDigitado = textoMinusculo.Split(" ");

            for (int i = 0; i < textoDigitado.Length; i++)
            {
                char[] primeiraLetra = textoDigitado[i].ToCharArray();
                Console.Write(primeiraLetra[0].ToString().ToUpper() + textoDigitado[i].Substring(1));
                Console.Write(" ");
            }
            Console.ReadLine();
        }
    }
}