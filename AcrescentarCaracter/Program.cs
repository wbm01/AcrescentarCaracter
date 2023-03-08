internal class Program
{
    private static void Main(string[] args)
    {
        string nome, alterada, resultante;

        nome = Console.ReadLine();


        resultante = InsereCaracter(nome);

        Console.WriteLine(resultante);

        string InsereCaracter(string nome)
        {
            char[] aux = new char[nome.Length * 2];
            string alterada = "";

            for (int i = 0, j = 0; i < nome.Length; i++)
            {
                if (nome[i] != 'a' && nome[i] != 'e' && nome[i] != 'i'
                && nome[i] != 'o' && nome[i] != 'u')
                {
                    aux[j + 1] = nome[i];
                    aux[j] = '.';
                    j = j + 2;
                }
                else
                {
                    aux[j] = nome[i];
                    j++;
                }
            }
            for (int i = 0; i < aux.Length; i++)
            {
                alterada = alterada + aux[i];
            }
            return alterada;
        }
    }
}