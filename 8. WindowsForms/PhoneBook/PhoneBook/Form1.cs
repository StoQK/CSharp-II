using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // added in order to input/output files

namespace PhoneBook
{
    public partial class Form1 : Form
    {

        Dictionary<string, string> myPhoneBook = new Dictionary<string, string>(); // declaration of the dictionary

        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Controls.Clear(); // clears the whole form and initializes everything to it's default value
            myPhoneBook.Clear(); // removes all the keys and values from the dictionary
            this.InitializeComponent(); // initialiazes Form1
        }

        private void buttonAddContact_Click(object sender, EventArgs e)
        {
            int phoneNumber;

            try // checks if all the entries are correctly inputed
            {
                phoneNumber = int.Parse(TextBoxPhone.Text);

                if (TextBoxName.Text != string.Empty && phoneNumber != 0) // checks if textboxes are not empty
                {
                    listBoxItemsCollection.Items.Add(TextBoxName.Text + "-0" + phoneNumber); // adds the name from the textboxName and the phone number to the listboxcollection
                }
                else if (TextBoxName.Text == string.Empty) // checks if TextBoxName is empty and shows a warning message
                {
                    MessageBox.Show("Please enter a contact name!", "Input value missing", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
                else if (phoneNumber == 0) // checks if the a phone number is entered and shows a message if empty
                {
                    MessageBox.Show("Please enter a phone number!", "Input value missing", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
            }
            catch (FormatException) // Makes sure the format of the number input is correct
            {
                MessageBox.Show("Incorrect input", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            try
            {
                myPhoneBook.Add(TextBoxName.Text, TextBoxPhone.Text); // Checks if an entry already exists in the dictionary
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Such name or number already exists", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);   
            }
     
            TextBoxName.Clear(); // clears the name textbox after the entry is added
            TextBoxPhone.Clear(); // clears the number textbox after the entry is added
        }

        private void buttonDeleteContact_Click(object sender, EventArgs e)
        {
            try
            {
                string itemToRemove = listBoxItemsCollection.SelectedItem.ToString(); 
                string takeValue = itemToRemove.Split('-')[0];
                if (myPhoneBook.ContainsKey(takeValue))
                {
                    myPhoneBook.Remove(takeValue); // removes the element with the key(name in our case) from the dictionary
                }

                listBoxItemsCollection.Items.Remove(listBoxItemsCollection.SelectedItem); // removes selected item from listboxcollection
            }
            catch (Exception) // if no item is selected, a message appears
            {
                MessageBox.Show("Select an item to delete", "No item selected", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
        }

        private void buttonLoadContacts_Click(object sender, EventArgs e) // contacts are loaded from an external text file
        {
            OpenFileDialog openPhoneBook = new OpenFileDialog();
            string fileName = string.Empty;
            openPhoneBook.Filter = "Text (*.txt)|*.txt";

            List<string> items = new List<string>(); // all the items from the file are later added to a list items

            if (openPhoneBook.ShowDialog() == DialogResult.OK)
            {
                string line;
                fileName = openPhoneBook.FileName;
                StreamReader sr = new StreamReader(fileName); // a streamreader is used to read the file

                while ((line = sr.ReadLine()) != null) // reads the whole file until the end
                {
                    myPhoneBook.Add(line.Split('-')[0], line.Split('-')[1]); // adds all the values from the file to the dictionary as keys and values, splitting the name from the number
                    listBoxItemsCollection.Items.Add(line); // adds the values from the file to the listboxcollection
                }
                sr.Close(); // closes the streamreader
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e) // saves the current form in a file
        {
            string path = "phoneBook.txt";
            if (!File.Exists(path)) // if no file with such name exists, it is then created
            {
                FileStream fs = File.Create(path);
                fs.Close();
            }
            using (TextWriter textWriter = File.CreateText(path)) // if such an item exists, adds all the values, each on new line
            {
                foreach (string item in listBoxItemsCollection.Items)
                {
                    textWriter.WriteLine(item);
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e) // saves the file as, so that a different path can be chosen, for example
        {
            SaveFileDialog saveFile = new SaveFileDialog(); // opens a dialog to choose the location where to save
            saveFile.Filter = "Text (*.txt)|*.txt";
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                using (var streamWriter = new StreamWriter(saveFile.FileName, false)) // saves all the inputs in a new file, each on a different line
                {
                    foreach (var item in listBoxItemsCollection.Items)
                    {
                        streamWriter.WriteLine(item.ToString());
                    }
                }
                // no streamWriter.Close() function is required, because using is used
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try // checks if an item to delete is selected
            {
                string itemToRemove = listBoxItemsCollection.SelectedItem.ToString();
                string takeValue = itemToRemove.Split('-')[0]; // splits the selected item where the '-' is in order to remove it from the dictionary
                if (myPhoneBook.ContainsKey(takeValue))
                {
                    myPhoneBook.Remove(takeValue); // makes sure the value exists in the dictionary and removes it
                }

                listBoxItemsCollection.Items.Remove(listBoxItemsCollection.SelectedItem); // removes the item from the list
            }
            catch (Exception)
            {
                MessageBox.Show("Select an item to delete", "No item selected", MessageBoxButtons.OKCancel, MessageBoxIcon.Stop);
            }
            
        }

        private void buttonSearchByName_Click(object sender, EventArgs e)
        {

            if (myPhoneBook.ContainsKey(TextBoxName.Text)) // checks if the value from the textbox exists in the dictionary as a key
            {
                var searchedValue = myPhoneBook.FirstOrDefault(x => x.Key == TextBoxName.Text).Value; // lambda expression to take the value of the selected key
                MessageBox.Show(TextBoxName.Text + " - " + searchedValue, "Contact Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information); // message box that shows the searched contact information
                TextBoxName.Clear(); // if such a value is found, the textbox is cleared
            }
            else if (TextBoxName.Text == string.Empty) // checks to make sure the text box is not empty and a message appears if it is
            {
                MessageBox.Show("Please, enter a contact name to search for", "No contact", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else // if no contact is found, a message appears
            {
                MessageBox.Show("No such contact", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void buttonSearchByNumber_Click(object sender, EventArgs e)
        {
            if (myPhoneBook.ContainsValue(TextBoxPhone.Text)) // checks if the key from the textbox exists in the dictionary as a value
            {
                var searchedKey = myPhoneBook.FirstOrDefault(x => x.Value == TextBoxPhone.Text).Key; // lambda expression to take the key of the selected value
                MessageBox.Show(searchedKey + " - " + TextBoxPhone.Text, "Contact Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                TextBoxPhone.Clear();
            }
            else if (TextBoxPhone.Text == string.Empty) // checks to make sure the text box is not empty and a message appears if it is
            {
                MessageBox.Show("Please, enter a number to search for", "No number", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else // if no contact is found, a message appears
            {
                MessageBox.Show("No such number", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e) // has the same function as the "Load" button
        {
            OpenFileDialog openPhoneBook = new OpenFileDialog();
            string fileName = string.Empty;
            openPhoneBook.Filter = "Text (*.txt)|*.txt";

            List<string> items = new List<string>();

            if (openPhoneBook.ShowDialog() == DialogResult.OK)
            {
                string line;
                fileName = openPhoneBook.FileName;
                StreamReader sr = new StreamReader(fileName);

                while ((line = sr.ReadLine()) != null)
                {
                    listBoxItemsCollection.Items.Add(line);
                }

                sr.Close();
            }
        }

        private void editContactToolStripMenuItem_Click(object sender, EventArgs e) // after a contact from the list is selected, get it's value back to the textboxes and removes it temporarily from the list
        {
            string contact = listBoxItemsCollection.SelectedItem.ToString();
            string getName = contact.Split('-')[0]; // splits the selected item from the list, so that the name is taken   
            string getNumber = contact.Split('-')[1]; // splits the selected item from the list, so that the number is taken              
            TextBoxName.Text = getName; // assigns the value of the name to the text box, so that it appears there
            TextBoxPhone.Text = getNumber; // assigns the value of the number to the text box, so that it appears there

            listBoxItemsCollection.Items.Remove(listBoxItemsCollection.SelectedItem); // temporarily removes the item from the list
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close(); // closes the program
        }

    }
}
