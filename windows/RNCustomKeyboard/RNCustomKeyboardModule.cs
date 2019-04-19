using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Custom.Keyboard.RNCustomKeyboard
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNCustomKeyboardModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNCustomKeyboardModule"/>.
        /// </summary>
        internal RNCustomKeyboardModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNCustomKeyboard";
            }
        }
    }
}
