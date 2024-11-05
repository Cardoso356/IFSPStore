﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IFSPStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IFSPStore.Repository.Mapping
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(255);

            builder.Property(x => x.Preco);

            builder.Property(x => x.Quantidade);

            builder.Property(x => x.DataCompra);

            builder.Property(x => x.DataCompra)
                .HasMaxLength(50);

            builder.HasOne(x => x.Grupo) //da chave estrangeira
                .WithMany()
                .HasConstraintName("nome_chave_estrangeira");
        }
    }
}
