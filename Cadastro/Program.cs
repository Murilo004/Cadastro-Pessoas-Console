using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

PessoaService service = new PessoaService();
int opcao = 0;

string Menu()
{
    Console.WriteLine("===========================");
    Console.WriteLine("\tMENU DO SISTEMA");
    Console.WriteLine("===========================");
    Console.WriteLine("\n[1] Cadastrar Pessoa");
    Console.WriteLine("[2] Listar Pessoas");
    Console.WriteLine("[3] Buscar Pessoa");
    Console.WriteLine("[9] Sair");
    Console.WriteLine("\nEscolha a opção da ação desejada: ");
    return Console.ReadLine();
}

void Pausar()
{
    Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
    Console.ReadKey();
}

void CadastrarPessoaUI() 
{
    Console.WriteLine("Digite seu nome: ");
    string nome = Console.ReadLine();
    Console.WriteLine("Digite sua idade: ");
    string idadeInput = Console.ReadLine();
    if(!int.TryParse(idadeInput, out int idade))
    {
        Console.WriteLine("Idade inválida!");
        return;
    }

    Console.WriteLine("Digite seu Cpf: ");
    string cpf = Console.ReadLine();
    try
    {
        service.CadastrarPessoa(nome, idade, cpf);   
    }
    catch(Exception ex)
    {
        Console.WriteLine($"Erro: {ex.Message}");
    }

    Pausar();
}

void ObterPessoasUI()
{
    var lista = service.ObterPessoas();

    if(lista.Count == 0)
    {
        Console.WriteLine("Nenhum usuário cadastrado!");
    }
    else
    {
        foreach(var pessoa in lista)
        {
            Console.WriteLine($"Nome: {pessoa.Nome} | Idade: {pessoa.Idade} | Cpf: {pessoa.Cpf}\n");
        }   
    }

    Pausar();
}

void ObterPorNomeUI()
{
    Console.WriteLine("Digite o nome da pessoa: ");
    string nome = Console.ReadLine();

    if(string.IsNullOrWhiteSpace(nome))
    {
        Console.WriteLine("Nome inválido!");
        return;
    }

    Pessoa pessoa = service.ObterPorNome(nome);       


    if(pessoa != null)
    {
        Console.WriteLine($"Nome: {pessoa.Nome} | Idade: {pessoa.Idade} | Cpf: {pessoa.Cpf}");
    }
    else
    {
        Console.WriteLine("Usuário não encontrado!");
    }

    Pausar();
}

while(true)
{
    string input = Menu();
    
    if(!int.TryParse(input, out opcao))
    {
        Console.WriteLine("Digite um número válido!");
        continue;
    }

    switch(opcao)
    {
        case 1:
            CadastrarPessoaUI();
            break;
        case 2:
            ObterPessoasUI();
            break;
        case 3:
            ObterPorNomeUI();
            break;
        case 9:
            return;
        default:
            Console.WriteLine("Escolha uma opção válida!");
            break;
    }
}