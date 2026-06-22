using System;
using System.Collections.Generic;
using System.Text;

namespace s3molib
{
    public class ResourceConflictModel
    {
        public string ResourceKey { get; private set; }
        public string PackageName { get; private set; }
        public string OtherModName { get; private set; }
        public string OtherPackageName { get; private set; }

        public ResourceConflictModel(string resourceKey, string packageName, string otherModName, string otherPackageName)
        {
            ResourceKey = resourceKey;
            PackageName = packageName;
            OtherModName = otherModName;
            OtherPackageName = otherPackageName;
        }
    }
}
