using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAnalysisAndDesignProject
{
    public interface Evaluatable
    {
        string GetId();
        bool GetAssociatedRole();

        string GetName();
    }
}
