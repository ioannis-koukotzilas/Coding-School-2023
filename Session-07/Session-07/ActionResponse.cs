using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Session_07 {

    public class ActionResponse : ActionEntity {

        // PROPERTIES
        
        public Guid ResponseID { get; set; }
        public string? Output { get; set; }

        // CTOR
        public ActionResponse() {
            ResponseID = Guid.NewGuid();
        }

    }

}