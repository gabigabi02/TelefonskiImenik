using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelefonskiImenik
{
    public partial class Form1 : Form
    {
        int[] broj = new int[]
{
        0923662549,0945776612,0923590653,0970387996,0912043610,0935480791,0968217045,0943850162,0978704392,0985627104,
        0908375946,0916453829,0937104826,0921703584,0971468932,0953847206,0906358291,0987051364,0973265481,0954736190,
        0931246857,0915627493,0957284306,0965413702,0983615270,0918537046,0931604972,0945082139,0972568431,0919427680,
        0940765328,0936728015,0928053649,0984720653,0907261483,0960518273,0974531609,0916825740,0927630954,0948512736,
        0936182740,0958243761,0987052136,0918435762,0936508172,0941268305,0967035218,0915487620,0936251847,0971602849,
        0967483025,0928516307,0973845206,0916528730,0962083457,0987415062,0914568372,0975328410,0956083274,0927180645,
        0940762381,0985314762,0931647058,0978326415,0941283760,0935702481,0924183750,0917680432,0974205813,0985230471,
        0941762380,0927408153,0963825470,0918547203,0935621780,0926738054,0943106257,0985473126,0972084351,0926081347,
        0947863025,0931587264,0917025638,0963051827,0926104375,0972485031,0947085326,0915038472,0926107843,0931286405,
        0974523806,0982357401,0927186405,0915038672,0934187605,0968025471,0975613284,0921740685,0946213085,0985314760,
        0917836204,0930548176,0971284503,0982536174,0917643058,0973850216,0962547830,0927103485,0934205871,0986310472,
        0914850623,0925107836,0948672035,0981740538,0967283054,0973158046,0915827460,0931406872,0942057613,0967810243,
        0982517430,0918476205,0963084217,0945782130,0926103847,0935816204,0913057482,0924176583,0987260154,0971825043,
        0946273018,0915063284,0964721580,0980134576,0971406235,0916720548,0945037186,0982613045,0926475103,0935027481,
        0971428065,0917835620,0984732016,0926103847,0945037128,0918534607,0971825304,0986104237,0947530186,0918234670,
        0936501247,0975826340,0913640725,0941532807,0967815420,0984736501,0918263470,0925041783,0937416820,0978516042,
        0962348057,0923176408,0985317624,0917642380,0973526481,0924076183,0948123506,0985762031,0971405832,0918725406,
        0931508742,0946108325,0963078521,0974183502,0986521704,0915836204,0943025187,0937481602,0965103472,0978235014,
        0916540723,0948012573,0936104827,0982517643,0974185203,0926403857,0938142605,0963072518,0916825304,0975043217,
        0934187056,0925187460,0918620745,0973146528,0985240176,0962017483,0916238405,0927405183,0978604125,0983720514,
        0925840137,0914735068,0982531704,0938146052,0918725401,0963085724,0928106437,0937518204,0915036872,0971603825,
        0985274301,0936812405,0972085146,0925137804,0916378205,0947105386,0962351807,0978102453,0935726401,0983045176,
        0916738204,0971235680,0938475201,0945031762,0928710534,0916524387,0985204731,0934185067,0978206143,0916537802,
        0947180543,0963015782,0985713064,0917845036,0928164075,0973058401,0935126740,0916378052,0947108236,0982514307

};
        string[] ime = new string[]
        {
        "Ada", "Adrian", "Aleksandar", "Alen", "Ana", "Anđela",
        "Andrej", "Anita", "Anja", "Anton", "Antonija", "Antun",
        "Barbara", "Berislav", "Biserka", "Blaženka", "Boris",
        "Branimir", "Branko", "Bruna", "Bruno", "Cvjetko", "Damir",
        "Damjana", "Danica", "Daniel", "Danijela", "Darko", "Dario",
        "Davor", "Davorin", "Dejan", "Dijana", "Dino", "Dominik",
        "Dora", "Dubravka", "Đuro", "Elena", "Elvira", "Emil",
        "Ena", "Eugen", "Filip", "Filomena", "Fran", "Franka",
        "Gabrijel", "Gizela", "Goran", "Gordana", "Grgur", "Helena",
        "Hrvoje", "Igor", "Ilija", "Ines", "Irina", "Iris", "Iva", "Ivan",
        "Ivana", "Ivanka", "Ivančica", "Ivona", "Izabela", "Jadranka", "Jakov",
        "Jana", "Janko", "Jasmina", "Jasna", "Jelena", "Jelica", "Jerko",
        "Jolanda", "Josina", "Josip", "Josipa", "Judita", "Jure",
        "Karla", "Karlo", "Karmen", "Katica", "Katarina", "Krešimir",
        "Krsto", "Kristijan", "Kristina", "Lana", "Larisa", "Lea", "Leon",
        "Leonard", "Lidija", "Lina", "Lovro", "Lucija", "Luka", "Magdalena",
        "Maja", "Marica", "Marija", "Marijan", "Marin", "Marina", "Mario",
        "Marko", "Marta", "Mate", "Mateo", "Matea", "Matija", "Melita", "Mia",
        "Mihael", "Milan", "Milena", "Mirela", "Mirjana", "Mirna", "Miroslav",
        "Miroslava", "Mislav", "Mladen", "Mirta", "Nada", "Nataša", "Nenad", "Nera",
        "Nikola", "Nikolina", "Nikol", "Nikša", "Nina", "Noa", "Orsat", "Pavao", "Paula",
        "Petar", "Petra", "Rajko", "Renata", "Robert", "Romana", "Roko", "Rozalija",
        "Sara", "Saša", "Slaven", "Slavica", "Snježana", "Sonja", "Srećko", "Stanko",
        "Stela", "Stjepan", "Tanja", "Tatjana", "Tea", "Teo", "Tihana", "Tijana", "Tihomir",
        "Tin", "Tina", "Tomislav", "Toni", "Valentina", "Vanja", "Vedran", "Veronika",
        "Vesna", "Viktor", "Viktorija", "Violeta", "Vjekoslav", "Vladimir", "Vlasta",
        "Vlatko", "Zdenka", "Zdravko", "Zlata", "Zlatan", "Zoran", "Zrinka", "Zvonimir",
        "Zvonko", "Zvjezdana", "Željka", "Željko",
        };
        public Form1()
        {
            InitializeComponent();

            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {
         
      

            for (int i = 0; i < Math.Min(broj.Length, ime.Length); i++)
            {
                ListViewItem kontakt = new ListViewItem((i + 1).ToString());
                kontakt.SubItems.Add(broj[i].ToString());
                kontakt.SubItems.Add(ime[i]);
                listView1.Items.Add(kontakt);
            }
        }

        public void button1_Click(object sender, EventArgs e)
        {
            int index = -1;
            string unos = textBox1.Text;
            index = Array.IndexOf(ime, unos);

            if (index >= 0)
            {
                int broj1 = broj[index];
                label3.Text = $"Broj korisnika '{unos}': {broj1}";
            }
            else
            {
                label3.Text = $"Korisnik '{unos}' ne postoji!";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
