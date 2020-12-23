using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Rnweb.Test.Components.RNRnwebTestComponents
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNRnwebTestComponentsModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNRnwebTestComponentsModule"/>.
        /// </summary>
        internal RNRnwebTestComponentsModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNRnwebTestComponents";
            }
        }
    }
}
