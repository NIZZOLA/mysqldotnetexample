using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotCoreNetMySql.Model
{
    public class BookModel
    {
        [Key]
        public int BookId { get; set; }

        [MaxLength(50,ErrorMessage ="O tamanho maximo do campo foi excedido")]
        public string Name { get; set; }

        [MaxLength(20)]
        public string ISBN { get; set; }

    }
}
