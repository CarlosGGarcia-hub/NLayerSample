using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models;

public class Posicion
{
    [Key]
    public int idPosicion { get; set; }
    public string NombrePosicion { get; set; }
}   
