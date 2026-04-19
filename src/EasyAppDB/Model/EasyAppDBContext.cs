// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EasyAppDB.Model
{
    public class EasyAppDBContext: DbContext
    {
        public EasyAppDBContext(DbContextOptions<EasyAppDBContext> options) : base(options)
        {
        }
        //public DbSet<DbApp> Apps { get; set; }
    }
}
