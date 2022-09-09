﻿// <autogenerated />
namespace Common
{
    #pragma warning disable // See configuration setting CommonConcepts:CompilerWarningsInGeneratedCode.

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Linq.Expressions;
    using System.Runtime.Serialization;
    using Rhetos.Dom.DefaultConcepts;
    using Rhetos.Utilities;
    using Autofac;
    /*CommonUsing*/

    public class DomRepository
    {
        private readonly Rhetos.Extensibility.INamedPlugins<IRepository> _repositories;

        public DomRepository(Rhetos.Extensibility.INamedPlugins<IRepository> repositories)
        {
            _repositories = repositories;
        }

        private Bookstore.Repositories.ModuleRepository _Bookstore;
        public Bookstore.Repositories.ModuleRepository Bookstore { get { return _Bookstore ?? (_Bookstore = new Bookstore.Repositories.ModuleRepository(_repositories)); } }

        private Common.Repositories.ModuleRepository _Common;
        public Common.Repositories.ModuleRepository Common { get { return _Common ?? (_Common = new Common.Repositories.ModuleRepository(_repositories)); } }

        /*CommonDomRepositoryMembers*/
    }
    
    public static class Infrastructure
    {
        public static readonly RegisteredInterfaceImplementations RegisteredInterfaceImplementations = new RegisteredInterfaceImplementations
        {
            { typeof(Rhetos.Dom.DefaultConcepts.ICommonClaim), @"Common.Claim" },
            { typeof(Rhetos.Dom.DefaultConcepts.ICommonFilterId), @"Common.FilterId" },
            { typeof(Rhetos.Dom.DefaultConcepts.IKeepSynchronizedMetadata), @"Common.KeepSynchronizedMetadata" },
            { typeof(Rhetos.Dom.DefaultConcepts.IPrincipal), @"Common.Principal" },
            { typeof(Rhetos.Dom.DefaultConcepts.IPrincipalHasRole), @"Common.PrincipalHasRole" },
            { typeof(Rhetos.Dom.DefaultConcepts.IPrincipalPermission), @"Common.PrincipalPermission" },
            { typeof(Rhetos.Dom.DefaultConcepts.IRole), @"Common.Role" },
            { typeof(Rhetos.Dom.DefaultConcepts.IRoleInheritsRole), @"Common.RoleInheritsRole" },
            { typeof(Rhetos.Dom.DefaultConcepts.IRolePermission), @"Common.RolePermission" },
            /*RegisteredInterfaceImplementationName*/
        };

        public static readonly ApplyFiltersOnClientRead ApplyFiltersOnClientRead = new ApplyFiltersOnClientRead
        {
            /*ApplyFiltersOnClientRead*/
        };

        public static readonly Dictionary<string, Func<KeyValuePair<string, Type>[]>> DataStructuresReadParameterTypes = new()
        {
            { "Bookstore.Book", Bookstore.Repositories.Book_Repository.GetReadParameterTypes },
            { "Bookstore.BookInfo", Bookstore.Repositories.BookInfo_Repository.GetReadParameterTypes },
            { "Bookstore.BookTopic", Bookstore.Repositories.BookTopic_Repository.GetReadParameterTypes },
            { "Bookstore.BookTopics", Bookstore.Repositories.BookTopics_Repository.GetReadParameterTypes },
            { "Bookstore.ChildrensBook", Bookstore.Repositories.ChildrensBook_Repository.GetReadParameterTypes },
            { "Bookstore.Comment", Bookstore.Repositories.Comment_Repository.GetReadParameterTypes },
            { "Bookstore.Department", Bookstore.Repositories.Department_Repository.GetReadParameterTypes },
            { "Bookstore.Disposal", Bookstore.Repositories.Disposal_Repository.GetReadParameterTypes },
            { "Bookstore.Education", Bookstore.Repositories.Education_Repository.GetReadParameterTypes },
            { "Bookstore.Employee", Bookstore.Repositories.Employee_Repository.GetReadParameterTypes },
            { "Bookstore.EmployeeDepartment", Bookstore.Repositories.EmployeeDepartment_Repository.GetReadParameterTypes },
            { "Bookstore.ExpectedBookRating", Bookstore.Repositories.ExpectedBookRating_Repository.GetReadParameterTypes },
            { "Bookstore.ForeignBook", Bookstore.Repositories.ForeignBook_Repository.GetReadParameterTypes },
            { "Bookstore.Manager", Bookstore.Repositories.Manager_Repository.GetReadParameterTypes },
            { "Bookstore.Person", Bookstore.Repositories.Person_Repository.GetReadParameterTypes },
            { "Bookstore.PersonInfo", Bookstore.Repositories.PersonInfo_Repository.GetReadParameterTypes },
            { "Bookstore.Review", Bookstore.Repositories.Review_Repository.GetReadParameterTypes },
            { "Bookstore.Topic", Bookstore.Repositories.Topic_Repository.GetReadParameterTypes },
            { "Common.AutoCodeCache", Common.Repositories.AutoCodeCache_Repository.GetReadParameterTypes },
            { "Common.Claim", Common.Repositories.Claim_Repository.GetReadParameterTypes },
            { "Common.ExclusiveLock", Common.Repositories.ExclusiveLock_Repository.GetReadParameterTypes },
            { "Common.FilterId", Common.Repositories.FilterId_Repository.GetReadParameterTypes },
            { "Common.KeepSynchronizedMetadata", Common.Repositories.KeepSynchronizedMetadata_Repository.GetReadParameterTypes },
            { "Common.Log", Common.Repositories.Log_Repository.GetReadParameterTypes },
            { "Common.LogReader", Common.Repositories.LogReader_Repository.GetReadParameterTypes },
            { "Common.LogRelatedItem", Common.Repositories.LogRelatedItem_Repository.GetReadParameterTypes },
            { "Common.LogRelatedItemReader", Common.Repositories.LogRelatedItemReader_Repository.GetReadParameterTypes },
            { "Common.Principal", Common.Repositories.Principal_Repository.GetReadParameterTypes },
            { "Common.PrincipalHasRole", Common.Repositories.PrincipalHasRole_Repository.GetReadParameterTypes },
            { "Common.PrincipalPermission", Common.Repositories.PrincipalPermission_Repository.GetReadParameterTypes },
            { "Common.RelatedEventsSource", Common.Repositories.RelatedEventsSource_Repository.GetReadParameterTypes },
            { "Common.Role", Common.Repositories.Role_Repository.GetReadParameterTypes },
            { "Common.RoleInheritsRole", Common.Repositories.RoleInheritsRole_Repository.GetReadParameterTypes },
            { "Common.RolePermission", Common.Repositories.RolePermission_Repository.GetReadParameterTypes },
            { "Bookstore.BookGrid", Bookstore.Repositories.BookGrid_Repository.GetReadParameterTypes },
            { "Bookstore.BookTopicsGrid", Bookstore.Repositories.BookTopicsGrid_Repository.GetReadParameterTypes },
            { "Common.MyClaim", Common.Repositories.MyClaim_Repository.GetReadParameterTypes },
            /*DataStructuresReadParameterTypes*/
        };

        public static readonly CurrentKeepSynchronizedMetadata CurrentKeepSynchronizedMetadata = new CurrentKeepSynchronizedMetadata
        {
            /*AddKeepSynchronizedMetadata*/
        };

        /*CommonInfrastructureMembers*/
    }

    public class ExecutionContext
    {
        protected Lazy<Rhetos.Persistence.IPersistenceTransaction> _persistenceTransaction;
        public Rhetos.Persistence.IPersistenceTransaction PersistenceTransaction { get { return _persistenceTransaction.Value; } }

        protected Lazy<Rhetos.Utilities.IUserInfo> _userInfo;
        public Rhetos.Utilities.IUserInfo UserInfo { get { return _userInfo.Value; } }

        protected Lazy<Rhetos.Utilities.ISqlExecuter> _sqlExecuter;
        public Rhetos.Utilities.ISqlExecuter SqlExecuter { get { return _sqlExecuter.Value; } }

        protected Lazy<Rhetos.Security.IAuthorizationManager> _authorizationManager;
        public Rhetos.Security.IAuthorizationManager AuthorizationManager { get { return _authorizationManager.Value; } }

        protected Lazy<Rhetos.Dom.DefaultConcepts.GenericRepositories> _genericRepositories;
        public Rhetos.Dom.DefaultConcepts.GenericRepositories GenericRepositories { get { return _genericRepositories.Value; } }

        public Rhetos.Dom.DefaultConcepts.GenericRepository<TEntity> GenericRepository<TEntity>() where TEntity : class, IEntity
        {
            return GenericRepositories.GetGenericRepository<TEntity>();
        }

        public Rhetos.Dom.DefaultConcepts.GenericRepository<TEntity> GenericRepository<TEntity>(string entityName) where TEntity : class, IEntity
        {
            return GenericRepositories.GetGenericRepository<TEntity>(entityName);
        }

        public Rhetos.Dom.DefaultConcepts.GenericRepository<IEntity> GenericRepository(string entityName)
        {
            return GenericRepositories.GetGenericRepository(entityName);
        }

        protected Lazy<Common.DomRepository> _repository;
        public Common.DomRepository Repository { get { return _repository.Value; } }

        protected Lazy<Rhetos.Dom.DefaultConcepts.IPersistenceStorage> _persistenceStorage;
        public Rhetos.Dom.DefaultConcepts.IPersistenceStorage PersistenceStorage { get { return _persistenceStorage.Value; } }

        public Rhetos.Logging.ILogProvider LogProvider { get; private set; }

        protected Lazy<EntityFrameworkContext> _entityFrameworkContext;
        public EntityFrameworkContext EntityFrameworkContext { get { return _entityFrameworkContext.Value; } }

        /*ExecutionContextMember*/

        // This constructor is used for automatic parameter injection with autofac.
        public ExecutionContext(
            Lazy<Rhetos.Persistence.IPersistenceTransaction> persistenceTransaction,
            Lazy<Rhetos.Utilities.IUserInfo> userInfo,
            Lazy<Rhetos.Utilities.ISqlExecuter> sqlExecuter,
            Lazy<Rhetos.Security.IAuthorizationManager> authorizationManager,
            Lazy<Rhetos.Dom.DefaultConcepts.GenericRepositories> genericRepositories,
            Lazy<Common.DomRepository> repository,
            Lazy<Rhetos.Dom.DefaultConcepts.IPersistenceStorage> persistenceStorage,
            Rhetos.Logging.ILogProvider logProvider/*ExecutionContextConstructorArgument*/,
            Lazy<EntityFrameworkContext> entityFrameworkContext)
        {
            _persistenceTransaction = persistenceTransaction;
            _userInfo = userInfo;
            _sqlExecuter = sqlExecuter;
            _authorizationManager = authorizationManager;
            _genericRepositories = genericRepositories;
            _repository = repository;
            _persistenceStorage = persistenceStorage;
            LogProvider = logProvider;
            _entityFrameworkContext = entityFrameworkContext;
            /*ExecutionContextConstructorAssignment*/
        }

        // This constructor is used for manual context creation (unit testing)
        protected ExecutionContext()
        {
        }
    }

    [System.ComponentModel.Composition.Export(typeof(Autofac.Module))]
    [System.ComponentModel.Composition.ExportMetadata(Rhetos.Extensibility.MefProvider.DependsOn, typeof(Rhetos.Dom.DefaultConcepts.AutofacModuleConfiguration))] // Overrides some registrations from that class.
    public class AutofacModuleConfiguration : Autofac.Module
    {
        protected override void Load(Autofac.ContainerBuilder builder)
        {
            builder.RegisterType<DomRepository>().InstancePerLifetimeScope();
            builder.RegisterType<EntityFrameworkConfiguration>()
                .As<System.Data.Entity.DbConfiguration>()
                .SingleInstance();
            builder.RegisterType<EntityFrameworkContext>()
                .As<EntityFrameworkContext>()
                .As<System.Data.Entity.DbContext>()
                .InstancePerLifetimeScope();
            builder.RegisterType<ExecutionContext>().InstancePerMatchingLifetimeScope(Rhetos.UnitOfWorkScope.ScopeName);
            builder.RegisterInstance(Infrastructure.RegisteredInterfaceImplementations).ExternallyOwned();
            builder.RegisterInstance(Infrastructure.ApplyFiltersOnClientRead).ExternallyOwned();
            builder.RegisterType<PersistenceStorage>().As<IPersistenceStorage>();
            builder.RegisterType<SqlCommandBatch>().As<IPersistenceStorageCommandBatch>();
            builder.RegisterType<PersistenceStorageObjectMappings>().As<IPersistenceStorageObjectMappings>().SingleInstance();

            builder.Register(context => context.Resolve<IConfiguration>().GetOptions<CommonConceptsRuntimeOptions>()).SingleInstance();
            builder.Register<CommonConceptsOptions>(context => throw new NotImplementedException($"{nameof(CommonConceptsOptions)} is a build-time configuration, not available at run-time."));
            builder.Register<IDataStructureReadParameters>(context => new Rhetos.Dom.DefaultConcepts.DataStructureReadParameters(Infrastructure.DataStructuresReadParameterTypes)).SingleInstance();
            
            builder.RegisterInstance(Infrastructure.CurrentKeepSynchronizedMetadata).ExternallyOwned();
            builder.RegisterType<Bookstore.Repositories.Book_Repository>().Keyed<IRepository>("Bookstore.Book").InstancePerLifetimeScope();
            builder.RegisterType<Bookstore.Repositories.BookInfo_Repository>().Keyed<IRepository>("Bookstore.BookInfo").InstancePerLifetimeScope();
            builder.RegisterType<Bookstore.Repositories.BookTopic_Repository>().Keyed<IRepository>("Bookstore.BookTopic").InstancePerLifetimeScope();
            builder.RegisterType<Bookstore.Repositories.BookTopics_Repository>().Keyed<IRepository>("Bookstore.BookTopics").InstancePerLifetimeScope();
            builder.RegisterType<Bookstore.Repositories.ChildrensBook_Repository>().Keyed<IRepository>("Bookstore.ChildrensBook").InstancePerLifetimeScope();
            builder.RegisterType<Bookstore.Repositories.Comment_Repository>().Keyed<IRepository>("Bookstore.Comment").InstancePerLifetimeScope();
            builder.RegisterType<Bookstore.Repositories.Department_Repository>().Keyed<IRepository>("Bookstore.Department").InstancePerLifetimeScope();
            builder.RegisterType<Bookstore.Repositories.Disposal_Repository>().Keyed<IRepository>("Bookstore.Disposal").InstancePerLifetimeScope();
            builder.RegisterType<Bookstore.Repositories.Education_Repository>().Keyed<IRepository>("Bookstore.Education").InstancePerLifetimeScope();
            builder.RegisterType<Bookstore.Repositories.Employee_Repository>().Keyed<IRepository>("Bookstore.Employee").InstancePerLifetimeScope();
            builder.RegisterType<Bookstore.Repositories.EmployeeDepartment_Repository>().Keyed<IRepository>("Bookstore.EmployeeDepartment").InstancePerLifetimeScope();
            builder.RegisterType<Bookstore.Repositories.ExpectedBookRating_Repository>().Keyed<IRepository>("Bookstore.ExpectedBookRating").InstancePerLifetimeScope();
            builder.RegisterType<Bookstore.Repositories.ForeignBook_Repository>().Keyed<IRepository>("Bookstore.ForeignBook").InstancePerLifetimeScope();
            builder.RegisterType<Bookstore.Repositories.InsertManyBooks_Repository>().Keyed<IRepository>("Bookstore.InsertManyBooks").InstancePerLifetimeScope();
            builder.RegisterType<Bookstore.Repositories.InsertManyBooks_Repository>().Keyed<IActionRepository>("Bookstore.InsertManyBooks").InstancePerLifetimeScope();
            builder.RegisterType<Bookstore.Repositories.Manager_Repository>().Keyed<IRepository>("Bookstore.Manager").InstancePerLifetimeScope();
            builder.RegisterType<Bookstore.Repositories.Person_Repository>().Keyed<IRepository>("Bookstore.Person").InstancePerLifetimeScope();
            builder.RegisterType<Bookstore.Repositories.PersonInfo_Repository>().Keyed<IRepository>("Bookstore.PersonInfo").InstancePerLifetimeScope();
            builder.RegisterType<Bookstore.Repositories.Review_Repository>().Keyed<IRepository>("Bookstore.Review").InstancePerLifetimeScope();
            builder.RegisterType<Bookstore.Repositories.Topic_Repository>().Keyed<IRepository>("Bookstore.Topic").InstancePerLifetimeScope();
            builder.RegisterType<Common.Repositories.AddToLog_Repository>().Keyed<IRepository>("Common.AddToLog").InstancePerLifetimeScope();
            builder.RegisterType<Common.Repositories.AddToLog_Repository>().Keyed<IActionRepository>("Common.AddToLog").InstancePerLifetimeScope();
            builder.RegisterType<Common.Repositories.AutoCodeCache_Repository>().Keyed<IRepository>("Common.AutoCodeCache").InstancePerLifetimeScope();
            builder.RegisterType<Common.Repositories.Claim_Repository>().Keyed<IRepository>("Common.Claim").InstancePerLifetimeScope();
            builder.RegisterType<Common.Repositories.ExclusiveLock_Repository>().Keyed<IRepository>("Common.ExclusiveLock").InstancePerLifetimeScope();
            builder.RegisterType<Common.Repositories.FilterId_Repository>().Keyed<IRepository>("Common.FilterId").InstancePerLifetimeScope();
            builder.RegisterType<Common.Repositories.KeepSynchronizedMetadata_Repository>().Keyed<IRepository>("Common.KeepSynchronizedMetadata").InstancePerLifetimeScope();
            builder.RegisterType<Common.Repositories.Log_Repository>().Keyed<IRepository>("Common.Log").InstancePerLifetimeScope();
            builder.RegisterType<Common.Repositories.LogReader_Repository>().Keyed<IRepository>("Common.LogReader").InstancePerLifetimeScope();
            builder.RegisterType<Common.Repositories.LogRelatedItem_Repository>().Keyed<IRepository>("Common.LogRelatedItem").InstancePerLifetimeScope();
            builder.RegisterType<Common.Repositories.LogRelatedItemReader_Repository>().Keyed<IRepository>("Common.LogRelatedItemReader").InstancePerLifetimeScope();
            builder.RegisterType<Common.Repositories.Principal_Repository>().Keyed<IRepository>("Common.Principal").InstancePerLifetimeScope();
            builder.RegisterType<Common.Repositories.PrincipalHasRole_Repository>().Keyed<IRepository>("Common.PrincipalHasRole").InstancePerLifetimeScope();
            builder.RegisterType<Common.Repositories.PrincipalPermission_Repository>().Keyed<IRepository>("Common.PrincipalPermission").InstancePerLifetimeScope();
            builder.RegisterType<Common.Repositories.RelatedEventsSource_Repository>().Keyed<IRepository>("Common.RelatedEventsSource").InstancePerLifetimeScope();
            builder.RegisterType<Common.Repositories.ReleaseLock_Repository>().Keyed<IRepository>("Common.ReleaseLock").InstancePerLifetimeScope();
            builder.RegisterType<Common.Repositories.ReleaseLock_Repository>().Keyed<IActionRepository>("Common.ReleaseLock").InstancePerLifetimeScope();
            builder.RegisterType<Common.Repositories.Role_Repository>().Keyed<IRepository>("Common.Role").InstancePerLifetimeScope();
            builder.RegisterType<Common.Repositories.RoleInheritsRole_Repository>().Keyed<IRepository>("Common.RoleInheritsRole").InstancePerLifetimeScope();
            builder.RegisterType<Common.Repositories.RolePermission_Repository>().Keyed<IRepository>("Common.RolePermission").InstancePerLifetimeScope();
            builder.RegisterType<Common.Repositories.SetLock_Repository>().Keyed<IRepository>("Common.SetLock").InstancePerLifetimeScope();
            builder.RegisterType<Common.Repositories.SetLock_Repository>().Keyed<IActionRepository>("Common.SetLock").InstancePerLifetimeScope();
            builder.RegisterType<Bookstore.Repositories.BookGrid_Repository>().Keyed<IRepository>("Bookstore.BookGrid").InstancePerLifetimeScope();
            builder.RegisterType<Bookstore.Repositories.BookTopicsGrid_Repository>().Keyed<IRepository>("Bookstore.BookTopicsGrid").InstancePerLifetimeScope();
            builder.RegisterType<Common.Repositories.MyClaim_Repository>().Keyed<IRepository>("Common.MyClaim").InstancePerLifetimeScope();
            builder.RegisterType<Common.Repositories.Claim_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.ICommonClaim>>().InstancePerLifetimeScope();
            builder.RegisterType<Common.Repositories.FilterId_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.ICommonFilterId>>().InstancePerLifetimeScope();
            builder.RegisterType<Common.Repositories.KeepSynchronizedMetadata_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IKeepSynchronizedMetadata>>().InstancePerLifetimeScope();
            builder.RegisterType<Common.Repositories.Principal_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IPrincipal>>().InstancePerLifetimeScope();
            builder.RegisterType<Common.Repositories.PrincipalHasRole_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IPrincipalHasRole>>().InstancePerLifetimeScope();
            builder.RegisterType<Common.Repositories.PrincipalPermission_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IPrincipalPermission>>().InstancePerLifetimeScope();
            builder.RegisterType<Common.Repositories.Role_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IRole>>().InstancePerLifetimeScope();
            builder.RegisterType<Common.Repositories.RoleInheritsRole_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IRoleInheritsRole>>().InstancePerLifetimeScope();
            builder.RegisterType<Common.Repositories.RolePermission_Repository>().As<IQueryableRepository<Rhetos.Dom.DefaultConcepts.IRolePermission>>().InstancePerLifetimeScope();
            /*CommonAutofacConfigurationMembers*/

            base.Load(builder);
        }
    }

    public abstract class RepositoryBase : IRepository
    {
        protected Common.DomRepository _domRepository;
        protected Common.ExecutionContext _executionContext;

        /*RepositoryBaseMembers*/
    }

    public abstract class ReadableRepositoryBase<TEntity> : RepositoryBase, IReadableRepository<TEntity>
        where TEntity : class, IEntity
    {
        public IEnumerable<TEntity> Load(object parameter, Type parameterType)
        {
            var items = _executionContext.GenericRepository(typeof(TEntity).FullName)
                .Load(parameter, parameterType);
            return (IEnumerable<TEntity>)items;
        }

        public IEnumerable<TEntity> Read(object parameter, Type parameterType, bool preferQuery)
        {
            var items = _executionContext.GenericRepository(typeof(TEntity).FullName)
                .Read(parameter, parameterType, preferQuery);
            return (IEnumerable<TEntity>)items;
        }

        public abstract TEntity[] Load();

        [Obsolete("Use Load() or Query() method.")]
        public TEntity[] All()
        {
            return Load();
        }

        public TEntity[] Load(FilterAll filterAll)
        {
            return Load();
        }

        [Obsolete("Use Load(parameter) method instead.")]
        public TEntity[] Filter<T>(T parameter)
        {
            var items = Load(parameter, typeof(T));
            if (items is TEntity[] itemsArray)
                return itemsArray;
            else
                return items.ToArray();
        }

        /*ReadableRepositoryBaseMembers*/
    }

    public abstract class QueryableRepositoryBase<TQueryableEntity, TEntity> : ReadableRepositoryBase<TEntity>, IQueryableRepository<TQueryableEntity, TEntity>
        where TEntity : class, IEntity
        where TQueryableEntity : class, IEntity, TEntity, IQueryableEntity<TEntity>
    {
        public TEntity[] Load(IEnumerable<Guid> ids)
        {
            if (!(ids is System.Collections.IList))
                ids = ids.ToList();
            const int BufferSize = 500; // EF 6.1.3 LINQ query has O(n^2) time complexity. Batch size of 500 results with optimal total time on the test system.
            int n = ids.Count();
            var result = new List<TEntity>(n);
            for (int i = 0; i < (n + BufferSize - 1) / BufferSize; i++)
            {
                Guid[] idBuffer = ids.Skip(i * BufferSize).Take(BufferSize).ToArray();
                List<TEntity> itemBuffer;
                if (idBuffer.Length == 1) // EF 6.1.3. does not use parametrized SQL query for Contains() function. The equality comparer is used instead, to reuse cached execution plans.
                {
                    Guid id = idBuffer.Single();
                    itemBuffer = Query().Where(item => item.ID == id).GenericToSimple<TEntity>().ToList();
                }
                else if(!idBuffer.Any())
                {
                    itemBuffer = new List<TEntity>();  
                }
                else
                    itemBuffer = Query().WhereContains(idBuffer.ToList(), item => item.ID).GenericToSimple<TEntity>().ToList();
                result.AddRange(itemBuffer);
            }
            return result.ToArray();
        }

        public abstract IQueryable<TQueryableEntity> Query();

        // LINQ to Entity does not support Query() method in subqueries.
        public IQueryable<TQueryableEntity> Subquery { get { return Query(); } }

        public IQueryable<TQueryableEntity> Query(object parameter, Type parameterType)
        {
            var query = _executionContext.GenericRepository(typeof(TEntity).FullName).Query(parameter, parameterType);
            return (IQueryable<TQueryableEntity>)query;
        }

        public override TEntity[] Load()
        {
            return Query().GenericToSimple<TEntity>().ToArray();
        }

        /*QueryableRepositoryBaseMembers*/
    }

    public abstract class OrmRepositoryBase<TQueryableEntity, TEntity> : QueryableRepositoryBase<TQueryableEntity, TEntity>
        where TEntity : class, IEntity
        where TQueryableEntity : class, IEntity, TEntity, IQueryableEntity<TEntity>
    {
        public override IQueryable<TQueryableEntity> Query()
        {
            return _executionContext.EntityFrameworkContext.Set<TQueryableEntity>().AsNoTracking();
        }

        public IQueryable<TQueryableEntity> Filter(IQueryable<TQueryableEntity> query, IEnumerable<Guid> ids)
        {
            if (!(ids is System.Collections.IList))
                ids = ids.ToList();

            if (ids.Count() == 1) // EF 6.1.3. does not use parametrized SQL query for Contains() function. The equality comparer is used instead, to reuse cached execution plans.
            {
                Guid id = ids.Single();
                return query.Where(item => item.ID == id);
            }
            else if (!ids.Any())
            {
                return Array.Empty<TQueryableEntity>().AsQueryable();
            }
            else
            {
                // Depending on the ids count, this method will return the list of IDs, or insert the ids to the database and return an SQL query that selects the ids.
                var idsQuery = _domRepository.Common.FilterId.CreateQueryableFilterIds(ids);

                if (idsQuery is IList<Guid>)
                    return query.WhereContains(idsQuery.ToList(), item => item.ID);
                else
                    return query.Where(item => idsQuery.Contains(item.ID));
            }
        }

        /*OrmRepositoryBaseMembers*/
    }

    internal class DontTrackHistory<T> : List<T>
    {
    }
    /*CommonNamespaceMembers*/

    #pragma warning restore // See configuration setting CommonConcepts:CompilerWarningsInGeneratedCode.
}
