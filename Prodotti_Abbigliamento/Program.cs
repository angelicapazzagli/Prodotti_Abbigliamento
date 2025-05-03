// See https://aka.ms/new-console-template for more information
string filePath1 = "prodotti_inflazione.txt";
string[] prodotti = File.ReadAllLines("prodotti.csv");
string[] colonne = new string[5];
float prezzo;
StreamWriter writer1 = new StreamWriter(filePath1);
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
    }
    for (int j = 0; j < colonne.Length; j++)
    {
        writer1.Write(colonne[j] + " ");
    }
    writer1.WriteLine();
}
writer1.Close();

string categorie = "";
for(int i = 1; i < prodotti.Length; i++)
{
    string categoria = prodotti[i].Split(',')[2];
    if(!categorie.Contains(categoria))
    {
        categorie += categoria + " ";
    }
}
categorie = categorie.Substring(0, categorie.Length - 1);
string[] categorie_array = categorie.Split(' ');
Console.WriteLine(categorie_array[1]);
for (int i = 0; i < categorie_array.Length; i++)
{
    StreamWriter scrittore = new StreamWriter("prodotti_" + categorie_array[i] + ".txt");
    for(int j = 1; j < prodotti.Length; j++)
    {
        string categoria = prodotti[j].Split(',')[2];
        if(categoria == categorie_array[i])
        {
            scrittore.WriteLine(prodotti[i]);
        }
    }
    scrittore.Close();
}
