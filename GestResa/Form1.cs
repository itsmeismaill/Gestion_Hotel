using GestResa.UC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace GestResa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        

            // Appeler la méthode AssignRoomProperties pour assigner les propriétés aux instances de Room
            AssignRoomProperties(room1);
            AssignRoomProperties(room2);
            AssignRoomProperties(room3);
            AssignRoomProperties(room4);
            AssignRoomProperties(room5);
            AssignRoomProperties(room6);
            AssignRoomProperties(room7);
            AssignRoomProperties(room8);
            AssignRoomProperties(room9);
        }

        private void AssignRoomProperties(Room room)
        {
            // Assigner les propriétés LabelResult, DateTimePicker1, et nomtext à l'instance de Room donnée
            room.LabelResult = lbresult;
            room.DateTimePicker1 = dateTimePicker1;
            room.nomtext = nomtext;
            room.errorlabel = errorlabel;
            room.duree = numericUpDown1;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

       


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void room1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void nomtext_TextChanged(object sender, EventArgs e)
        {

        }

        private void errorlabel_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
       private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
{
                DateTime selectedDate = dateTimePicker1.Value.Date;

           // Liste pour stocker les numéros de chambre réservés à la date sélectionnée
                 List<int> reservedRooms = new List<int>();

    try
    {
        using (MySqlConnection connection = DatabaseManager.GetConnection())
        {
            string query = "SELECT RoomNumber FROM Rooms WHERE DateReservation <= @SelectedDate AND DateFinReservation >= @SelectedDate";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@SelectedDate", selectedDate);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int roomNumber = reader.GetInt32("RoomNumber");
                    reservedRooms.Add(roomNumber);
                }
            }
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Erreur: " + ex.Message);
    }

    // Parcourir les chambres et appliquer la couleur appropriée
    foreach (Control control in this.Controls)
    {
        if (control is Room roomControl)
        {     
          
            if (reservedRooms.Contains(roomControl.Number))
            {
                roomControl.BackColor = Color.Red; // Chambre réservée

            }
            else
            {
                roomControl.BackColor = Color.White; // Chambre libre
            }
        }
    }
    StringBuilder reservedRoomsText = new StringBuilder();
          foreach (int roomNumber in reservedRooms)
{
                 reservedRoomsText.AppendLine($"Chambre {roomNumber}");
}

        // Afficher la liste des chambres réservées dans le label lbresult
         if(reservedRooms.Count > 0)
         lbresult.Text = $"Les chambres réservées le \n {dateTimePicker1.Value.Date:dd/MM/yyyy} sont :\n{reservedRoomsText}";
         else
        lbresult.Text = "Toutes la chambres sont vides \n 😊";
       
            
}

    }
}
