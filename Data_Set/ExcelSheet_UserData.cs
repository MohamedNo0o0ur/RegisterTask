using Dapper;
using System.Configuration;
using System.Data.OleDb;
using System.Linq;

namespace RegisterTask.Data_Set
{
    class ExcelSheet_UserData
    {

        public static string TestDataFileConnection_AddUser()
        {
            var fileName = ConfigurationManager.AppSettings["F:/codepro/IPMATS_Auto/Data_Set/RegAddUser.xlsx"];
            string con = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = F:/codepro/IPMATS_Auto/Data_Set/RegAddUser.xlsx; Extended Properties=Excel 12.0;", fileName);
            return con;
        }

        public static DataSet_UserData GetTestData(string keyName)
        {
            using (var connection = new OleDbConnection(TestDataFileConnection_AddUser()))
            {
                connection.Open();
                var query = string.Format("select * from [UserData$]", keyName);
                var value_Adduser = connection.Query<DataSet_UserData>(query).FirstOrDefault();
                connection.Close();
                return value_Adduser;
            }
        }
    }
    }

