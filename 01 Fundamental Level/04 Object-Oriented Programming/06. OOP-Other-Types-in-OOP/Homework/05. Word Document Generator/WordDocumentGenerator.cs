using System;
using System.Drawing;
using Novacode;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

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
                    var paragraph = document.InsertParagraph();
                    paragraph.Alignment = Alignment.center;
                    paragraph.Append(reader.ReadLine()).FontSize(24).Bold();

                    //Picture
                    var img = document.AddImage(@"../../rpg-game.png");

                    paragraph = document.InsertParagraph();

                    Picture picture = img.CreatePicture();
                    picture.Width = picture.Width / 3;
                    picture.Height = picture.Height / 3;

                    paragraph.InsertPicture(picture);


                    //3 lines of text bellow picture
                    for (int i = 0; i < 3; i++)
                    {
                        paragraph = document.InsertParagraph();
                        paragraph.Append(reader.ReadLine());
                        paragraph.ReplaceText("role playing game", "role playing game", false, RegexOptions.None, new Formatting() { Bold = true });

                        paragraph.ReplaceText("grand prize!", "grand prize!", false, RegexOptions.None, new Formatting() { UnderlineStyle = UnderlineStyle.singleLine });
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
                    var table = document.AddTable(4, 3);
                    table.Alignment = Alignment.center;
                    table.Design = TableDesign.TableGrid;

                    for (int i = 0; i < 3; i++)
                    {
                        table.Rows[0].Cells[i].FillColor = Color.CornflowerBlue;
                    }


                    for (int row = 0; row < 4; row++)
                    {
                        string[] rowContent = reader.ReadLine().Split(new char[] { ' ', '\t' });
                        for (int col = 0; col < rowContent.Length; col++)
                        {
                            table.Rows[row].Cells[col].Paragraphs.First().Append(rowContent[col]).Alignment = Alignment.center;
                        }
                    }

                    document.InsertTable(table);

                    //Empty line
                    document.InsertParagraph(reader.ReadLine());

                    //Last two lines of text
                    paragraph = document.InsertParagraph();
                    paragraph.Append(reader.ReadLine()).Alignment = Alignment.center;
                    paragraph.ReplaceText("SPECTACULAR", "SPECTACULAR", false, RegexOptions.None, new Formatting() { Bold = true });

                    paragraph = document.InsertParagraph();
                    paragraph.Append(reader.ReadLine())
                        .FontSize(20)
                        .Font(new FontFamily("Arial"))
                        .UnderlineStyle(UnderlineStyle.singleLine)
                        .Alignment = Alignment.center;
                }

                document.Save();
            }
        }
    }
}
