// note: decompiled from ZooKeeperNetEx source
#pragma warning disable CS1591

using System.Collections.Generic;
using org.apache.jute;

namespace org.apache.zookeeper.data
{
    public class ACL : Record
    {
        private int perms;
        private org.apache.zookeeper.data.Id id;
        public ACL() { }
        public ACL(int perms, org.apache.zookeeper.data.Id id)
        {
            this.perms = perms;
            this.id = id;
        }
        public int getPerms() { return perms; }
        internal void setPerms(int m_) { perms = m_; }

        public org.apache.zookeeper.data.Id getId() { return id; }
        internal void setId(org.apache.zookeeper.data.Id m_) { id = m_; }

        void Record.serialize(OutputArchive a_, string tag)
        {
            a_.writeInt(perms, "perms");
            a_.writeRecord(id, "id");
        }
        void Record.deserialize(InputArchive a_, string tag)
        {
            perms = a_.readInt("perms");
            id = new org.apache.zookeeper.data.Id();
            a_.readRecord(id, "id");
        }
    }
}