using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_tarde
{
    internal class Cliente
    {
        private int Id;
        private string Nome;
        private string Tel;
        public Cliente(int id, string Nome, string Tel)
        {
            Id = id;
            Nome = "Lucas";
            Tel = "16-12345 6789";
        }
        public int getId()
        {
            return Id;
        }
        public void setId(int id)
        {
            Id = id;
        }
        public string getNome()
        {
            return Nome;
        }
        public void setNome(string nome)
        {
            Nome = nome;
        }
        public string getTel()
        {
            return Tel;
        }
        public void setTel(string tel)
        {
            Tel = tel;
        }
    }
}