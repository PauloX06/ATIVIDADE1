

/*
public static class Validacoes
{
    public static bool ValidaCPF(string cpf)
    {
        // Remover pontos e traço do CPF
        cpf = cpf.Replace(".", "").Replace("-", "");

        // Verificar se possui 11 dígitos
        if (cpf.Length != 11)
            return false;

        // Calcular primeiro dígito verificador
        int soma = 0;
        for (int i = 0; i < 9; i++)
            soma += int.Parse(cpf[i].ToString()) * (10 - i);

        int primeiroDigitoVerificador = (soma % 11 < 2) ? 0 : 11 - (soma % 11);

        // Verificar primeiro dígito verificador
        if (primeiroDigitoVerificador != int.Parse(cpf[9].ToString()))
            return false;

        // Calcular segundo dígito verificador
        soma = 0;
        for (int i = 0; i < 10; i++)
            soma += int.Parse(cpf[i].ToString()) * (11 - i);

        int segundoDigitoVerificador = (soma % 11 < 2) ? 0 : 11 - (soma % 11);

        // Verificar segundo dígito verificador
        if (segundoDigitoVerificador != int.Parse(cpf[10].ToString()))
            return false;

        return true;
    }
}
*/