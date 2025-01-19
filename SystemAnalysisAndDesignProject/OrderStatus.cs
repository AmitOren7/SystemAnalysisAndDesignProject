using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemAnalysisAndDesignProject
{
    public enum OrderStatus
    {
        pendingForAssignment,
        assigned,
        departure,
        arrivedToSite,
        taskCompleted,
        workCertificateSigned,
        orderClosed   
    }
}
