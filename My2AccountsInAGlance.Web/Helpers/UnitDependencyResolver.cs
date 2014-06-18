using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Microsoft.Practices.Unity;
using System.Web.Mvc;

namespace My2AccountsInAGlance.Web.Helpers
{

    //I need to create this
    public class UnitDependencyResolver : IDependencyResolver
    {
        IUnityContainer _Container;
        public UnitDependencyResolver(IUnityContainer container)
        {
            _Container = container;

        }

        #region IDependencyResolver Members

        public object GetService(Type serviceType)
        {
            if (!_Container.IsRegistered(serviceType) && (serviceType.IsAbstract || serviceType.IsInterface))
                return null;

            return _Container.Resolve(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _Container.ResolveAll(serviceType);
        }

        #endregion
    }
}