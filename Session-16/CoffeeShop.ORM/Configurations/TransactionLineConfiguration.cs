﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShop.Models;

namespace CoffeeShop.ORM.Configurations {
    public class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine> {

        public void Configure(EntityTypeBuilder<TransactionLine> builder) {

            builder.ToTable("Transaction.Lines");
            builder.HasKey(transactionLine => transactionLine.ID);

        }

    }
}