using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using CV_Archive.DAL;

namespace CV_Archive.BL
{
    class ClassDocument
    {
        public static int AddDoc(string DocType, string DocOwn, string DocNum, DateTime DocDate, string Doc_note) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("AddDoc", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Doc_Type", SqlDbType.NVarChar, DocType),
                DataAccessLayer.CreateParameter("@Doc_Own", SqlDbType.NVarChar, DocOwn),
                DataAccessLayer.CreateParameter("@Doc_number", SqlDbType.NVarChar, DocNum),
                DataAccessLayer.CreateParameter("@Doc_Date", SqlDbType.Date, DocDate),
                DataAccessLayer.CreateParameter("@Doc_Note", SqlDbType.NVarChar, Doc_note));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable SelectLastDoc() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SelectLastDoc", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static int AddDocImage(byte[] arr, int id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("AddDocImage", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Doc_Img", SqlDbType.Image, arr),
                DataAccessLayer.CreateParameter("@Doc_id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable selectAllDoc() 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectAllDoc", CommandType.StoredProcedure);
            DataAccessLayer.Close();
            return dt;
        }
        public static DataTable searchForDoc(string search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("searchForDoc", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.NVarChar, search));
            DataAccessLayer.Close();
            return dt;
        }
        public static int updateDocDetails(int id, string docType, string docOwn, string docnumber, DateTime docDate, string docnote) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("updateDocDetails", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Doc_id", SqlDbType.Int, id),
                DataAccessLayer.CreateParameter("@Doc_Type", SqlDbType.NVarChar, docType),
                DataAccessLayer.CreateParameter("@Doc_Own", SqlDbType.NVarChar, docOwn),
                DataAccessLayer.CreateParameter("@Doc_number", SqlDbType.NVarChar, docnumber),
                DataAccessLayer.CreateParameter("@Doc_Date", SqlDbType.Date, docDate),
                DataAccessLayer.CreateParameter("@Doc_Note", SqlDbType.NVarChar, docnote));
            DataAccessLayer.Close();
            return i;
        }
        public static int DeleteDoc(int id) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("DeleteDoc", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Doc_id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;
        }
        public static int DeleteImgWithDelDoc(int id)
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("DeleteImgWithDelDoc", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Doc_id", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable selectImgForOneDoc(int id) 
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("selectImgForOneDoc", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@DocID", SqlDbType.Int, id));
            DataAccessLayer.Close();
            return dt;
        }
        public static int insertImgToDoc(byte[] arr, int DocId) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("insertImgToDoc", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Doc_Img", SqlDbType.Image, arr),
                DataAccessLayer.CreateParameter("@Doc_id", SqlDbType.Int, DocId));
            DataAccessLayer.Close();
            return i;
        }
        public static int DeleteImg(int ImgId) 
        {
            DataAccessLayer.Open();
            int i = DataAccessLayer.ExecuteNonQuery("DeleteImg", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@Doc_Img_ID", SqlDbType.Int, ImgId));
            DataAccessLayer.Close();
            return i;
        }
        public static DataTable SearchAfterDate(DateTime search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SearchAfterDate", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.Date, search));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SearchBeforDate(DateTime search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SearchBeforDate", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.Date, search));
            DataAccessLayer.Close();
            return dt;
        }

        public static DataTable SearchEqualDate(DateTime search)
        {
            DataAccessLayer.Open();
            DataTable dt = DataAccessLayer.ExecuteTable("SearchEqualDate", CommandType.StoredProcedure,
                DataAccessLayer.CreateParameter("@search", SqlDbType.Date, search));
            DataAccessLayer.Close();
            return dt;
        }
    }
}
