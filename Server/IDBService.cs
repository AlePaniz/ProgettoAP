﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Server
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di interfaccia "IDBService" nel codice e nel file di configurazione contemporaneamente.
    [ServiceContract]
    public interface IDBService
    {
        [OperationContract]
        void Connessione();


        [OperationContract]
        bool Login(string user, string psw, bool organizzatore);
    }
}