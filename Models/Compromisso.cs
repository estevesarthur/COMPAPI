using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CompApi.Models
{
    [Table("TB_COMPROMISSO")]
    public class Compromisso
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage="O campo descrição é obrigatório")]
        public int TipoCompromissoId  { get; set; }

        [Required(ErrorMessage="O campo descrição é obrigatório")]
        [MaxLenght(30, ErrorMessage="O campo descrição deve conter até 30 caracteres")]
        [MinLenght(10, ErrorMessage="O campo descrição deve conter pelo menos 10 caracteres")]
        public string Descricao { get; set; }
        public string Localizacao { get; set; }

        [Required(ErrorMessage="A data de início é obrigatória")]
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
        public bool Visivel { get; set; }
        public int ParticipanteId { get; set; }
        public List<Participante> Participantes { get; set; }
    }
}