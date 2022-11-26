/* Programmer: Ngoc Thi Kim Nguyen
   Course: CMSC222
   Professor: Janet Joy
   Description: Birthday
*/


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace birthday
{
    public partial class birthday : Form
    {
        public birthday()
        {
            InitializeComponent();
        }

        // When the Date Time Picker values change.
        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            // Declare variables and assign values.
            String localDirectory = System.IO.Path.GetDirectoryName(Environment.GetCommandLineArgs()[0]);
            DateTime d = dateTimePicker.Value;
            int year = d.Date.Year;
            int month = d.Date.Month;
            int day = d.Date.Day;
            int mAndD = month*100 + day;
            String season = "";
            String zodiac = "";

            // Array of animals' names.
            String[] animals = {"Monkey", "Rooster", "Dog", "Pig", "Rat", "Ox", 
                "Tiger", "Rabbit", "Dragon", "Snake", "Horse", "Sheep"};
            // Array of path to the animals' pictures.
            String[] aPics = { "/pics/monkey.png", "/pics/rooster.png", "/pics/dog.png", "/pics/pig.png",
                "/pics/rat.png", "/pics/ox.png", "/pics/tiger.png", "/pics/rabbit.png", "/pics/dragon.png",
                "/pics/snake.png", "/pics/horse.png", "/pics/sheep.png"};

            // Array of seasons in numeric values.
            int[] seasons = {320, 620, 922, 1221};
            // Array of seasons' names.
            String[] ssStr = {"Spring", "Summer", "Fall", "Winter"};

            // Array of zodiacs in numeric values.
            int[] zodiacs = {121, 220, 321, 421, 522, 622, 723, 822, 924, 1024, 1123, 1223, 1300};
            // Array of zodiacs' names.
            String[] zStr = {"Aquarius", "Pisces", "Aries", "Taurus", "Gemini", "Cancer", "Leo", 
                "Virgo", "Libra", "Scorpio", "Sagittarius", "Capricorn"};
            // Array of path to the zodiacs' pictures.
            String[] zPics = { "/pics/aquarius.png", "/pics/pisces.png", "/pics/aries.png", "/pics/taurus.png",
                "/pics/gemini.png", "/pics/cancer.png", "/pics/leo.png", "/pics/virgo.png", "/pics/libra.png",
                "/pics/scorpio.png", "/pics/sagittarius.png", "/pics/capricorn.png"};

            // Display date of week.
            txtDOW.Text = "" + d.Date.DayOfWeek;
            // Display name of animal.
            txtAnimal.Text = "" + animals[year % 12];
            // Display a picture of the animal.
            picAnimals.Image = Image.FromFile(localDirectory + aPics[year%12]);

            // Calculate and display the season using a for loop inside if-else.
            if ((mAndD < seasons[0]) || (mAndD >= seasons[seasons.Length - 1]))
            {
                season = ssStr[seasons.Length - 1];
            }
            else
            {
                for (int i = 0; i < seasons.Length; i++)
                {
                    if ((mAndD >= seasons[i]) && (mAndD < seasons[i + 1]))
                    {
                        season = ssStr[i];
                    }
                }
            }
            txtSeason.Text = season;

            // Calculate and display the zodiac using a for loop inside if-else.
            if ((mAndD < zodiacs[0]) || (mAndD >= zodiacs[zodiacs.Length - 1]))
            {
                zodiac = zStr[zodiacs.Length - 2];
                picZodiacs.Image = Image.FromFile(localDirectory + zPics[zodiacs.Length - 2]);
            }
            else
            {
                for (int i = 0; i < zodiacs.Length; i++)
                {
                    if ((mAndD >= zodiacs[i]) && (mAndD < zodiacs[i + 1]))
                    {
                        zodiac = zStr[i];
                        picZodiacs.Image = Image.FromFile(localDirectory + zPics[i]);
                    }
                }
            }
            txtZodiac.Text = zodiac;
        }
    }
}
