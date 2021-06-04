using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Reflection;
using Audit.EntityFramework;
using DBService.Domain;
using DBService.Mappings;

namespace DBService
{
    public class DataBaseContext:DbContext
    {
        private static DbContextHelper _helper = new DbContextHelper();
        private readonly IAuditDbContext _auditContext;

        public DataBaseContext() : base("DataBaseAuditTests1")
        {
            _auditContext = new DefaultAuditContext(this);
            _helper.SetConfig(_auditContext);

            //comments this lines and the problem persists.
            Audit.EntityFramework.Configuration.Setup().ForContext<DataBaseContext>(config =>
            {
                config.IncludeEntityObjects();
                config.IncludeIndependantAssociations();
            }).UseOptOut();
        }

        public override int SaveChanges()
        {
//            return base.SaveChanges();
            return _helper.SaveChanges(_auditContext, () => base.SaveChanges());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Register Entity types
            List<Type> entityTypesToRegister = Assembly.GetExecutingAssembly().GetTypes().Where(type =>
                type.BaseType != null && !type.IsAbstract && type.BaseType.IsGenericType &&
                (type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>) ||
                 type.BaseType.GetGenericTypeDefinition() == typeof(BaseMap<>))).ToList();

            foreach (object configurationInstance in entityTypesToRegister.Select(Activator.CreateInstance))
                modelBuilder.Configurations.Add((dynamic)configurationInstance);

        }
    }
}