﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.SystemModule;

using Xenial.Framework.Badges.Model;

namespace Xenial.Framework.Badges.Model
{
    /// <summary>
    /// Interface IXenialModelBadgeStaticTextItem
    /// </summary>
    /// <autogeneratedoc />
    public interface IXenialModelBadgeStaticTextItem
    {
        /// <summary>
        /// Gets or sets the xenial badge static text.
        /// </summary>
        /// <value>The xenial badge static text.</value>
        /// <autogeneratedoc />
        [Category("Xenial.Badges")]
        [ModelPersistentName("Xenial.Badges." + nameof(XenialBadgeStaticText))]
        [Description("Gets or sets a static text badge on the item")]
        [DisplayName("StaticText")]
        [Localizable(true)]
        string? XenialBadgeStaticText { get; set; }

        /// <summary>
        /// Gets or sets the xenial badge static paint style.
        /// </summary>
        /// <value>The xenial badge static paint style.</value>
        /// <autogeneratedoc />
        [Category("Xenial.Badges")]
        [ModelPersistentName("Xenial.Badges." + nameof(XenialBadgeStaticPaintStyle))]
        [Description("Gets or sets a static text badge paint style on the item")]
        [DisplayName("PaintStyle")]
        XenialStaticBadgePaintStyle? XenialBadgeStaticPaintStyle { get; set; }
    }

    /// <summary>
    /// Enum XenialStaticBadgePaintStyle
    /// </summary>
    public enum XenialStaticBadgePaintStyle
    {
        /// <summary>
        /// The default
        /// </summary>
        /// <autogeneratedoc />
        Default = 0,
        /// <summary>
        /// The critical
        /// </summary>
        /// <autogeneratedoc />
        Critical = 1,
        /// <summary>
        /// The information
        /// </summary>
        /// <autogeneratedoc />
        Information = 2,
        /// <summary>
        /// The warning
        /// </summary>
        /// <autogeneratedoc />
        Warning = 3,
        /// <summary>
        /// The question
        /// </summary>
        /// <autogeneratedoc />
        Question = 4,
        /// <summary>
        /// The system
        /// </summary>
        /// <autogeneratedoc />
        System = 5
    }
}

namespace DevExpress.ExpressApp.SystemModule
{
    /// <summary>
    /// Class IModelNavigationItemExtensions.
    /// </summary>
    /// <autogeneratedoc />
    public static partial class IModelNavigationItemExtensions
    {
        /// <summary>
        /// Sets the xenial static badge properties.
        /// </summary>
        /// <param name="modelNavigationItem">The model navigation item.</param>
        /// <param name="options">The options.</param>
        /// <returns>IModelNavigationItem.</returns>
        /// <exception cref="ArgumentNullException">modelNavigationItem</exception>
        /// <exception cref="ArgumentNullException">options</exception>
        /// <autogeneratedoc />
        public static IModelNavigationItem SetXenialStaticBadgeProperties(this IModelNavigationItem modelNavigationItem, Action<IXenialModelBadgeStaticTextItem> options)
        {
            _ = modelNavigationItem ?? throw new ArgumentNullException(nameof(modelNavigationItem));
            _ = options ?? throw new ArgumentNullException(nameof(options));
            if (modelNavigationItem is IXenialModelBadgeStaticTextItem modelBadgeStaticTextItem)
            {
                options(modelBadgeStaticTextItem);
            }
            return modelNavigationItem;
        }
    }
}

namespace DevExpress.ExpressApp.Model
{
    /// <summary>
    /// Class ModelInterfaceExtendersBadgesExtensions.
    /// </summary>
    /// <autogeneratedoc />
    public static partial class ModelInterfaceExtendersBadgesExtensions
    {
        /// <summary>
        /// Uses the navigation item badges.
        /// </summary>
        /// <param name="extenders">The extenders.</param>
        /// <returns>ModelInterfaceExtenders.</returns>
        /// <exception cref="ArgumentNullException">extenders</exception>
        /// <autogeneratedoc />
        public static ModelInterfaceExtenders UseNavigationItemBadges(this ModelInterfaceExtenders extenders)
        {
            _ = extenders ?? throw new ArgumentNullException(nameof(extenders));

            extenders.Add<IModelNavigationItem, IXenialModelBadgeStaticTextItem>();

            return extenders;
        }
    }
}

namespace DevExpress.ExpressApp.Model
{
    /// <summary>
    /// Class XenialBadgesModelTypeList.
    /// </summary>
    /// <autogeneratedoc />
    public static partial class XenialBadgesModelTypeList
    {
        /// <summary>
        /// Uses the badges regular types.
        /// </summary>
        /// <param name="types">The types.</param>
        /// <returns>IEnumerable&lt;Type&gt;.</returns>
        /// <autogeneratedoc />
        public static IEnumerable<Type> UseBadgesRegularTypes(this IEnumerable<Type> types)
            => types.Concat(new[]
            {
                typeof(IXenialModelBadgeStaticTextItem)
            });
    }
}