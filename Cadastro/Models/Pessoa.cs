using System.Dynamic;
using System.Runtime.CompilerServices;

public class Pessoa 
{
    private string _nome;
    private int _idade;
    private string _cpf;

    public Pessoa(string nome, int idade, string cpf) 
    {
        Nome = nome;
        Idade = idade;
        Cpf = cpf;
    }

    public string Nome
    {
        get { return _nome; }
        set
        {
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Nome não pode ser vazio ou conter apenas espaços!");
            }
            else
            {
                _nome = value.Trim();
            }
        }
    }

    public int Idade
    {
        get { return _idade; }
        set
        {
            if(value >= 18)
            {
                _idade = value;
            }
            else
            {
                throw new ArgumentException("Idade abaixo da permitida");
            }
        }
    }

    public string Cpf
    {
        get { return _cpf;}
        set
        {
            if(string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Cpf não pode ser vazio ou conter apenas espaços!");
            }
            else
            {
                _cpf = value.Trim();
            }
        }
    }
}