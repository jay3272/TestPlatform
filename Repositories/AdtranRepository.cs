using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using TestPlatform.Models;

namespace TestPlatform.Repositories
{
    public class AdtranRepository : BaseRepository, IAdtranRepository
    {
        //Constructor
        public AdtranRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        //Methods
        public void Add(AdtranModel adtranModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(AdtranModel adtranModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AdtranModel> GetAll()
        {
            var adtranList = new List<AdtranModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select *from Adtran_632V_ThroughputTest order by testdate desc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var adtranModel = new AdtranModel();
                        adtranModel.Tester = reader[0].ToString();
                        adtranModel.Model = reader[1].ToString();
                        adtranModel.Pcbsn = reader[2].ToString();
                        adtranModel.Saleno = reader[3].ToString();
                        adtranModel.OLT_to_Lan1 = reader[4].ToString();
                        adtranModel.Lan1_to_OLT = reader[5].ToString();
                        adtranModel.OLT_to_Lan3 = reader[6].ToString();
                        adtranModel.Lan3_to_OLT = reader[7].ToString();
                        adtranModel.Framelen = reader[8].ToString();
                        adtranModel.Framerate = reader[9].ToString();
                        adtranModel.Testduration = reader[10].ToString();
                        adtranModel.Result = reader[11].ToString();
                        adtranModel.Testtime = reader[12].ToString();
                        adtranModel.Swver = reader[13].ToString();
                        adtranModel.Ip = reader[14].ToString();
                        adtranModel.Testdate = DateTime.Parse(reader[15].ToString());
                        adtranList.Add(adtranModel);
                    }
                }
            }
            return adtranList;
        }

        public IEnumerable<AdtranModel> GetByValue(string value)
        {
            var adtranList = new List<AdtranModel>();
            string tester = value;
            string pcbsn = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select *from Adtran_632V_ThroughputTest
                                        where tester=@tester or pcbsn like @pcbsn+'%' 
                                        order by testdate desc";
                command.Parameters.Add("@tester", SqlDbType.VarChar).Value = tester;
                command.Parameters.Add("@pcbsn", SqlDbType.VarChar).Value = pcbsn;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var adtranModel = new AdtranModel();
                        adtranModel.Tester = reader[0].ToString();
                        adtranModel.Model = reader[1].ToString();
                        adtranModel.Pcbsn = reader[2].ToString();
                        adtranModel.Saleno = reader[3].ToString();
                        adtranModel.OLT_to_Lan1 = reader[4].ToString();
                        adtranModel.Lan1_to_OLT = reader[5].ToString();
                        adtranModel.OLT_to_Lan3 = reader[6].ToString();
                        adtranModel.Lan3_to_OLT = reader[7].ToString();
                        adtranModel.Framelen = reader[8].ToString();
                        adtranModel.Framerate = reader[9].ToString();
                        adtranModel.Testduration = reader[10].ToString();
                        adtranModel.Result = reader[11].ToString();
                        adtranModel.Testtime = reader[12].ToString();
                        adtranModel.Swver = reader[13].ToString();
                        adtranModel.Ip = reader[14].ToString();
                        adtranModel.Testdate = DateTime.Parse(reader[15].ToString());
                        adtranList.Add(adtranModel);
                    }
                }
            }
            return adtranList;
        }
    }
}
