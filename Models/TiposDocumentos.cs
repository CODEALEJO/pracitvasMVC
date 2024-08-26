using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace pracitcasMVC.Models;
public class TiposDocumentos
{
    [Column("id")]
    [Key]
    public int Id { get; set; }
    [Column("Nombre")]
    [MaxLength(50, ErrorMessage ="Ingresaste un nombre muy largo")]
    public required string Nombre { get; set; }
    [Column("avrebiacion")]
    [MaxLength(10, ErrorMessage ="Debe cotener maximo 10 caracteres")]
    [MinLength(2, ErrorMessage ="debe contener minimo 2 caracteres")]
    public required string Abreviacion { get; set; }
    [Column("Descripcion")]
    [MaxLength(500, ErrorMessage ="Ingresaste una descripcion muy larga")]	
    public string? Descripcion { get; set; }
}