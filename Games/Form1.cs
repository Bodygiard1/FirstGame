using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Games
{
    public partial class Form1 : Form
    {
        /*D:\learning\Games\*/
        Image storage = Image.FromFile(@"storage_final.png");
        Image garage = Image.FromFile(@"garaj_final.jpg");
        Image washing = Image.FromFile(@"laundry.png");
        Image kitchen = Image.FromFile(@"kitchen.png");
        Image crowbarImage = Image.FromFile(@"ranga1231.png");
        Image kitchenKey = Image.FromFile(@"key_kitchen.png");
        Image livingKey = Image.FromFile(@"key_living.png");
        Image livingRoomStorageImage = Image.FromFile(@"storageLiving.png");
        Image livingRoomMainImmage = Image.FromFile(@"mainLivingRoom.png");
        Image livingRoomBedroomImage = Image.FromFile(@"livingRoomBedroom.png");
        Image livingRoomHallwayImage = Image.FromFile(@"livingRoomHallway.png");
        Image bedroomOneImage = Image.FromFile(@"dormitor1.png");
        Image bedroomTwoImage = Image.FromFile(@"dormitor2.png");
        Image storageOneImage = Image.FromFile(@"dulap1.png");
        Image storageTwoImage = Image.FromFile(@"dulap2.png");
        Image bedroomKey = Image.FromFile(@"key_bedroom.png");
        Image finish = Image.FromFile(@"exit.png");
        Image closedDoor = Image.FromFile(@"1move.png");
        Image openDoor = Image.FromFile(@"3move.png");
        Image key1 = Image.FromFile(@"key1.png");
        Image key2 = Image.FromFile(@"key2.png");
        Image key3 = Image.FromFile(@"key3.png");
        Image doorCrack = Image.FromFile(@"doorCrack.png");
        Image sound0 = Image.FromFile(@"sound0.png");
        Image sound1 = Image.FromFile(@"sound1.png");
        Image sound2 = Image.FromFile(@"sound2.png");
        Image sound3 = Image.FromFile(@"sound3.png");
        Image sound4 = Image.FromFile(@"sound4.png");
        string Location = "mainLivingRoom";
        bool hideCrowbare = false;
        bool hideKitchenKey = false;
        bool hideLivingKey = false;
        bool hideBedroomKey = false;
        bool right;
        bool left;
        bool forward;
        bool back;
        bool item1picked = false;
        bool item2picked = false;
        bool item3picked = false;
        bool item4picked = false;
        bool item1completed = false;
        bool item2completed = false;
        bool item3completed = false;
        int soundLevel = 0;
        bool start = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            keyKitchen.Image = kitchenKey;
            crowbar.Image = crowbarImage;
            keyLiving.Image = livingKey;
            keyBedroom.Image = bedroomKey;
            finishImage.Image = finish;
            key1image.Image = key1;
            key2image.Image = key2;
            key3image.Image = key3;
            doorCrackImage.Image = doorCrack;
            sound.Image = sound0;
            locationDetector(Location);
        }

        private void background_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
        private void kitchenRoom(string move)
        {
            background.Image = kitchen;
            possibleMovements.Text = "A - laundry; S - living room 4";
            if(hideKitchenKey == false)
            {
                keyKitchen.Show();
            }
            if (move == "left")
            {
                Location = "washingRoom";
                move = "";
                locationDetector(move);
            }
            if (move == "back")
            {
                Location = "livingRoomHallway";
                move = "";
                locationDetector(move);
            }
        }
        private void storageRoom(string move)
        {
            background.Image = storage;
            possibleMovements.Text = "S - garage";
            if (hideCrowbare == false)
            {
                crowbar.Show();
            }
            if (move == "back")
            {
                Location = "garageRoom";
                move = "";
                locationDetector(move);
            }
        }
        private void washingRoom(string move)
        {
            background.Image = washing;
            possibleMovements.Text = "A - garage; D - kitchen";
            if (move == "left")
            {
                Location = "garageRoom";
                move = "";
                locationDetector(move);
            }
            if (move == "right")
            {
                Location = "kitchen";
                move = "";
                locationDetector(move);
            }
        }

        private void garageRoom(string move)
        {
            background.Image = garage;
            possibleMovements.Text = "A - garage storage; D - washing room";
            if (move == "left")
            {
                Location = "storage";
                move = "";
                locationDetector(move);
            }
            if (move == "right")
            {
                Location = "washingRoom";
                move = "";
                locationDetector(move);
            }
        }
        private void mainLivingRoom(string move)
        {
            background.Image = livingRoomMainImmage;
            finishImage.Show();
            possibleMovements.Text = "A - living room 3; D - living room 2; W - living room 4";
            if (move == "left")
            {
                Location = "storageLiving";
                move = "";
                locationDetector(move);
            }
            if (move == "right")
            {
                Location = "livingRoomBedroom";
                move = "";
                locationDetector(move);
            }
            if(move == "forward")
            {
                Location = "livingRoomHallway";
                move = "";
                locationDetector(move);
            }
        }
        private void storageLiving(string move)
        {
            background.Image = livingRoomStorageImage;
            possibleMovements.Text = "A - living room 1; D - living room 4";
            if (move == "left")
            {
                Location = "mainLivingRoom";
                move = "";
                locationDetector(move);
            }
            if (move == "right")
            {
                Location = "livingRoomHallway";
                move = "";
                locationDetector(move);
            }
        }
        private void livingRoomBedroom(string move)
        {
            background.Image = livingRoomBedroomImage;
            possibleMovements.Text = "A - living room 1; D - living room 4; W- living room 2; S - bedroom 1";
            if (move == "left")
            {
                Location = "mainLivingRoom";
                move = "";
                locationDetector(move);
            }
            if (move == "right")
            {
                Location = "livingRoomHallway";
                move = "";
                locationDetector(move);
            }
            if (move == "forward")
            {
                Location = "storageLiving";
                move = "";
                locationDetector(move);
            }
            if(move == "back")
            {
                Location = "bedroomOne";
                move = "";
                locationDetector(move);
            }
        }
        private void livingRoomHallway(string move)
        {
            background.Image = livingRoomHallwayImage;
            possibleMovements.Text = "A - living room 1; W - kitchen";
            if (hideLivingKey == false)
            {
                keyLiving.Show();
            }
            if (move == "left")
            {
                Location = "mainLivingRoom";
                move = "";
                locationDetector(move);
            }
            if (move == "forward")
            {
                Location = "kitchen";
                move = "";
                locationDetector(move);
            }
        }
        private void bedroomOne(string move)
        {
            background.Image = bedroomOneImage;
            possibleMovements.Text = "A - storage 1; D - living room 4; S - bedroom 2";
            if(hideBedroomKey == false)
            {
                keyBedroom.Show();
            }
            if (move == "left")
            {
                Location = "storageOne";
                move = "";
                locationDetector(move);
            }
            if (move == "right")
            {
                Location = "livingRoomHallway";
                move = "";
                locationDetector(move);
            }
            if (move == "back")
            {
                Location = "bedroomTwo";
                move = "";
                locationDetector(move);
            }
        }
        private void bedroomTwo(string move)
        {
            background.Image = bedroomTwoImage;
            possibleMovements.Text = "A - storage 2; S - bedroom 1";
            if (move == "left")
            {
                Location = "storageTwo";
                move = "";
                locationDetector(move);
            }
            if (move == "back")
            {
                Location = "bedroomOne";
                move = "";
                locationDetector(move);
            }
        }
        private void storageOne(string move)
        {
            background.Image = storageOneImage;
            possibleMovements.Text = "S - bedroom 1";
            if (move == "back")
            {
                Location = "bedroomOne";
                move = "";
                locationDetector(move);
            }
        }
        private void storageTwo(string move)
        {
            background.Image = storageTwoImage;
            possibleMovements.Text = "S - bedroom 2";
            if (move == "back")
            {
                Location = "bedroomTwo";
                move = "";
                locationDetector(move);
            }
        }
        private bool check(string move)
        {
            if(move != "")
            {
                if (start)
                {
                    return true;
                }
            }
            return false;
        }
        private void locationDetector(string move)
        {
            crowbar.Hide();
            keyKitchen.Hide();
            keyLiving.Hide();
            keyBedroom.Hide();
            finishImage.Hide();
            key1image.Hide();
            key2image.Hide();
            key3image.Hide();
            doorCrackImage.Hide();
            if (check(move))
            {
                soundLevel++;
            }
            else
            {
                start = true;
            }
            if (Location == "garageRoom")
            {

                garageRoom(move);
            }
            else if (Location == "storage")
            {

                storageRoom(move);
            }
            else if (Location == "washingRoom")
            {

                washingRoom(move);
            }
            else if (Location == "kitchen")
            {

                kitchenRoom(move);
            }
            else if (Location == "storageLiving")
            {

                storageLiving(move);
            }
            else if(Location == "mainLivingRoom")
            {

                mainLivingRoom(move);
            }
            else if(Location == "livingRoomBedroom")
            {

                livingRoomBedroom(move);
            }
            else if(Location == "livingRoomHallway")
            {

                livingRoomHallway(move);
            }
            else if(Location == "bedroomOne")
            {

                bedroomOne(move);
            }
            else if (Location == "bedroomTwo")
            {

                bedroomTwo(move);
            }
            else if (Location == "storageOne")
            {

                storageOne(move);
            }
            else if (Location == "storageTwo")
            {

                storageTwo(move);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A)
            {
                left = true;
                moveController();
            }
            if (e.KeyData == Keys.D)
            {
                right = true;
                moveController();
            }
            if(e.KeyData == Keys.W)
            {
                forward = true;
                moveController();
            }
            if(e.KeyData == Keys.S)
            {
                back = true;
                moveController();
            }
        }
        private void moveController()
        {
            string move;
            if(right == true)
            {
                right = false;
                move = "right";
                locationDetector(move);
            }
            if (left == true)
            {
                left = false;
                move = "left";
                locationDetector(move);
            }
            if(forward == true)
            {
                forward = false;
                move = "forward";
                locationDetector(move);
            }
            if(back == true)
            {
                back = false;
                move = "back";
                locationDetector(move);
            }
        }

        private void end()
        {
            background.Image = closedDoor;
            key1image.Show();
            key2image.Show();
            key3image.Show();
            doorCrackImage.Show();
        }

        private void crowbar_Click(object sender, EventArgs e)
        {
            item4.Image = crowbarImage;
            crowbar.Hide();
            hideCrowbare = true;
        }

        private void keyKitchen_Click(object sender, EventArgs e)
        {
            item3.Image = kitchenKey;
            keyKitchen.Hide();
            hideKitchenKey = true;
        }

        private void keyLiving_Click(object sender, EventArgs e)
        {
            item2.Image = livingKey;
            keyLiving.Hide();
            hideLivingKey = true;
        }

        private void keyBedroom_Click(object sender, EventArgs e)
        {
            item1.Image = bedroomKey;
            keyBedroom.Hide();
            hideBedroomKey = true;
        }

        private void finishImage_Click(object sender, EventArgs e)
        {
            finishImage.Hide();
            if (item1.Image == bedroomKey & item2.Image == livingKey & item3.Image == kitchenKey & item4.Image == crowbarImage)
            {
                end();
            }
            else
            {
                possibleMovements.Text = "You do not have all the items required";
            }
        }

        private void key1image_Click(object sender, EventArgs e)
        {
            if(item1picked == true)
            {
                possibleMovements.Text = "Unlocked first lock";
                item1completed = true;
                item1.Dispose();
                key1image.Hide();
            }
            else
            {
                possibleMovements.Text = "Please choose the right item";
            }
            if(item1completed == true & item2completed == true & item3completed == true)
            {
                possibleMovements.Text = "crack the door open!!";
            }
        }

        private void doorCrackImage_Click(object sender, EventArgs e)
        {
            if (item4picked == true & item1completed == true & item2completed == true & item3completed == true)
            {
                possibleMovements.Text = "You escaped!!";
                background.Image = openDoor;
                item4.Dispose();
                doorCrackImage.Hide();
            }
            else
            {
                possibleMovements.Text = "Please choose the right item";
            }
        }

        private void key2image_Click(object sender, EventArgs e)
        {
            if (item2picked == true)
            {
                possibleMovements.Text = "Unlocked second lock";
                item2completed = true;
                item2.Dispose();
                key2image.Hide();
            }
            else
            {
                possibleMovements.Text = "Please choose the right item";
            }
            if (item1completed == true & item2completed == true & item3completed == true)
            {
                possibleMovements.Text = "crack the door open!!";
            }
        }

        private void key3image_Click(object sender, EventArgs e)
        {
            if (item3picked == true)
            {
                possibleMovements.Text = "Unlocked third lock";
                item3completed = true;
                item3.Dispose();
                key3image.Hide();
            }
            else
            {
                possibleMovements.Text = "Please choose the right item";
            }
            if (item1completed == true & item2completed == true & item3completed == true)
            {
                possibleMovements.Text = "crack the door open!!";
            }
        }

        private void item1_Click(object sender, EventArgs e)
        {
            item1picked = true;
            item2picked = false;
            item3picked = false;
            item4picked = false;
        }

        private void item2_Click(object sender, EventArgs e)
        {
            item1picked = false;
            item2picked = true;
            item3picked = false;
            item4picked = false;
        }

        private void item3_Click(object sender, EventArgs e)
        {
            item1picked = false;
            item2picked = false;
            item3picked = true;
            item4picked = false;
        }

        private void item4_Click(object sender, EventArgs e)
        {
            item1picked = false;
            item2picked = false;
            item3picked = false;
            item4picked = true;
        }

        private void soundTimer_Tick(object sender, EventArgs e)
        {
            soundLevel--;
        }

        private void soundUpdate_Tick(object sender, EventArgs e)
        {
            if(soundLevel == 1)
            {
                sound.Image = sound1;
            }
            if (soundLevel == 2)
            {
                sound.Image = sound2;
            }
            if (soundLevel == 3)
            {
                sound.Image = sound3;
            }
            if (soundLevel == 4)
            {
                sound.Image = sound4;
            }
        }
    }
}
