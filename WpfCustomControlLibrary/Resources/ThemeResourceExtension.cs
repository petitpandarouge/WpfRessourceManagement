using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace WpfCustomControlLibrary.Resources
{
    public class ThemeResourceExtension : MarkupExtension
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ThemeResourceExtension"/> class.
        /// </summary>
        public ThemeResourceExtension()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThemeResourceExtension"/> class.
        /// </summary>
        /// <param name="pResourceKey">The resource key.</param>
        public ThemeResourceExtension(Keys pResourceKey)
        {
            this.ResourceKey = pResourceKey;
        }

        #endregion // Constructors.

        #region Properties

        /// <summary>
        /// Gets or sets the resource key.
        /// </summary>
        public Keys ResourceKey
        {
            get;
            set;
        }

        #endregion // Properties.

        #region Methods

        /// <summary>
        /// Provides the value created from the extension properties.
        /// </summary>
        /// <param name="pServiceProvider">The service provider.</param>
        /// <returns>The found resource.</returns>
        public override object ProvideValue(IServiceProvider pServiceProvider)
        {
            return All.Instance.FindResource(this.ResourceKey);
        }

        #endregion // Methods.
    }
}
