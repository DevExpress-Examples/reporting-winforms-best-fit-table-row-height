using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dx_sample {
    public class TestData {
        public static List<TestData> CreateRows() {
            List<TestData> l = new List<TestData>();
            for (int i = 0; i < 50; i++) {
                if (i == 1)
                    l.Add(new TestData { ID = i, Value = "Begin.\n\n\n\n\n\n\n\n\n\n\nEnd." });
                else
                    l.Add(new TestData { ID = i, Value = "Begin. End." });
            }
            return l;
        }
        public int ID { get; set; }
        public string Value { get; set; }
    }
    public class DataContainer : List<TestData> {
    }
}
