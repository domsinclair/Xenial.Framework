﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.SystemModule;

using Xenial.Framework.Base;

namespace Xenial.Framework.SystemModule
{
    /// <summary>
    /// Class SingletonController.
    /// Implements the <see cref="DevExpress.ExpressApp.ViewController" />
    /// </summary>
    /// <seealso cref="DevExpress.ExpressApp.ViewController" />
    /// <autogeneratedoc />
    public sealed class XenialSingletonViewController : ViewController
    {
        private const string key = "IsSingleton";
        /// <summary>
        /// Called when [activated].
        /// </summary>
        /// <autogeneratedoc />
        protected override void OnActivated()
        {
            base.OnActivated();

            if (View.Model is IModelObjectView modelObjectView && modelObjectView.ModelClass.TypeInfo.IsAttributeDefined<SingletonAttribute>(true))
            {
                var newObjectViewController = Frame.GetController<NewObjectViewController>();
                if (newObjectViewController != null)
                {
                    newObjectViewController.NewObjectAction.Active[key] = false;
                }
                var deleteObjectViewController = Frame.GetController<DeleteObjectsViewController>();
                if (deleteObjectViewController != null)
                {
                    deleteObjectViewController.DeleteAction.Active[key] = false;
                }
                var modificationsController = Frame.GetController<ModificationsController>();
                if (modificationsController != null)
                {
                    modificationsController.SaveAndNewAction.Active[key] = false;
                }
            }
        }

        /// <summary>
        /// Called when [deactivated].
        /// </summary>
        /// <autogeneratedoc />
        protected override void OnDeactivated()
        {
            var newObjectViewController = Frame.GetController<NewObjectViewController>();
            if (newObjectViewController != null)
            {
                newObjectViewController.NewObjectAction.Active.RemoveItem(key);
            }
            var deleteObjectViewController = Frame.GetController<DeleteObjectsViewController>();
            if (deleteObjectViewController != null)
            {
                deleteObjectViewController.DeleteAction.Active.RemoveItem(key);
            }
            var modificationsController = Frame.GetController<ModificationsController>();
            if (modificationsController != null)
            {
                modificationsController.SaveAndNewAction.Active.RemoveItem(key);
            }

            base.OnDeactivated();
        }
    }
}

namespace DevExpress.ExpressApp
{
    /// <summary>
    /// Class SingletonControllerExtensions.
    /// </summary>
    /// <autogeneratedoc />
    public static class SingletonControllerExtensions
    {
        /// <summary>
        /// Uses the singleton controller.
        /// </summary>
        /// <param name="types">The types.</param>
        /// <returns>IEnumerable&lt;Type&gt;.</returns>
        /// <autogeneratedoc />
        public static IEnumerable<Type> UseXenialSingletonControllers(this IEnumerable<Type> types)
            => types.Concat(new[] { typeof(Xenial.Framework.SystemModule.XenialSingletonViewController) });
    }
}
