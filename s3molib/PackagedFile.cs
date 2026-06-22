using System;
using System.Collections.Generic;
using System.Text;

namespace s3molib
{
    public class PackagedFile
    {
        public string Name { get; private set; }
        public void SetName(string name) => Name = name;

        public int Length { get; private set; }
        public void SetLength(int length) => Length = length;

        public long Offset { get; private set; }
        public void SetOffset(long offset) => Offset = offset;

        public PackagedFile()
        {

        }
    }
}
