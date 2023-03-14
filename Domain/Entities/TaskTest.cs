using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace TaskManagement.Domain.Entities
{
    [TestFixture]
    public class TaskTest {

        private Tasks tasks;
        private const int Id = 1;
        private const string text = "task";
        private static readonly DateTime Date = new(2001, 2, 3);

        [SetUp]
         public void SetUp()
            {
                tasks = new Tasks();
            }

            [Test]
            public void TestSetAndGetId()
            {
                tasks.Id = Id;

                Assert.That(tasks.Id,
                    Is.EqualTo(Id));
            }

            [Test]
            public void TestSetAndGetText()
            {
                tasks.Text = text;

            Assert.That(tasks.Text,
                Is.EqualTo(text));
            }
        [Test]
        public void TestSetAndGetDate()
        {
            tasks.dateTime = Date;

            Assert.That(tasks.dateTime,
                Is.EqualTo(Date));
        }
    }


    
}
