using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Lopez_Tomas_Examen_Progreso_1.Models;

    public class LopezTomas_Context : DbContext
    {
        public LopezTomas_Context (DbContextOptions<LopezTomas_Context> options)
            : base(options)
        {
        }

        public DbSet<Lopez_Tomas_Examen_Progreso_1.Models.Lopez> Lopez { get; set; } = default!;

public DbSet<Lopez_Tomas_Examen_Progreso_1.Models.Celular> Celular { get; set; } = default!;
    }
