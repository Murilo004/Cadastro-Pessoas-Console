public class PessoaService
{
    private List<Pessoa> _lista = new List<Pessoa>();

    public void CadastrarPessoa(string nome, int idade, string cpf)
    {
        Pessoa pessoa = new Pessoa(nome, idade, cpf);

        _lista.Add(pessoa);
    }

    public List<Pessoa> ObterPessoas()
    {
        return new List<Pessoa>(_lista);
    }

    public Pessoa ObterPorNome(string nome)
    {
        foreach(var pessoa in _lista)
        {
            if(nome.Equals(pessoa.Nome, StringComparison.OrdinalIgnoreCase))
            {
                return pessoa;
            }
        }
        return null;
    }
}