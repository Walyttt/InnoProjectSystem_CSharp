using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnoProjectSystem.src.models
{
    public class User
    {
        private string id;
        private string pwd;
        private string name;

        public User(string id, string pwd, string name=null)
        {
            this.Id = id;
            this.Pwd = pwd;
            this.Name = name;
        }

        public string Id { get => id; set => id = value; }
        public string Pwd { get => pwd; set => pwd = value; }
        public string Name { get => name; set => name = value; }
    }
}
