using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Group07
{
    public interface IWritable
    {
        void Write(TextWriter writer);
    }
}
