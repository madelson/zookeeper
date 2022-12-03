// note: decompiled from ZooKeeperNetEx source
// File generated by hadoop record compiler. Do not edit.

#pragma warning disable

using System.Collections.Generic;
using org.apache.jute;

namespace org.apache.zookeeper.proto
{
    internal class SetMaxChildrenRequest : Record
    {
        private string path;
        private int max;
        public SetMaxChildrenRequest() { }
        public SetMaxChildrenRequest(string path, int max)
        {
            this.path = path;
            this.max = max;
        }
        public string getPath() { return path; }
        internal void setPath(string m_) { path = m_; }

        public int getMax() { return max; }
        internal void setMax(int m_) { max = m_; }

        void Record.serialize(OutputArchive a_, string tag)
        {
            a_.writeString(path, "path");
            a_.writeInt(max, "max");
        }
        void Record.deserialize(InputArchive a_, string tag)
        {
            path = a_.readString("path");
            max = a_.readInt("max");
        }
    }
}
