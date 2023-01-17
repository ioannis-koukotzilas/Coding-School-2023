using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Session_07 {

    public class ActionResponse : ActionRequest {

        public Guid ResponseID { get; set; } = Guid.NewGuid();
        public string? Output { get; set; }

        public ActionResponse() { }


        public virtual string? GetString(string Input) {

            // Do default

            return null;

        }

    }

    public class Convert : ActionResponse {

        public override string? GetString(string Input) {

            // Do Convert

            return null;
        }

    }

    public class Uppercase : ActionResponse {

        public override string? GetString(string Input) {

            // Do Uppercase

            return null;
        }

    }

    public class Reverse : ActionResponse {

        public override string? GetString(string Input) {

            // Do Reverse

            return null;
        }

    }

}
