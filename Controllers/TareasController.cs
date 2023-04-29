using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using GestorDeTareas.Models;

namespace GestorDeTareas.Controllers
{
    public class TareasController : Controller
    {
      
        public IActionResult Index()
        {
            var tareas = new List<Tarea>
            {
                new Tarea { Id = 1, Nombre = "Presentarse al trabajo", Descripcion = "Cada mañana presentarse a laburar en su horario determinado", FechaLimite = DateTime.Now.AddDays(7), Completada = false },
                new Tarea { Id = 2, Nombre = "Estudiar", Descripcion = "Despues de la jornada laboral, estudiar dos horas", FechaLimite = DateTime.Now.AddDays(14), Completada = false }
            };

            return View(tareas);
        }

        
    }
}
