using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Configuration : IEntityTypeConfiguration<Blog>
    { 
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.Property(x => x.URL).IsRequired();
        }

    }
}
