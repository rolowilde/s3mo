namespace s3molib;

public class ResourceConflictModel(
    string resourceKey,
    string packageName,
    string otherModName,
    string otherPackageName
)
{
    public string ResourceKey { get; private set; } = resourceKey;
    public string PackageName { get; private set; } = packageName;
    public string OtherModName { get; private set; } = otherModName;
    public string OtherPackageName { get; private set; } = otherPackageName;
}
