﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MySql.Data.MySqlClient;
using System.Configuration;

namespace Webservice
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {


        [OperationContract]
        string Insert(fileData data);

        [OperationContract]
        List<fileData> GetDocuments(int user);

        [OperationContract]
        string Createuser(UserData Udata);



    }


    [DataContract]
    public class fileData
    {
        string name = string.Empty;
        string type = string.Empty;
        string date = string.Empty;
        string hash = string.Empty;

        int userid;
        byte[] fdata;
        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        [DataMember]
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        [DataMember]
        public string Hash
        {
            get { return hash; }
            set { hash = value; }
        }

        [DataMember]
        public string Date
        {
            get { return date; }
            set { date = value; }
        }
        [DataMember]
        public int Userid
        {
            get { return userid; }
            set { userid = value; }
        }

        [DataMember]
        public byte[] Data
        {
            get { return fdata; }
            set { fdata = value; }
        }

    }
    [DataContract]
    public class UserData
    {
        string username = string.Empty;
        string password = string.Empty;
        string email = string.Empty;

        [DataMember]
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        [DataMember]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        [DataMember]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
    }
}

