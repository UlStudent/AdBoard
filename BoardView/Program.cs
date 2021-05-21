using System;
using System.Collections.Generic;
using System.Linq;
using Unity;
using System.Windows.Forms;
using BoardBusinessLogic.Interfaces;
using BoardImplement.Implements;
using BoardBusinessLogic.BusinessLogic;
using Unity.Lifetime;
using BoardDatabaseImplement.Implements;

namespace BoardView
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BuildUnityContainer();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(container.Resolve<FormMain>());
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<IAdStorage, AdStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IUsersStorage, UsersStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IFavoritesStorage, FavoritesStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IBalanceStorage, BalanceStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<IMessagesStorage, MessagesStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<AdLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<UsersLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<BalanceLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<FavoritesLogic>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<MessagesLogic>(new HierarchicalLifetimeManager());
            return currentContainer;
        }

    }
}
