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
    class Unite
    {
        //Attributs
        int code;
        string nom;

        public static List<Salarie> Salaries = new List<Salarie>();

        //Properties
        public int Code { get { return code; } set { code = value; } }
        public string Nom { get { return nom; } set { nom = value; } }
        
        // Constructeur d'initialisation
        public Unite(int code, string nom)
        {
            this.code = code;
            this.nom = nom;
        }


    }
}
