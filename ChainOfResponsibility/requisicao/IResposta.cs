using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public interface IResposta
    {
        void Responde(Requisicao requisicao, Conta conta);
        IResposta Proximo { get; set; }
    }
}
