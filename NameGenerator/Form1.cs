using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NameGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int MAX_LENGTH = 10; //Maximum characters in generated name
        const int MIN_LENGTH = 3;
        const int MAX_MATCH = 4; //Maximum consonants or vowels that can be in a row
        char[] VOWELS = { 'a', 'e', 'i', 'o', 'u', 'y' };
        char[] CONSONANTS = { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z' };


        private void genButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("---Start Name Gen---");
            Random rnd = new Random();

            int nameLength = rnd.Next(Convert.ToInt32(min_length_box.Value), Convert.ToInt32(max_length_box.Value));
            System.Diagnostics.Debug.WriteLine("Name Length: " + nameLength);
            string genName = "";
            bool genVowel;
            
            for(int i = 0; i < nameLength; i++)
            {
                System.Diagnostics.Debug.WriteLine("--Start Char Loop--");
                genVowel = false; //unasigned genvowel issue. Cause unknown
                //Decide on if a consonant or vowel will be generated
                if (genName.Length >= Convert.ToInt32(max_in_row_box.Value)) //Make sure there are enough char that it matters 
                {
                    //Make list of chars to be checked
                    List<char> checkChars = new List<char>();
                    for (int a = 1; a < Convert.ToInt32(max_in_row_box.Value) + 1; a++) //Additional one to avoid out of range exception
                    {
                        System.Diagnostics.Debug.WriteLine("Attempting to add to checkChars");
                        checkChars.Add(genName[genName.Length - a]);
                    }
                    //Debug list checkChars
                    /*
                    System.Diagnostics.Debug.WriteLine(checkChars.Count);
                    foreach(char a in checkChars)
                    {
                        System.Diagnostics.Debug.WriteLine(a);
                    }
                    */

                    //Now check if the whole list are all consonants or all vowels
                    bool isInconsistant = false;
                    bool isFirstVowel = VOWELS.Contains(checkChars[0]);
                    for(int a = 0; a < checkChars.Count; a++)
                    {

                        if(VOWELS.Contains(checkChars[a]) != isFirstVowel)
                        {
                            //If there is an inconsistancy then we are free to generate random char
                            System.Diagnostics.Debug.WriteLine("Inconsistancy in past " + Convert.ToInt32(max_in_row_box.Value) + " chars (" + a +"/"+checkChars.Count+"). Generating Random Char.");
                            isInconsistant = true;
                            if (rnd.Next(2) == 0)
                            {
                                genVowel = true;
                            }
                            else
                            {
                                genVowel = false;
                            }

                        }
                        else if(isFirstVowel == true)
                        {
                            //first char is vowel and whole list is same. Gen consonant
                            System.Diagnostics.Debug.WriteLine("Char " + a + "/" + checkChars.Count +" is vowel. Gen set to Consonant");
                            genVowel = false;
                        }
                        else
                        {
                            //Otherwise whole list is consonant and we need to gen vowel
                            System.Diagnostics.Debug.WriteLine("Char " + a + "/" + checkChars.Count + " is consonant. Gen set to vowel");
                            genVowel = true;
                        }

                        //If there is an inconsistancy break loops
                        if(isInconsistant) { System.Diagnostics.Debug.WriteLine("End of Loop due to inconsistancy, breaking"); break; }
                    }

                    /*
                    //if all last characters are vowels, gen consonant
                    //If all last characters are consonants gen vowel
                    //otherwise gen random
                    if (isLastCharVowel == true && is2LastCharVowel == true && is3LastCharVowel == true)
                    {
                        System.Diagnostics.Debug.WriteLine("Last 3 Vowels, gen consonant");
                        genVowel = false;
                    }
                    else if (isLastCharVowel == false && is2LastCharVowel == false && is3LastCharVowel == false)
                    {
                        System.Diagnostics.Debug.WriteLine("Last 3 Consonants, gen vowel");
                        genVowel = true;
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine("Fell to random");
                        if (rnd.Next(2) == 0)
                        {
                            genVowel = true;
                        }
                        else
                        {
                            genVowel = false;
                        }
                    }
                    */

                }
                else //If there aren't enough chars to matter pick randomly
                {
                    System.Diagnostics.Debug.WriteLine("Not enough char. Gen random");
                    if (rnd.Next(2) == 0)
                    {
                        genVowel = true;
                    }
                    else
                    {
                        genVowel = false;
                    }
                }


                //Add vowel or consonant to name
                if (genVowel == true)
                {
                    genName += VOWELS[rnd.Next(VOWELS.Length - 1)].ToString();
                }
                else
                {
                    genName += CONSONANTS[rnd.Next(CONSONANTS.Length - 1)].ToString();
                }

                System.Diagnostics.Debug.WriteLine("--End Char Loop--");
            }
            //Capitalize first letter
            genName = char.ToUpper(genName[0]) + genName.Substring(1);

            genBox.Text = genName;
            System.Diagnostics.Debug.WriteLine("Gen Name: " + genName);

            System.Diagnostics.Debug.WriteLine("---End Name Gen---");
        }
    }
}
