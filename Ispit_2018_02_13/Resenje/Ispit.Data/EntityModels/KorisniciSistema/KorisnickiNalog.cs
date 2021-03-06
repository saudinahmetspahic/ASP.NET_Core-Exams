﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Ispit.Data.EntityModels
{
    public class KorisnickiNalog
    {
        [Key]
        public int Id { get; set; }
        public string KorisnickoIme { get; set; }

        public virtual ICollection<AutorizacijskiToken> AutorizacijskiTokeni { get; set; }

    }
}
