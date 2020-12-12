﻿using System;

using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Win;
using DevExpress.ExpressApp.Win.Editors;
using DevExpress.Xpo.DB.Helpers;

using Xenial.Framework.WebView.Win.Editors;

namespace Xenial.Framework.WebView.Win.Editors
{
    /// <summary>
    /// Class WebViewUriPropertyEditor.
    /// Implements the <see cref="DevExpress.ExpressApp.Win.Editors.WinPropertyEditor" />
    /// </summary>
    /// <seealso cref="DevExpress.ExpressApp.Win.Editors.WinPropertyEditor" />
    /// <autogeneratedoc />
    public class WebViewUriPropertyEditor : WinPropertyEditor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebViewUriPropertyEditor"/> class.
        /// </summary>
        /// <param name="objectType">Type of the object.</param>
        /// <param name="model">The model.</param>
        /// <autogeneratedoc />
        public WebViewUriPropertyEditor(Type objectType, IModelMemberViewItem model) : base(objectType, model)

        {
            ControlBindingProperty = nameof(Control.Source);
            ControlCreated -= WebViewUriPropertyEditor_ControlCreated;
            ControlCreated += WebViewUriPropertyEditor_ControlCreated;
        }

        private async void WebViewUriPropertyEditor_ControlCreated(object sender, EventArgs e)
        {
            ControlCreated -= WebViewUriPropertyEditor_ControlCreated;
            try
            {
                await Control.EnsureCoreWebView2Async();
            }
            catch (Exception ex)
            {
                WinApplication.Messaging.ShowException(ex.ToString());
            }
        }

        /// <summary>
        /// Creates the control core.
        /// </summary>
        /// <returns>System.Object.</returns>
        /// <autogeneratedoc />
        protected override object CreateControlCore() => new Microsoft.Web.WebView2.WinForms.WebView2()
        {
            Source = new Uri("https://www.xenial.io")
        };

        /// <summary>
        /// Provides access to the control that represents the current Property Editor in a UI.
        /// </summary>
        /// <value>A <see cref="T:System.Windows.Forms.Control" /> object used to display the current Property Editor in a UI.</value>
        /// <autogeneratedoc />
        public new Microsoft.Web.WebView2.WinForms.WebView2 Control => (Microsoft.Web.WebView2.WinForms.WebView2)base.Control;
    }
}

namespace DevExpress.ExpressApp.Editors
{
    /// <summary>
    /// Class WebViewUriPropertyEditorExtensions.
    /// </summary>
    /// <autogeneratedoc />
    public static class WebViewUriPropertyEditorExtensions
    {
        /// <summary>
        /// Uses the web view URI property editor.
        /// </summary>
        /// <param name="editorDescriptorsFactory">The editor descriptors factory.</param>
        /// <returns>EditorDescriptorsFactory.</returns>
        /// <exception cref="ArgumentNullException">editorDescriptorsFactory</exception>
        /// <autogeneratedoc />
        public static EditorDescriptorsFactory UseWebViewUriPropertyEditor(this EditorDescriptorsFactory editorDescriptorsFactory)
        {
            _ = editorDescriptorsFactory ?? throw new ArgumentNullException(nameof(editorDescriptorsFactory));
            editorDescriptorsFactory.RegisterPropertyEditorAlias("WebViewUriPropertyEditor", typeof(Uri), true);
            editorDescriptorsFactory.RegisterPropertyEditor(typeof(Uri), typeof(WebViewUriPropertyEditor), false);
            return editorDescriptorsFactory;
        }
    }
}
