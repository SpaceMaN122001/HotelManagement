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
    public partial class FormAdmin : Form
    {
        private Dictionary<string, string> mSelectedClientInfo = new Dictionary<string, string>();

        public FormAdmin()
        {
            InitializeComponent();
            FillAllClientsToListBox();
            FillHotelRoomsInDataGridView();
            FillAllHotelRoomCategoriesInComboBox();
        }

        private void FillAllClientsToListBox()
        {
            ListBoxAllClients.Items.Clear();
            ListBoxAllClientsForSearching.Items.Clear();

            using (SqlCommand sqlCommand = new SqlCommand("SELECT FullName, Id FROM Clients", DataBase.SqlConnection))
            {
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    ListBoxAllClients.Items.Add(sqlDataReader["FullName"].ToString());
                    ListBoxAllClientsForSearching.Items.Add(sqlDataReader["FullName"].ToString());
                    mSelectedClientInfo[sqlDataReader["FullName"].ToString()] = sqlDataReader["Id"].ToString();
                }

                sqlDataReader.Close();
            }
        }

        private void FillHotelRoomsInDataGridView()
        {
            DataGridViewHotelRooms.Rows.Clear();

            using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM HotelRooms WHERE IsBusy = 0", DataBase.SqlConnection))
            {
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    DataGridViewHotelRooms.Rows.Add
                    (
                        sqlDataReader["Number"].ToString(),
                        sqlDataReader["CategoryId"].ToString(),
                        sqlDataReader["Description"].ToString(),
                        sqlDataReader["Price"].ToString(),
                        sqlDataReader["SeatsCount"].ToString()
                    );
                }

                sqlDataReader.Close();
            }
        }

        private void FillAllHotelRoomCategoriesInComboBox()
        {
            ComboBoxSelectCategoryForSearching.Items.Clear();

            using (SqlCommand sqlCommand = new SqlCommand("SELECT Id FROM Categories", DataBase.SqlConnection))
            {
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    ComboBoxSelectCategoryForSearching.Items.Add(sqlDataReader["Id"].ToString());
                }

                sqlDataReader.Close();
            }
        }

        private void ButtonAddClient_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBoxFullName.Text) || String.IsNullOrEmpty(ComboBoxSelectGender.Text) || String.IsNullOrEmpty(TextBoxPassportData.Text)
                || String.IsNullOrEmpty(ComboBoxSelectBonusCard.Text))
            {
                MessageBox.Show("Заполнены не все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO Clients VALUES(@fullname, @gender, @dateOfBirth, @passportData, @bonusCard)", DataBase.SqlConnection))
            {
                sqlCommand.Parameters.AddWithValue("@fullname", TextBoxFullName.Text);
                sqlCommand.Parameters.AddWithValue("@gender", ComboBoxSelectGender.Text);
                sqlCommand.Parameters.AddWithValue("@dateOfBirth", DateTimePickerDateOfBirth.Value.ToString("dd.MM.yyyy"));
                sqlCommand.Parameters.AddWithValue("@passportData", TextBoxPassportData.Text);
                sqlCommand.Parameters.AddWithValue("@bonusCard", ComboBoxSelectBonusCard.Text);
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Клиент добавлен", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            FillAllClientsToListBox();
        }

        private void TextBoxSearchClientSurname_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(TextBoxSearchClientSurname.Text))
            {
                FillAllClientsToListBox();
            }

            ListBoxAllClientsForSearching.Items.Clear();
            mSelectedClientInfo.Clear();

            using (SqlCommand sqlCommand = new SqlCommand("SELECT Id, FullName FROM Clients WHERE FullName LIKE @searchSurname", DataBase.SqlConnection))
            {
                sqlCommand.Parameters.AddWithValue("@searchSurname", TextBoxSearchClientSurname.Text + '%');
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    ListBoxAllClientsForSearching.Items.Add(sqlDataReader["FullName"].ToString());
                    mSelectedClientInfo[sqlDataReader["FullName"].ToString()] = sqlDataReader["Id"].ToString();
                }

                sqlDataReader.Close();
            }
        }

        private void ButtonContractForm_Click(object sender, EventArgs e)
        {
            int daysCount = DateTimePickerDateOfDeparture.Value.Day - DateTimePickerDateOfCheckIn.Value.Day;

            if (daysCount <= 0)
            {
                MessageBox.Show("Введите корректную дату", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string clientBonusCard = DataBase.GetQueryValue("SELECT BonusCard FROM Clients WHERE Id = " + mSelectedClientInfo[ListBoxAllClientsForSearching.SelectedItem.ToString()]).ToString();
            int hotelRoomPrice = Convert.ToInt32(DataBase.GetQueryValue("SELECT Price FROM HotelRooms WHERE Number = " + TextBoxSelectedHotelRoomNumberFromDataGridView.Text));
            int paymentAmount = daysCount * hotelRoomPrice;

            if (clientBonusCard == "Обычная")
            {
                paymentAmount -= hotelRoomPrice / 100 * 1;
            }
            else if (clientBonusCard == "Золотая")
            {
                paymentAmount -= hotelRoomPrice / 100 * 3;
            }
            else if (clientBonusCard == "Платиновая")
            {
                paymentAmount -= hotelRoomPrice / 100 * 5;
            }

            /*MessageBox.Show(DateTime.Now.ToString("dd.MM.yyyy"));
            MessageBox.Show(mSelectedClientInfo[ListBoxAllClientsForSearching.SelectedItem.ToString()]);
            MessageBox.Show(TextBoxSelectedHotelRoomNumberFromDataGridView.Text);
            MessageBox.Show(DateTimePickerDateOfCheckIn.Value.ToString("dd.MM.yyyy"));
            MessageBox.Show(DateTimePickerDateOfDeparture.Value.ToString("dd.MM.yyyy"));
            MessageBox.Show(Convert.ToString(paymentAmount));*/

            using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO Contracts VALUES(@dateOfRegistration, @clientId, @hotelRoomNumber, @dateOfCheckIn, @dateOfDeparture, @paymentAmount, 1) UPDATE HotelRooms SET IsBusy = 1 WHERE Number = @SelectedHotelRoomNumber", DataBase.SqlConnection))
            {
                sqlCommand.Parameters.AddWithValue("@dateOfRegistration", DateTime.Now.ToString("dd.MM.yyyy"));
                sqlCommand.Parameters.AddWithValue("@clientId", mSelectedClientInfo[ListBoxAllClientsForSearching.SelectedItem.ToString()]);
                sqlCommand.Parameters.AddWithValue("@hotelRoomNumber", TextBoxSelectedHotelRoomNumberFromDataGridView.Text);
                sqlCommand.Parameters.AddWithValue("@dateOfCheckIn", DateTimePickerDateOfCheckIn.Value.ToString("dd.MM.yyyy"));
                sqlCommand.Parameters.AddWithValue("@dateOfDeparture", DateTimePickerDateOfDeparture.Value.ToString("dd.MM.yyyy"));
                sqlCommand.Parameters.AddWithValue("@paymentAmount", paymentAmount);
                sqlCommand.Parameters.AddWithValue("@SelectedHotelRoomNumber", TextBoxSelectedHotelRoomNumberFromDataGridView.Text);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Договор оформлен", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            FillHotelRoomsInDataGridView();
        }

        private void ButtonFillAllHotelRooms_Click(object sender, EventArgs e)
        {
            FillHotelRoomsInDataGridView();
        }

        private void CheckBoxEnableSearchingByCategory_CheckStateChanged(object sender, EventArgs e)
        {
            if (CheckBoxEnableSearchingByCategory.Checked)
            {
                ComboBoxSelectCategoryForSearching.Enabled = true;
            }
            else
                ComboBoxSelectCategoryForSearching.Enabled = false;
        }

        private void CheckBoxEnableSearchingByPrice_CheckStateChanged(object sender, EventArgs e)
        {
            if (CheckBoxEnableSearchingByPrice.Checked)
            {
                TextBoxHotelToomPriceForSearching.Enabled = true;
            }
            else
                TextBoxHotelToomPriceForSearching.Enabled = false;
        }

        private void CheckBoxEnableSearchingBySeatsCount_CheckStateChanged(object sender, EventArgs e)
        {
            if (CheckBoxEnableSearchingBySeatsCount.Checked)
            {
                TextBoxSeatsCountForSearching.Enabled = true;
            }
            else
                TextBoxSeatsCountForSearching.Enabled = false;
        }

        private void ButtonSearchHotelRoom_Click(object sender, EventArgs e)
        {
            DataGridViewHotelRooms.Rows.Clear();

            string queryText = "SELECT * FROM HotelRooms WHERE IsBusy = 0";

            if (CheckBoxEnableSearchingByCategory.Checked)
            {
                queryText += " AND CategoryId = " + "'" + ComboBoxSelectCategoryForSearching.Text + "'";
            }
            if (CheckBoxEnableSearchingByPrice.Checked)
            {
                queryText += " AND Price <= " + TextBoxHotelToomPriceForSearching.Text;
            }
            if (CheckBoxEnableSearchingBySeatsCount.Checked)
            {
                queryText += " AND SeatsCount = " + TextBoxSeatsCountForSearching.Text;
            }

            using (SqlCommand sqlCommand = new SqlCommand(queryText, DataBase.SqlConnection))
            {
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    DataGridViewHotelRooms.Rows.Add
                    (
                        sqlDataReader["Number"].ToString(),
                        sqlDataReader["CategoryId"].ToString(),
                        sqlDataReader["Description"].ToString(),
                        sqlDataReader["Price"].ToString(),
                        sqlDataReader["SeatsCount"].ToString()
                    );
                }

                sqlDataReader.Close();
            }
        }

        private void DataGridViewHotelRooms_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DataGridViewHotelRooms.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    TextBoxSelectedHotelRoomNumberFromDataGridView.Text = DataGridViewHotelRooms.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                }
            }
            catch { }
        }
    }
}
