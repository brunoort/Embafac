using Embafac.Pcp.Entidades.Models;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Embafac.Pcp.Entidades
{
    public class EmbafacContext : DbContext
    {
        public EmbafacContext(string connectionString)
            : base(connectionString)
        {
            _caminhao = Caminhoes;
            _tipoVeiculo = TipoVeiculos;
        }

        private IDbSet<Caminhao> _caminhao;
        public IDbSet<Caminhao> Caminhoes
        {
            get { return _caminhao ?? (_caminhao = DbSet<Caminhao>()); }
        }

        private IDbSet<TipoVeiculo> _tipoVeiculo;
        public IDbSet<TipoVeiculo> TipoVeiculos
        {
            get { return _tipoVeiculo ?? (_tipoVeiculo = DbSet<TipoVeiculo>()); }
        }

        /// <summary>
        /// Returns a DbSet for the specified type, this allows CRUD operations to be performed for 
        /// the given entity in the context.  
        /// </summary>
        public virtual IDbSet<T> DbSet<T>() where T : class
        {
            return Set<T>();
        }

        /// <summary>
        /// Saves all changes made in this context to the underlying database. 
        /// </summary>
        public virtual void Commit()
        {
            SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //string database = ConfigurationManager.AppSettings["database"];
            string connection = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            Database.Connection.ConnectionString = connection;

            base.OnModelCreating(modelBuilder);
            //Recarregar dados da base
            //Database.SetInitializer(new Initialiser());

            //Mapeamento das chaves estrangeiras (One to Many)
            modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //modelBuilder.Entity<Solicitacao>().HasMany(c => c.FluxoAprovacoes).WithOptional(a => a.Solicitacao).HasForeignKey(a => a.SolicitacaoID);
        }
    }


    /// <summary>
    /// The Initialiser class defines the behaviour for recreating the Opendesk data structure and seeds 
    /// the database with the default values required for the application to run.
    /// </summary>
    //internal class Initialiser : DropCreateDatabaseAlways<EmbafacContext>
    //{
    //    protected override void Seed(EmbafacContext context)
    //    {
    //        /* Atores */
    //        //context.Atores.AddOrUpdate(i => i.Nome,
    //        //        new Ator { Nome = "Dwayne Jonhson" , Foto = "1.jpg"},
    //        //        new Ator { Nome = "Vin Diesel" , Foto = "2.jpg"}
    //        //    );

    //        context.SaveChanges();

    //    }
    //}
}
