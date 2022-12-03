// note: decompiled from ZooKeeperNetEx source
// File generated by hadoop record compiler. Do not edit.

#pragma warning disable

using System.Collections.Generic;
using org.apache.jute;

namespace org.apache.zookeeper.proto
{
    internal class SetACLRequest : Record
    {
        private string path;
        private List<org.apache.zookeeper.data.ACL> acl;
        private int version;
        public SetACLRequest() { }
        public SetACLRequest(string path, List<org.apache.zookeeper.data.ACL> acl, int version)
        {
            this.path = path;
            this.acl = acl;
            this.version = version;
        }
        public string getPath() { return path; }
        internal void setPath(string m_) { path = m_; }

        public List<org.apache.zookeeper.data.ACL> getAcl() { return acl; }
        internal void setAcl(List<org.apache.zookeeper.data.ACL> m_) { acl = m_; }

        public int getVersion() { return version; }
        internal void setVersion(int m_) { version = m_; }

        void Record.serialize(OutputArchive a_, string tag)
        {
            a_.writeString(path, "path");
            {
                a_.startVector(acl, "acl");
                if (acl != null)
                {
                    foreach (var e1 in acl) a_.writeRecord(e1, "e1");
                }
            }
            a_.writeInt(version, "version");
        }
        void Record.deserialize(InputArchive a_, string tag)
        {
            path = a_.readString("path");
            {
                Index vidx1 = a_.startVector("acl");
                if (vidx1 != null)
                {
                    var tmpLst = new List<org.apache.zookeeper.data.ACL>();
                    for (; !vidx1.done(); vidx1.incr())
                    {
                        org.apache.zookeeper.data.ACL e1;
                        e1 = new org.apache.zookeeper.data.ACL();
                        a_.readRecord(e1, "e1");
                        tmpLst.Add(e1);
                    }
                    acl = tmpLst;
                }
            }
            version = a_.readInt("version");
        }
    }
}
