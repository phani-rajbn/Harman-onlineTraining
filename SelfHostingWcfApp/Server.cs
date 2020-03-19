using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Data.SqlClient;// Namespace for ADO.NET to connect exclusively to SQL server only. 
using System.Configuration;
using System.Data;//DataSet

//U should add the references of System.ServiceModel and System.Runtime.Serialization.
namespace SelfHostingWcfApp
{
    [DataContract]
    public class Patient
    {
        [DataMember] public int PatientID { get; set; }
        [DataMember] public string PatientName { get; set; }
        [DataMember] public long ContactNo { get; set; }
        [DataMember] public DateTime DateOfVisit { get; set; } = DateTime.Now;
        [DataMember] public double BillAmount { get; set; } = 500;
    }

    [ServiceContract]
    public interface IPatientService
    {
        [OperationContract] void AddNewPatient(Patient patient);
        [OperationContract] List<Patient> GetAllPatients();
    }

    public class PatientService : IPatientService
    {
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        private const string strInsert = "Insert into PatientTable values(@name, @phone, @date, @bill)";
        private const string strSelect = "Select * from PatientTable";

        public void AddNewPatient(Patient patient)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(strInsert, con);
            cmd.Parameters.AddWithValue("@name", patient.PatientName);
            cmd.Parameters.AddWithValue("@phone", patient.ContactNo);
            cmd.Parameters.AddWithValue("@date", patient.DateOfVisit);
            cmd.Parameters.AddWithValue("@bill", patient.BillAmount);
            try
            {
                con.Open();//Opens the connection to the database...
                int rowsAffected = cmd.ExecuteNonQuery();//For insert statement to be executed..
                Debug.WriteLine($"Rows  Affected: {rowsAffected}");
                Trace.WriteLine($"Rows  Affected: {rowsAffected}");
            }
            catch (Exception ex)
            { 
                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public List<Patient> GetAllPatients()
        {
            List<Patient> patients = new List<Patient>();
            //Disconnected Model..
            SqlDataAdapter ada = new SqlDataAdapter(strSelect, connectionString);
            DataSet ds = new DataSet("MyRecords");
            ada.Fill(ds, "FirstTable");//Fills the data into a DataTable called FirstTable belonging to the dataset...
            foreach(DataRow row in ds.Tables["FirstTable"].Rows)
            {
                var patient = new Patient
                {
                    PatientID = Convert.ToInt32(row[0]),
                    PatientName = row[1].ToString(),
                    ContactNo = Convert.ToInt64(row[2]),
                    DateOfVisit = Convert.ToDateTime(row[3]),
                    BillAmount = Convert.ToDouble(row[4])
                };
                patients.Add(patient);
            }
            return patients;
        }
    }

    class WcfServer
    {
        static void Main(string[] args)
        {
            //UR service  needs to be created inside this program. This is called as the Host App or the WCF Host.
            ServiceHost hostApp = new ServiceHost(typeof(PatientService));
            try
            {
                hostApp.Open();
                Console.WriteLine("The Host App is ready to recieve the requests\nPress any key to exit the Server");
                Console.ReadKey();
                hostApp.Close();
            }
            catch (CommunicationException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
