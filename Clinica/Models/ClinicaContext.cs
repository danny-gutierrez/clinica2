using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Clinica.Models
{
    public class ClinicaContext : DbContext

    {
        public DbSet<Paciente> Pacientes { get; set; }
       
    }
}