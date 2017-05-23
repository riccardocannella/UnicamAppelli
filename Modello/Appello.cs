using System;
using System.ComponentModel.DataAnnotations;

namespace UnicamAppelli.Modello{
    public class Appello{
        public Corso Corso{
            get;
            set;
        }

        public DateTime DataAppello{
            get;
            set;
        }
        public int IdAppello{
            get;
            private set;
        }
    }
}