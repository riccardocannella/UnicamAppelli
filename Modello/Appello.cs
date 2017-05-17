using System;

namespace UnicamAppelli.Modello{
    public class Appello{
        public Corso Corso{
            get;
            set;
        }
        public string DataAppello{
            get;
            set;
        }
        public int IdAppello{
            get;
            private set;
        }
    }
}