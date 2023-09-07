using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My__Everything
{  // JSON 파일 이렇게 생김{"slip": { "id": 187, "advice": "The sun always shines above the clouds."}}
    internal class Quotes
    {
       public class slip
        {
            public string advice { get; set; }
        }

        public class root
        {
            public slip slip { get; set; }
        }
    }
}
