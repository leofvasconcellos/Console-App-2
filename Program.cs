using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Criando uma lista de tarefas
            List<Tarefa> tarefas = new List<Tarefa>{
            new Tarefa(1, "Tarefa Limpar"),
            new Tarefa(2, "Tarefa Lavar"),
            new Tarefa(3, "Tarefa Polir"),
            new Tarefa(4, "Tarefa Colocar para venda"),
            new Tarefa(5, "Tarefa Vender"),
            new Tarefa(5, "Tarefa Entregar")
            };

            // Criando uma lista de tarefas para executar
            List<Task> tarefasAsync = new List<Task>();

            // Processando cada tarefa de forma assíncrona
            foreach (var tarefa in tarefas)
            {
                tarefasAsync.Add(ProcessarTarefa(tarefa));
            }

            // Espera todas as tarefas serem concluídas
            await Task.WhenAll(tarefasAsync);

            // Mantendo a aplicação aberta, para visualização das informações
            Console.WriteLine("Pressione Enter para sair...");
            Console.ReadLine();
        }

        // Método que irá simular o processamento de cada tarefa
        static async Task ProcessarTarefa(Tarefa tarefa)
        {
            // Marca o tempo de início
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            // Simula um atraso aleatório para o processamento
            Random random = new Random();
            int tempoDeExecucao = random.Next(1000, 5000); // entre 1 e 5 segundos
            await Task.Delay(tempoDeExecucao);

            // Marca o tempo de término
            stopwatch.Stop();

            // Imprime no console os resultados
            Console.WriteLine($"Tarefa ID: {tarefa.Id}, Nome: {tarefa.Nome}, Tempo de Execução: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
}
