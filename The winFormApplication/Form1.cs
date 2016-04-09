using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsoleApplication1;


namespace The_winFormApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StageOne();
        }
        Character ENPaladin;
        Character ENPriest;
        Character ENRogue;
        Character ENShaman;
        Character APaladin;
        Character APriest;
        Character ARogue;
        Character AShaman;
        int stage;
        Character agressor;
        private void Form1_Load(object sender, EventArgs e)
        {

            

            
            ENPaladin = new Paladin(800, 400, 80);
            ENPaladinHPlabel.Text = "HP = " + ENPaladin.Hp;
            ENPaladinMPlabel.Text = "MP = " + ENPaladin.Mp;
            ENPriest = new Priest(400, 900, 30);
            ENPriestHPlabel.Text = "HP = " + ENPriest.Hp;
            ENPriestMPlabel.Text = "MP = " + ENPriest.Mp;
            ENRogue = new Rogue(360, 500, 100);
            ENRogueHPlabel.Text = "HP = " + ENRogue.Hp;
            ENRogueMPlabel.Text = "MP = " + ENRogue.Mp;
            ENShaman = new Shaman(500, 700, 50);
            ENShamanHPlabel.Text = "HP = " + ENShaman.Hp;
            ENShamanMPlabel.Text = "MP = " + ENShaman.Mp;



            APaladin = new Paladin(800, 400, 80);
            APaladinHPlabel.Text = "HP = " + APaladin.Hp;
            APaladinMPlabel.Text = "MP = " + APaladin.Mp;
            APriest = new Priest(400, 900, 30);
            APriestHPlabel.Text = "HP = " + APriest.Hp;
            APriestMPlabel.Text = "MP = " + APriest.Mp;
            ARogue = new Rogue(360, 500, 100);
            ARogueHPlabel.Text = "HP = " + ARogue.Hp;
            ARogueMPlabel.Text = "MP = " + ARogue.Mp;
            AShaman = new Shaman(500, 700, 50);
            AShamanHPlabel.Text = "HP = " + AShaman.Hp;
            AShamanMPlabel.Text = "MP = " + AShaman.Mp;

            //Полосы здоровья и маны
            HPAPaladin.Maximum = APaladin.Hp;
            HPAPaladin.Value = APaladin.Hp;
            HPENPaladin.Maximum = ENPaladin.Hp;
            HPENPaladin.Value = ENPaladin.Hp;
            MPAPaladin.Maximum = APaladin.Mp;
            MPAPaladin.Value = APaladin.Mp;
            MPENPaladin.Maximum = ENPaladin.Mp;
            MPENPaladin.Value = ENPaladin.Mp;
            HPARogue.Maximum = ARogue.Hp;
            HPARogue.Value = ARogue.Hp;
            HPENRogue.Maximum = ENRogue.Hp;
            HPENRogue.Value = ENRogue.Hp;
            MPARogue.Maximum = ARogue.Mp;
            MPARogue.Value = ARogue.Mp;
            MPENRogue.Maximum = ENRogue.Mp;
            MPENRogue.Value = ENRogue.Mp;
            HPAShaman.Maximum = AShaman.Hp;
            HPAShaman.Value = AShaman.Hp;
            HPENShaman.Maximum = ENShaman.Hp;
            HPENShaman.Value = ENShaman.Hp;
            MPAShaman.Maximum = AShaman.Mp;
            MPAShaman.Value = AShaman.Mp;
            MPENShaman.Maximum = ENShaman.Mp;
            MPENShaman.Value = ENShaman.Mp;
            HPAPriest.Maximum = APriest.Hp;
            HPAPriest.Value = APriest.Hp;
            HPENPriest.Maximum = ENPriest.Hp;
            HPENPriest.Value = ENPriest.Hp;
            MPAPriest.Maximum = APriest.Mp;
            MPAPriest.Value = APriest.Mp;
            MPENPriest.Maximum = ENPriest.Mp;
            MPENPriest.Value = ENPriest.Mp;
           
        }
        public void StageOne()
        {
            labelTipStart.Text = ("Нажмите кнопку 'НАЧАТЬ' чтобы запустить игру. Нажмити 'INFO' Чтобы получить дополнительные сведенья об игре.");
            
            panelAlies.Visible = false;
            panelEnemy.Visible = false;
            labelTips.Visible = false;
            panelChangePlayers.Visible = false;

        }
        public void StageTwo()
        {
            panelAlies.Visible = true;
            panelEnemy.Visible = false;
            StageOneINFOBut.Visible = false;
            StageOneStartBut.Visible = false;
            labelTipStart.Visible = false;
            labelTips.Visible = true;
            labelChangePLayers.Visible = false;
            labelTips.Text = ("Теперь вам нужно выбрать из левой панели(ваша команда) кем вы будете атаковать.");
            
        }
        public void StageThree()
        {
            
            panelAlies.Visible = false;
            panelEnemy.Visible = true;
            labelTips.Text = ("Теперь из правой панели(команда игрока 2) выберете того кeм вы хотите атаковать.");
            
            }
        public void StageChangePlayers()
        {
            panelEnemy.Visible = false;
            labelTips.Visible = false;
            labelChangePLayers.Visible = true;
            panelChangePlayers.Visible = true;
            labelChangePLayers.Text = ("ХОД ИГРОКА PLAYER2");
           
           
        }
        public void StageFour()
    {
        panelChangePlayers.Visible = false;
        panelAlies.Visible = false;
        panelEnemy.Visible = true;
        labelTips.Visible = true;
        labelTips.Text = ("Выберете кем вы будете атаковать из вашей комады (Правый столбец)");
        
        }
        public void StageFive()
            {
                panelEnemy.Visible = false;
                panelAlies.Visible = true;
                labelTips.Text = ("Теперь выберите кого атаковать из левого столбца.");
             
            
    }
        
        
            
    

    

        private void APaladinHPlabel_Click(object sender, EventArgs e)
        {
            
        }

        private void ENPaladinHPlabel_Click(object sender, EventArgs e)
        {

        }

        private void StageOneINFOBut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("В этой игре на двоих нужно уничтожить команду противника. Сначала нужно выбрать в вашей команде кем атаковать а потом кого атаковать из команды противников. Думайте и удачи вам в игре:)");
        }

        private void StageOneStartBut_Click(object sender, EventArgs e)
        {
            StageTwo();
        }

        private void APaladinbutton_Click(object sender, EventArgs e)
        {
            if (stage == 5)
            {
                stage = 2;
                StageTwo();
                agressor.target = APaladin;
                agressor.Attack();
            }
            else
            {
                agressor = APaladin;
                stage = 3;
                StageThree();
            }
            
        }

        private void AShamanbutton_Click(object sender, EventArgs e)
        {
            if (stage == 5)
            {
                stage = 2;
                StageTwo();
                agressor.target = AShaman;
                agressor.Attack();
            }
            else
            {
                agressor = AShaman;
                stage = 3;
                StageThree();
            }
        }

        private void APriestbutton_Click(object sender, EventArgs e)
        {
            if (stage == 5)
            {
                stage = 2;
                StageTwo();
                agressor.target = APriest;
                agressor.Attack();
            }
            else
            {
                agressor = APriest;
                stage = 3;
                StageThree();
            }
        }

        private void ARoguebutton_Click(object sender, EventArgs e)
        {
            if (stage == 5)
            {
                stage = 2;
                StageTwo();
                agressor.target = ARogue;
                agressor.Attack();
            }
            else
            {
                agressor = ARogue;
                stage = 3;
                StageThree();
            }
        }

        private void ENPaladinbutton_Click(object sender, EventArgs e)
        {
            if (stage == 3)
            {
                stage = 4;
                StageFour();
                agressor.target = ENPaladin;
                agressor.Attack();
            }
            else
            {
                stage = 5;
                StageFive();
                agressor = ENPaladin;
            }
        }

        private void ENShamanbutton_Click(object sender, EventArgs e)
        {
            if (stage == 3)
            {
                stage = 4;
                StageFour();
                agressor.target = ENShaman;
                agressor.Attack();
            }
            else
            {
                stage = 5;
                StageFive();
                agressor = ENShaman;
            }
            
        }

        private void ENPriestbutton_Click(object sender, EventArgs e)
        {
            if (stage == 3)
            {
                stage = 4;
                StageFour();
                agressor.target = ENPriest;
                agressor.Attack();
            }
            else
            {
                
                stage = 5;
                StageFive();
                agressor = ENPriest;
            }
            
        }

        private void ENRoguebutton_Click(object sender, EventArgs e)
        {
            if (stage == 3)
            {
                stage = 4;
                StageFour();
                agressor.target = ENRogue;
                agressor.Attack();
            }
            else
            {
                stage = 5;
                StageFive();
                agressor = ENRogue;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
