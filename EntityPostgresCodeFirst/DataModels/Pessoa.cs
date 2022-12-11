using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityPostgresCodeFirst.DataModels
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public virtual ICollection<Email>? Emails { get; set; }
    }
}
