// See https://aka.ms/new-console-template for more information
hashTable.ucMethods run = new hashTable.ucMethods();
Console.WriteLine("1 To FindFrequency");
Console.WriteLine("2 To FindFrequency Paragraph");
int select = Convert.ToInt32(Console.ReadLine());
switch (select)
{
    case 1:
        run.findFrequency();
        break;
    case 2:
        run.findFrequencyParagraph();
        break;
}

