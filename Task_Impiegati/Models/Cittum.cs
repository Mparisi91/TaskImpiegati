using System;
using System.Collections.Generic;

namespace Task_Impiegati.Models;

public partial class Cittum
{
    public int Id { get; set; }

    public string NomeCitta { get; set; } = null!;

    public int? ProvinciaRif { get; set; }

    public virtual Provincium? ProvinciaRifNavigation { get; set; }
}
