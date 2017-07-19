using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace WindowsFormsApplication1.DAO
{
    class ConnectDB
    {
        private string connectString;
        private SqlConnection connection;
        private SqlTransaction transaction;

        public string StringCon
        {
            get { return connectString; }
            set { connectString = value; }
        }

        public ConnectDB()
        {

            //connectString = @"Data Source=DESKTOP-TR24MPG;Initial Catalog=C:\USERS\ADMIN\DESKTOP\TESTING_DEMO1\TESTING_DEMO1\TESTING_DEMO1\BIN\DEBUG\DB\QL_THUVIENKHTN.MDF;Integrated Security=True"; // chuỗi kết nối 
            //connectString = @"Data Source=HAITRAN;Initial Catalog=QLDKIDOAN;Integrated Security=True";
            connectString = @"Data Source=JSTCOMDEVICE\THIENHOANGSERVER;Initial Catalog=QLDKIDOAN;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            connection = new SqlConnection(connectString);
        }

        public DataSet execute_Query1(string query)
        {
            DataSet ds = new DataSet();
            using (SqlCommand command = new SqlCommand(query, this.connection))
            {

                using (SqlDataAdapter da = new SqlDataAdapter(command))
                {
                    connection.Open();
                    if (DefineClass.TransactionDefault == 1)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadUncommitted);
                    }
                    if (DefineClass.TransactionDefault == 2)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                    }
                    if (DefineClass.TransactionDefault == 3)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);
                    }
                    if (DefineClass.TransactionDefault == 4)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.Serializable);
                    }
                    da.SelectCommand.Transaction = transaction;

                    da.Fill(ds);
                    transaction.Commit();
                    connection.Close();
                }
            }
            return ds;
        }

        public DataTable execute_Query(string query)
        {
            DataTable a = new DataTable();

            using (SqlCommand command = new SqlCommand(query, this.connection))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(command))
                {
                    da.Fill(a);
                }
            }
            return a;
        }
        public bool execute_store(string spname, string maDA, string soluongcapnhat)
        {
            bool result = false;
            using (SqlCommand scCommand = new SqlCommand(spname, connection))
            {
                scCommand.CommandType = CommandType.StoredProcedure;
                scCommand.Parameters.Add("@MaDA", SqlDbType.Char, 10).Value = maDA;
                scCommand.Parameters.Add("@SLTD", SqlDbType.Int).Value = soluongcapnhat;
                scCommand.Parameters.Add("@RESULT ", SqlDbType.Bit).Direction = ParameterDirection.Output;
                try
                {
                    if (scCommand.Connection.State == ConnectionState.Closed)
                    {
                        scCommand.Connection.Open();
                    }
                    if (DefineClass.TransactionDefault == 1)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadUncommitted);
                    }
                    if (DefineClass.TransactionDefault == 2)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                    }
                    if (DefineClass.TransactionDefault == 3)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);
                    }
                    if (DefineClass.TransactionDefault == 4)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.Serializable);
                    }
                    scCommand.Transaction = transaction;

                    scCommand.ExecuteNonQuery();
                    transaction.Commit();
                    result = true;
                }
                catch (Exception)
                {

                }
                finally
                {
                    scCommand.Connection.Close();
                }
            }
            return result;


        }
        // here
        public bool execute_nonQuery(string query)
        {

            bool checking;
            try
            {
                this.connection.Open();
                using (SqlCommand command = new SqlCommand(query, this.connection))
                {
                    if (DefineClass.TransactionDefault == 1)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadUncommitted);
                    }
                    if (DefineClass.TransactionDefault == 2)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                    }
                    if (DefineClass.TransactionDefault == 3)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);
                    }
                    if (DefineClass.TransactionDefault == 4)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.Serializable);
                    }
                    command.Transaction = transaction;
                    command.ExecuteNonQuery();
                    transaction.Commit();

                }
                checking = true;
            }
            catch
            {
                checking = false;
            }
            finally
            {
                this.connection.Close();
            }
            return checking;
        }

        public string PhatSinhMa(string kytu)
        {
            using (var command = connection.CreateCommand())
            {
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "PhatSinhMa";
                command.Parameters.Add(new SqlParameter("@kytudau", kytu));

                SqlParameter returnValue = command.Parameters.Add("@RETURN_VALUE", SqlDbType.Int);
                returnValue.Direction = ParameterDirection.ReturnValue;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                return returnValue.Value.ToString();
            }
        }

        public bool execute_store1s(string spname, string MaNhom, string MaSV, string MaMonHoc, string MaDoAn, string MaNhomCu)
        {
            bool result = false;
            using (SqlCommand scCommand = new SqlCommand(spname, connection))
            {
                scCommand.CommandType = CommandType.StoredProcedure;
                scCommand.Parameters.Add("@MaNhom", SqlDbType.Char, 10).Value = MaNhom;
                scCommand.Parameters.Add("@MaSV", SqlDbType.Char, 10).Value = MaSV;
                scCommand.Parameters.Add("@MaMonHoc", SqlDbType.Char, 10).Value = MaMonHoc;
                scCommand.Parameters.Add("@MaDoAn", SqlDbType.Char, 10).Value = MaDoAn;
                scCommand.Parameters.Add("@MaNhomCu", SqlDbType.Char, 10).Value = MaNhomCu;
                scCommand.Parameters.Add("@Resulf ", SqlDbType.Bit).Direction = ParameterDirection.Output;
                try
                {
                    if (scCommand.Connection.State == ConnectionState.Closed)
                    {
                        scCommand.Connection.Open();
                    }
                    if (DefineClass.TransactionDefault == 1)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadUncommitted);
                    }
                    if (DefineClass.TransactionDefault == 2)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                    }
                    if (DefineClass.TransactionDefault == 3)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);
                    }
                    if (DefineClass.TransactionDefault == 4)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.Serializable);
                    }
                    scCommand.Transaction = transaction;
                    scCommand.ExecuteNonQuery();
                    transaction.Commit();
                    result = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error!");
                }
                finally
                {
                    scCommand.Connection.Close();
                }
            }
            return result;
        }

        public bool execute_store2s(string spname, string MaMonHoc, string MaDoAn, string MaNhom, string MaSV)
        {
            bool result = false;
            using (SqlCommand scCommand = new SqlCommand(spname, connection))
            {
                scCommand.CommandType = CommandType.StoredProcedure;
                scCommand.Parameters.Add("@MaNhom", SqlDbType.Char, 10).Value = MaNhom;
                scCommand.Parameters.Add("@MaSV", SqlDbType.Char, 10).Value = MaSV;
                scCommand.Parameters.Add("@MaMonHoc", SqlDbType.Char, 10).Value = MaMonHoc;
                scCommand.Parameters.Add("@MaDoAn", SqlDbType.Char, 10).Value = MaDoAn;
                scCommand.Parameters.Add("@Resulf ", SqlDbType.Bit).Direction = ParameterDirection.Output;
                try
                {
                    if (scCommand.Connection.State == ConnectionState.Closed)
                    {
                        scCommand.Connection.Open();
                    }

                    if (DefineClass.TransactionDefault == 1)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadUncommitted);
                    }
                    if (DefineClass.TransactionDefault == 2)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                    }
                    if (DefineClass.TransactionDefault == 3)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);
                    }
                    if (DefineClass.TransactionDefault == 4)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.Serializable);
                    }
                    scCommand.Transaction = transaction;
                    scCommand.ExecuteNonQuery();
                    transaction.Commit();
                    result = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Errorsss!");
                }
                finally
                {
                    scCommand.Connection.Close();
                }
            }
            return result;
        }

        public bool execute_storeUpdateDeadline(string spname, string MaMonHoc, string MaDoAn, DateTime deadline)
        {
            bool result = false;
            using (SqlCommand scCommand = new SqlCommand(spname, connection))
            {
                scCommand.CommandType = CommandType.StoredProcedure;
                scCommand.Parameters.Add("@MaMH", SqlDbType.Char, 10).Value = MaMonHoc;
                scCommand.Parameters.Add("@MaDA", SqlDbType.Char, 10).Value = MaDoAn;
                scCommand.Parameters.Add("@deadline", SqlDbType.DateTime).Value = deadline;
                scCommand.Parameters.Add("@RESULT ", SqlDbType.Bit).Direction = ParameterDirection.Output;
                try
                {
                    if (scCommand.Connection.State == ConnectionState.Closed)
                    {
                        scCommand.Connection.Open();
                    }
                    if (DefineClass.TransactionDefault == 1)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadUncommitted);
                    }
                    if (DefineClass.TransactionDefault == 2)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                    }
                    if (DefineClass.TransactionDefault == 3)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);
                    }
                    if (DefineClass.TransactionDefault == 4)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.Serializable);
                    }
                    scCommand.Transaction = transaction;
                    scCommand.ExecuteNonQuery();
                    transaction.Commit();
                    result = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Errorsss!");
                }
                finally
                {
                    scCommand.Connection.Close();
                }
            }
            return result;
        }


        /*-------------------------------------Hải-----------------------------------------------*/
        public bool execute_storeThemMH(string spname, string maMH, string TenMH, string TrangThai, DateTime ThoiGianBD, DateTime ThoiGianKT, int SoLuong)
        {
            bool result = false;
            using (SqlCommand scCommand = new SqlCommand(spname, connection))
            {
                scCommand.CommandType = CommandType.StoredProcedure;
                scCommand.Parameters.Add("@maMH", SqlDbType.Char, 10).Value = maMH;
                scCommand.Parameters.Add("@TenMH", SqlDbType.NVarChar, 50).Value = TenMH;
                scCommand.Parameters.Add("@TrangThai", SqlDbType.NVarChar, 20).Value = TrangThai;
                scCommand.Parameters.Add("@ThoiGianBD", SqlDbType.DateTime).Value = ThoiGianBD;
                scCommand.Parameters.Add("@ThoiGianKT", SqlDbType.DateTime).Value = ThoiGianKT;
                scCommand.Parameters.Add("@SL_SV", SqlDbType.Int).Value = SoLuong;
                try
                {

                    if (scCommand.Connection.State == ConnectionState.Closed)
                    {
                        scCommand.Connection.Open();
                    }
                    if (DefineClass.TransactionDefault == 1)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadUncommitted);
                    }
                    if (DefineClass.TransactionDefault == 2)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                    }
                    if (DefineClass.TransactionDefault == 3)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);
                    }
                    if (DefineClass.TransactionDefault == 4)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.Serializable);
                    }
                    scCommand.Transaction = transaction;
                    scCommand.ExecuteNonQuery();
                    transaction.Commit();
                    result = true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Errors[0].Message.ToString());
                }
                finally
                {
                    scCommand.Connection.Close();
                }
            }
            return result;
        }

        public bool execute_storeThemSV(string spname, string masv, string hoten, string trangthai, string gioitinh, DateTime ngaysinh)
        {
            bool result = false;
            using (SqlCommand scCommand = new SqlCommand(spname, connection))
            {
                scCommand.CommandType = CommandType.StoredProcedure;
                scCommand.Parameters.Add("@MaSV", SqlDbType.Char, 10).Value = masv;
                scCommand.Parameters.Add("@TenSV", SqlDbType.NVarChar, 50).Value = hoten;
                scCommand.Parameters.Add("@TrangThai", SqlDbType.NVarChar, 20).Value = trangthai;
                scCommand.Parameters.Add("@GioiTinh", SqlDbType.NVarChar, 5).Value = gioitinh;
                scCommand.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = ngaysinh;
                try
                {
                    if (scCommand.Connection.State == ConnectionState.Closed)
                    {
                        scCommand.Connection.Open();
                    }
                    if (DefineClass.TransactionDefault == 1)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadUncommitted);
                    }
                    if (DefineClass.TransactionDefault == 2)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                    }
                    if (DefineClass.TransactionDefault == 3)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);
                    }
                    if (DefineClass.TransactionDefault == 4)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.Serializable);
                    }
                    scCommand.Transaction = transaction;
                    scCommand.ExecuteNonQuery();
                    transaction.Commit();
                    result = true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Errors[0].Message.ToString());
                }
                finally
                {
                    scCommand.Connection.Close();
                }
            }
            return result;
        }

        public DataSet execute_storelayDanhSachMH(string spname)
        {
            DataSet ds = new DataSet();
            using (SqlCommand scCommand = new SqlCommand(spname, connection))
            {
                using (SqlDataAdapter da = new SqlDataAdapter(scCommand))
                {
                    connection.Open();
                    if (DefineClass.TransactionDefault == 1)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadUncommitted);
                    }
                    if (DefineClass.TransactionDefault == 2)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                    }
                    if (DefineClass.TransactionDefault == 3)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);
                    }
                    if (DefineClass.TransactionDefault == 4)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.Serializable);
                    }
                    da.SelectCommand.Transaction = transaction;
                    da.Fill(ds);
                    transaction.Commit();
                    connection.Close();
                }
            }
            return ds;
        }


        public DataTable execute_storeTimSV(string spname, string masv)
        {
            DataTable a = new DataTable();
            using (SqlCommand scCommand = new SqlCommand(spname, connection))
            {
                scCommand.CommandType = CommandType.StoredProcedure;
                scCommand.Parameters.Add("@MaSV", SqlDbType.Char, 10).Value = masv;
                using (SqlDataAdapter da = new SqlDataAdapter(scCommand))
                {
                    connection.Open();
                    if (DefineClass.TransactionDefault == 1)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadUncommitted);
                    }
                    if (DefineClass.TransactionDefault == 2)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                    }
                    if (DefineClass.TransactionDefault == 3)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);
                    }
                    if (DefineClass.TransactionDefault == 4)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.Serializable);
                    }
                    da.SelectCommand.Transaction = transaction;
                    da.Fill(a);
                    transaction.Commit();
                    connection.Close();
                }
            }
            return a;
        }

        public DataTable execute_storeTimMH(string spname, string mamh)
        {
            DataTable a = new DataTable();
            using (SqlCommand scCommand = new SqlCommand(spname, connection))
            {
                scCommand.CommandType = CommandType.StoredProcedure;
                scCommand.Parameters.Add("@MaMH", SqlDbType.Char, 10).Value = mamh;
                using (SqlDataAdapter da = new SqlDataAdapter(scCommand))
                {
                    connection.Open();
                    if (DefineClass.TransactionDefault == 1)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadUncommitted);
                    }
                    if (DefineClass.TransactionDefault == 2)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                    }
                    if (DefineClass.TransactionDefault == 3)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);
                    }
                    if (DefineClass.TransactionDefault == 4)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.Serializable);
                    }
                    da.SelectCommand.Transaction = transaction;
                    da.Fill(a);
                    transaction.Commit();
                    connection.Close();
                }
            }
            return a;
        }


        public bool execute_storeupdateSLSV_MH(string spname, string mamh, int sl)
        {
            bool result = false;
            using (SqlCommand scCommand = new SqlCommand(spname, connection))
            {
                scCommand.CommandType = CommandType.StoredProcedure;
                scCommand.Parameters.Add("@MaMH", SqlDbType.Char, 10).Value = mamh;
                scCommand.Parameters.Add("@SL_SV", SqlDbType.Int).Value = sl;
                try
                {
                    if (scCommand.Connection.State == ConnectionState.Closed)
                    {
                        scCommand.Connection.Open();
                    }
                    if (DefineClass.TransactionDefault == 1)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadUncommitted);
                    }
                    if (DefineClass.TransactionDefault == 2)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                    }
                    if (DefineClass.TransactionDefault == 3)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);
                    }
                    if (DefineClass.TransactionDefault == 4)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.Serializable);
                    }
                    scCommand.Transaction = transaction;
                    scCommand.ExecuteNonQuery();
                    transaction.Commit();
                    result = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error!");
                }
                finally
                {
                    scCommand.Connection.Close();
                }
            }
            return result;
        }


        public bool execute_storeThemSV_MH(string spname, string mamh, string masv, int hocki, int namhoc)
        {
            bool result = false;
            using (SqlCommand scCommand = new SqlCommand(spname, connection))
            {
                scCommand.CommandType = CommandType.StoredProcedure;
                scCommand.Parameters.Add("@MaMH", SqlDbType.Char, 10).Value = mamh;
                scCommand.Parameters.Add("@MaSV", SqlDbType.Char, 10).Value = masv;
                scCommand.Parameters.Add("@HocKy", SqlDbType.Int).Value = hocki;
                scCommand.Parameters.Add("@NamHoc", SqlDbType.Int).Value = namhoc;
                try
                {
                    if (scCommand.Connection.State == ConnectionState.Closed)
                    {
                        scCommand.Connection.Open();
                    }
                    if (DefineClass.TransactionDefault == 1)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadUncommitted);
                    }
                    if (DefineClass.TransactionDefault == 2)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                    }
                    if (DefineClass.TransactionDefault == 3)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);
                    }
                    if (DefineClass.TransactionDefault == 4)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.Serializable);
                    }
                    scCommand.Transaction = transaction;
                    scCommand.ExecuteNonQuery();
                    result = true;
                    transaction.Commit();
                }
                catch (Exception)
                {
                    MessageBox.Show("Error!");
                }
                finally
                {
                    scCommand.Connection.Close();
                }
            }
            return result;
        }
        /*----------------------------------Hải - hết--------------------------------------------*/

        /*------------------------------------Hoàng----------------------------------------------*/
        public DataTable execute_storeXemChiTietMonHoc(string spname, string mamh)
        {
            DataTable a = new DataTable();
            using (SqlCommand scCommand = new SqlCommand(spname, connection))
            {
                scCommand.CommandType = CommandType.StoredProcedure;
                scCommand.Parameters.Add("@MaMH", SqlDbType.Char, 10).Value = mamh;
                using (SqlDataAdapter da = new SqlDataAdapter(scCommand))
                {
                    connection.Open();
                    if (DefineClass.TransactionDefault == 1)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadUncommitted);
                    }
                    if (DefineClass.TransactionDefault == 2)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                    }
                    if (DefineClass.TransactionDefault == 3)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);
                    }
                    if (DefineClass.TransactionDefault == 4)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.Serializable);
                    }
                    da.SelectCommand.Transaction = transaction;
                    da.Fill(a);
                    transaction.Commit();
                    connection.Close();
                }
            }
            return a;
        }


        public bool execute_storeTangNgayKT(string spname, string mamh, int day)
        {
            bool result = true;

            using (SqlCommand scCommand = new SqlCommand(spname, connection))
            {
                scCommand.CommandType = CommandType.StoredProcedure;
                scCommand.Parameters.Add("@MaMH", SqlDbType.Char, 10).Value = mamh;
                scCommand.Parameters.Add("@SoNgay", SqlDbType.Int).Value = day;
                scCommand.Parameters.Add("@RESULT", SqlDbType.Bit).Value = result;
                try
                {
                    if (scCommand.Connection.State == ConnectionState.Closed)
                    {
                        scCommand.Connection.Open();
                    }
                    if (DefineClass.TransactionDefault == 1)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadUncommitted);
                    }
                    if (DefineClass.TransactionDefault == 2)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                    }
                    if (DefineClass.TransactionDefault == 3)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);
                    }
                    if (DefineClass.TransactionDefault == 4)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.Serializable);
                    }
                    scCommand.Transaction = transaction;
                    scCommand.ExecuteNonQuery();
                    transaction.Commit();
                    result = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error!");
                }
                finally
                {
                    scCommand.Connection.Close();
                }
            }
            return result;
        }

        public bool store_procedureCapNhatMH(string spname, string mamh, string tenmh, string trangthai, DateTime ngayBD, DateTime ngayKT, int sl_sv, int sl_sv_duocdk)
        {

            bool result = true;
            using (SqlCommand scCommand = new SqlCommand(spname, connection))
            {
                scCommand.CommandType = CommandType.StoredProcedure;
                scCommand.Parameters.Add("@MaMH", SqlDbType.Char, 10).Value = mamh;
                scCommand.Parameters.Add("@TenMH", SqlDbType.NVarChar, 50).Value = tenmh;
                scCommand.Parameters.Add("@TrangThai", SqlDbType.NVarChar, 20).Value = trangthai;
                scCommand.Parameters.Add("@ThoiGianBD", SqlDbType.DateTime).Value = ngayBD;
                scCommand.Parameters.Add("@ThoiGianKT", SqlDbType.DateTime).Value = ngayKT;
                scCommand.Parameters.Add("@SL_SV", SqlDbType.Int).Value = sl_sv;
                scCommand.Parameters.Add("@SL_SV_DuocDK", SqlDbType.Int).Value = sl_sv_duocdk;
                scCommand.Parameters.Add("@RESULT", SqlDbType.Bit).Value = result;
                try
                {
                    if (scCommand.Connection.State == ConnectionState.Closed)
                    {
                        scCommand.Connection.Open();
                    }
                    if (DefineClass.TransactionDefault == 1)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadUncommitted);
                    }
                    if (DefineClass.TransactionDefault == 2)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                    }
                    if (DefineClass.TransactionDefault == 3)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);
                    }
                    if (DefineClass.TransactionDefault == 4)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.Serializable);
                    }
                    scCommand.Transaction = transaction;
                    scCommand.ExecuteNonQuery();
                    transaction.Commit();
                    result = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error!");
                }
                finally
                {
                    scCommand.Connection.Close();
                }
                return result;
            }
        }

        public DataTable execute_storeXemTongMonTrangThai(string spname, string trangthai)
        {
            DataTable a = new DataTable();
            using (SqlCommand scCommand = new SqlCommand(spname, connection))
            {
                scCommand.CommandType = CommandType.StoredProcedure;
                scCommand.Parameters.Add("@TrangThai", SqlDbType.NVarChar, 20).Value = trangthai;
                DataSet ds = new DataSet();
                using (SqlDataAdapter da = new SqlDataAdapter(scCommand))
                {
                    connection.Open();
                    if (DefineClass.TransactionDefault == 1)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadUncommitted);
                    }
                    if (DefineClass.TransactionDefault == 2)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                    }
                    if (DefineClass.TransactionDefault == 3)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);
                    }
                    if (DefineClass.TransactionDefault == 4)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.Serializable);
                    }
                    da.SelectCommand.Transaction = transaction;
                    da.Fill(ds);
                    a = ds.Tables[0];
                    transaction.Commit();
                    connection.Close();
                }
            }

            return a;
        }


        public bool execute_storeXoaMonHoc(string spname, string mamh)
        {

            bool result = true;
            using (SqlCommand scCommand = new SqlCommand(spname, connection))
            {
                scCommand.CommandType = CommandType.StoredProcedure;
                scCommand.Parameters.Add("@MaMH", SqlDbType.Char, 10).Value = mamh;
                scCommand.Parameters.Add("@RESULT", SqlDbType.Bit).Value = result;
                try
                {
                    if (scCommand.Connection.State == ConnectionState.Closed)
                    {
                        scCommand.Connection.Open();
                    }
                    if (DefineClass.TransactionDefault == 1)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadUncommitted);
                    }
                    if (DefineClass.TransactionDefault == 2)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.ReadCommitted);
                    }
                    if (DefineClass.TransactionDefault == 3)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.RepeatableRead);
                    }
                    if (DefineClass.TransactionDefault == 4)
                    {
                        transaction = connection.BeginTransaction(IsolationLevel.Serializable);
                    }
                    scCommand.Transaction = transaction;
                    scCommand.ExecuteNonQuery();
                    transaction.Commit();
                    result = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Error!");
                }
                finally
                {
                    scCommand.Connection.Close();
                }
                return result;
            }
        }


    }
}
