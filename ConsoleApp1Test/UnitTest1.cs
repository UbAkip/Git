using System;
using NUnit.Framework;
using MySql.Data.MySqlClient;

namespace ConsoleApp1Test
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void sum()
        {
            ConsoleApp1.Calculate calc = new ConsoleApp1.Calculate();

            int x = calc.doubleSum(6);

            Assert.AreEqual(x, 6 + 6);
        }
        [Test]
        public void minus()
        {
            ConsoleApp1.Calculate calc = new ConsoleApp1.Calculate();

            int x = calc.minus(6, 3);

            Assert.AreEqual(x, 3);
        }
        [Test]
        public void div()
        {
            ConsoleApp1.Calculate calc = new ConsoleApp1.Calculate();

            double x = calc.div(6, 3);

            Assert.AreEqual(x, 2);
        }
        [Test]
        [TestCase("SELECT * FROM `crm`.`_binary`", "DELETE FROM `crm`.`book`", 0)]
        public void connection(string takeDataquery, string executeQuery, object expectedResult)
        {
            var conn_info = "Server=localhost;Port=3306;Database=crm;Uid=root;Pwd=fayHBn1wuld001";

            int result = DataTaking(conn_info, takeDataquery);

            Assert.IsTrue(result > 0);
        }

        public int DataTaking(string conn, string query)
        {
            MySqlConnection connection = new MySqlConnection(conn);
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();
            int total = 0;
            using (MySqlDataReader dr = command.ExecuteReader())
            {
                while (dr.Read())
                    total++;
            }
            connection.Close();
            connection.Dispose();
            return total;
        }

        private int NonQuery(string conn, string query)
        {
            MySqlConnection connection = new MySqlConnection(conn);
            MySqlCommand command = new MySqlCommand(query, connection);
            connection.Open();

            int result = command.ExecuteNonQuery();
            connection.Close();
            connection.Dispose();
            return result;
        }

    }
}
