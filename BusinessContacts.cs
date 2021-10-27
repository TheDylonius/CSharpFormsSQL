using System;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Office.Interop.Excel;

namespace CSharpFormsSQL
{
    public partial class BusinessContacts : Form
    {
        // Modify with the connection string for the database we'd like to connect to.
        static readonly string connectionString = @"Data Source=DYLAN-PC;Initial Catalog=AddressBook;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static readonly string tableName = "Contacts";

        // Create the Data Table and SQL Data Adapter objects for later querying of the database.
        SqlDataAdapter dataAdapter;
        System.Data.DataTable dataTable;

        // Create the Binding Source object as an intermedium table within program memory.
        readonly BindingSource contactsTable = new BindingSource()
        {
            DataSource = "CSharpFormsSQL.BusinessContacts"
        };

        readonly OpenFileDialog imagePicker = new OpenFileDialog()
        {
            InitialDirectory = @"C:\Users\Public\Pictures",
            Filter = "Image Files|*.bmp; *.jpg; *.gif; *.png; *.tif|All Files|*.*",
            FilterIndex = 0
        };

        readonly SaveFileDialog excelExporter = new SaveFileDialog()
        {
            Filter = "Excel Files|*.xlsx"
        };

        readonly SaveFileDialog textExporter = new SaveFileDialog()
        {
            Filter = "Text Files|*.txt"
        };

        public BusinessContacts()
        {
            InitializeComponent();
        }

        public void BusinessContacts_Load(object sender, EventArgs e)
        {
            // Reset the selected index to 0.
            columnSelector.SelectedIndex = 0;

            // Set the data source of the table on the form to the Contacts table.
            FormTable.DataSource = contactsTable;

            // Execute the SELECT query against the database to pull back all records.
            ExecuteQuery($"SELECT * FROM {tableName}");
        }

        private void InputPicture_DoubleClick(object sender, EventArgs e)
        {
            if (InputPicture.Image != null)
            {
                var form = new Form()
                {
                    BackgroundImage = InputPicture.Image,
                    Size = InputPicture.Image.Size
                };

                form.Show();
            }
        }

        private void ButtonGetImage_Click(object sender, EventArgs e)
        {
            if (imagePicker.ShowDialog() == DialogResult.OK)
            {
                InputPicture.ImageLocation = imagePicker.FileName;
            }
        }

        [DllImport("user32.dll")]
        static extern int GetWindowThreadProcessId(int hWnd, out int lpdwProcessId);
        private void ButtonExportExcel_Click(object sender, EventArgs e)
        {
            var app = new Microsoft.Office.Interop.Excel.Application();
            Workbooks bk = app.Workbooks;
            var workbook = bk.Add(Type.Missing);
            var worksheet = new Worksheet();

            try
            {
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Business Contacts";

                for (int i = 1; i < FormTable.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = FormTable.Columns[i - 1].HeaderText;
                }

                for (int i = 0; i < FormTable.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < FormTable.Columns.Count; j++)
                    {
                        if (FormTable.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = FormTable.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            worksheet.Cells[i + 2, j + 1] = "";
                        }
                    }

                    if (excelExporter.ShowDialog() == DialogResult.OK)
                    {
                        app.ActiveWorkbook.SaveAs(excelExporter.FileName);
                        Process.Start(excelExporter.FileName);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                app.Quit();
                GetWindowThreadProcessId(app.Hwnd, out int Id);

                Process.GetProcessById(Id).Kill();
            }
        }

        private void ButtonExportText_Click(object sender, EventArgs e)
        {
            if (textExporter.ShowDialog() == DialogResult.OK)
            {
                using (var writer = new StreamWriter(textExporter.FileName))
                {
                    foreach(DataGridViewRow row in FormTable.Rows)
                    {
                        foreach(DataGridViewCell cell in row.Cells)
                        {
                            writer.Write(cell.Value);
                        }

                        writer.WriteLine();
                    }
                }

                Process.Start(textExporter.FileName);
            }
        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
            // Execute the SELECT query against the database to pull back the filtered records.
            ExecuteQuery($"SELECT * FROM {tableName} WHERE {columnSelector.Text} LIKE '%{inputSearch.Text}%'");
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            // Execute the INSERT query against the database to insert the new record using data from the form's input boxes.
            ExecuteQuery
            (
                $"INSERT INTO {tableName} ([Date_Added], [Company], [Website], [Title], [Forename], [Surname], [Address], [City], [County], [Postcode], [Email], [Mobile], [Notes])" +
                $"VALUES (GETDATE(), '{inputCompany.Text}', '{inputWebsite.Text}', '{inputTitle.Text}', '{inputForename.Text}', '{inputSurname.Text}', '{inputAddress.Text}', '{inputCity.Text}', '{inputCounty.Text}', '{inputPostcode.Text}', '{inputEmail.Text}', '{inputMobile.Text}', '{inputNotes.Text}')"
            );
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            var cell = FormTable.CurrentCell.OwningRow.Cells;
            string rowToDelete = cell["ID"].Value.ToString();
            string nameToDelete = cell["Forename"].Value.ToString() + " " + cell["Surname"].Value.ToString();

            if (MessageBox.Show($"Are you sure you want to delete the record for {nameToDelete}? This is irreversible.", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                ExecuteQuery($"DELETE FROM {tableName} WHERE ID = {rowToDelete}");
            }
            else
            {
                MessageBox.Show("Operation has been cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // Get the current cell's Row ID and Column Name.
            var rowId = FormTable[0, e.RowIndex].Value.ToString();
            var columnName = dataTable.Columns[e.ColumnIndex].ToString();
            var currentCellValue = FormTable[e.ColumnIndex, e.RowIndex].Value.ToString();

            // Confirm the edit has ended.
            FormTable.EndEdit();

            // Execute the UPDATE query against the database to change the current cell.
            ExecuteQuery($"UPDATE {tableName} SET {columnName} = '{currentCellValue}' WHERE ID = '{rowId}'");
        }

        private void ExecuteQuery(string query)
        {
            try
            {
                // Assign the DataAdapter and DataTable for querying the database.
                dataAdapter = new SqlDataAdapter(query, connectionString);
                dataTable = new System.Data.DataTable()
                {
                    Locale = System.Globalization.CultureInfo.InvariantCulture
                };

                // Fill the data table with the rows returned after the query.
                dataAdapter.Fill(dataTable);

                contactsTable.DataSource = dataTable;
            }
            catch (Exception error)
            {
                // Show any error which may have occured.
                MessageBox.Show(error.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Dispose of the DataAdapter and DataTable to recover resources.
                dataAdapter.Dispose();
                dataTable.Dispose();

                // Update the visible form table with the latest changes to the end database.
                //UpdateTable();
            }
        }

        private void UpdateTable()
        {
            try
            {
                // Assign the DataAdapter and DataTable for querying the database.
                dataAdapter = new SqlDataAdapter($"SELECT * FROM {tableName}", connectionString);
                dataTable = new System.Data.DataTable()
                {
                    Locale = System.Globalization.CultureInfo.InvariantCulture
                };

                // Fill the data table with the rows returned after the query.
                dataAdapter.Fill(dataTable);

                contactsTable.DataSource = dataTable;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                // Dispose of the DataAdapter and DataTable to recover resources.
                dataAdapter.Dispose();
                dataTable.Dispose();
            }
        }
    }
}