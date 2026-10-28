using EFCoreDemo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreDemo.Configurations
{
    internal class StudentCourseConfigurations : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.HasKey(X => new { X.StId, X.CrsId });
            builder.HasOne(SC => SC.Student)
                .WithMany(S => S.Courses)
                .HasForeignKey(X => X.StId);

            builder.HasOne(SC => SC.Course)
               .WithMany(C => C.StudentCourses)
               .HasForeignKey(X => X.CrsId);
        }
    }
}
