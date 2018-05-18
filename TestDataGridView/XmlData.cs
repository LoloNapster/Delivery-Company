using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace TestDataGridView
{
    class XmlData
    {
        public static void SaveList(List<User> listToSave)
        {
            XDocument xmlDocument = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),

                new XComment("Creating a XML Tree using LINQ to XML"),

                new XElement("Users",

                    from user in listToSave
                    select new XElement("User", new XAttribute("ID", user.ID),
                        new XElement("Name", user.Name),
                        new XElement("Surname", user.Surname),
                        new XElement("Address", user.Address),
                        new XElement("Function", user.Function),
                        new XElement("Login", user.Login),
                        new XElement("Password", user.Password))
                ));

            xmlDocument.Save(@"UsersData.xml");
        }

        public static List<User> ReadToList()
        {
            XDocument xDoc = XDocument.Load(@"UsersData.xml");
            List<User> us = (from xml in xDoc.Elements("Users").Elements("User")
                             select new User
                             {
                                 ID = int.Parse(xml.Attribute("ID").Value),
                                 Name = xml.Element("Name").Value,
                                 Surname = xml.Element("Surname").Value,
                                 Address = xml.Element("Address").Value,
                                 Function = xml.Element("Function").Value,
                                 Login = xml.Element("Login").Value,
                                 Password = xml.Element("Password").Value
                             }).ToList();
            return us;
        }

        public static int FreeIndex()
        {
            int index = 1;
            List<User> listUs = new List<User>();
            listUs = ReadToList();

            foreach (var u in listUs)
            {
                var obj = listUs.SingleOrDefault(o => o.ID == index);
                if (obj == null)
                    break;
                index++;
            }
            return index;
        }

        public static bool IsValidLogin(string user, string password)
        {
            XDocument doc = XDocument.Load(@"UsersData.xml");

            return doc.Descendants("User")
                          .Where(id => id.Element("Login").Value == user
                                 && id.Element("Password").Value == password)
                          .Any();

        }

        public static void SaveListPackage(List<Package> listToSave)
        {
            XDocument xmlDocument = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),

                new XComment("Creating a XML Tree using LINQ to XML"),

                new XElement("Packages",

                    from package in listToSave
                    select new XElement("Package", new XAttribute("ID", package.ID),
                        new XElement("Status", package.Status),
                        new XElement("Date", package.Date),
                        new XElement("IDUser", package.IDUser),
                        new XElement("NameUser", package.NameUser),
                        new XElement("SurnameUser", package.SurnameUser),
                        new XElement("AddressUser", package.AddressUser))
                ));

            xmlDocument.Save(@"PackagesData.xml");
        }

        public static List<Package> ReadToListPackage()
        {
            XDocument xDoc = XDocument.Load(@"PackagesData.xml");
            List<Package> pa = (from xml in xDoc.Elements("Packages").Elements("Package")
                                select new Package
                                {
                                    ID = int.Parse(xml.Attribute("ID").Value),
                                    Status = xml.Element("Status").Value,
                                    Date = xml.Element("Date").Value,
                                    IDUser = int.Parse(xml.Element("IDUser").Value),
                                    NameUser = xml.Element("NameUser").Value,
                                    SurnameUser = xml.Element("SurnameUser").Value,
                                    AddressUser = xml.Element("AddressUser").Value
                                }).ToList();
            return pa;
        }
        public static int FreeIndexPackage()
        {
            int index = 1;
            List<Package> listPa = new List<Package>();
            listPa = ReadToListPackage();

            foreach (var p in listPa)
            {
                var obj = listPa.SingleOrDefault(o => o.ID == index);
                if (obj == null)
                    break;
                index++;
            }
            return index;
        }

        public static List<User> LoadListOfUser()
        {
            List<User> onlyUser = new List<User>();
            onlyUser = ReadToList();

            onlyUser = onlyUser.Where(x => x.Function == "Użytkownik").ToList();

            return onlyUser;
        }

        public static int GetUserId(string login, string password)
        {
            XDocument doc = XDocument.Load(@"UsersData.xml");
            String response = doc.Descendants("User")
                               .Where(x => x.Element("Login").Value == login && x.Element("Password").Value == password)
                               .Single()
                               .Attribute("ID")
                               .Value;
            return int.Parse(response);
        }

        public static List<Package> LoadListOUserfPackages(int id)
        {
            List<Package> userPackages = new List<Package>();
            userPackages = ReadToListPackage();

            userPackages = userPackages.Where(x => x.IDUser == id).ToList();

            return userPackages;
        }

        public static string WhatAFunction(string login, string password)
        {
            XDocument doc = XDocument.Load(@"UsersData.xml");
            String response = doc.Descendants("User")
                               .Where(x => x.Element("Login").Value == login && x.Element("Password").Value == password)
                               .Single()
                               .Element("Function")
                               .Value;
            return response;
        }
    }
}
