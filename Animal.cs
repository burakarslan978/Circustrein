using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circustrein
{
    internal class Animal
    {
        private int id;
        private string animalName;
        private int size;
        private bool meatEater;

        public int Id { get { return id; } set { id = value; } }
        public int Size { get { return size; } set { size = value; } }
        public bool MeatEater { get { return meatEater; } set { meatEater = value; } }
        public string AnimalName { get { return animalName; } set { animalName = value;} }
        public Animal() { }
        public Animal(int _Size, bool _MeatEater, string _AnimalName)
        {

            Size = _Size;
            MeatEater = _MeatEater;
            AnimalName = _AnimalName;
        }

        public void createAnimal()
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\grapi\Desktop\ICTsemester2\Circustrein\Animals.accdb";

            OleDbCommand cmd = new OleDbCommand("INSERT INTO Animals (AnimalName, [Size], MeatEater) VALUES (@AnimalName, @Size, @MeatEater)");
            cmd.Connection = conn;

            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                cmd.Parameters.Add("@AnimalName", OleDbType.VarChar).Value = this.AnimalName;
                cmd.Parameters.Add("@Size", OleDbType.Integer).Value = this.Size;
                cmd.Parameters.Add("@MeatEater", OleDbType.Boolean).Value = this.MeatEater;

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(this.AnimalName + " is toegevoegd");
                    conn.Close();
                }
                catch (OleDbException ex)
                {
                    MessageBox.Show(ex.Message);
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Connection Failed");
            }

        }

        public List<Animal> getAnimals()
        {
            List<Animal> list = new List<Animal>();

            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\grapi\Desktop\ICTsemester2\Circustrein\Animals.accdb";
            using (OleDbConnection connection = new OleDbConnection(connString))
            {
                connection.Open();
                OleDbDataReader reader = null;
                OleDbCommand command = new OleDbCommand("SELECT * from  Animals", connection);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Animal animal = new Animal()
                    {
                        AnimalName = reader[3].ToString(),
                        Size = Convert.ToInt32(reader[1]),
                        MeatEater = Convert.ToBoolean(reader[2])
                    };
                    list.Add(animal);
                }
                
                return list;
            }
        }

        public List<string> getAnimalNames()
        {
            List<string> names = new List<string>();
            List<Animal> animals = new List<Animal>();
            animals = getAnimals();

            foreach (Animal animal in animals)
            {
                string name = animal.AnimalName;
                names.Add(name);
            }
            return names;
        }


    }
}
