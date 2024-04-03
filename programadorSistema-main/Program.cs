using System;
using System.Collections.Generic;

class Task
{
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public bool IsCompleted { get; set; }

    public Task(string description, DateTime dueDate)
    {
        Description = description;
        DueDate = dueDate;
        IsCompleted = false;
    }

    public override string ToString()
    {
        string status = IsCompleted ? "Concluída" : "Pendente";
        return $"{Description} (Data Limite: {DueDate.ToString("dd/MM/yyyy")}, Status: {status})";
    }
}

class TaskManager
{
    private List<Task> tasks = new List<Task>();

    public void AddTask(string description, DateTime dueDate)
    {
        tasks.Add(new Task(description, dueDate));
        Console.WriteLine("Tarefa adicionada com sucesso!");
    }

    public void ViewTasks()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("Não há tarefas para exibir.");
        }
        else
        {
            Console.WriteLine("Tarefas:");
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
    }

    public void CompleteTask(int index)
    {
        if (index >= 1 && index <= tasks.Count)
        {
            tasks[index - 1].IsCompleted = true;
            Console.WriteLine("Tarefa concluída com sucesso!");
        }
        else
        {
            Console.WriteLine("Índice de tarefa inválido!");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        TaskManager taskManager = new TaskManager();

        while (true)
        {
            Console.WriteLine("\nGerenciador de Tarefas:\n");
            Console.WriteLine("1. Adicionar Tarefa");
            Console.WriteLine("2. Visualizar Tarefas");
            Console.WriteLine("3. Concluir Tarefa");
            Console.WriteLine("4. Sair\n");
            Console.Write("Escolha uma opção: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Descrição da Tarefa: ");
                    string description = Console.ReadLine();
                    Console.Write("Data Limite (dd/mm/aaaa): ");
                    if (DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime dueDate))
                    {
                        taskManager.AddTask(description, dueDate);
                    }
                    else
                    {
                        Console.WriteLine("Formato de data inválido! Use o formato dd/mm/aaaa.");
                    }
                    break;
                case "2":
                    taskManager.ViewTasks();
                    break;
                case "3":
                    Console.Write("Digite o número da tarefa a ser concluída: ");
                    if (int.TryParse(Console.ReadLine(), out int index))
                    {
                        taskManager.CompleteTask(index);
                    }
                    else
                    {
                        Console.WriteLine("Número inválido! Insira um número válido.");
                    }
                    break;
                case "4":
                    Console.WriteLine("Saindo do programa...");
                    return;
                default:
                    Console.WriteLine("Opção inválida! Tente novamente.");
                    break;
            }
        }
    }
}
