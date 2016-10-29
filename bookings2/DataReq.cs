using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bookings2
{
    class DataReq
    {

        public static void DataFill(string orderBy, DateTime date)
        {
            OleDbConnection cnn = new OleDbConnection(Properties.Resources.DatabaseConnectionString);

            OleDbCommand cmd = new OleDbCommand("SELECT * FROM BNUMBERS WHERE @orderBy = @date", cnn);
            cmd.Parameters.AddWithValue("orderBy", orderBy);
            cmd.Parameters.AddWithValue("date", date);

            cmd.ExecuteNonQuery();
        }

        public static List<string> tourArray()
        {
            List<string> tourNames = new List<string>();
            using (OleDbConnection cnn = new OleDbConnection(Properties.Resources.DatabaseConnectionString))
            {
                OleDbDataAdapter da = new OleDbDataAdapter("select TourName from Tours", cnn);
                DataSet ds = new DataSet();
                da.Fill(ds, "Tours");
                
                foreach (DataRow row in ds.Tables["Tours"].Rows)
                {
                    tourNames.Add(row["TourName"].ToString());
                }
            };
            return tourNames;
        }

        public static bool LoginCheck(string userName, string password)
        {
            OleDbConnection cnn = new OleDbConnection(Properties.Resources.DatabaseConnectionString);

            string cmdString = ("SELECT * FROM EMP WHERE EmpID = @uname AND Pass = @pw");
            OleDbCommand cmd = new OleDbCommand(cmdString, cnn);

            cmd.Parameters.AddWithValue("uname", userName);
            cmd.Parameters.AddWithValue("pw", password);

            DataSet loginData = new DataSet();
            OleDbDataAdapter dataAdapter;

            try
            {
                if (cnn.State.Equals(ConnectionState.Closed))
                {
                    cnn.Open();

                    dataAdapter = new OleDbDataAdapter(cmd);
                    dataAdapter.Fill(loginData);

                    cnn.Close();

                    if (loginData != null)
                    {
                        if (loginData.Tables[0].Rows.Count > 0)
                        {
                            return true;
                        }

                        else
                        {

                        }
                    }
                }
            }

            catch (Exception er)
            {
                MessageBox.Show(" " + er);
                return false;
            }

            return false;
        }

        public static int GetRefNumber()
        {
            OleDbConnection cnn = new OleDbConnection(Properties.Resources.DatabaseConnectionString);

            string cmdString = ("SELECT TOP 1 BNumber FROM BNumbers ORDER BY Bnumber DESC;");
            OleDbCommand cmd = new OleDbCommand(cmdString, cnn);

            DataSet Bnumber = new DataSet();
            DataTable table = new DataTable();
            OleDbDataAdapter dataAdapter;

            dataAdapter = new OleDbDataAdapter(cmd);
            dataAdapter.Fill(Bnumber);

            int rowNum = int.Parse(Bnumber.Tables[0].Rows[0][0].ToString());
            return rowNum + 1;
        }

        public static void AddEntry(string pax, string name, string pickup, string hotelID, DateTime travelDate, string rate, string payment, string type, string McCombs, string notes)
        {
            OleDbConnection cnn = new OleDbConnection(Properties.Resources.DatabaseConnectionString);
            int tour;


            cnn.Open();
            OleDbCommand IDcmd = new OleDbCommand("SELECT TourID FROM TOURS WHERE TourName = @type", cnn);
            IDcmd.Parameters.AddWithValue("type", type);

            DataSet TourId = new DataSet();
            OleDbDataAdapter adapter = new OleDbDataAdapter(IDcmd);
            try {
                adapter.Fill(TourId);
            }

            catch (Exception ex) { MessageBox.Show("" + ex); }

            if (int.TryParse(TourId.Tables[0].Rows[0][0].ToString(), out tour))
            {
                tour = int.Parse(TourId.Tables[0].Rows[0][0].ToString());
            }

            else
            {
                tour = 0;
            }

            try
            {
                if (cnn.State.Equals(ConnectionState.Closed)) {
                    cnn.Open();
                }

                OleDbCommand cmd = new OleDbCommand(
                    "INSERT INTO BNUMBERS VALUES( @BNumber, @Pax, @Name, @Pickup, @hotelID, @BookedDate, @TravelDate, @McCombs, @Rate, @Payment, @Type,  @EmpID, @notes)", cnn);

                cmd.Parameters.Add(new OleDbParameter { Value = GetRefNumber() });
                cmd.Parameters.Add(new OleDbParameter { Value = int.Parse(pax) });
                cmd.Parameters.Add(new OleDbParameter { Value = name });
                cmd.Parameters.Add(new OleDbParameter { Value = pickup });
                cmd.Parameters.Add(new OleDbParameter { Value = int.Parse(hotelID) });
                cmd.Parameters.Add(new OleDbParameter { Value = DateTime.Today.ToShortDateString() });
                cmd.Parameters.Add(new OleDbParameter { Value = travelDate });
                cmd.Parameters.Add(new OleDbParameter { Value = int.Parse(McCombs) });
                cmd.Parameters.Add(new OleDbParameter { Value = Decimal.Parse(rate) });
                cmd.Parameters.Add(new OleDbParameter { Value = payment });
                cmd.Parameters.Add(new OleDbParameter { Value = tour });

                cmd.Parameters.Add(new OleDbParameter { Value = Forms.BaseMenu.empNumber });
                cmd.Parameters.Add(new OleDbParameter { Value = notes });

                /*
                    cmd.Parameters.AddWithValue("BNumber", GetRefNumber());
                    cmd.Parameters.AddWithValue("Pax", int.Parse(pax));
                    cmd.Parameters.AddWithValue("Name", name);
                    cmd.Parameters.AddWithValue("Pickup", pickup);
                    cmd.Parameters.AddWithValue("BookedDate", "#"+ DateTime.Today.ToShortDateString() + "#");
                    cmd.Parameters.AddWithValue("TravelDate", "#" + travelDate + "#");
                    cmd.Parameters.AddWithValue("Rate", int.Parse(rate));
                    cmd.Parameters.AddWithValue("Payment", payment);
                    cmd.Parameters.AddWithValue("Type", tour);
                    cmd.Parameters.AddWithValue("McCombs", int.Parse(McCombs));
                    cmd.Parameters.AddWithValue("EmpID", Forms.BaseMenu.empNumber);
                    */
                cmd.ExecuteNonQuery();

            }

            catch (OleDbException ex)
            {
                MessageBox.Show("Something went wrong. Please check all values are correct." + ex);
            }

            cnn.Close();
        }

        public static void fillComboBoxTours(ComboBox comboBox)
        {
            OleDbConnection cnn = new OleDbConnection(Properties.Resources.DatabaseConnectionString);

            OleDbCommand cmd = new OleDbCommand("SELECT tourName FROM TOURS WHERE TourID <> 0;", cnn);
            DataSet TourNames = new DataSet();
            OleDbDataAdapter tourAdapter = new OleDbDataAdapter(cmd);
            try {

                tourAdapter.Fill(TourNames);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

            DataView view = TourNames.Tables[0].DefaultView;
            comboBox.DataSource = view;
            comboBox.DisplayMember = "TourName";
            comboBox.ValueMember = "TourName";

            /*  DataView dv=glObalDataSet.Tables["JOBURI"].DefaultView;
                dv.RowFilter="CONT = '" + comboBox1.SelectedValue.ToString() + "'";
                comboBox2.DataSource=dv;
                comboBox2.DisplayMember="JOB";
                comboBox2.ValueMember="ID";
            */


        }

        public static void addHotel(string name, string num, string email)
        {
            OleDbConnection cnn = new OleDbConnection(Properties.Resources.DatabaseConnectionString);

            try
            {
                if (cnn.State.Equals(ConnectionState.Closed))
                {
                    cnn.Open();
                }


                OleDbCommand cmd = new OleDbCommand("INSERT INTO HOTELS(H_name, H_number, H_email) VALUES(@Name, @number, @email)", cnn);
                cmd.Parameters.Add(new OleDbParameter { Value = name });
                cmd.Parameters.Add(new OleDbParameter { Value = num });
                cmd.Parameters.Add(new OleDbParameter { Value = email });

                cmd.ExecuteNonQuery();

                cnn.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show("an error occurred. Error 501 \n" + ex, "error 501");
            }
        }

        public static void addCredit(string creditType, string tour, DateTime date, string hotel, string pax, string rate)
        {
            OleDbConnection cnn = new OleDbConnection(Properties.Resources.DatabaseConnectionString);
            int tourID;


            cnn.Open();
            OleDbCommand IDcmd = new OleDbCommand("SELECT TourID FROM TOURS WHERE TourName = @type", cnn);
            IDcmd.Parameters.AddWithValue("type", tour);

            DataSet TourId = new DataSet();
            OleDbDataAdapter adapter = new OleDbDataAdapter(IDcmd);
            try
            {
                adapter.Fill(TourId);
            }

            catch (Exception ex) { MessageBox.Show("" + ex); }

            if (int.TryParse(TourId.Tables[0].Rows[0][0].ToString(), out tourID))
            {
                tourID = int.Parse(TourId.Tables[0].Rows[0][0].ToString());
            }

            else
            {
                tourID = 0;
            }

            if (creditType == "Yard")
            {
                try
                {
                    
                    OleDbCommand cmd = new OleDbCommand("INSERT INTO YARDCC(Date_Taken, TourID, HotelID, pax, Rate, EmpID) VALUES(@Date, @Tour, @HotelID, @pax, @rate, @empID)", cnn);
                    cmd.Parameters.Add(new OleDbParameter { Value = date.Date });
                    cmd.Parameters.Add(new OleDbParameter { Value = tourID });
                    cmd.Parameters.Add(new OleDbParameter { Value = int.Parse(hotel) });
                    cmd.Parameters.Add(new OleDbParameter { Value = int.Parse(pax) });
                    cmd.Parameters.Add(new OleDbParameter { Value = Decimal.Parse(rate) });
                    cmd.Parameters.Add(new OleDbParameter { Value = Forms.BaseMenu.empNumber });

                    cmd.ExecuteNonQuery();
                }


                catch (Exception ex)
                {
                    MessageBox.Show("an error occurred. Error 501 \n" + ex, "error 501");
                }

                OleDbCommand MainCCCheck = new OleDbCommand("SELECT * FROM MAINCC WHERE CCDate = @Date AND HotelID = @ID", cnn);
                MainCCCheck.Parameters.Add(new OleDbParameter { Value = date.Date });
                MainCCCheck.Parameters.Add(new OleDbParameter { Value = int.Parse(hotel) });

                DataSet ch = new DataSet();
                OleDbDataAdapter adap = new OleDbDataAdapter(MainCCCheck);
                adap.Fill(ch);

                if (ch.Tables[0].Rows.Count == 0)
                {
                    OleDbCommand addCreditOn = new OleDbCommand("INSERT INTO MAINCC(CCDate, HotelID, Total, YardCC) VALUES(@Date, @ID, @Total, @CC)", cnn);
                    addCreditOn.Parameters.Add(new OleDbParameter { Value = date.Date });
                    addCreditOn.Parameters.Add(new OleDbParameter { Value = int.Parse(hotel) });
                    addCreditOn.Parameters.Add(new OleDbParameter { Value = Decimal.Parse(rate) });
                    addCreditOn.Parameters.Add(new OleDbParameter { Value = Decimal.Parse(rate) });

                    addCreditOn.ExecuteNonQuery();
                }

                if (ch.Tables[0].Rows.Count > 0)
                {
                    OleDbCommand addCreditOn = new OleDbCommand("UPDATE MAINCC SET Total = @total, YardCC = @cc WHERE CCDate = @date AND HotelID = @id", cnn);
                    addCreditOn.Parameters.Add(new OleDbParameter { Value = Decimal.Parse(ch.Tables[0].Rows[0][2].ToString()) + Decimal.Parse(rate) });
                    addCreditOn.Parameters.Add(new OleDbParameter { Value = Decimal.Parse(ch.Tables[0].Rows[0][4].ToString()) + Decimal.Parse(rate) });
                    addCreditOn.Parameters.Add(new OleDbParameter { Value = date.Date });
                    addCreditOn.Parameters.Add(new OleDbParameter { Value = int.Parse(hotel) });


                    addCreditOn.ExecuteNonQuery();
                }
            }


            else
            {
                try
                {
                    if (cnn.State.Equals(ConnectionState.Closed))
                    {
                        cnn.Open();
                    }


                    OleDbCommand cmd = new OleDbCommand("INSERT INTO CREDIT(Date_Taken, TourID, HotelID, pax, Rate, EmpID) VALUES(@Date, @Tour, @HotelID, @pax, @rate, @empID)", cnn);
                    cmd.Parameters.Add(new OleDbParameter { Value = date.Date });
                    cmd.Parameters.Add(new OleDbParameter { Value = tourID });
                    cmd.Parameters.Add(new OleDbParameter { Value = int.Parse(hotel) });
                    cmd.Parameters.Add(new OleDbParameter { Value = int.Parse(pax) });
                    cmd.Parameters.Add(new OleDbParameter { Value = Decimal.Parse(rate) });
                    cmd.Parameters.Add(new OleDbParameter { Value = Forms.BaseMenu.empNumber });

                    cmd.ExecuteNonQuery();
                }


                catch (Exception ex)
                {
                    MessageBox.Show("an error occurred. Error 501 \n" + ex, "error 501");
                }

                OleDbCommand MainCCCheck = new OleDbCommand("SELECT * FROM MAINCC WHERE CCDate = @Date AND HotelID = @ID", cnn);
                MainCCCheck.Parameters.Add(new OleDbParameter { Value = date.Date });
                MainCCCheck.Parameters.Add(new OleDbParameter { Value = int.Parse(hotel) });

                DataSet ch = new DataSet();
                OleDbDataAdapter adap = new OleDbDataAdapter(MainCCCheck);
                adap.Fill(ch);

                if (ch.Tables[0].Rows.Count == 0)
                {
                    OleDbCommand addCreditOn = new OleDbCommand("INSERT INTO MAINCC(CCDate, HotelID, Total, OfficeCC) VALUES(@Date, @ID, @Total, @CC)", cnn);
                    addCreditOn.Parameters.Add(new OleDbParameter { Value = date.Date });
                    addCreditOn.Parameters.Add(new OleDbParameter { Value = int.Parse(hotel) });
                    addCreditOn.Parameters.Add(new OleDbParameter { Value = Decimal.Parse(rate) });
                    addCreditOn.Parameters.Add(new OleDbParameter { Value = Decimal.Parse(rate) });

                    addCreditOn.ExecuteNonQuery();
                }

                if (ch.Tables[0].Rows.Count > 0)
                {
                    OleDbCommand addCreditOn = new OleDbCommand("UPDATE MAINCC SET Total = @total, OfficeCC = @cc WHERE CCDate = @date AND HotelID = @id", cnn);
                    addCreditOn.Parameters.Add(new OleDbParameter { Value = Decimal.Parse(ch.Tables[0].Rows[0][2].ToString()) + Decimal.Parse(rate) });
                    addCreditOn.Parameters.Add(new OleDbParameter { Value = Decimal.Parse(ch.Tables[0].Rows[0][4].ToString()) + Decimal.Parse(rate) });
                    addCreditOn.Parameters.Add(new OleDbParameter { Value = date.Date });
                    addCreditOn.Parameters.Add(new OleDbParameter { Value = int.Parse(hotel) });


                    addCreditOn.ExecuteNonQuery();
                }
            }




            if (cnn.State.Equals(ConnectionState.Open))
            {
                cnn.Close();
            }

        }
    

        public static bool checkAdmin(int id)
        {
            OleDbConnection cnn = new OleDbConnection(Properties.Resources.DatabaseConnectionString);

            try
            {
                if (cnn.State.Equals(ConnectionState.Closed))
                {
                    cnn.Open();
                }

                string cmdString = ("SELECT Admin FROM EMP WHERE EmpID = @id");
                OleDbCommand cmd = new OleDbCommand(cmdString, cnn);
                cmd.Parameters.Add(new OleDbParameter { Value = id });


                DataSet Admin = new DataSet();
                DataTable table = new DataTable();
                OleDbDataAdapter dataAdapter;

                dataAdapter = new OleDbDataAdapter(cmd);
                dataAdapter.Fill(Admin);

                return bool.Parse(Admin.Tables[0].Rows[0][0].ToString());

            }

            catch(Exception e) { MessageBox.Show("Error 401 \n " + e); return false; }
        }
    }

    }

