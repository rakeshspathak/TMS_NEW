using System;
using TMS.Business.Interface.Logger;
using TMS.Dependency.Business.Business.Logger;
using TMS.Dependency.Business.Data.Error;
using TMS.Dependency.Data.Employees;
using TMS.Dependency.Data.Menus;
using TMS.Repository.Interface.Employees;
using TMS.Repository.Interface.ErrorRepository;
using TMS.Repository.Interface.Menus;
using TMS.Repository.Interface.RoleRepository;
using TMS.Dependency.Business.Data.Role;
using Unity;

namespace TMS.Client.Mvc
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container =
          new Lazy<IUnityContainer>(() =>
          {
              var container = new UnityContainer();
              RegisterTypes(container);
              return container;
          });

        /// <summary>
        /// Configured Unity Container.
        /// </summary>
        public static IUnityContainer Container => container.Value;
        #endregion

        /// <summary>
        /// Registers the type mappings with the Unity container.
        /// </summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>
        /// There is no need to register concrete types such as controllers or
        /// API controllers (unless you want to change the defaults), as Unity
        /// allows resolving a concrete type even if it was not previously
        /// registered.
        /// </remarks>
        public static void RegisterTypes(IUnityContainer container)
        {
            // NOTE: To load from web.config uncomment the line below.
            // Make sure to add a Unity.Configuration to the using statements.
            // container.LoadConfiguration();

            // TODO: Register your type's mappings here.
            // container.RegisterType<IProductRepository, ProductRepository>();
            container.RegisterType<IEmployeeRepository, EmployeeRepository>();
            //container.RegisterType<IRepository<TEntity>, Repository<>>();
            //container.RegisterType<IUnitOfWork, UnitOfWork>();
            //container.RegisterType<IRepository<Employee>, Repository<Employee>>();
            container.RegisterType<IMenuAccessRepository, MenuAccessRepository>();
            container.RegisterType<ILogger, Logger>();
            container.RegisterType<IErrorRepository, ErrorRepository>();
            container.RegisterType<IRoleRepository, RoleRepository>();


        }
    }
}