using System;
using NUnit.Framework;
using MySql.Data.MySqlClient;
using System.Net;
using Newtonsoft.Json.Linq;
using System.Text;
using System.IO;
using Newtonsoft.Json;

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
        //[Test]
        //[TestCase("SELECT * FROM `crm`.`_binary`", "DELETE FROM `crm`.`book`", 0)]
        //public void connection(string takeDataquery, string executeQuery, object expectedResult)
        //{
        //    var conn_info = "Server=data.aihelps.com;Port=3306;Database=db726029;Uid=user726029;Pwd=TLvCvX+l+Vjxim5mfTTQ";

        //    int result = DataTaking(conn_info, takeDataquery);

        //    Assert.IsTrue(result > 0);
        //}

        //public int DataTaking(string conn, string query)
        //{
        //    MySqlConnection connection = new MySqlConnection(conn);
        //    MySqlCommand command = new MySqlCommand(query, connection);
        //    connection.Open();
        //    int total = 0;
        //    using (MySqlDataReader dr = command.ExecuteReader())
        //    {
        //        while (dr.Read())
        //            total++;
        //    }
        //    connection.Close();
        //    connection.Dispose();
        //    return total;
        //}

        //private int NonQuery(string conn, string query)
        //{
        //    MySqlConnection connection = new MySqlConnection(conn);
        //    MySqlCommand command = new MySqlCommand(query, connection);
        //    connection.Open();

        //    int result = command.ExecuteNonQuery();
        //    connection.Close();
        //    connection.Dispose();
        //    return result;
        //}
        private const string BearerToken = "Bearer 751392d5-a113-44e4-bb30-0d9e190b2f4c";


        //[Test]
        //[TestCase("http://localhost:81/v1/clients")]
        //[TestCase("http://localhost:81/v1/employees")]
        //[TestCase("http://localhost:81/v1/services")]
        //[TestCase("http://localhost:81/v1/clients/relations")]
        //public void GetRequest_GetClient_ReturnTrue(string uri)
        //{
        //    //Arrange
        //    var client = new WebClient();
        //    client.Headers.Add(HttpRequestHeader.Authorization, BearerToken);
        //    client.Headers.Add(HttpRequestHeader.ContentLanguage, "ru");

        //    //Act
        //    var result = JsonConvert.DeserializeObject(client.DownloadString(uri));

        //    //Assert 
        //    Assert.IsTrue((result != null) && (result is JArray));
        //}


        //public object POSTMethod(string uri, string apiTableName, object value)
        //{
        //    HttpWebRequest request1 = WebRequest.CreateHttp(uri);
        //    WebHeaderCollection headers = new WebHeaderCollection();
        //    headers.Add(HttpRequestHeader.Authorization, BearerToken);
        //    headers.Add(HttpRequestHeader.ContentLanguage, "ru");
        //    request1.Headers = headers;
        //    request1.ContentType = "application/json";
        //    request1.Method = "POST";
        //    JObject obj = new JObject
        //    {
        //        { apiTableName, new JValue(value) }
        //    };
        //    string serializeObject = JsonConvert.SerializeObject(obj);
        //    byte[] bytes = Encoding.GetEncoding(1251).GetBytes(serializeObject);
        //    request1.ContentLength = bytes.Length;

        //    request1.GetRequestStream().Write(bytes, 0, bytes.Length);

        //    var response = request1.GetResponse();
        //    var sr = new StreamReader(response.GetResponseStream()).ReadToEnd();
        //    return JsonConvert.DeserializeObject(sr);
        //}

    }
}
