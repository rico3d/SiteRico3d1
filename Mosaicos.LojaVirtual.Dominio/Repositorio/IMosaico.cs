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
        int Item { get; set; }
        string Nome { get; set; }
        string Descricao { get; set; }
        decimal Preco { get; set; }
        decimal Peso { get; set; }
        string Dimensao { get; set; }
        string Imagem { get; set; }

        [InverseProperty("Mosaicos")]
        ICategoria Categoria { get; set; }

    }


    
}
