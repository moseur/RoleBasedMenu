using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RoleBasedMenu.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RoleBasedMenu.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		public DbSet<RoleMenuPermission> RoleMenuPermission { get; set; }

		public DbSet<NavigationMenu> NavigationMenu { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			base.OnModelCreating(builder);
		}
	}
}
