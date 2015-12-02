using System;
using Novacode;
using System.IO;
using System.Linq;

namespace _05.Word_Document_Generator
{
    public class WordDocumentGenerator
    {
        public static void Main()
        {
            using (DocX document = DocX.Create(@"../../NewWordDocument.docx"))
            {
                using (var reader = new StreamReader("../../text.txt"))
                {
                    //Text above picture
                    Paragraph paragraph = document.InsertParagraph();
                    paragraph.Alignment = Alignment.center;
                    paragraph.Append(reader.ReadLine()).FontSize(24).Bold();

                    //Picture
                    Novacode.Image img = document.AddImage(@"../../rpg-game.png");

                    paragraph = document.InsertParagraph();

                    Picture picture = img.CreatePicture();
                    picture.Width = picture.Width / 3;
                    picture.Height = picture.Height / 3;

                    paragraph.InsertPicture(picture);

                    //3 lines of text bellow picture
                    for (int i = 0; i < 3; i++)
                    {
                        document.InsertParagraph(reader.ReadLine());
                    }

                    //Bullets
                    var list = document.AddList(listType: ListItemType.Bulleted);
                    for (int i = 0; i < 3; i++)
                    {
                        document.AddListItem(list, reader.ReadLine());
                    }
                    document.InsertList(list);

                    //Empty line
                    document.InsertParagraph(reader.ReadLine());

                    //Table
                    Table table = document.AddTable(4, 3);
                    table.Alignment = Alignment.center;
                    table.Design = TableDesign.MediumGrid1Accent1;

                    for (int row = 0; row < 4; row++)
                    {
                        string[] rowContent = reader.ReadLine().Split(new char[] {' ', '\t'});
                        for (int col = 0; col < rowContent.Length; col++)
                        {
                            table.Rows[row].Cells[col].Paragraphs.First().Append(rowContent[col]);
                        }
                    }

                    document.InsertTable(table);

                    //Empty line
                    document.InsertParagraph(reader.ReadLine());

                    //Last two lines of text
                    paragraph = document.InsertParagraph();
                    paragraph.Alignment = Alignment.center;
                    paragraph.Append(reader.ReadLine()).FontSize(14);

                    paragraph = document.InsertParagraph();
                    paragraph.Alignment = Alignment.center;
                    paragraph.Append(reader.ReadLine()).FontSize(22).UnderlineStyle(UnderlineStyle.singleLine);
                }

                document.Save();
            }
        }
    }
}
