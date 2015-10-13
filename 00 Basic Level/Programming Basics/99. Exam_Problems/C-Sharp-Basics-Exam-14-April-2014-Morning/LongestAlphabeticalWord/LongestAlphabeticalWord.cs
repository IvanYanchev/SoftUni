using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestAlphabeticalWord
{
    class LongestAlphabeticalWord
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            char[] lettersInWord = word.ToCharArray();
            int size = int.Parse(Console.ReadLine());
            char[,] block = new char[size, size];
            int index = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (index >= lettersInWord.Length)
                    {
                        index = 0;
                    }
                    block[i, j] = lettersInWord[index];
                    index++;
                }
            }

            int longestWordLenght = 1;
            string longestAlphabeticalWord = Convert.ToString(block[0,0]);


            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    // RIGHT
                    int wordLenght = 1;
                    string alphabeticalWord = Convert.ToString(block[i, j]); 
                    for (int k = j; k < size; k++)
                    {
                        if (k + 1 >= size)
                        {
                            break;
                        }
                        else if (block[i, k + 1] > block[i, k])
                        {
                            wordLenght++;
                            alphabeticalWord = alphabeticalWord + block[i, k + 1];
                            if (wordLenght > longestWordLenght)
                            {
                                longestWordLenght = wordLenght;
                                longestAlphabeticalWord = alphabeticalWord;
                            }
                            else if (wordLenght == longestWordLenght)
                            {
                                int comp = alphabeticalWord.CompareTo(longestAlphabeticalWord);
                                if (comp == -1)
                                {
                                    longestAlphabeticalWord = alphabeticalWord;
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                    }

                    // LEFT
                    wordLenght = 1;
                    alphabeticalWord = Convert.ToString(block[i, j]);
                    for (int k = j; k >= 0 ; k--)
                    {
                        if (k - 1 < 0)
                        {
                            break;
                        }
                        else if (block[i, k - 1] > block[i, k])
                        {
                            wordLenght++;
                            alphabeticalWord = alphabeticalWord + block[i, k - 1];
                            if (wordLenght > longestWordLenght)
                            {
                                longestWordLenght = wordLenght;
                                longestAlphabeticalWord = alphabeticalWord;
                            }
                            else if (wordLenght == longestWordLenght)
                            {
                                int comp = alphabeticalWord.CompareTo(longestAlphabeticalWord);
                                if (comp == -1)
                                {
                                    longestAlphabeticalWord = alphabeticalWord;
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                    }

                    // DOWN
                    wordLenght = 1;
                    alphabeticalWord = Convert.ToString(block[i, j]);
                    for (int k = i; k < size; k++) 
                    {
                        if (k + 1 >= size)
                        {
                            break;
                        }
                        else if (block[k + 1, j] > block[k, j])
                        {
                            wordLenght++;
                            alphabeticalWord = alphabeticalWord + block[k + 1, j];
                            if (wordLenght > longestWordLenght)
                            {
                                longestWordLenght = wordLenght;
                                longestAlphabeticalWord = alphabeticalWord;
                            }
                            else if (wordLenght == longestWordLenght)
                            {
                                int comp = alphabeticalWord.CompareTo(longestAlphabeticalWord);
                                if (comp == -1)
                                {
                                    longestAlphabeticalWord = alphabeticalWord;
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                    }

                    // UP
                    wordLenght = 1;
                    alphabeticalWord = Convert.ToString(block[i, j]);
                    for (int k = i; k >= 0; k--)
                    {
                        if (k - 1 < 0)
                        {
                            break;
                        }
                        else if (block[k-1, j] > block[k, j])
                        {

                            wordLenght++;
                            alphabeticalWord = alphabeticalWord + block[k - 1, j];
                            if (wordLenght > longestWordLenght)
                            {
                                longestWordLenght = wordLenght;
                                longestAlphabeticalWord = alphabeticalWord;
                            }
                            else if (wordLenght == longestWordLenght)
                            {
                                int comp = alphabeticalWord.CompareTo(longestAlphabeticalWord);
                                if (comp == -1)
                                {
                                    longestAlphabeticalWord = alphabeticalWord;
                                }
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            Console.WriteLine(longestAlphabeticalWord);
        }
    }
}
