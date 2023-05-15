using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using System.Collections;
using System.Data.SqlClient;

namespace cobacoba
{
    public partial class Form1 : Form
    {
        string connectionString = "server=localhost; uid=root; pwd= ; database=premier_league";
        MySqlConnection sqlConnect;
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        DataTable dtNation = new DataTable();
        DataTable dtTeam = new DataTable();
    
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlConnect = new MySqlConnection(connectionString);

            sqlQuery = "select nation From nationality";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtNation);
            comboBoxNationally.DataSource = dtNation;
            comboBoxNationally.DisplayMember = "nation";

            sqlQuery = "select team_name from team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);
            comboBoxTeamName.DataSource = dtTeam;
            comboBoxTeamName.DisplayMember = "team_name";

            sqlQuery = "select team_name from team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);
            comboBoxEditManager.DataSource = dtTeam;
            comboBoxEditManager.DisplayMember = "team_name";
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }
    }
}
