using System;
using System.Collections.Generic;
using System.Linq;
using Unity;
using System.Windows.Forms;
using BoardBusinessLogic.Interfaces;
using BoardImplement.Implements;
using BoardBusinessLogic.BusinessLogic;
using Unity.Lifetime;

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
            Application.Run(container.Resolve<FormUsers>());
        }
        private static IUnityContainer BuildUnityContainer()
        {
            var currentContainer = new UnityContainer();
            currentContainer.RegisterType<IUsersStorage, UsersStorage>(new HierarchicalLifetimeManager());
            //currentContainer.RegisterType<IOrderStorage, OrderStorage>(new HierarchicalLifetimeManager());
            currentContainer.RegisterType<UsersLogic>(new HierarchicalLifetimeManager());
            // currentContainer.RegisterType<MailLogic>(new HierarchicalLifetimeManager());
            return currentContainer;
        }

    }
}
