using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Models.Entidades
{
    [Table("Usuario")]
    public class Usuario
    {
        [Display(Description = "Codigo")]
        public int Id { get; set; }

        [Display(Description = "Nome do Usuario")]
        public string NomeUsuario { get; set; }

        [Display(Description = "Idade")]
        public int Idade { get; set; }

        [Display(Description = "Tipo de usuario")]
        public int Tipo { get; set; }

    }
}
