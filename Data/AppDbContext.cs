namespace App.Data;

using App.Models.Contacts;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // foreach(var entityType in modelBuilder.Model.GetEntityTypes()){
        //     var tableName = entityType.GetTableName();
        //     if(tableName.StartsWith("AspNet"))
        //     {
        //         entityType.SetTableName(tableName.Substring(6));
        //     }
        // }
    }

    public DbSet<Contact> Contacts { get; set; }

}