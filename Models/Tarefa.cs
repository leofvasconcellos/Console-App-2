using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    internal class Tarefa
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Tarefa(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
