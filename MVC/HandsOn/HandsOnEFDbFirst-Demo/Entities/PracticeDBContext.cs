using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HandsOnEFDbFirst_Demo.Entities
{
    public partial class PracticeDBContext : DbContext
    {
        //public PracticeDBContext()
        //{
        //}

        public PracticeDBContext(DbContextOptions<PracticeDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmployeeProject> EmployeeProjects { get; set; }
        public virtual DbSet<EmployeeView> EmployeeViews { get; set; }
        public virtual DbSet<First> Firsts { get; set; }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Second> Seconds { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                //optionsBuilder.UseSqlServer("Data Source=SANTU\\MSSQLSERVER2019;Initial Catalog=PracticeDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmployeeCode)
                    .HasName("PK__Employee__B0AA73445E3E0D44");

                entity.HasIndex(e => e.ProjectCode, "project_code_nci");

                entity.Property(e => e.EmployeeCode)
                    .ValueGeneratedNever()
                    .HasColumnName("employee_code");

                entity.Property(e => e.Designation)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("designation");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("employee_name");

                entity.Property(e => e.JoinDate)
                    .HasColumnType("date")
                    .HasColumnName("join_date");

                entity.Property(e => e.ProjectCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("project_code")
                    .IsFixedLength(true);

                entity.Property(e => e.Salary)
                    .HasColumnType("money")
                    .HasColumnName("salary");

                entity.HasOne(d => d.ProjectCodeNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.ProjectCode)
                    .HasConstraintName("FK__Employees__proje__412EB0B6");
            });

            modelBuilder.Entity<EmployeeProject>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EmployeeProject");

                entity.Property(e => e.EmployeeCode).HasColumnName("employee_code");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("employee_name");

                entity.Property(e => e.ProjectCode)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("project_code")
                    .IsFixedLength(true);

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("project_name");
            });

            modelBuilder.Entity<EmployeeView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EmployeeView");

                entity.Property(e => e.EmployeeCode).HasColumnName("employee_code");

                entity.Property(e => e.EmployeeName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("employee_name");
            });

            modelBuilder.Entity<First>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("First");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("Pid_PK");

                entity.ToTable("Person");

                entity.Property(e => e.Pid).ValueGeneratedNever();

                entity.Property(e => e.City)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("city");

                entity.Property(e => e.Pname)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Pid)
                    .HasName("PK__Product__C5705938072E5376");

                entity.ToTable("Product");

                entity.HasIndex(e => e.Pname, "UQ__Product__173BB01CF117E843")
                    .IsUnique();

                entity.Property(e => e.Pid).ValueGeneratedNever();

                entity.Property(e => e.Pname)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(e => e.ProjectCode)
                    .HasName("PK__Projects__891B3A6E6351D996");

                entity.HasIndex(e => e.ProjectName, "UQ__Projects__4A0B0D69A0A8957D")
                    .IsUnique();

                entity.Property(e => e.ProjectCode)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("project_code")
                    .IsFixedLength(true);

                entity.Property(e => e.EndDate)
                    .HasColumnType("date")
                    .HasColumnName("end_date");

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("project_name");

                entity.Property(e => e.StartDate)
                    .HasColumnType("date")
                    .HasColumnName("start_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TeamSize).HasColumnName("team_size");
            });

            modelBuilder.Entity<Second>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Second");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasNoKey();

                entity.HasIndex(e => e.UserId, "user_id_ci")
                    .IsUnique()
                    .IsClustered();

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("user_name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
