using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_07 {

    public class ActionRequest {

        public Guid RequestID { get; set; } = Guid.NewGuid();
        public string? Input { get; set; }
        public ActionEnum Action { get; set; }

    }

}