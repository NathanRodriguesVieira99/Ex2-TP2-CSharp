class Ex2
{
    static void Main()
    {
        Console.WriteLine("Informe sua data de nascimento: ");

        string dataInformada = Console.ReadLine();

        if (DateTime.TryParse(dataInformada, out DateTime dataNascimento))
        {
            DateTime diaAtual = DateTime.Today;

            DateTime aniversarioData = new DateTime(diaAtual.Year, dataNascimento.Month, dataNascimento.Day);

            if (aniversarioData < diaAtual)
            {
                aniversarioData = aniversarioData.AddYears(1);
            }

            TimeSpan diasQueFaltam = aniversarioData - diaAtual;

            Console.WriteLine($"Faltam {diasQueFaltam.Days} dias para sei aniversario");
        }
        else
        {
            Console.WriteLine("Data informada invalida");
        }
    }
}