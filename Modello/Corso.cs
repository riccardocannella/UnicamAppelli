using System;
using System.Collections.Generic;

namespace UnicamAppelli.Modello{

    public class Corso{

        public int IdCorso{
            get;
            private set;
            } 
        public String NomeCorso{
            get; 
            private set;
            }

         public List<Appello> Appelli{
             get;
             set;
         }
        public String Docente{
            get;
            set;
            }
    public Corso(String corso, String docente){
        this.NomeCorso = corso;
        this.Docente = docente;
    }

    private Corso(){

    }
    
    }
    
}