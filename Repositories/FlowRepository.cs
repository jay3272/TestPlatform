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
    public class FlowRepository : BaseRepository, IFlowRepository
    {
        //Constructor
        public FlowRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        //Methods
        public void Add(FlowModel flowModel)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(FlowModel flowModel)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FlowModel> GetAll()
        {
            var flowList = new List<FlowModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "Select *from Flow order by id asc";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var flowModel = new FlowModel();
                        flowModel.Id = (int)reader[0];
                        flowModel.LevelName = reader[1].ToString();
                        flowModel.Model = reader[2].ToString();
                        flowModel.SendCmd = reader[3].ToString();
                        flowModel.SendValue = reader[4].ToString();
                        flowModel.ReValue = reader[5].ToString();
                        flowModel.ReType = reader[6].ToString();
                        flowModel.ReTest = Convert.ToBoolean(reader[7].ToString());
                        flowModel.Commenet = reader[8].ToString();
                        flowList.Add(flowModel);
                    }
                }
            }
            return flowList;
        }

        public IEnumerable<FlowModel> GetByValue(string value)
        {
            var flowList = new List<FlowModel>();
            int flowId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string model = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"Select *from Flow
                                        where id=@id or Model like @model+'%' 
                                        order by id asc";
                command.Parameters.Add("@id", SqlDbType.Int).Value = flowId;
                command.Parameters.Add("@Model", SqlDbType.NVarChar).Value = model;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var flowModel = new FlowModel();
                        flowModel.Id = (int)reader[0];
                        flowModel.LevelName = reader[1].ToString();
                        flowModel.Model = reader[2].ToString();
                        flowModel.SendCmd = reader[3].ToString();
                        flowModel.SendValue = reader[4].ToString();
                        flowModel.ReValue = reader[5].ToString();
                        flowModel.ReType = reader[6].ToString();
                        flowModel.ReTest = bool.Parse(reader[7].ToString());
                        flowModel.Commenet = reader[8].ToString();
                        flowList.Add(flowModel);
                    }
                }
            }
            return flowList;
        }
    }
}
