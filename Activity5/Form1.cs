using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Activity5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SelectFile_Click(object sender, EventArgs e)
        {
            string fileContents = ""; // A string variable that will contain the contents of the inputFile
            string fileContentsLowercase; // A string variable that will contain the value of the fileContents variable after it has been set to lowercase
            string fileContentsFirstWordAlphabetically; // A string variable that will contain the first word alphabetically in the fileContents variable
            string fileContentsLastWordAlphabetically; // A string variable that will contain the last word alphabetically in the fileContents variable
            string fileContentsLongestWord; // A string variable that will contain the longest word in the the fileContents variable
            string fileContentsWordWithMostVowels; // A string variable that will contain the word with the most vowels in the fileContents variable
            StreamReader inputFile; // A StreamReader object to read the contents of the inputFile
            StreamWriter outputFile; // A StreamWriter object to write the result to an output file

            // The user can select a text file for the program to use using a standard OpenFileDialog. Made with help from the textbook (Gaddis, 308-310, 323)
            if(OpenFileDialog.ShowDialog() == DialogResult.OK) // The following code runs if a file is chosen using the OpenFileDialog
            {
                try
                {
                    inputFile = File.OpenText(OpenFileDialog.FileName); // Sets the StreamReader object to the file that the user selected

                    while (!inputFile.EndOfStream) // This loop runs for every line of the file, adding each of them to the fileContents variable. Made with help from the textbook (Gaddis, 316).
                    {
                        fileContents += inputFile.ReadLine() + " "; // Sets the fileContents variable to the contents of the chosen file
                    }

                    inputFile.Close(); // Closes the file
                } 
                catch(Exception ex) // If an error occurs while reading the file, an error message is displayed
                {
                    MessageBox.Show(ex.Message);
                }
            }

            fileContents = fileContents.Trim(); // Removes the extra space from the end of the fileContents string

            fileContentsLowercase = fileContents.ToLower(); // Sets the fileContentsLowercase variable to the lower case version of the fileContents variable
            TextBoxLowercase.Text = fileContentsLowercase; // Sets the text of the TextBoxLowercase TextBox to the fileContentsLowercase variable

            fileContentsFirstWordAlphabetically = FindFirstWordAlphabetically(fileContents); // Sets the fileContentsFirstWordAlphabetically variable to the first word alphabetically in the fileContents variable
            TextBoxFirstWordAlphabetically.Text = fileContentsFirstWordAlphabetically; // Sets the text of the TextBoxFirstWordAlphabetically TextBox to the fileContentsFirstWordAlphabetically variable

            fileContentsLastWordAlphabetically = FindLastWordAlphabetically(fileContents); // Sets the fileContentsLastWordAlphabetically variable to the last word alphabetically in the fileContents variable
            TextBoxLastWordAlphabetically.Text = fileContentsLastWordAlphabetically; // Sets the text of the TextBoxLastWordAlphabetically TextBox to the fileContentsLasttWordAlphabetically variable

            fileContentsLongestWord = FindLongestWord(fileContents); // Sets the fileContentsLongestWord variable to the longest word in the fileContents variable
            TextBoxLongestWord.Text = fileContentsLongestWord; // Sets the text of the TextBoxLongestWord TextBox to the fileContentsLongestWord variable

            fileContentsWordWithMostVowels = FindWordWithMostVowels(fileContents); // Sets the fileContentsWordWithMostVowels variable to the word with the most vowels in the fileContents variable
            TextBoxWordWithMostVowels.Text = fileContentsWordWithMostVowels; // Sets the text of the TextBoxWordWithMostVowels TextBox to the the fileContentsWordWithMostVowels variable

            // The formatted strings are also written to an output file. Made with help from the textbook (Gaddis, 300)
            try
            {
                outputFile = File.CreateText("output.txt"); // A text file called output.txt is created

                outputFile.WriteLine(fileContentsLowercase); // Adds the fileContentsLowercase variable to the file
                outputFile.WriteLine(fileContentsFirstWordAlphabetically); // Adds the fileContentsFirstWordAlphabetically to the file
                outputFile.WriteLine(fileContentsLastWordAlphabetically); // Adds the fileContentsLastWordAlphabetically to the file
                outputFile.WriteLine(fileContentsLongestWord); // Adds the fileContentsLongestWord to the file
                outputFile.WriteLine(fileContentsWordWithMostVowels); // Adds the fileContentsWordWithMostVowels to the file
                outputFile.Close(); // Closes the file
            }
            catch(Exception ex) // If an exception occurs, an error message is displayed
            {
                MessageBox.Show(ex.Message);
            }

        }

        // Takes in a sentence in the form of a string and returns the first word alphabetically
        private string FindFirstWordAlphabetically(string sentence)
        {
            string firstWordAlphabetically; // A string variable that will eventually contain the first word in the sentence alphabetically
            List<string> words = SentenceToList(sentence); // A list of words in the sentence

            firstWordAlphabetically = words[0]; // Sets the firstWordAlphabetically variable to the first word in the sentence by default
            for(int i = 1; i < words.Count; i++) // This loop iterates over every word in the sentence except for the first one, as the the firstWordAlphabetically variable is already equal to the first word
            {
                firstWordAlphabetically = CompareWords(words[i], firstWordAlphabetically); // Compares the current word with the value of the firstWordAlphabetically variable, sets the firstWordAlphabetically variable to the result
            }

            return firstWordAlphabetically; // Returns the firstWordAlphabetically variable
        }

        // Takes in a sentence in the form of a string and returns the last word alphabetically
        private string FindLastWordAlphabetically(string sentence)
        {
            string lastWordAlphabetically; // A string variable that will eventually contain the last word in the sentence alphabetically
            List<string> words = SentenceToList(sentence); // A list of words in the sentence

            lastWordAlphabetically = words[0]; // Sets the lastWordAlphabetically variable to the first word in the sentence by default
            for (int i = 1; i < words.Count; i++) // This loop iterates over every word in the sentence except for the first one, as the the lastWordAlphabetically variable is already equal to the first word
            {
                if(CompareWords(words[i], lastWordAlphabetically) == lastWordAlphabetically) // Compares the current word with the value of the lastWordAlphabetically variable. If the lastWordAlphabetically variable precedes the current word alphabetically, the lastWordAlphabetically variable is set to the current word
                {
                    lastWordAlphabetically = words[i];
                }
            }

            return lastWordAlphabetically; // Returns the lastWordAlphabetically variable
        }

        // Takes in a sentence in the form of a string and returns the longest word in the sentence
        private string FindLongestWord(string sentence)
        {
            string longestWord; // A string variable that will eventually contain the longest word in the sentence
            List<string> words = SentenceToList(sentence); // A list of words in the sentence

            longestWord = words[0]; // Sets the longestWord variable to the first word in the sentence by default
            for(int i = 1; i < words.Count; i++) // This loop iterates over every word in the sentence except for the first one, as the the longestWord variable is already equal to the first word
            {
                if(words[i].Length > longestWord.Length) // Compares the length of the current word to the length of the longestWord variable. If the current word is longer than the longestWord variable, the longestWord variable is set to the current word
                {
                    longestWord = words[i];
                }
            }

            return longestWord; // Returns the longestWord variable
        }

        // Takes in a sentence in the form of a string and returns the word in the sentence with the most vowels
        private string FindWordWithMostVowels(string sentence)
        {
            string wordWithMostVowels; // A string variable that will eventually contain the word with the most vowels
            List<string> words = SentenceToList(sentence); // A list of words in the sentence

            wordWithMostVowels = words[0]; // Sets the wordWithMostVowels variable to the first word in the sentence by default
            for (int i = 0; i < words.Count; i++) // This loop iterates over every word in the sentence except for the first one, as the the wordWithMostVowels variable is already equal to the first word
            {
                if(VowelsInWord(words[i]) > VowelsInWord(wordWithMostVowels)) // Compares the number of vowels in the current word with that of the wordWithMostVowels vairalbe. If the current word contains more vowels than the wordWithMostVowels variable, the wordWithMostVowels variable is set to the current word
                {
                    wordWithMostVowels = words[i];
                }
            }

            return wordWithMostVowels; // Returns the wordWithMostVowels variable
        }

        // Takes in a word in the form of a string and returns the number of vowels in that word
        private int VowelsInWord(string word)
        {
            int vowels = 0; // An integer variable that will contain the number of vowels in the word

            for(int i = 0; i < word.Length; i++) // This loop iterates over every letter in the word
            {
                if (word[i] == 'a' || word[i] == 'e' || word[i] == 'i' || word[i] == 'o' || word[i] == 'u') // If the current letter is a vowel, the vowels variable is incremented
                {
                    vowels++;
                }
            }

            return vowels; // Returns the vowels variable
        }

        // Takes in a sentence as a string and returns a list of strings representing the words in that sentence
        private List<string> SentenceToList(string sentence)
        {
            List<string> words = new List<string>(); // A list of strings that will eventually contain the words in the sentence

            words.Add(""); // Adds an item to the words list as it will need to contain at least one item
            for (int i = 0, j = 0; i < sentence.Length; i++) // This loop iterates over character in the sentence. It has two counter variables, one to track the current character in the sentence and another to keep track of the current item in the words list
            {
                if (sentence[i] != ' ') // If the current character is not a space, it is added to the current item of the words list. It is set to lower case as strings are easier to compare when they are in the same case
                {
                    words[j] += sentence[i].ToString().ToLower();
                }
                else // If the current character is a space, then a new item is added to the words list and the counter variable tracking the current item in the words list is incremented
                {
                    j++;
                    words.Add("");
                }
            }

            return words; // Returns the words list
        }

        // This method takes in two strings and returns whichever is first alphabetically
        private string CompareWords(string word1, string word2)
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz"; // A string that contains the alphabet

            for(int i = 0; i < word1.Length; i++) // This loop iterates over the two words one character at a time, comparing them to see which is first alphabetically
            {
                if (alphabet.IndexOf(word1[i]) < alphabet.IndexOf(word2[i])) // If the current character in word1 appears earlier in the alphabet than the current character in word2 then word1 is returned
                {
                    return word1;
                }
                else if(alphabet.IndexOf(word1[i]) > alphabet.IndexOf(word2[i])) // If the current character in word2 appears earlier in the alphabet than the current character in word1 then word2 is returned
                {
                    return word2;
                }
            }

            return word1; // If the program reaches this point then that means that the two words are identical, so it doesn't matter which is returned

        }

    }
}

// References
// Gaddis, T. (2020). Starting Out With Visual C#. Pearson.