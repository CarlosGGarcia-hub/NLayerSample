using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models;

public class Equipo
{
    [Key]
    public int Idequipo { get; set; }
    [Required]
    public int idPersona { get; set; }
    [Required]
    public int Idposicion { get; set; }

}
