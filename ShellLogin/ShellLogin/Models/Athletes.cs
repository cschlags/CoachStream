using System;
using System.Collections.Generic;
using System.Text;

namespace ShellLogin.Models
{
    class Athletes
    {
        public static IEnumerable<Athlete> Get()
        {
            return new List<Athlete>
            {
              new Athlete() {Id="1", Name="Mike Tyson", Date="07/29/2020"},
              new Athlete() {Id="2", Name="Tebow", Date="07/28/2020"},
              new Athlete() {Id="3", Name="Rick Astley", Date="07/15/2020"},
              new Athlete() {Id="4", Name="Michael Phelps", Date="07/14/2020"},
              new Athlete() {Id="5", Name="Anne Gables", Date="07/14/2020"},
              new Athlete() {Id="6", Name="Bob Roberts", Date="07/14/2020"},
              new Athlete() {Id="7", Name="John Johnston", Date="07/13/2020"},
              new Athlete() {Id="8", Name="Tom Timtam", Date="07/12/2020"},
            };
        }
    }
}
