﻿using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    

namespace Suma2788307
{
    [SQLite.Table("Resultado")]
    public class Resultado
    {
        [PrimaryKey, AutoIncrement]
        [SQLite.Column("id")]
        public int Id { get; set; }

        [SQLite.Column("numero1")]

        public string? Numero1 { get; set; }
        [SQLite.Column("numero2")]

        public string? Numero2 { get; set; }

        [SQLite.Column("suma")]
        public string? Suma { get; set; }

    }
}
