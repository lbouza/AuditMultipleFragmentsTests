using System;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using DBService.Domain;
using DBService.Domain.Inheritance;

namespace DBService
{
    public class Tests
    {
        public void Test()
        {
            //to run creation of database if it not exist
            using (DataBaseContext dbContext = new DataBaseContext())
            {
                dbContext.Database.Initialize(false);
            }

            ///////////////////add
            try
            {
                using (DataBaseContext context = new DataBaseContext())
                {
                    var leafTwo = new LeafFour
                    {
                        Attention = "Attention",
                    };
                    DbSet<LeafFour> set = context.Set<LeafFour>();
                    set.Add(leafTwo);
                    context.SaveChanges();
                }
            }
            catch (DbEntityValidationException e)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }


            ///////////////////update
            try
            {
                using (DataBaseContext context = new DataBaseContext())
                {
                    LeafFour entity = context.Set<LeafFour>().First();

                    if(entity==null)
                        throw new Exception("1");

                    entity.Attention = "AttentionUpdate";

                    context.SaveChanges();
                }
            }
            catch (DbEntityValidationException e)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }

            ///////////////////delete
            try
            {
                using (DataBaseContext context = new DataBaseContext())
                {
                    LeafFour entity = context.Set<LeafFour>().First();

                    if (entity == null)
                        throw new Exception("1");

                    DbSet<LeafFour> set = context.Set<LeafFour>();
                    set.Remove(entity);
                    context.SaveChanges();
                }
            }
            catch (DbEntityValidationException e)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}