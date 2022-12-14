using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cseveges {
    internal class Beszelgetes {
        public DateTime begin;
        public DateTime end;
        public string callerName;
        public string calledName;

        public Beszelgetes(string line)
        {
            string[] data = line.Split(';');
            begin = DateTime.Parse( 20 + data[0].Replace("-", " "));
            end = DateTime.Parse(20 + data[1].Replace("-", " "));

            callerName = data[2];
            calledName = data[3];
        }

    }
}