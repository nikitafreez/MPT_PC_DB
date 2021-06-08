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
using System.Data.SQLite;

namespace MPT_PC_DB
{
    public partial class MainForm : Form
    {
        private SQLiteConnection connection;
        private SQLiteCommand command;
        private SQLiteDataReader reader;
        private SQLiteDataAdapter adapter;
        private DataSet dataSet;
        private DataTable dataTable;
        private SQLiteDataAdapter dataAdapter;
        private string dbFileName = "MoneyStat.db";

        public MainForm()
        {
            string connectionString = $"Data Source={dbFileName};Version=3"; //Строка подключения
            connection = new SQLiteConnection(connectionString);

            InitializeComponent();
            GetTable();
            CheckRole();
        }

        private void GetTable()
        {
            try
            {
                connection.Open();
                dataAdapter = new SQLiteDataAdapter("SELECT * FROM PC", connection);
                dataSet = new DataSet();
                DataTable dt = dataSet.Tables.Add("PC");
                dataAdapter.Fill(dt);
                All_PC_dataFrid.DataSource = dataSet.Tables["PC"];

                PCidBox.DataSource = dataSet.Tables["PC"];
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


        private void CheckRole()
        {
            switch(Autharization.Role)
            {
                case 1:
                    {
                        saveBtn.Enabled = false;
                        updateBtn.Enabled = false;
                        deleteBtn.Enabled = false;
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (CheckBoxFill() == true)
            {
                try
                {
                    connection.Open();

                    command = new SQLiteCommand();
                    command.Connection = connection;
                    command.CommandText = $"INSERT INTO PC (GraphicCard_Name, Processor_Name, OZU_Amount, HDD_Amount, OS_Name, Building_Name, Cabinet_Num, Programm_List) VALUES ('{graphicCardBox.Text}', '{processorBox.Text}', '{ozuBox.Text}', '{HDDBox.Text}', '{OSBox.Text}', '{buildingNameBox.Text}', '{cabinetNumBox.Text}', '{programmListBox.Text}'";
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
            if (e.RowIndex > -1)
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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            Form filterForm = new Form();
            filterForm.Show();
        }

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
            try
            {
                connection.Open();
                command.CommandText = $"DELETE FROM PC WHERE ID_PC = '{All_PC_dataFrid.SelectedRows[0].Cells[0].Value}'";
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
            try
            {
                if (CheckBoxFill() == true)
                {
                    connection.Open();
                    command.CommandText = $"UPDATE PC SET GraphicCard_Name='{graphicCardBox.Text}', Processor_Name='{processorBox.Text}', OZU_Amount='{ozuBox.Text}', HDD_Amount='{HDDBox.Text}', OS_Name='{OSBox.Text}', Building_Name='{buildingNameBox.Text}', Cabinet_Num='{cabinetNumBox.Text}', Programm_List='{programmListBox.Text}' WHERE ID_PC ='{All_PC_dataFrid.SelectedRows[0].Cells[0].Value}'";
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
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "PNG(*.PNG)|*.png";
            sf.FileName = $"pcID_{PCidBox.Text}";
            sf.Title = "Выберите папку сохранения";

            if (sf.ShowDialog() ==  DialogResult.OK)
            {
                //QRCodeBox.Image.Save($@"C:\Users\nikit\Desktop\PC_QRCodes\pcID_{PCidBox.Text}.png", System.Drawing.Imaging.ImageFormat.Png);
                QRCodeBox.Image.Save(sf.FileName);
            }
        }

        private void GetAllPCSpecs(int PC_ID)
        {
            try
            {
                connection.Open();
                command.CommandText = $"SELECT GraphicCard_Name FROM PC WHERE ID_PC = '{PC_ID}'";
                GraphicCard_Name = command.ExecuteScalar().ToString();
                command.CommandText = $"SELECT Processor_Name FROM PC WHERE ID_PC = '{PC_ID}'";
                Processor_Name = command.ExecuteScalar().ToString();
                command.CommandText = $"SELECT OZU_Amount FROM PC WHERE ID_PC = '{PC_ID}'";
                OZU_Amount = command.ExecuteScalar().ToString();
                command.CommandText = $"SELECT HDD_Amount FROM PC WHERE ID_PC = '{PC_ID}'";
                HDD_Amount = command.ExecuteScalar().ToString();
                command.CommandText = $"SELECT OS_Name FROM PC WHERE ID_PC = '{PC_ID}'";
                OS_Name = command.ExecuteScalar().ToString();
                command.CommandText = $"SELECT Building_Name FROM PC WHERE ID_PC = '{PC_ID}'";
                Building_Name = command.ExecuteScalar().ToString();
                command.CommandText = $"SELECT Cabinet_Num FROM PC WHERE ID_PC = '{PC_ID}'";
                Cabinet_Num = command.ExecuteScalar().ToString();
                command.CommandText = $"SELECT Programm_List FROM PC WHERE ID_PC = '{PC_ID}'";
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
            contextMenuStrip1.Enabled = true;
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
            contextMenuStrip1.Enabled = true;
            FolderBrowserDialog fb = new FolderBrowserDialog();
            fb.Description = "Выберите папку сохранения";
            if (fb.ShowDialog() == DialogResult.OK)
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
                    QRCodeBox.Image.Save(fb.SelectedPath + $@"\pcID_{ID_PC}.png", System.Drawing.Imaging.ImageFormat.Png);
                }
                saveQR.Enabled = true;
            }
        }
    }
}