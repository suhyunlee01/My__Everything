using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My__Everything
{
    public class Weather
    {
        // json 파일로 받아온 데이터들 중 {}로 이루어 진 것이 class가 될 것이고 안에 있는 것들이 모두 속성데이터들이 될 것임. 

        public class coord
        {
            public double lon { get; set; }
            public double lat { get; set; }
        }
        public class weather
        {
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
        }
        public class main
        {
            public double temp { get; set; }
            public double humidity { get; set; }
        }
        public class wind
        {
            public double speed { get; set; }
        }
        public class sys
        {
            public long sunrise { get; set; }
            public long sunset { get; set; }
        }

        //모든 클래스를 담고있는 클래스 생성 //JSON 데이터의 처음과 끝 {}을 하나의 root 클래스로 만들었음.
        public class root
        {
            public coord coord { get; set; }
            public List<weather> weather { get; set; } //weather은 json파일에서 [0]으로 분류
            public main main { get; set; }
            public wind wind { get; set; }
            public sys sys { get; set; }
        }
    }
}
