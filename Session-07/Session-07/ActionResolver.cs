using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Session_07 {

    public class ActionResolver : ActionResponse {

        public MessageLogger Logger { get; set; }

        public ActionResolver() {}

        public ActionResponse Execute(ActionRequest request) {
            return null;
        }

    }

}
