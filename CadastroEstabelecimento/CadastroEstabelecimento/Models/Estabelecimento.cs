using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CadastroEstabelecimento.Models
{
    public class Estabelecimento
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdEstabelecimento { get; set; }

        [Required(ErrorMessage = "Nome Obrigatório!", AllowEmptyStrings = false)]
        [StringLength(40, MinimumLength = 2)]
        [Display(Name ="Razão Social")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "Nome Obrigatório!", AllowEmptyStrings = false)]
        [StringLength(40, MinimumLength = 2)]
        [Display(Name ="Nome Fantasia")]
        public string NomeFantasia { get; set; }

        [Required(ErrorMessage = "CNPJ é obrigatório!", AllowEmptyStrings = false)]
        [StringLength(20, MinimumLength = 20)]
        [Display(Name ="CNPJ")]
        public string Cnpj { get; set; }

        [StringLength(30)]
        [Display(Name ="E-mail")]
        public string Email { get; set; }

        [StringLength(100, MinimumLength = 5)]
        [Display(Name="Endereço")]
        public string Endereco { get; set; }

        [StringLength(30, MinimumLength = 5)]
        [Display(Name ="Cidade")]
        public string Cidade { get; set; }

        [StringLength(30, MinimumLength = 2)]
        [Display(Name ="Estado")]
        public string Estado { get; set; }

        public string Telefone { get; set; }

        [Display(Name ="Data Criação")]
        public string DataInclusao { get; set; }

        public string Categoria { get; set; }

        public string Status { get; set; }

        [Display(Name ="Agência")]
        public string Agencia { get; set; }

        public string Conta { get; set; }

    }
}