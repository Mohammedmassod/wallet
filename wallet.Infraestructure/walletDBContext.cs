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

        
        #endregion

    }
}
