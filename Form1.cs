using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class Form1 : Form
    {
        private readonly Dictionary<string, string> characterSets = new Dictionary<string, string>
        {
            { "Lowercase", "abcdefghijklmnopqrstuvwxyz" },
            { "Uppercase", "ABCDEFGHIJKLMNOPQRSTUVWXYZ" },
            { "Digits", "0123456789" },
            { "Special Characters", "!@#$%^&*()_+" }
        };

        public Form1()
        {
            InitializeComponent();

            // Populate the CheckedListBox with character sets
            //checkedListBox1.Items.AddRange(characterSets.Keys.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Build the character set based on selected items in the CheckedListBox
            string characters = "";
            foreach (string selectedCharacterType in checkedListBox1.CheckedItems)
            {
                characters += characterSets[selectedCharacterType];
            }

            // Set the desired length of the password
            int passwordLength = int.Parse(textBox2.Text);

            // Generate a random password
            string password = GenerateRandomPassword(characters, passwordLength);

            // Display the password in the textBox1
            textBox1.Text = password;
        }

        private string GenerateRandomPassword(string characters, int length)
        {
            Random random = new Random();
            return new string(Enumerable.Repeat(characters, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // This method can be left empty for now since it's not used in the provided code.
        }
    }
}
