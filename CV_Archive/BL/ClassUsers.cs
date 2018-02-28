﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CV_Archive.DAL;

namespace CV_Archive.BL
{
    class ClassUsers
    {
        public static DataTable sp_SelectAllUser()
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("sp_SelectAllUser", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static int sp_changepassword(string newpass, int id)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("sp_changepassword", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@newPass", SqlDbType.NVarChar, newpass),
                DataAccessLayer.CreateParameter("@id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;
        }
    }
}
