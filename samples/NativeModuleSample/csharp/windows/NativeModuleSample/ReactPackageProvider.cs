 // Copyright (c) Microsoft Corporation. All rights reserved.
 // Licensed under the MIT License.
 
using Microsoft.ReactNative;

namespace NativeModuleSample
{
    public partial class ReactPackageProvider : IReactPackageProvider
    {
        public void CreatePackage(IReactPackageBuilder packageBuilder)
        {
            CreatePackageImplementation(packageBuilder);
        }

        /// <summary>
        /// This method is implemented by the C# code generator
        /// </summary>
        partial void CreatePackageImplementation(IReactPackageBuilder packageBuilder);
    }
}
