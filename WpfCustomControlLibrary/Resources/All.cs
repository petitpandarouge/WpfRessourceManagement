using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfCustomControlLibrary.Resources
{
    /// <summary>
    /// Class referencing all the resources used by this assembly.
    /// </summary>
    public class All
    {
        #region Fields

        /// <summary>
        /// Stores the unique instance of the singleton.
        /// </summary>
        private static All sInstance;

        /// <summary>
        /// Stores all the local resources 
        /// </summary>
        private ResourceDictionary mLocalResources;

        #endregion // Fields.
        
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="All"/> class.
        /// </summary>
        private All()
        {
        }

        #endregion // Constructors.

        #region Properties

        /// <summary>
        /// Gets the unique instance of the singleton.
        /// </summary>
        public static All Instance
        {
            get
            {
                if (All.sInstance == null)
                {
                    All.sInstance = new All();
                    All.Instance.LoadLocalResources();
                }

                return All.sInstance;
            }
        }

        #endregion // Properties.

        #region Methods

        /// <summary>
        /// Loads the local resources.
        /// </summary>
        private void LoadLocalResources()
        {
            this.mLocalResources = new ResourceDictionary();
            this.mLocalResources.MergedDictionaries.Add(new Brushes());
            this.mLocalResources.MergedDictionaries.Add(new Themes.Default());
        }

        /// <summary>
        /// Tries to find the resource identified by the given key in the loaded resources.
        /// </summary>
        /// <param name="pResourceKey">The resource key.</param>
        /// <returns>The resource if found, null otherwise.</returns>
        public object FindResource(object pResourceKey)
        {
            // Try to find a specific resource.
            object lResource = Application.Current.TryFindResource(pResourceKey);
            if (lResource != null)
            {
                return lResource;
            }

            // If not using the resources provided by the current library.
            return this.mLocalResources[pResourceKey];
        }

        #endregion // Methods.
    }
}
