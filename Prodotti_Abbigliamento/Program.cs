// See https://aka.ms/new-console-template for more information
string filePath1 = "prodotti_inflazione.txt";
string[] prodotti = File.ReadAllLines("prodotti.csv");
string[] colonne = new string[5];
float prezzo;
string filePath2 = "sport.txt";
string filePath3 = "shoes.txt";
string filePath4 = "donna.txt";
string filePath5 = "uomo.txt";
string filePath6 = "accessori.txt";
string filePath7 = "bambino.txt";
StreamWriter writer1 = new StreamWriter(filePath1);
StreamWriter writer2 = new StreamWriter(filePath2);
StreamWriter writer3 = new StreamWriter(filePath3);
StreamWriter writer4 = new StreamWriter(filePath4);
StreamWriter writer5 = new StreamWriter(filePath5);
StreamWriter writer6 = new StreamWriter(filePath6);
StreamWriter writer7 = new StreamWriter(filePath7);
for (int i = 0; i < prodotti.Length; i++)
{
    colonne = prodotti[i].Split(',');
    for(int j = 0; j < colonne.Length; j++)
    {
        if (j == 3 && i != 0)
        {
            colonne[3] = colonne[3].Replace('.', ',');
            prezzo = float.Parse(colonne[j]);
            prezzo += prezzo * 10 / 100;
            colonne[3] = prezzo.ToString();
        }
        if(j == 2 && i != 0)
        {
            if(colonne[j] == "Sport")
            {
                for(int k = 0; k < colonne.Length; k++)
                {
                    writer2.Write(colonne[k] + " ");
                }
                writer2.WriteLine();
            }
            if (colonne[j] == "Shoes")
            {
                for (int k = 0; k < colonne.Length; k++)
                {
                    writer3.Write(colonne[k] + " ");
                }
                writer3.WriteLine();
            }
            if (colonne[j] == "Donna")
            {
                for (int k = 0; k < colonne.Length; k++)
                {
                    writer4.Write(colonne[k] + " ");
                }
                writer4.WriteLine();
            }
            if (colonne[j] == "Uomo")
            {
                for (int k = 0; k < colonne.Length; k++)
                {
                    writer5.Write(colonne[k] + " ");
                }
                writer5.WriteLine();
            }
            if (colonne[j] == "Accessori")
            {
                for (int k = 0; k < colonne.Length; k++)
                {
                    writer6.Write(colonne[k] + " ");
                }
                writer6.WriteLine();
            }
            if (colonne[j] == "Bambino")
            {
                for (int k = 0; k < colonne.Length; k++)
                {
                    writer7.Write(colonne[k] + " ");
                }
                writer7.WriteLine();
            }
        }
    }
    for (int j = 0; j < colonne.Length; j++)
    {
        writer1.Write(colonne[j] + " ");
    }
    writer1.WriteLine();
}
writer1.Close();
writer2.Close();
writer3.Close();
writer4.Close();
writer5.Close();
writer6.Close();
writer7.Close();
