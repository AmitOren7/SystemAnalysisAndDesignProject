using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemAnalysisAndDesignProject
{
    public class OfficeManager : Employee
    {
    
    public OfficeManager(string firstName, string lastName, string id, string phoneNumber,
           string email, string address, string userName, string password,
           string idCopy, bool is_new)
            : base (firstName, lastName, id, phoneNumber,email, address, userName, password,idCopy)
        {
            if (is_new)
            {
                this.Create();
                Program.OfficeManagerList.Add(this);
            }
        }

        public override void Create()
        {
            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE dbo.sp_add_officeManager @firstName, @lastName, @id, @phoneNumber" +
                ", @email, @address, @userName, @password, @idCopy";
            sp.Parameters.AddWithValue("@firstName", this.firstName);
            sp.Parameters.AddWithValue("@lastName", this.lastName);
            sp.Parameters.AddWithValue("@id", this.id);
            sp.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);
            sp.Parameters.AddWithValue("@email", this.email);
            sp.Parameters.AddWithValue("@address", this.address);
            sp.Parameters.AddWithValue("@userName", this.userName);
            sp.Parameters.AddWithValue("@password", this.password);
            sp.Parameters.AddWithValue("@idCopy", this.idCopy);

            SQL_CON SC = new SQL_CON();
            SC.execute_non_query(sp);
        }
        public override void Update()
        {
            SqlCommand sp = new SqlCommand();
            sp.CommandText = "EXECUTE SP_update_officeManager @firstName, @lastName, @id, @phoneNumber" +
                ",@email, @address, @userName, @password, @idCopy";
            
            {
                sp.Parameters.AddWithValue("@firstName", this.firstName);
                sp.Parameters.AddWithValue("@lastName", this.lastName);
                sp.Parameters.AddWithValue("@id", this.id);
                sp.Parameters.AddWithValue("@phoneNumber", this.phoneNumber);
                sp.Parameters.AddWithValue("@email", this.email);
                sp.Parameters.AddWithValue("@address", this.address);
                sp.Parameters.AddWithValue("@userName", this.userName);
                sp.Parameters.AddWithValue("@password", this.password);
                sp.Parameters.AddWithValue("@idCopy", this.idCopy);

                SQL_CON SC = new SQL_CON();
                SC.execute_non_query(sp);
            }
        }
    }
}
