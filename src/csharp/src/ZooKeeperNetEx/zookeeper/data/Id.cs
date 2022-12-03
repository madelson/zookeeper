// note: decompiled from ZooKeeperNetEx source
#pragma warning disable CS1591

using System.Collections.Generic;
using org.apache.jute;

namespace org.apache.zookeeper.data
{
    public class Id : Record
    {
        private string scheme;
        private string id;
        public Id() { }
        public Id(string scheme, string id)
        {
            this.scheme = scheme;
            this.id = id;
        }
        public string getScheme() { return scheme; }
        internal void setScheme(string m_) { scheme = m_; }

        public string getId() { return id; }
        internal void setId(string m_) { id = m_; }

        void Record.serialize(OutputArchive a_, string tag)
        {
            a_.writeString(scheme, "scheme");
            a_.writeString(id, "id");
        }
        void Record.deserialize(InputArchive a_, string tag)
        {
            scheme = a_.readString("scheme");
            id = a_.readString("id");
        }
    }
}