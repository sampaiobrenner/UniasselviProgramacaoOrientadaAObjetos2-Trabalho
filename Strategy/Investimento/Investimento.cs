using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public interface Investimento
    {
        double calcula(Conta conta);
    }
}
