using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class PasswordGenerator : Form
    {
        public PasswordGenerator()
        {
            InitializeComponent();
        }



        private void PasswordGenerator_Load(object sender, EventArgs e)
        {
            string todaydate = DateTime.Now.ToString("dd-MMM-yyyy"); //get Today's Date and convert to string
            lblDate.Text = todaydate; // set Date to label date  
            string username = "Username"; // get Username  
            lblUsername.Text = username; //set username to label Username
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            CboLength.SelectedIndex = -1; // restore selection to default position
            ChkNumbers.Checked = false; // disable checkbox
            ChkSpecialCharacters.Checked = false; // disable checkbox
            txtPassword.Text = "";
        }

        private void btnGenPass_Click(object sender, EventArgs e)
        {
            /*************************************************
             * Author: 
             * Program: this event create an instance of the
             * random class, alphanumeric constants and
             * variables for holding length of password, 
             * result of checkboxes and the generated password 
             ***************************************************/
            Random rnd = new Random(); // instance of Random class  

            const string ALPHABET = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string SPECIAL_CHARACTERS = "!@#$%&*";
            const string NUMBERS = "1234567890";


            int lengthOfPassword = Convert.ToInt32(CboLength.SelectedItem);
            bool useSpecialCharacters = ChkSpecialCharacters.Checked;
            bool useNumbers = ChkNumbers.Checked;
            string password = ""; 


            for(int i = 1; i <= lengthOfPassword; i++)
            {
                int randomNumber = rnd.Next(0, 25);
                string pwChar = ALPHABET[randomNumber].ToString();
                password = password + pwChar;
            }
            /************************************************
             *Program: condition for when Special Character 
             *checkbox is selected
             ***********************************************/
            if (useSpecialCharacters)
            {
                int insertPos = lengthOfPassword / 3; //set inserting positon
                int randomNumber = rnd.Next(0, 6); //generate random character to be inserted
                char extraChar = SPECIAL_CHARACTERS[randomNumber]; //get random character generated
                StringBuilder sb = new StringBuilder(password);
                sb[insertPos] = extraChar; //insert generated number to password
                sb.Remove(insertPos + 1, 0); //remove extra character in password
                password = sb.ToString(); // save generated password to variable password
            }

            /************************************************
             *Program: condition for when Numbers 
             * checkbox is selected
             ***********************************************/

            if (useNumbers)
            {
                int insertPos = lengthOfPassword / 2; //set inserting positon
                int randomNumber = rnd.Next(0, 9); //generate random numbers to be inserted
                char extraChar = NUMBERS[randomNumber]; //check number with available list of numbers 
                StringBuilder sb = new StringBuilder(password); 
                sb[insertPos] = extraChar; //insert generated number to password
                sb.Remove(insertPos + 1, 0); //remove extra character in password
                password = sb.ToString(); // save generated password to variable password
            }
            txtPassword.Text = password; // set generated password to TextField
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close(); //close form
        }
    }
}
