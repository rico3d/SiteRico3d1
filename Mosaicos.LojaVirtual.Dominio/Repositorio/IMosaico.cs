using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BrightstarDB.EntityFramework;

namespace Mosaicos.LojaVirtual.Dominio.Repositorio
{
    [Entity]
    public interface IMosaico
    {
        [Identifier("http://www.rico3d.com.br/mosaicos")]
        string MosaicoId { get; }

        [Required(ErrorMessage = "Favor prover um nome para o produto")]
        string Nome { get; set; }

        string Descricao { get; set; }

        decimal Preco { get; set; }

        string Categoria { get; set; }

    }
}
