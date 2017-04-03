using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading
{
    public class ReaderWriterLock
    {
    }
}
/*
Begin Read
    Lock r.
    Increment b.
    Unlock r.

End Read
    Lock r.
    Decrement b.
    Unlock r.

Begin Write
    if(b==0)
    Lock g.
End Write
    Unlock g.

*/
