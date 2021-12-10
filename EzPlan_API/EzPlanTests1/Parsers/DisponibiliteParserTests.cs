using Microsoft.VisualStudio.TestTools.UnitTesting;
using EzPlan.Parsers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EzPlan.Models;
using Microsoft.AspNetCore.Mvc;

namespace EzPlan.Parsers.Tests
{
    [TestClass()]
    public class DisponibiliteParserTests
    {
        [TestMethod()]
        public void ParseFromJSONTest()
        {
            Disponibilite dispo = new("Mardi", 1234, 1235);
            string expResult = dispo.ToString();
            string result = DisponibiliteParser.ParseFromJSON("{\"disponibiliteID\": 0,\"journee\": \"Mardi\",\"heureDebut\": 1234,\"heureFin\": 1235}").ToString();
            Assert.AreEqual(expResult,result);
        }
    }
}