﻿using System;
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
    class ListeUnite : List<Unite>
    {
        public static List<Unite> Unites = new List<Unite>();
    }
}
