    using MySql.Data.MySqlClient;
    
    public class operacoes 
{
    private string connectionString = @"server=phpmyadmin.uni9.marine.us;User ID=user_poo;password=S3nh4!Fort3;database=user_poo;";
    public int Criar(Tarefa tarefa)
    {
        using(var conexao = new MySlqConnectionString))
        {
           conexao.Open();
           string sql = @"INSERT INTO tarefa (nome, descricao, dataCriacao, status, dataExecucao)
                         VALUES (@nome, @descricao, @dataCriacao, @status, @dataExecucao);
                         SELECT LAST_INSERT_ID();";
           using (var cmd = new MySqlCommand(sql, conexao))
          {
            cmd.Parameters.AddWithValue("@nome", tarefa.Nome);
            cmd.Parameters.AddWithValue("@descricao", tarefa.Descricao);
            cmd.Parameters.AddWithValue("@dataCriacao", tarefa.DataCriacao);
            cmd.Parameters.AddWithValue("@status", tarefa.status);
            cmd.Parameters.AddWithValue("@dataExecucao", tarefa.DataExecucao);

            return Convert.ToInt32(cmd.ExecuteScalar());
          }            
        }
    }

    public Tarefa Buscar (int id)
    {
    return null;
    }
 
    public List<Tarefa> Listar()
    {
    return Array.Empty<Tarefa>();
    }

    public void Alterar(Tarefa tarefa)
    {

    }

    public void Excluir(int id)
    {

    }
}