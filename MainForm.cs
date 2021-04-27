using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MPT_PC_DB
{
    public partial class MainForm : Form
    {

        public string conString = @"Data Source=LAPTOP-GTKGDTGS\NIKITASERVER;Initial Catalog=MPT_PC;Integrated Security=True";

        private SqlConnection connection;
        private SqlCommand command;
        private DataSet dataSet;
        private SqlDataAdapter dataAdapter;

        public MainForm()
        {
            InitializeComponent();
            GetTable();
        }

        private void GetTable()
        {
            connection = new SqlConnection(conString);
            try
            {
                connection.Open();
                dataAdapter = new SqlDataAdapter("SELECT * FROM dbo.PC", connection);
                dataSet = new DataSet();
                DataTable dt = dataSet.Tables.Add("dbo.PC");
                dataAdapter.Fill(dt);
                All_PC_dataFrid.DataSource = dataSet.Tables["dbo.PC"];

                PCidBox.DataSource = dataSet.Tables["dbo.PC"];
                PCidBox.DisplayMember = "ID_PC";
                PCidBox.ValueMember = "ID_PC";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        private void saveBtn_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(conString);
            if (CheckBoxFill() == true)
            {
                try
                {
                    connection.Open();
                    command = new SqlCommand($"INSERT INTO dbo.PC (GraphicCard_Name, Processor_Name, OZU_Amount, HDD_Amount, OS_Name, Building_Name, Cabinet_Num, Programm_List) VALUES ('{graphicCardBox.Text}', '{processorBox.Text}', '{ozuBox.Text}', '{HDDBox.Text}', '{OSBox.Text}', '{buildingNameBox.Text}', '{cabinetNumBox.Text}', '{programmListBox.Text}')", connection);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
                GetTable();
            }
        }

        private void All_PC_dataFrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            graphicCardBox.Text = All_PC_dataFrid.Rows[e.RowIndex].Cells[1].Value.ToString();
            processorBox.Text = All_PC_dataFrid.Rows[e.RowIndex].Cells[2].Value.ToString();
            ozuBox.Text = All_PC_dataFrid.Rows[e.RowIndex].Cells[3].Value.ToString();
            HDDBox.Text = All_PC_dataFrid.Rows[e.RowIndex].Cells[4].Value.ToString();
            OSBox.Text = All_PC_dataFrid.Rows[e.RowIndex].Cells[5].Value.ToString();
            buildingNameBox.Text = All_PC_dataFrid.Rows[e.RowIndex].Cells[6].Value.ToString();
            cabinetNumBox.Text = All_PC_dataFrid.Rows[e.RowIndex].Cells[7].Value.ToString();
            programmListBox.Text = All_PC_dataFrid.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private bool CheckBoxFill()
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(graphicCardBox.Text) && !string.IsNullOrWhiteSpace(processorBox.Text) &&
                    int.Parse(ozuBox.Text) > 0 && int.Parse(HDDBox.Text) > 0 &&
                    !string.IsNullOrWhiteSpace(OSBox.Text) && !string.IsNullOrWhiteSpace(buildingNameBox.Text) &&
                    (int.Parse(cabinetNumBox.Text) > 0 && int.Parse(cabinetNumBox.Text) < 400) &&
                    !string.IsNullOrWhiteSpace(programmListBox.Text))
                    return true;
                else
                {
                    MessageBox.Show("Не все поля были заполнены");
                    return false;
                }
            }
            catch
            {
                MessageBox.Show("Неверные значения у полей");
                return false;
            }
        }

        string GraphicCard_Name, Processor_Name, OZU_Amount, HDD_Amount, OS_Name, Building_Name, Cabinet_Num, Programm_List;

        private void clearAllBoxButton_Click(object sender, EventArgs e)
        {
            graphicCardBox.Text = "";
            processorBox.Text = "";
            ozuBox.Text = "";
            HDDBox.Text = "";
            OSBox.Text = "";
            cabinetNumBox.Text = "";
            programmListBox.Text = "";
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(conString);
            try
            {
                connection.Open();
                command = new SqlCommand($"DELETE FROM dbo.PC WHERE ID_PC = '{All_PC_dataFrid.SelectedRows[0].Cells[0].Value}'", connection);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            GetTable();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(conString);
            try
            {
                if (CheckBoxFill() == true)
                {
                    connection.Open();
                    command = new SqlCommand($"UPDATE dbo.PC SET GraphicCard_Name='{graphicCardBox.Text}', Processor_Name='{processorBox.Text}', OZU_Amount='{ozuBox.Text}', HDD_Amount='{HDDBox.Text}', OS_Name='{OSBox.Text}', Building_Name='{buildingNameBox.Text}', Cabinet_Num='{cabinetNumBox.Text}', Programm_List='{programmListBox.Text}' WHERE ID_PC ='{All_PC_dataFrid.SelectedRows[0].Cells[0].Value}'", connection);
                    command.ExecuteNonQuery();  
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            GetTable();
        }

        private void saveQR_Click(object sender, EventArgs e)
        {
            QRCodeBox.Image.Save($@"C:\Users\nikit\Desktop\PC_QRCodes\pcID_{PCidBox.Text}.png", System.Drawing.Imaging.ImageFormat.Png);
        }

        private void GetAllPCSpecs(int PC_ID)
        {
            connection = new SqlConnection(conString);
            try
            {
                connection.Open();
                command = new SqlCommand($"SELECT GraphicCard_Name FROM dbo.PC WHERE ID_PC = '{PC_ID}'", connection);
                GraphicCard_Name = command.ExecuteScalar().ToString();
                command = new SqlCommand($"SELECT Processor_Name FROM dbo.PC WHERE ID_PC = '{PC_ID}'", connection);
                Processor_Name = command.ExecuteScalar().ToString();
                command = new SqlCommand($"SELECT OZU_Amount FROM dbo.PC WHERE ID_PC = '{PC_ID}'", connection);
                OZU_Amount = command.ExecuteScalar().ToString();
                command = new SqlCommand($"SELECT HDD_Amount FROM dbo.PC WHERE ID_PC = '{PC_ID}'", connection);
                HDD_Amount = command.ExecuteScalar().ToString();
                command = new SqlCommand($"SELECT OS_Name FROM dbo.PC WHERE ID_PC = '{PC_ID}'", connection);
                OS_Name = command.ExecuteScalar().ToString();
                command = new SqlCommand($"SELECT Building_Name FROM dbo.PC WHERE ID_PC = '{PC_ID}'", connection);
                Building_Name = command.ExecuteScalar().ToString();
                command = new SqlCommand($"SELECT Cabinet_Num FROM dbo.PC WHERE ID_PC = '{PC_ID}'", connection);
                Cabinet_Num = command.ExecuteScalar().ToString();
                command = new SqlCommand($"SELECT Programm_List FROM dbo.PC WHERE ID_PC = '{PC_ID}'", connection);
                Programm_List = command.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }


        private void createQRButton_Click(object sender, EventArgs e)
        {
            GetAllPCSpecs(int.Parse(PCidBox.Text));

            string Message = $"Видеокарта: {GraphicCard_Name}\r\nПроцессор: {Processor_Name}\r\nОЗУ: {OZU_Amount}\r\nHDD: {HDD_Amount}\r\nОС: {OS_Name}\r\nЗдание: {Building_Name}\r\nКабинет: {Cabinet_Num}\r\nСписок программ: {Programm_List}";

            QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
            var MyData = QG.CreateQrCode(Message, QRCoder.QRCodeGenerator.ECCLevel.M);
            var code = new QRCoder.QRCode(MyData);
            QRCodeBox.Image = code.GetGraphic(3);
            saveQR.Enabled = true;
        }

        private void createForAllAndSave_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < All_PC_dataFrid.RowCount; i++)
            {
                int ID_PC = Convert.ToInt32(All_PC_dataFrid.Rows[i].Cells[0].Value);
                GetAllPCSpecs(ID_PC);

                string Message = $"Видеокарта: {GraphicCard_Name}\r\nПроцессор: {Processor_Name}\r\nОЗУ: {OZU_Amount}\r\nHDD: {HDD_Amount}\r\nОС: {OS_Name}\r\nЗдание: {Building_Name}\r\nКабинет: {Cabinet_Num}\r\nСписок программ: {Programm_List}";

                QRCoder.QRCodeGenerator QG = new QRCoder.QRCodeGenerator();
                var MyData = QG.CreateQrCode(Message, QRCoder.QRCodeGenerator.ECCLevel.M);
                var code = new QRCoder.QRCode(MyData);
                QRCodeBox.Image = code.GetGraphic(3);
                QRCodeBox.Image.Save($@"C:\Users\nikit\Desktop\PC_QRCodes\pcID_{ID_PC}.png", System.Drawing.Imaging.ImageFormat.Png);
            }
            saveQR.Enabled = true;
        }
    }
}
