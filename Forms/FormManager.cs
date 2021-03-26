using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelManagement;
using System.Data.SqlClient;

namespace HotelManagement.Forms
{
    public partial class FormManager : Form
    {
        private Dictionary<string, string> mClientsInfo = new Dictionary<string, string>();
        public FormManager()
        {
            InitializeComponent();
            FillAllClientsForDeparturingInDataGridView();
        }

        private void FillAllClientsForDeparturingInDataGridView()
        {
            DataGridViewAllClientsForDeparturing.Rows.Clear();
            mClientsInfo.Clear();
            ComboBoxSelectClientForDeparturing.Items.Clear();

            using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Contracts WHERE DateOfDeparture = @nowDate AND isWork = 1", DataBase.SqlConnection))
            {
                sqlCommand.Parameters.AddWithValue("@nowDate", DateTime.Now.ToString("dd.MM.yyyy"));
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string clientFullName = DataBase.GetQueryValue("SELECT FullName FROM Clients WHERE Id = " + sqlDataReader["ClientId"].ToString()).ToString();
                    DataGridViewAllClientsForDeparturing.Rows.Add
                    (
                        sqlDataReader["Id"].ToString(),
                        sqlDataReader["HotelRoomNumber"].ToString(),
                        clientFullName,
                        sqlDataReader["DateOfCheckIn"].ToString(),
                        sqlDataReader["DateOfDeparture"].ToString()
                    );
                    mClientsInfo[clientFullName] = sqlDataReader["ClientId"].ToString();
                    ComboBoxSelectClientForDeparturing.Items.Add(clientFullName);
                }

                sqlDataReader.Close();
            }
        }

        private void ButtonSearchClientsForDeparturing_Click(object sender, EventArgs e)
        {
            DataGridViewAllClientsForDeparturing.Rows.Clear();
            mClientsInfo.Clear();
            ComboBoxSelectClientForDeparturing.Items.Clear();

            using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Contracts WHERE DateOfDeparture = @selectDate AND isWork = 1", DataBase.SqlConnection))
            {
                string selectedDate = DateTimePickerClientDeparture.Value.ToString("dd.MM.yyyy");
                sqlCommand.Parameters.AddWithValue("@selectDate", selectedDate);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    string clientFullName = DataBase.GetQueryValue("SELECT FullName FROM Clients WHERE Id = " + sqlDataReader["ClientId"].ToString()).ToString();
                    DataGridViewAllClientsForDeparturing.Rows.Add
                    (
                        sqlDataReader["Id"].ToString(),
                        sqlDataReader["HotelRoomNumber"].ToString(),
                        clientFullName,
                        sqlDataReader["DateOfCheckIn"].ToString(),
                        sqlDataReader["DateOfDeparture"].ToString()
                    );
                    mClientsInfo[clientFullName] = sqlDataReader["ClientId"].ToString();
                    ComboBoxSelectClientForDeparturing.Items.Add(clientFullName);
                }

                sqlDataReader.Close();
            }
        }

        private void ButtonDepartureClient_Click(object sender, EventArgs e)
        {
            string hotelRoomNumber = DataBase.GetQueryValue("SELECT HotelRoomNumber FROM Contracts WHERE ClientId = " + mClientsInfo[ComboBoxSelectClientForDeparturing.Text]).ToString();

            using (SqlCommand sqlCommand = new SqlCommand("UPDATE Contracts SET IsWork = 0 WHERE ClientId = @selectClient" +
                " UPDATE HotelRooms SET IsBusy = 0 WHERE Number = @hotelRoomNumber", DataBase.SqlConnection))
            {
                sqlCommand.Parameters.AddWithValue("@selectClient", mClientsInfo[ComboBoxSelectClientForDeparturing.Text]);
                sqlCommand.Parameters.AddWithValue("@hotelRoomNumber", hotelRoomNumber);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Клиент выселен", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            FillAllClientsForDeparturingInDataGridView();
        }

        private void ButtonGenerateReport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application excelApplication = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workBook;
            Microsoft.Office.Interop.Excel.Worksheet workSheet;
            workBook = excelApplication.Workbooks.Add();
            workSheet = (Microsoft.Office.Interop.Excel.Worksheet)workBook.Worksheets.Item[1];
            workSheet.Name = "Report";
            int rowCount = 1;

            using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Categories", DataBase.SqlConnection))
            {
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                string suma = null;

                while (sqlDataReader.Read())
                {
                    workSheet.Cells[rowCount, 1] = sqlDataReader["Id"].ToString();
                    workSheet.Cells[rowCount, 2] = sqlDataReader["Description"].ToString();

                    SqlConnection sqlConnection = new SqlConnection(DataBase.StringConnection);
                    sqlConnection.Open();

                    using (SqlCommand command = new SqlCommand("SELECT SUM(PaymentAmount) FROM Contracts WHERE (SELECT CategoryId FROM HotelRooms WHERE Number = HotelRoomNumber) = @categoryId AND DateOfRegistration >= @dateOfBegin AND DateOfRegistration <= @dateOfEnd", sqlConnection))
                    {
                        command.Parameters.AddWithValue("@categoryId", sqlDataReader["Id"].ToString());
                        command.Parameters.AddWithValue("@dateOfBegin", DateTimePickerGenerateReportFrom.Value.ToString("dd.MM.yyyy"));
                        command.Parameters.AddWithValue("@dateOfEnd", DateTimePickerGenerateReportTo.Value.ToString("dd.MM.yyyy"));
                        SqlDataReader reader = command.ExecuteReader();
                        reader.Read();
                        suma = reader.GetValue(0).ToString();
                        reader.Close();
                        sqlConnection.Close();
                    }

                    workSheet.Cells[rowCount, 3] = suma;
                    rowCount++;
                }

                sqlDataReader.Close();
            }

            using (SqlCommand sqlCommand = new SqlCommand("SELECT SUM(PaymentAmount) FROM Contracts WHERE DateOfRegistration >= @dateOfBegin AND DateOfRegistration <= @dateOfEnd", DataBase.SqlConnection))
            {
                sqlCommand.Parameters.AddWithValue("@dateOfBegin", DateTimePickerGenerateReportFrom.Value.ToString("dd.MM.yyyy"));
                sqlCommand.Parameters.AddWithValue("@dateOfEnd", DateTimePickerGenerateReportTo.Value.ToString("dd.MM.yyyy"));
                SqlDataReader reader = sqlCommand.ExecuteReader();
                reader.Read();
                string totalSum = reader.GetValue(0).ToString();
                reader.Close();
                workSheet.Cells[rowCount, 1] = totalSum;
            }

            using (SqlCommand sqlCommand = new SqlCommand("SELECT COUNT(*) FROM Contracts WHERE DateOfRegistration >= @dateOfBegin AND DateOfRegistration <= @dateOfEnd", DataBase.SqlConnection))
            {
                sqlCommand.Parameters.AddWithValue("@dateOfBegin", DateTimePickerGenerateReportFrom.Value.ToString("dd.MM.yyyy"));
                sqlCommand.Parameters.AddWithValue("@dateOfEnd", DateTimePickerGenerateReportTo.Value.ToString("dd.MM.yyyy"));
                SqlDataReader reader = sqlCommand.ExecuteReader();
                reader.Read();
                string totalContractsCount = reader.GetValue(0).ToString();
                reader.Close();
                workSheet.Cells[rowCount, 2] = totalContractsCount;
            }

            excelApplication.Visible = true;
            excelApplication.UserControl = true;
        }
    }
}
