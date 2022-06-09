using NUnit.Framework;
using System.IO;
using System;
using iPlatoVwModel;
namespace UnitTest
{
    public class Tests
    {
        private const string Expected = "Record Added Successfully";

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            PeopleVwModel pvm = PeopleVwModel.Instance();
            string res = pvm.SaveData("Add", null, "Iyappan", "01/01/1980", "Software");
            res = pvm.SaveData("Update", 1, "Iyappan Krishnan", "01/01/1980", "Software Engineer");
            Assert.AreEqual(res, "Record Updated Successfully");

        }

        [Test]
        public void Test2()
        {
            PeopleVwModel pvm = PeopleVwModel.Instance();
            string res = pvm.SaveData("Add", null, "Iyappan", "01/01/1980", "Software");
            Assert.AreEqual(res,Expected );

        }        

        [Test]
        public void Test3()
        {
            PeopleVwModel pvm = PeopleVwModel.Instance();
            string res = pvm.SaveData("Add", null, "Iyappan", "01/01/1980", "Software");
            res = pvm.DeleteData(1);
            Assert.AreEqual(res, "Record Deleted Successfully");
            //var teststring =new List<string>();
            //teststring.Add("Iyappan");
            //var teststrings = teststring.Find(str => str == "Iyappan");
            //Assert.IsNotNull(teststrings);
            //Assert.That(teststrings, Is.EqualTo("Iyappan"));
            /* PeopleVwModel pvm = PeopleVwModel.Instance();
             string res = pvm.DeleteData();
             Assert.AreEqual(res, ""); */

        }
       
      
        
    }
}