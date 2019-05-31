using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class Requisicao
    {
        public Formato Formato { get; set; }
        public Requisicao(Formato formato)
        {
            this.Formato = formato;
        }
    }
}
