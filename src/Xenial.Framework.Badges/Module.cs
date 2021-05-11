﻿using System;
using System.Collections.Generic;

using DevExpress.ExpressApp.Model;

namespace Xenial.Framework.Badges
{
    /// <summary>
    /// Class XenialBadgesModule.
    /// Implements the <see cref="Xenial.Framework.XenialModuleBase" />
    /// </summary>
    /// <seealso cref="Xenial.Framework.XenialModuleBase" />
    /// <autogeneratedoc />
    public class XenialBadgesModule : XenialModuleBase
    {
        /// <summary>
        /// returns empty types
        /// </summary>
        /// <returns>IEnumerable&lt;Type&gt;.</returns>
        /// <autogeneratedoc />
        protected override IEnumerable<Type> GetDeclaredExportedTypes()
            => base.GetDeclaredExportedTypes()
                .UseXenialBadgesRegularTypes();

        /// <summary>
        /// Extends the Application Model.
        /// </summary>
        /// <param name="extenders">A ModelInterfaceExtenders object that is a collection of Application Model interface extenders.</param>
        /// <autogeneratedoc />
        public override void ExtendModelInterfaces(ModelInterfaceExtenders extenders)
        {
            base.ExtendModelInterfaces(extenders);
            extenders.UseNavigationItemBadges();
        }
    }
}
