using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Zensurrechner_Console
{
    public class Class
    {
        public string Name { get; set; }
        public int anzahlAnNoten { get; set; } 
        public int g1anz { get; set; }
        public int g2anz {  get; set; }
        public int g3anz { get; set; }
        public int g4anz { get; set; }
        public int g5anz { get; set; }
        public int g6anz { get; set; }
        public int CountOfStudent { get; set; }

        public Class()
        {
            this.Name = "";
            this.anzahlAnNoten = 0;
            this.g1anz = 0;
            this.g2anz = 0;
            this.g3anz = 0;
            this.g4anz = 0;
            this.g5anz = 0;
            this.g6anz = 0;
            this.CountOfStudent = 0;
        }
        public void CreateClass(string name,   int CountOfStudent)
        {
            this.Name = name;
            this.CountOfStudent = CountOfStudent;
        }
        public void AddStudentToClass(string studentname, string classname)
        {

        }
        public void AddGrandToClas(string Name, int anzahlannoten, int g1anz, int g2anz, int g3anz, int g4anz, int g5anz, int g6anz)
        {
            this.Name = Name;
            this.anzahlAnNoten = anzahlannoten;
            this.g1anz = g1anz;
            this.g2anz = g2anz;
            this.g3anz = g3anz;
            this.g4anz = g4anz;
            this.g5anz = g5anz;
            this.g6anz = g6anz;
        }
    }
}
