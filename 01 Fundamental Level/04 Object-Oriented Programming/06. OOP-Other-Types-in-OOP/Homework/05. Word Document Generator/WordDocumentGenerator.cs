using System;
using Novacode;
using System.IO;

namespace _05.Word_Document_Generator
{
    public class WordDocumentGenerator
    {
        public static void Main()
        {
            using (DocX doc = DocX.Create(@"../../NewWordDocument.docx"))
            {
                //Novacode.Image img = doc.AddImage(@"../../rpg-game.png");

                string text = File.ReadAllText("../../text.txt");

                doc.InsertParagraph(text);

                doc.Save();
            }
        }
    }
}
