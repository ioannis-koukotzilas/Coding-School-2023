using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Session_07 {

    public class ActionResponse {

        public Guid RequestID { get; set; }
        public Guid ResponseID { get; set; } = Guid.NewGuid();
        public string? Output { get; set; }

    }

}
