﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;

using Xenial.Framework.Model.Core;
using Xenial.Framework.TokenEditors.Model;
using Xenial.Framework.TokenEditors.PubTernal;

namespace Xenial.Framework.TokenEditors.Model
{
    /// <summary>
    /// Interface IXenialTokenStringModelMember
    /// </summary>
    /// <autogeneratedoc />
    public interface IXenialTokenStringModelMember
    {
        /// <summary>
        /// Gets or sets the token drop down show mode.
        /// This value has only an effect in WindowsForms
        /// </summary>
        /// <value>The token drop down show mode.</value>
        /// <autogeneratedoc />
        [ModelBrowsable(typeof(XenialTokenStringEditorTypeVisibilityCalculator))]
        [Category(TokenEditorAliases.TokenStringPropertyEditor)]
        [ModelPersistentName(TokenEditorAliases.TokenStringPropertyEditor + "." + nameof(XenialTokenStringDropDownShowMode))]
        [Description("Gets or sets the token drop down show mode.\r\nThis value has only an effect in WindowsForms")]
        [DisplayName("DropDownShowMode")]
        TokenDropDownShowMode? XenialTokenStringDropDownShowMode { get; set; }

        /// <summary>
        /// Gets or sets the token popup filter mode.
        /// </summary>
        /// <value>The token popup filter mode.</value>
        /// <autogeneratedoc />
        [ModelBrowsable(typeof(XenialTokenStringEditorTypeVisibilityCalculator))]
        [Category(TokenEditorAliases.TokenStringPropertyEditor)]
        [ModelPersistentName(TokenEditorAliases.TokenStringPropertyEditor + "." + nameof(XenialTokenStringPopupFilterMode))]
        [Description("Gets or sets the token popup filter mode.")]
        [DisplayName("PopupFilterMode")]
        TokenPopupFilterMode? XenialTokenStringPopupFilterMode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [xenial token string allow user defined tokens].
        /// </summary>
        /// <value><c>null</c> if [xenial token string allow user defined tokens] contains no value, <c>true</c> if [xenial token string allow user defined tokens]; otherwise, <c>false</c>.</value>
        /// <autogeneratedoc />
        [ModelBrowsable(typeof(XenialTokenStringEditorTypeVisibilityCalculator))]
        [Category(TokenEditorAliases.TokenStringPropertyEditor)]
        [ModelPersistentName(TokenEditorAliases.TokenStringPropertyEditor + "." + nameof(XenialTokenStringAllowUserDefinedTokens))]
        [Description("Gets or sets if the user is able to define custom tokens.")]
        [DisplayName("AllowUserDefinedTokens")]
        bool? XenialTokenStringAllowUserDefinedTokens { get; set; }
    }

    /// <summary>
    /// Interface IXenialTokenStringModelPropertyEditor
    /// </summary>
    /// <autogeneratedoc />
    public interface IXenialTokenStringModelPropertyEditor
    {
        /// <summary>
        /// Gets or sets the token drop down show mode.
        /// This value has only an effect in WindowsForms
        /// </summary>
        /// <value>The token drop down show mode.</value>
        /// <autogeneratedoc />
        [ModelValueCalculator(nameof(IModelPropertyEditor.ModelMember), typeof(IXenialTokenStringModelMember), nameof(IXenialTokenStringModelMember.XenialTokenStringDropDownShowMode))]
        [ModelBrowsable(typeof(XenialTokenStringEditorTypeVisibilityCalculator))]
        [Category(TokenEditorAliases.TokenStringPropertyEditor)]
        [ModelPersistentName(TokenEditorAliases.TokenStringPropertyEditor + "." + nameof(XenialTokenStringDropDownShowMode))]
        [Description("Gets or sets the token drop down show mode.\r\nThis value has only an effect in WindowsForms")]
        [DisplayName("DropDownShowMode")]
        TokenDropDownShowMode? XenialTokenStringDropDownShowMode { get; set; }

        /// <summary>
        /// Gets or sets the token popup filter mode.
        /// </summary>
        /// <value>The token popup filter mode.</value>
        /// <autogeneratedoc />
        [ModelValueCalculator(nameof(IModelPropertyEditor.ModelMember), typeof(IXenialTokenStringModelMember), nameof(IXenialTokenStringModelMember.XenialTokenStringPopupFilterMode))]
        [ModelBrowsable(typeof(XenialTokenStringEditorTypeVisibilityCalculator))]
        [Category(TokenEditorAliases.TokenStringPropertyEditor)]
        [ModelPersistentName(TokenEditorAliases.TokenStringPropertyEditor + "." + nameof(XenialTokenStringPopupFilterMode))]
        [Description("Gets or sets the token popup filter mode.")]
        [DisplayName("PopupFilterMode")]
        TokenPopupFilterMode? XenialTokenStringPopupFilterMode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [xenial token string allow user defined tokens].
        /// </summary>
        /// <value><c>null</c> if [xenial token string allow user defined tokens] contains no value, <c>true</c> if [xenial token string allow user defined tokens]; otherwise, <c>false</c>.</value>
        /// <autogeneratedoc />
        [ModelValueCalculator(nameof(IModelPropertyEditor.ModelMember), typeof(IXenialTokenStringModelMember), nameof(IXenialTokenStringModelMember.XenialTokenStringAllowUserDefinedTokens))]
        [ModelBrowsable(typeof(XenialTokenStringEditorTypeVisibilityCalculator))]
        [Category(TokenEditorAliases.TokenStringPropertyEditor)]
        [ModelPersistentName(TokenEditorAliases.TokenStringPropertyEditor + "." + nameof(XenialTokenStringAllowUserDefinedTokens))]
        [Description("Gets or sets if the user is able to define custom tokens.")]
        [DisplayName("AllowUserDefinedTokens")]
        bool? XenialTokenStringAllowUserDefinedTokens { get; set; }
    }

    /// <summary>
    /// Class TokenStringEditorTypeVisibilityCalculator. This class cannot be inherited.
    /// Implements the <see cref="Xenial.Framework.Model.Core.EditorTypeVisibilityCalculator" />
    /// </summary>
    /// <seealso cref="Xenial.Framework.Model.Core.EditorTypeVisibilityCalculator" />
    /// <autogeneratedoc />
    public sealed class XenialTokenStringEditorTypeVisibilityCalculator : EditorTypeAliasVisibilityCalculator
    {
        /// <summary>
        /// Gets the name of the editor alias.
        /// </summary>
        /// <value>The name of the editor alias.</value>
        /// <autogeneratedoc />
        protected override string EditorAliasName => TokenEditorAliases.TokenStringPropertyEditor;
    }

#pragma warning disable CA1707 //Convention by XAF

    /// <summary>
    /// Class TokenStringModelMemberDomainLogic.
    /// </summary>
    /// <autogeneratedoc />
    [DomainLogic(typeof(IXenialTokenStringModelMember))]
    public static class XenialTokenStringModelMemberDomainLogic
    {
        /// <summary>
        /// Gets the token drop down show mode.
        /// </summary>
        /// <param name="modelMember">The model member.</param>
        /// <returns>DevExpress.Persistent.Base.TokenDropDownShowMode?.</returns>
        /// <autogeneratedoc />
        public static TokenDropDownShowMode? Get_XenialTokenStringDropDownShowMode(IModelMember modelMember)
        {
            _ = modelMember ?? throw new ArgumentNullException(nameof(modelMember));
            var attribute = modelMember.MemberInfo.FindAttribute<TokenStringEditorAttribute>();
            if (attribute is not null)
            {
                return attribute.DropDownShowMode;
            }
            return null;
        }

        /// <summary>
        /// Gets the token popup filter mode.
        /// </summary>
        /// <param name="modelMember">The model member.</param>
        /// <returns>DevExpress.Persistent.Base.TokenPopupFilterMode?.</returns>
        /// <autogeneratedoc />
        public static TokenPopupFilterMode? Get_XenialTokenStringPopupFilterMode(IModelMember modelMember)
        {
            _ = modelMember ?? throw new ArgumentNullException(nameof(modelMember));
            var attribute = modelMember.MemberInfo.FindAttribute<TokenStringEditorAttribute>();
            if (attribute is not null)
            {
                return attribute.PopupFilterMode;
            }
            return null;
        }

        /// <summary>
        /// Gets the xenial token string allow user defined tokens.
        /// </summary>
        /// <param name="modelMember">The model member.</param>
        /// <returns>bool?.</returns>
        /// <autogeneratedoc />
        public static bool? Get_XenialTokenStringAllowUserDefinedTokens(IModelMember modelMember)
        {
            _ = modelMember ?? throw new ArgumentNullException(nameof(modelMember));
            var attribute = modelMember.MemberInfo.FindAttribute<TokenStringEditorAttribute>();
            if (attribute is not null)
            {
                return attribute.AllowUserDefinedTokens;
            }
            return null;
        }
    }
#pragma warning restore CA1707
}

namespace DevExpress.ExpressApp.Model
{
    /// <summary>
    /// Class ModelInterfaceExtendersLayoutBuilderExtensions.
    /// </summary>
    /// <autogeneratedoc />
    public static partial class ModelInterfaceExtendersTokenEditorsExtensions
    {
        /// <summary>
        /// Uses the token string property editors.
        /// </summary>
        /// <param name="extenders">The extenders.</param>
        /// <returns>DevExpress.ExpressApp.Model.ModelInterfaceExtenders.</returns>
        /// <autogeneratedoc />
        public static ModelInterfaceExtenders UseTokenStringPropertyEditors(this ModelInterfaceExtenders extenders)
        {
            _ = extenders ?? throw new ArgumentNullException(nameof(extenders));

            extenders.Add<IModelMember, IXenialTokenStringModelMember>();
            extenders.Add<IModelPropertyEditor, IXenialTokenStringModelPropertyEditor>();

            return extenders;
        }
    }
}

namespace DevExpress.ExpressApp.Model
{
    /// <summary>
    /// Class XenialTokenEditorsModelTypeList.
    /// </summary>
    /// <autogeneratedoc />
    public static partial class XenialTokenEditorsModelTypeList
    {
        /// <summary>
        /// Uses the token string editor regular types.
        /// </summary>
        /// <param name="types">The types.</param>
        /// <returns>IEnumerable&lt;Type&gt;.</returns>
        /// <autogeneratedoc />
        public static IEnumerable<Type> UseTokenStringEditorRegularTypes(this IEnumerable<Type> types)
            => types.Concat(new[]
            {
                typeof(IXenialTokenStringModelMember),
                typeof(IXenialTokenStringModelPropertyEditor),
                typeof(XenialTokenStringModelMemberDomainLogic),
                typeof(XenialTokenStringEditorTypeVisibilityCalculator)
            });
    }
}