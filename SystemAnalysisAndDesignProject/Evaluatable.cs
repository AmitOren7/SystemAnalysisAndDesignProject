using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAnalysisAndDesignProject
{
    public interface Evaluatable
    {

        string GetName();
        string GetId();

        PerformanceStatus GetPerformanceStatus();

        bool GetAssociatedRole();

        void changeStatus(PerformanceStatus status);

        string GetEmail();

        void Archive();


    }
}
