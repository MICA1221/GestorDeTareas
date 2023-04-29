﻿using System;

namespace GestorDeTareas.Models
{
    public class Tarea
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Completada { get; set; }
        public DateTime FechaLimite { get; set; }
    }
}

