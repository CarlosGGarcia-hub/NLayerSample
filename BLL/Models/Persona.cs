using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Models;

public class Persona
{
    [Key]
    public int idcolumna{ get; set; }
    public string cedula { get; set; }
    public string telefono { get; set; }
    public string Nombres { get; set; }

}
