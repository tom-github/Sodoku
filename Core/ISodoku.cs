using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public interface ISodoku
    {
         int Generate();
        ArrayList Set(int n, ArrayList arrayList);

        void Print(ArrayList arrayList);
    }
}
