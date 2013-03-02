using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WindowsFormsApplication2
{
    public partial class AddDB : Form
    {
        private SQLiteConnection sqlConnection;
        private SQLiteCommand sqlCommand;
        private SQLiteDataReader sqlDataReader;
                
        public AddDB()
        {
            InitializeComponent();
            InitializeDB();
            InitializeTables();
            InitializeMovies();
            InitializeCast();
        }
        
        private void InitializeDB()
        {
            sqlConnection = new SQLiteConnection("Data Source=MoveDB.db;Version=3;New=True;Compress=True;");
            sqlConnection.Open();
            sqlCommand = sqlConnection.CreateCommand();
        }

        private void InitializeTables()
        {
            sqlCommand.CommandText = "CREATE TABLE IF NOT EXISTS movie (id integer primary key autoincrement, title varchar(100));";
                sqlCommand.ExecuteNonQuery();
            sqlCommand.CommandText = "CREATE TABLE IF NOT EXISTS cast (id integer primary key autoincrement, name text);";
                sqlCommand.ExecuteNonQuery();
            sqlCommand.CommandText = "CREATE TABLE IF NOT EXISTS movie_cast (id integer primary key autoincrement, int movie_id, int cast_id);";
                sqlCommand.ExecuteNonQuery();
        }

        private void InitializeMovies()
        {
            sqlCommand.CommandText = "INSERT INTO movie VALUES(null,'100 Girls');";
            sqlCommand.CommandText = "INSERT INTO movie VALUES(null,'300');";
            sqlCommand.CommandText = "INSERT INTO movie VALUES(null,'Stigmata');";
            sqlCommand.CommandText = "INSERT INTO movie VALUES(null,'Exorcist');";
            sqlCommand.CommandText = "INSERT INTO movie VALUES(null,'Hannibal');";
            sqlCommand.ExecuteNonQuery();
        }
        
        private void InitializeCast()
        {
            sqlCommand.CommandText = "INSERT INTO cast VALUES(null,'Philip Seymour Hofman');";
            sqlCommand.CommandText = "INSERT INTO cast VALUES(null,'Kate Shindle');";
            sqlCommand.CommandText = "INSERT INTO cast VALUES(null,'Kelci Stephenson');";
            sqlCommand.CommandText = "INSERT INTO cast VALUES(null,'Al Pacino');";
            sqlCommand.CommandText = "INSERT INTO cast VALUES(null,'Gabrielle Anwar');";
            sqlCommand.CommandText = "INSERT INTO cast VALUES(null,'Patricia Arquette');";
            sqlCommand.CommandText = "INSERT INTO cast VALUES(null,'Gabriel Byrne');";
            sqlCommand.CommandText = "INSERT INTO cast VALUES(null,'Max von Sydow');";
            sqlCommand.CommandText = "INSERT INTO cast VALUES(null,'Ellen Burstyn');";
            sqlCommand.CommandText = "INSERT INTO cast VALUES(null,'Jason Miller');";
                sqlCommand.ExecuteNonQuery();
        }

/*
INSERT INTO ActorsMovies VALUES(1,1,1);
INSERT INTO ActorsMovies VALUES(2,2,1);
INSERT INTO ActorsMovies VALUES(3,3,1);
INSERT INTO ActorsMovies VALUES(4,4,2);
INSERT INTO ActorsMovies VALUES(5,5,2);
INSERT INTO ActorsMovies VALUES(6,6,3);
INSERT INTO ActorsMovies VALUES(7,7,3);
INSERT INTO ActorsMovies VALUES(8,8,4);
INSERT INTO ActorsMovies VALUES(9,9,4);
INSERT INTO ActorsMovies VALUES(10,10,4);
INSERT INTO ActorsMovies VALUES(11,8,5);
*/

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
