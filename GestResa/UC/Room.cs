using MySql.Data.MySqlClient;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace GestResa.UC
{
    public partial class Room : UserControl
    {
        public Label LabelResult { get; set; }

        public DateTimePicker DateTimePicker1 { get; set; }
        public int Number { get; set; }
        public bool IsFree = false;
        public TextBox nomtext { get; set; }
        public NumericUpDown duree { get; set; }
        public int dureeReservation;
        public string nom;
        public Label errorlabel { get; set; }   
        public DateTime ReservationDate { get; private set; } // Propriété pour stocker la date de réservation
        public DateTime FinReservationDate { get; private set; }

        public Room()
        {
            InitializeComponent();
        }

        public void ShowStatus()
        {
            this.BackColor = IsFree ? Color.White : Color.Red;
            libMenu.Visible = !IsFree;
            resMenu.Visible = IsFree;
}


 private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
{
    DateTime selectedDate = DateTimePicker1.Value.Date;

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
                roomControl.BackColor = Color.Black; // Chambre réservée
            }
            else
            {
                roomControl.BackColor = Color.Yellow; // Chambre libre
            }
        }
    }
}



private void Room_Load(object sender, EventArgs e)
{
    lbNumber.Text = Number.ToString();

    // Récupération du nom de réservation depuis la base de données
    try
    {
        using (MySqlConnection connection = DatabaseManager.GetConnection())
        {
            string query = "SELECT Nom FROM Rooms WHERE RoomNumber = @RoomNumber";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@RoomNumber", Number);
            object result = command.ExecuteScalar();
            if (result.ToString()=="")
            {
                this.IsFree = true;
              ShowStatus();
            }
            else
               { this.IsFree = false;
                ShowStatus();
              }
            
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Erreur: " + ex.Message);
    }
}



        private void resMenu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nomtext.Text) || duree.Value == 0)
            {
                this.errorlabel.Text = "Veuillez remplir tous les champs .";
            }
            else
            {
                this.errorlabel.Text = "";
                IsFree = false;
                ReservationDate = this.DateTimePicker1.Value;
                dureeReservation = (int)this.duree.Value;
                FinReservationDate = ReservationDate.AddDays((int)duree.Value);
                nom = nomtext.Text;
                LabelResult.Text = $"Réservation de la chambre {Number}\n {dureeReservation} Jrs à partir du \n {ReservationDate:dd/MM/yyyy}\n pour Mr/Mme: {nom} \n  date de fin de réservation: \n {FinReservationDate:dd/MM/yyyy} ";
                ShowStatus();

                // Sauvegarde dans la base de données
                try
                {
                    using (MySqlConnection connection = DatabaseManager.GetConnection())
                    {
                        string query = "UPDATE Rooms SET Nom = @Nom, DateReservation = @DateReservation, Duree = @Duree, DateFinReservation = @DateFinReservation WHERE RoomNumber = @RoomNumber";
                        MySqlCommand command = new MySqlCommand(query, connection);
                        command.Parameters.AddWithValue("@Nom", nom);
                        command.Parameters.AddWithValue("@DateReservation", ReservationDate);
                        command.Parameters.AddWithValue("@Duree", dureeReservation);
                        command.Parameters.AddWithValue("@DateFinReservation", FinReservationDate);
                        command.Parameters.AddWithValue("@RoomNumber", Number);
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            Console.WriteLine("Réservation enregistrée avec succès.");
                        }
                        else
                        {
                            Console.WriteLine("Erreur lors de l'enregistrement de la réservation.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erreur: " + ex.Message);
                }
            }
        }


        private void libMenu_Click(object sender, EventArgs e)
        {

            IsFree = true;
            try
            {
                using (MySqlConnection connection = DatabaseManager.GetConnection())
                {
                    string query = "UPDATE Rooms SET Nom = NULL, DateReservation = NULL, Duree = NULL, DateFinReservation = NULL WHERE RoomNumber = @RoomNumber";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@RoomNumber", Number);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        LabelResult.Text = $"La chambre {Number} a été libérée";
                        duree.Value = 0;
                        nomtext.Text = "";
                    }
                    else
                    {
                        LabelResult.Text = $"La chambre {Number}\n n'était pas réservée.";
                    }
                    ShowStatus();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur: " + ex.Message);
            }
        }

    }
}
