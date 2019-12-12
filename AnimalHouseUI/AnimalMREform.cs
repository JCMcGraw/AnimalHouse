using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimalHouse;
using AnimalHouseEntities;
//using System.Text.RegularExpressions;

namespace AnimalHouseUI
{
    public partial class AnimalMREform : Form
    {
        Animal animal;
        //List<MedicalRecord> medicalRecords;
        public AnimalMREform(MedicalRecord medicalRecord,Animal animal)
        {
            InitializeComponent();
            BossController.Instance().animalController.GetAllMedicalRecordByAnimal(animal);
            animal_mrEntry.Text = medicalRecord.entry.ToString();
            
        }
    }
}
