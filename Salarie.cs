using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Gestion_des_Salaries
{
    [Serializable]
    class Salarie
    {
        //Attributs
        int matr;
        string nom;
        string situ_famil;
        int echelle;
        DateTime date_afct;
        int cpt;

        //Properties
        public int Matr          { get { return matr;       } set { matr = value;      } }
        public string Nom        { get { return nom;        } set { nom = value;       } }
        public string Situ_famil { get { return situ_famil; } set { situ_famil = value;} }
        public int Echelle       { get { return echelle;    } set { echelle = value;   } }
        public DateTime Date_afct{ get { return date_afct;  } set { date_afct = value; } }

        // Constructeur par default
        public Salarie() { }

        // Constructeur d'initialisation
        public Salarie(int matr, string nom, string situ_famil, int echelle,DateTime date_afct) 
        {
            this.matr = matr;
            this.nom = nom;
            this.situ_famil = situ_famil;
            this.echelle = echelle;
            this.date_afct = date_afct;
            cpt++;
        }

        //Equals Overriden
        public override bool Equals(object obj)
        {
            Salarie salarie = obj as Salarie;
            if (this.nom == salarie.nom)
                return true;
            else return false;
        }



    }
}
