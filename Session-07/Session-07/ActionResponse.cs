using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {

    public class ActionResponse : ActionRequest {

        public Guid ResponseID { get; set; } = Guid.NewGuid();
        public string? Output { get; set; }

    }

}
