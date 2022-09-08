using System.Data;
using System.Data.OleDb;

namespace Circustrein
{
    public partial class Circustrein : Form
    {
         
        public Circustrein()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateAnimalList();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private int checkSize()
        {
            if(smallBtn.Checked == true){
                return 1;
            } else if(mediumBtn.Checked == true){
                return 3;
            } else if(bigBtn.Checked == true){
                return 5;
            }
            else
            {
                MessageBox.Show("Size not selected!");
                return 0;
            }
        }

        private bool checkMeat()
        {
            if (meatBtn.Checked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String animalName = nameTxtbox.Text;
            int Size = checkSize();
            bool meatEater = checkMeat();

            Animal animal = new Animal(Size, meatEater, animalName);
            animal.createAnimal();

            updateAnimalList();
        }

        private void updateAnimalList()
        {
            Animal animal = new Animal();
            List<string> animalList = new List<string>();
            animalList = animal.getAnimalNames();
            

            animalListbox.DataSource = animalList;

        }

        private void animalListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void wagonBtn_Click(object sender, EventArgs e)
        {
            Wagon _wagon = new Wagon();
            List<Wagon> wagonList = new List<Wagon>();
            wagonList = _wagon.getWagons();
            string labeltext = "";

            foreach (Wagon wagon in wagonList)
            {
                
                labeltext = "Wagon " + wagonList.Count + " " + wagon.AnimalsInside;
            }
            wagonLbl.Text = labeltext;
        }
    }
}