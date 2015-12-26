using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrightstarDB.EntityFramework;

namespace Mosaicos.LojaVirtual.Dominio.Repositorio
{
    [Entity]
    public interface IMosaico
    {
        string Id { get; }
        string Nome { get; set; }
        string Descricao { get; set; }


    }
}
