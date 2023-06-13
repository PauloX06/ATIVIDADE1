

public class Pessoa
{
    private string nome;
    private string cpf;
    private double peso;
    private string sexo;
    private double altura;
    private string idade;


    public Pessoa(string nome, string cpf, double peso, string sexo, double altura, string idade)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.peso = peso;
        this.sexo = sexo;
        this.altura = altura;
        this.idade = idade;    

    }
    public string getNome(string nome)
    {
        return nome;
    }

    public void setNome(string nome) 
    {
        this.nome = nome;
    }
    public string getCpf(string cpf)
    {
        return cpf;
    }

    public void setCpf(string cpf)
    {
        this.cpf = cpf;
    }
    public double getPeso(double peso)
    {
        return peso;
    }

    public void setPeso(double peso)
    {
        this.peso = peso;
    }

    public string getSexo(string sexo)
    {
        return sexo;
    }

    public void setSexo(string sexo)
    {
        this.sexo = sexo;
    }
    public double getAltura(double altura)
    {
        return altura;
    }

    public void setAltura(double altura)
    {
        this.altura = altura;
    }
    public string getIdade(string idade)
    {
        return idade;
    }

    public void setIdade(string idade)
    {
        this.idade = idade;

    }


    public (double, string, string) CalcularIMC()
    {
        double imc = peso / (altura * altura);


        if (imc < 18.5)
        {
            return (imc, "MAGREZA", "0");
        }
        else if (imc >= 18.5 && imc <= 24.9)
        {
            return (imc, "NORMAL", "0");
        }
        else if (imc >= 25 && imc <= 29.9) 
        {
            return (imc, "SOBREPESO", "I");
        }
        else if (imc >= 30 && imc <= 39.9)
        {
            return (imc, "OBESIDADE","II");
        }
        else 
        {
            return (imc, "OBESIDADE GRAVE", "III");
       
        }

    }
}


   