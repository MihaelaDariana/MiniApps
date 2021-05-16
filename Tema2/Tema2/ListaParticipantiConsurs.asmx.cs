using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Tema2
{
    /// <summary>
    /// Summary description for ListaParticipantiConsurs
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
   
    public class ListaParticipantiConsurs : System.Web.Services.WebService
    {
        SqlConnection myCon = new SqlConnection();

        [WebMethod]
        public List<string> GetParticipants()
        {
            List<string> lista = new List<string>();
            myCon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\mihae\\OneDrive\\Desktop\\II\\Laborator\\Lab5\\Tema2\\Tema2\\App_Data\\DatabaseTema2.mdf;Integrated Security=True";
            myCon.Open();
            SqlCommand cmd = new SqlCommand("Select * From Participanti",myCon);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(reader.GetValue(0)+ "       " +reader.GetValue(1)+"       "+reader.GetValue(2)+"       "+reader.GetValue(3)+"       "+reader.GetValue(4));
            }
            myCon.Close();
            return lista;
        }

        [WebMethod]
        public void InsertParticipants(int id, string name, string adress, string username, string facebook)
        {
            myCon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\mihae\\OneDrive\\Desktop\\II\\Laborator\\Lab5\\Tema2\\Tema2\\App_Data\\DatabaseTema2.mdf;Integrated Security=True";
            myCon.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("Insert into Participanti (Id,Numeprenume,Adresa,Username,Facebook) values(@id,@name,@adress,@username,@facebook)", myCon);
           
            cmd.Parameters.AddWithValue("@id",id); 
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@adress",adress);
            cmd.Parameters.AddWithValue("@username",username);
            cmd.Parameters.AddWithValue("@facebook", facebook);
            cmd.ExecuteNonQuery();
           
        }

        [WebMethod]
        public void DeleteParticipants(int id)
        {
            myCon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\mihae\\OneDrive\\Desktop\\II\\Laborator\\Lab5\\Tema2\\Tema2\\App_Data\\DatabaseTema2.mdf;Integrated Security=True";
            myCon.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("Delete From Participanti Where Id=@id", myCon);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.ExecuteNonQuery();

        }

        [WebMethod]

        public void EditParticipants(int id, string name, string adress, string username, string facebook)
        {
            myCon.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\mihae\\OneDrive\\Desktop\\II\\Laborator\\Lab5\\Tema2\\Tema2\\App_Data\\DatabaseTema2.mdf;Integrated Security=True";
            myCon.Open();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("Update Participanti set NumePrenume=@name,Adresa=@adress,Username=@username,Facebook=@facebook where Id=@Id", myCon);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@adress", adress);
            cmd.Parameters.AddWithValue("@username", username);
            cmd.Parameters.AddWithValue("@facebook", facebook);
            cmd.ExecuteNonQuery();


        }


    }
}
