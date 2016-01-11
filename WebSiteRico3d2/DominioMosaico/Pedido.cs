using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebSiteRico3d2.DominioMosaico
{
    public class Pedido
    {
    
        [Required(ErrorMessage = "Informe seu nome")]
        [Display(Name = "Cliente:")]
        public string NomeCliente { get; set; }

        [Display(Name = "Cep:")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "Informe seu endereço")]
        [Display(Name = "Endereço:")]
        public string Endereco { get; set; }

        [Display(Name = "Complemento:")]
        public string Complemento { get; set; }

        [Required(ErrorMessage = "Informe sua cidade")]
        [Display(Name = "Cidade:")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Informe seu bairro")]
        [Display(Name = "Bairro:")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Informe seu estado")]
        [Display(Name = "Estado:")]
        public string Estado { get; set; }

        [Required(ErrorMessage = "Informe seu email")]
        [Display(Name = "Email:")]
        [EmailAddress(ErrorMessage = "Email invalido")]
        public string Email { get; set; }

        public bool EmbrulhaPresente { get; set; }




    }
}