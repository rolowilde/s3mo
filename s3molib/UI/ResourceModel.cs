using System;
using System.Collections.Generic;
using System.Text;

namespace s3molib
{
    public class ResourceModel
    {
        public ResourceEntry ResourceEntry { get; private set; }
        public string ResourceKey { get; private set; }
        public string Tag { get; private set; }
        public string Type { get; private set; }
        public string Group { get; private set; }
        public string ChunkOffset { get; private set; }
        public string Instance { get; private set; }
        public byte[] Data { get; private set; }

        public ResourceModel(ResourceEntry resourceEntry)
        {
            ResourceEntry = resourceEntry;
            Type = Helper.UInt32ToHexString(resourceEntry.Type);
            Group = Helper.UInt32ToHexString(resourceEntry.Group);
            Instance = Helper.UInt64ToHexString(resourceEntry.Instance);
            ChunkOffset = Helper.UInt32ToHexString(resourceEntry.ChunkOffset);
            ResourceKey = $"{Type}-{Group}-{Instance}-{ChunkOffset}";
            Tag = Helper.TagList.TryGetValue(Type, out string t) ? t : string.Empty;
        }

        public void SetData(byte[] data) => Data = data;
    }
}
