using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data
{
    using Npgsql;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(NpgsqlConnection connection)
        {
            InitializeComponent();
            _connection = connection;
            Data = new DataManager(connection);
        }

        private NpgsqlConnection _connection;

        public DataManager Data { get; }

        private void SchemeTreeView_MouseClick(object sender, MouseEventArgs e)
        {
            List<string> list = GetTablesList();
            int i;
            i = 10;
        }

        private List<string> GetTablesList()
        {
            bool isSuccess;
            string message;
            DataSet dataSet = Data.GetDataSet(get_tables_request, out isSuccess, out message);
            return dataSet.Tables[0].AsEnumerable().Select(dataRow => dataRow.Field<string>("tableName")).ToList();
        }


   
    }
}
