﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RS1_Ispit_asp.net_core.EntityModels
{
    public class PopravniIspit
    {
        public int Id { get; set; }
        public DateTime DatumOdrzavanja { get; set; }
        public string Napomena { get; set; }

        [ForeignKey(nameof(Skola))]
        public int SkolaId { get; set; }
        public Skola Skola { get; set; }

        [ForeignKey(nameof(Predmet))]
        public int PredmetId { get; set; }
        public Predmet Predmet { get; set; }

        [ForeignKey(nameof(SkolskaGodina))]
        public int SkolskaGodinaId { get; set; }
        public SkolskaGodina SkolskaGodina { get; set; }

        public ICollection<PopravniIspitStavka> Ucenici { get; set; }
    }
}