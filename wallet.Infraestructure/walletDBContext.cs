using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using wallet.Domain.Entities;

namespace wallet.infraestructure
{
    public class walletDBContext : DbContext
    {
        public walletDBContext(DbContextOptions<walletDBContext> options) : base(options) { }


        #region Tables

        public DbSet<Currency> Currencies { get; set; }
        public DbSet<Wallet> Wallets { get; set; }
        public DbSet<Payment> Payments { get; set; }
        
        #endregion

    }
}
