﻿// <auto-generated />
using FilippovKirillKt_41_21.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FilippovKirillKt_41_21.Migrations
{
    [DbContext(typeof(StudentDbContext))]
    partial class StudentDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("FilippovKirillKt_41_21.Models.Group", b =>
                {
                    b.Property<int>("GroupId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("group_id")
                        .HasComment("Идентификатор записи группы");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("c_group_name")
                        .HasComment("Название группы");

                    b.Property<int>("SubjectId")
                        .HasColumnType("INTEGER");

                    b.HasKey("GroupId")
                        .HasName("pk_cd_group_group_id");

                    b.HasIndex(new[] { "SubjectId" }, "idx_cd_group_fk_f_subject_id");

                    b.ToTable("cd_group", (string)null);
                });

            modelBuilder.Entity("FilippovKirillKt_41_21.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("student_id")
                        .HasComment("Идентификатор записи студента");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("c_student_firstname")
                        .HasComment("Имя студента");

                    b.Property<int>("GroupId")
                        .HasColumnType("int4")
                        .HasColumnName("f_group_id")
                        .HasComment("Идентификатор группы");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bool")
                        .HasColumnName("b_deleted")
                        .HasComment("Статус удаления");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("c_student_lastname")
                        .HasComment("Фамилия студента");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("c_student_middlename")
                        .HasComment("Отчество студента");

                    b.HasKey("StudentId")
                        .HasName("pk_cd_student_student_id");

                    b.HasIndex(new[] { "GroupId" }, "idx_cd_student_fk_f_group_id");

                    b.ToTable("cd_student", (string)null);
                });

            modelBuilder.Entity("FilippovKirillKt_41_21.Models.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("subject_id")
                        .HasComment("Идентификатор записи предмета");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar")
                        .HasColumnName("c_subject_name")
                        .HasComment("Название предмета");

                    b.HasKey("SubjectId")
                        .HasName("pk_cd_subject_subject_id");

                    b.ToTable("cd_subject", (string)null);
                });

            modelBuilder.Entity("FilippovKirillKt_41_21.Models.Group", b =>
                {
                    b.HasOne("FilippovKirillKt_41_21.Models.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_f_subject_id");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("FilippovKirillKt_41_21.Models.Student", b =>
                {
                    b.HasOne("FilippovKirillKt_41_21.Models.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("fk_f_group_id");

                    b.Navigation("Group");
                });
#pragma warning restore 612, 618
        }
    }
}
