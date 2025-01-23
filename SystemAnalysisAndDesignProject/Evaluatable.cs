using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAnalysisAndDesignProject
{
    public interface Evaluatable
    { //this interface references drivers and clerks only since they are the employees who are evaluated through the surveys.

        string GetName();
        string GetId();

        PerformanceStatus GetPerformanceStatus();

        bool GetAssociatedRole();

        void changeStatus(PerformanceStatus status);

        string GetEmail();

        void Archive();


    }
}
