using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPostgresCodeFirst.DataModels
{
    public class Email
    {
        public int Id { get; set; }
        public string? Endereco { get; set; }
        public virtual Pessoa? Pessoa { get; set; }
    }
}
