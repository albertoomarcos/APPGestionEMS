using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace APPGestionEMS.Models
{
    public class AsignacionDocentes
    {
        public int Id { get; set; }

        [Display(Name = "Curso")]
        public int CursoId { get; set; }
        public virtual Cursos Curso { get; set; }

        [Display(Name = "Profesor")]
        public String UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        [Display(Name = "Grupo")]
        public int GrupoId { get; set; }
        public virtual GrupoClases Grupo { get; set; }
    }
}