// note: decompiled from ZooKeeperNetEx source
#pragma warning disable CS1591

using System.Collections.Generic;
using org.apache.jute;

namespace org.apache.zookeeper.data
{
    public class Stat : Record
    {
        private long czxid;
        private long mzxid;
        private long ctime;
        private long mtime;
        private int version;
        private int cversion;
        private int aversion;
        private long ephemeralOwner;
        private int dataLength;
        private int numChildren;
        private long pzxid;
        public Stat() { }
        public Stat(long czxid, long mzxid, long ctime, long mtime, int version, int cversion, int aversion, long ephemeralOwner, int dataLength, int numChildren, long pzxid)
        {
            this.czxid = czxid;
            this.mzxid = mzxid;
            this.ctime = ctime;
            this.mtime = mtime;
            this.version = version;
            this.cversion = cversion;
            this.aversion = aversion;
            this.ephemeralOwner = ephemeralOwner;
            this.dataLength = dataLength;
            this.numChildren = numChildren;
            this.pzxid = pzxid;
        }
        public long getCzxid() { return czxid; }
        internal void setCzxid(long m_) { czxid = m_; }

        public long getMzxid() { return mzxid; }
        internal void setMzxid(long m_) { mzxid = m_; }

        public long getCtime() { return ctime; }
        internal void setCtime(long m_) { ctime = m_; }

        public long getMtime() { return mtime; }
        internal void setMtime(long m_) { mtime = m_; }

        public int getVersion() { return version; }
        internal void setVersion(int m_) { version = m_; }

        public int getCversion() { return cversion; }
        internal void setCversion(int m_) { cversion = m_; }

        public int getAversion() { return aversion; }
        internal void setAversion(int m_) { aversion = m_; }

        public long getEphemeralOwner() { return ephemeralOwner; }
        internal void setEphemeralOwner(long m_) { ephemeralOwner = m_; }

        public int getDataLength() { return dataLength; }
        internal void setDataLength(int m_) { dataLength = m_; }

        public int getNumChildren() { return numChildren; }
        internal void setNumChildren(int m_) { numChildren = m_; }

        public long getPzxid() { return pzxid; }
        internal void setPzxid(long m_) { pzxid = m_; }

        void Record.serialize(OutputArchive a_, string tag)
        {
            a_.writeLong(czxid, "czxid");
            a_.writeLong(mzxid, "mzxid");
            a_.writeLong(ctime, "ctime");
            a_.writeLong(mtime, "mtime");
            a_.writeInt(version, "version");
            a_.writeInt(cversion, "cversion");
            a_.writeInt(aversion, "aversion");
            a_.writeLong(ephemeralOwner, "ephemeralOwner");
            a_.writeInt(dataLength, "dataLength");
            a_.writeInt(numChildren, "numChildren");
            a_.writeLong(pzxid, "pzxid");
        }
        void Record.deserialize(InputArchive a_, string tag)
        {
            czxid = a_.readLong("czxid");
            mzxid = a_.readLong("mzxid");
            ctime = a_.readLong("ctime");
            mtime = a_.readLong("mtime");
            version = a_.readInt("version");
            cversion = a_.readInt("cversion");
            aversion = a_.readInt("aversion");
            ephemeralOwner = a_.readLong("ephemeralOwner");
            dataLength = a_.readInt("dataLength");
            numChildren = a_.readInt("numChildren");
            pzxid = a_.readLong("pzxid");
        }
    }
}