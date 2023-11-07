using System;

namespace ExercicioListaDeTarefas
{
    internal class Tarefas
    {
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public DateTime Data { get; private set; }
        public string Status { get; private set; }

        //Construtores
        public Tarefas(string nome, string descricao, DateTime data)
        {
            Nome = nome;
            Descricao = descricao;
            Data = data;
            Status = "Pendente";
        }

        //Função para editar nome da tarefa
        public void AlterarNome(string altNome)
        {
            Nome = altNome;
        }

        //Função para alterar o status da tarefa
        public void AlterarStatus()
        {
            Status = "✓ Feito";
        }

        //Exibir tarefas
        public override string ToString()
        {
            return $"Nome:{Nome}\nDescrição:{Descricao}\nData de Vencimento:{Data.ToString("dd/MM/yyyy")}\nStatus:{Status}";
        }
    }
}
