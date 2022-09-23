﻿using Exam1_2.Infrastructure.BusinessObjects;
using Exam1_2.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;

namespace Exam1_2.Infrastructure.DbContexts
{
    public interface IApplicationDbContext
    {
        DbSet<Book> Books { get; set; }
        DbSet<Reader> Readers { get; set; }
    }
}