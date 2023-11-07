using System;
using System.Collections.Generic;
namespace ExercicioListaDeTarefas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Tarefas> Lista = new List<Tarefas>();
            List<Tarefas> ListaRealizada = new List<Tarefas>();
            int resp;
            do
            {
                Console.WriteLine("\n\n***Lista de Tarefas***\n");
                Console.WriteLine("[1]Adicionar Tarefa\n[2]Remover Tarefa\n[3]Editar Tarefa\n[4]Listar Tarefa\n[5]Sair");
                resp = int.Parse(Console.ReadLine());
                switch (resp)
                {
                    case 1:
                        Console.WriteLine("---Descrição da Tarefa---");
                        Console.Write("Nome:");
                        string nome = Console.ReadLine();
                        Console.Write("Descrição:");
                        string descricao = Console.ReadLine();
                        Console.Write("Data limite(dd/mm/aaaa):");
                        DateTime data = DateTime.Parse(Console.ReadLine());
                        Lista.Add(new Tarefas(nome, descricao, data));
                        break;
                    case 2:
                        Console.Write("Digite a tarefa que deseja remover:");
                        string remover = Console.ReadLine();
                        Tarefas tarefa = Lista.Find(x => x.Nome == remover);
                        if (tarefa != null)
                        {
                            Lista.Remove(tarefa);
                        }
                        else
                        {
                            Console.WriteLine("TAREFA NÃO ENCONTRADA");
                        }
                        break;
                    case 3:
                        Console.Write("Qual tarefa você gostaria de editar o nome?:");
                        string nomeAlt = Console.ReadLine();
                        Tarefas altTarefa = Lista.Find(x => x.Nome == nomeAlt);
                        if (altTarefa != null)
                        {
                            Console.Write("Digite o nome já alterado:");
                            string nomeAlterado = Console.ReadLine();
                            altTarefa.AlterarNome(nomeAlterado);
                        }
                        break;
                    case 4:
                        Console.Write("Qual tarefa foi realizada?:");
                        string tarefaRealizada = Console.ReadLine();
                        Tarefas tarefaR = Lista.Find(x => x.Nome == tarefaRealizada);
                        ListaRealizada = Lista.FindAll(x => x.Nome == tarefaR.Nome);
                        Tarefas ListaR2 = ListaRealizada.Find(x => x.Status == "Pendente");
                        if (ListaR2 != null)
                        {
                            ListaR2.AlterarStatus();
                        }
                        Lista.Remove(tarefaR);
                        break;
                }

                Console.Clear();
                Console.WriteLine("------TAREFAS------");
                if (Lista.Count == 0)
                {
                    Console.WriteLine("\nLISTA VAZIA\n");
                }
                else
                {
                    foreach (Tarefas obj in Lista)
                    {
                        Console.WriteLine($"\n{obj}");
                    }
                }

                Console.WriteLine("\n------TAREFAS REALIZADAS------");
                if (ListaRealizada.Count == 0)
                {
                    Console.WriteLine("\nLISTA VAZIA\n");
                }
                else
                {
                    foreach (Tarefas obj in ListaRealizada)
                    {
                        Console.WriteLine($"{obj}");
                    }
                }
            }
            while (resp != 5);
        }
    }
}