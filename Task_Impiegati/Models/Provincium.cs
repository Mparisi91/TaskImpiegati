using System;
using System.Collections.Generic;

namespace Task_Impiegati.Models;

public partial class Provincium
{
    public int Id { get; set; }

    public string NomeProvincia { get; set; } = null!;

    public virtual ICollection<Cittum> Citta { get; set; } = new List<Cittum>();
}
