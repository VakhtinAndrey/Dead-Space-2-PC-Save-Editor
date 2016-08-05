using System.Collections.Generic;
using System.IO;

namespace DeadSpace2SaveEditor.Models
{
    public interface IEntityContainer<T>
    {
        int ItemSize { get; }

        List<T> Items { get; set; }
    }

    public interface IDataBlock
    {
        ushort GetDataSize();

        void ReadData(MemoryStream stream);

        bool WriteData(MemoryStream stream);
    }
}
