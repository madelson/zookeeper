// note: decompiled from ZooKeeperNetEx source
// File generated by hadoop record compiler. Do not edit.

#pragma warning disable

using System.Collections.Generic;
using org.apache.jute;

namespace org.apache.zookeeper.proto
{
    internal class ReplyHeader : Record
    {
        private int xid;
        private long zxid;
        private int err;
        public ReplyHeader() { }
        public ReplyHeader(int xid, long zxid, int err)
        {
            this.xid = xid;
            this.zxid = zxid;
            this.err = err;
        }
        public int getXid() { return xid; }
        internal void setXid(int m_) { xid = m_; }

        public long getZxid() { return zxid; }
        internal void setZxid(long m_) { zxid = m_; }

        public int getErr() { return err; }
        internal void setErr(int m_) { err = m_; }

        void Record.serialize(OutputArchive a_, string tag)
        {
            a_.writeInt(xid, "xid");
            a_.writeLong(zxid, "zxid");
            a_.writeInt(err, "err");
        }
        void Record.deserialize(InputArchive a_, string tag)
        {
            xid = a_.readInt("xid");
            zxid = a_.readLong("zxid");
            err = a_.readInt("err");
        }
    }
}
