using Api.Stored.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Stored.Infrastructure.Data
{
    public class StoredAppDbContext: IdentityDbContext<User>
    {
        public StoredAppDbContext(DbContextOptions<StoredAppDbContext> options)
            :base(options)
        {

        }

        public virtual DbSet<TblCatEspecialidades> TblCatEspecialidades { get; set; }
        public virtual DbSet<TblCatMedico> TblCatMedicos { get; set; }
        public virtual DbSet<TblCatPaciente> TblCatPacientes { get; set; }
        public virtual DbSet<TblDatCita> TblDatCitas { get; set; }
        public virtual DbSet<TblDatHorario> TblDatHorarios { get; set; }
        public virtual DbSet<TblDatRetrasoCita> TblDatRetrasoCitas { get; set; }
        public virtual DbSet<TblIntMedicosEspecialidades> TblIntMedicosEspecialidades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblCatEspecialidades>(entity =>
            {
                entity.HasKey(e => e.FiIdEspecialidad)
                    .HasName("PK_TblCatEspecialidades_fiIdEspecialidad");

                entity.ToTable("TblCatEspecialidades", "CitasMedicas");

                entity.Property(e => e.FiIdEspecialidad)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("fiIdEspecialidad");

                entity.Property(e => e.FcDescripcion)
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnName("fcDescripcion");

                entity.Property(e => e.FcNombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("fcNombre");

                entity.Property(e => e.FcUsuarioModificacion)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("fcUsuarioModificacion");

                entity.Property(e => e.FcUsuarioRegistro)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("fcUsuarioRegistro");

                entity.Property(e => e.FdFechaModificacion)
                    .HasPrecision(0)
                    .HasColumnName("fdFechaModificacion");

                entity.Property(e => e.FdFechaRegistro)
                    .HasPrecision(0)
                    .HasColumnName("fdFechaRegistro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FlActivo).HasColumnName("flActivo");
            });

            modelBuilder.Entity<TblCatMedico>(entity =>
            {
                entity.HasKey(e => e.FiIdMedico)
                    .HasName("PK_TblCatMedicos_fiIdMedico");

                entity.ToTable("TblCatMedicos", "CitasMedicas");

                entity.Property(e => e.FiIdMedico).HasColumnName("fiIdMedico");

                entity.Property(e => e.FcApellidos)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fcApellidos");

                entity.Property(e => e.FcClaveCedula)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("fcClaveCedula");

                entity.Property(e => e.FcDireccion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("fcDireccion");

                entity.Property(e => e.FcEmail)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("fcEmail");

                entity.Property(e => e.FcNombres)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fcNombres");

                entity.Property(e => e.FcSexo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("fcSexo")
                    .IsFixedLength(true);

                entity.Property(e => e.FcTelefono1)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("fcTelefono1");

                entity.Property(e => e.FcTelefono2)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("fcTelefono2");

                entity.Property(e => e.FcUsuarioModificacion)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("fcUsuarioModificacion");

                entity.Property(e => e.FcUsuarioRegistro)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("fcUsuarioRegistro");

                entity.Property(e => e.FdFechaModificacion)
                    .HasPrecision(0)
                    .HasColumnName("fdFechaModificacion");

                entity.Property(e => e.FdFechaRegistro)
                    .HasPrecision(0)
                    .HasColumnName("fdFechaRegistro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FlActivo).HasColumnName("flActivo");
            });

            modelBuilder.Entity<TblCatPaciente>(entity =>
            {
                entity.HasKey(e => e.FiIdPaciente)
                    .HasName("PK_TblCatPacientes_fiIdPaciente");

                entity.ToTable("TblCatPacientes", "CitasMedicas");

                entity.Property(e => e.FiIdPaciente).HasColumnName("fiIdPaciente");

                entity.Property(e => e.FcApellidos)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fcApellidos");

                entity.Property(e => e.FcDireccion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("fcDireccion");

                entity.Property(e => e.FcEmail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("fcEmail");

                entity.Property(e => e.FcFechaRegistro)
                    .HasPrecision(0)
                    .HasColumnName("fcFechaRegistro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FcNombres)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("fcNombres");

                entity.Property(e => e.FcSexo)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("fcSexo")
                    .IsFixedLength(true);

                entity.Property(e => e.FcTelefono)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("fcTelefono");

                entity.Property(e => e.FcUsuarioModificacion)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("fcUsuarioModificacion");

                entity.Property(e => e.FcUsuarioRegistro)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("fcUsuarioRegistro");

                entity.Property(e => e.FdFechaModificacion)
                    .HasPrecision(0)
                    .HasColumnName("fdFechaModificacion");

                entity.Property(e => e.FdFechaNacimiento)
                    .HasPrecision(0)
                    .HasColumnName("fdFechaNacimiento");

                entity.Property(e => e.FlActivo).HasColumnName("flActivo");
            });

            modelBuilder.Entity<TblDatCita>(entity =>
            {
                entity.HasKey(e => new { e.FiIdCita, e.FiAnio, e.FiMes })
                    .HasName("PK_TblDatCitas_fiIdCita");

                entity.ToTable("TblDatCitas", "CitasMedicas");

                entity.Property(e => e.FiIdCita).HasColumnName("fiIdCita");

                entity.Property(e => e.FiAnio).HasColumnName("fiAnio");

                entity.Property(e => e.FiMes).HasColumnName("fiMes");

                entity.Property(e => e.FcEstado)
                    .IsRequired()
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("fcEstado");

                entity.Property(e => e.FcObservaciones)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("fcObservaciones");

                entity.Property(e => e.FcUsuarioModificacion)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("fcUsuarioModificacion");

                entity.Property(e => e.FcUsuarioRegistro)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("fcUsuarioRegistro");

                entity.Property(e => e.FdFechaAtencion)
                    .HasPrecision(0)
                    .HasColumnName("fdFechaAtencion");

                entity.Property(e => e.FdFechaModificacion)
                    .HasPrecision(0)
                    .HasColumnName("fdFechaModificacion");

                entity.Property(e => e.FdFechaRegistro)
                    .HasPrecision(0)
                    .HasColumnName("fdFechaRegistro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FiIdMedico).HasColumnName("fiIdMedico");

                entity.Property(e => e.FiIdPaciente).HasColumnName("fiIdPaciente");

                entity.Property(e => e.FlActivo).HasColumnName("flActivo");

                entity.Property(e => e.FtFinAtencion).HasColumnName("ftFinAtencion");

                entity.Property(e => e.FtInicioAtencion).HasColumnName("ftInicioAtencion");

                entity.HasOne(d => d.TblCatMedico)
                    .WithMany(p => p.TblDatCita)
                    .HasForeignKey(d => d.FiIdMedico)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.TblCatPaciente)
                    .WithMany(p => p.TblDatCita)
                    .HasForeignKey(d => d.FiIdPaciente)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblDatHorario>(entity =>
            {
                entity.HasKey(e => e.FiIdHorario)
                    .HasName("PK_TblDatHorarios_fiIdHorario");

                entity.ToTable("TblDatHorarios", "CitasMedicas");

                entity.Property(e => e.FiIdHorario).HasColumnName("fiIdHorario");

                entity.Property(e => e.FcUsuarioModificacion)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("fcUsuarioModificacion");

                entity.Property(e => e.FcUsuarioRegistro)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("fcUsuarioRegistro");

                entity.Property(e => e.FdFechaAtencion)
                    .HasPrecision(0)
                    .HasColumnName("fdFechaAtencion");

                entity.Property(e => e.FdFechaModificacion)
                    .HasPrecision(0)
                    .HasColumnName("fdFechaModificacion");

                entity.Property(e => e.FdFechaRegistro)
                    .HasPrecision(0)
                    .HasColumnName("fdFechaRegistro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FiIdMedico).HasColumnName("fiIdMedico");

                entity.Property(e => e.FlActivo).HasColumnName("flActivo");

                entity.Property(e => e.FtFinAtencion).HasColumnName("ftFinAtencion");

                entity.Property(e => e.FtInicioAtencion).HasColumnName("ftInicioAtencion");

                entity.HasOne(d => d.TblCatMedico)
                    .WithMany(p => p.TblDatHorarios)
                    .HasForeignKey(d => d.FiIdMedico)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<TblDatRetrasoCita>(entity =>
            {
                entity.HasKey(e => new { e.FiIdCita, e.FiAnio, e.FiMes, e.FiIdRetraso })
                    .HasName("PK_TblCatPacientes_fiIdCita");

                entity.ToTable("TblDatRetrasoCitas", "CitasMedicas");

                entity.Property(e => e.FiIdCita).HasColumnName("fiIdCita");

                entity.Property(e => e.FiAnio).HasColumnName("fiAnio");

                entity.Property(e => e.FiMes).HasColumnName("fiMes");

                entity.Property(e => e.FiIdRetraso).HasColumnName("fiIdRetraso");

                entity.Property(e => e.FcObservaciones)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("fcObservaciones");

                entity.Property(e => e.FcUsuarioModificacion)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("fcUsuarioModificacion");

                entity.Property(e => e.FcUsuarioRegistro)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("fcUsuarioRegistro");

                entity.Property(e => e.FdFecha)
                    .HasPrecision(0)
                    .HasColumnName("fdFecha");

                entity.Property(e => e.FdFechaModificacion)
                    .HasPrecision(0)
                    .HasColumnName("fdFechaModificacion");

                entity.Property(e => e.FdFechaRegistro)
                    .HasPrecision(0)
                    .HasColumnName("fdFechaRegistro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FiIdMedico).HasColumnName("fiIdMedico");

                entity.Property(e => e.FiIdPaciente).HasColumnName("fiIdPaciente");

                entity.Property(e => e.FlActivo).HasColumnName("flActivo");

                entity.Property(e => e.FtFin).HasColumnName("ftFin");

                entity.Property(e => e.FtInicio).HasColumnName("ftInicio");

                entity.HasOne(d => d.TblDatCita)
                    .WithMany(p => p.TblDatRetrasoCita)
                    .HasForeignKey(d => new { d.FiIdCita, d.FiAnio, d.FiMes })
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TblDatRetrasoCitas");
            });

            modelBuilder.Entity<TblIntMedicosEspecialidades>(entity =>
            {
                entity.HasKey(e => e.FiIdMedEspecialidades)
                    .HasName("PK_TblIntMedicosEspecialidades_fiIdMedEspecialidades");

                entity.ToTable("TblIntMedicosEspecialidades", "CitasMedicas");

                entity.Property(e => e.FiIdMedEspecialidades).HasColumnName("fiIdMedEspecialidades");

                entity.Property(e => e.FdFechaRegistro)
                    .HasPrecision(0)
                    .HasColumnName("fdFechaRegistro")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FiIdEspecialidad).HasColumnName("fiIdEspecialidad");

                entity.Property(e => e.FiIdMedico).HasColumnName("fiIdMedico");

                entity.Property(e => e.FlActivo).HasColumnName("flActivo");

                entity.HasOne(d => d.TblCatEspecialidades)
                    .WithMany(p => p.TblIntMedicosEspecialidades)
                    .HasForeignKey(d => d.FiIdEspecialidad)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.TblCatMedico)
                    .WithMany(p => p.TblIntMedicosEspecialidades)
                    .HasForeignKey(d => d.FiIdMedico)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
