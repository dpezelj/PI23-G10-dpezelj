using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvaluationManagerG10.Models {
    public abstract class Person  : Object {
        public int Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set;}
        public override string ToString() {
            return First_Name + " " + Last_Name;
        }
    } //public abstract class Person
}
