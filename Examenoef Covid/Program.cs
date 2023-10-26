
string[] menu = new string[] { "stoppen", "maandtotaal opvragen", "Jaartotaal opvragen" };
string[] submenu = new string[] { "Aantal besmettingen", "Aantal sterfgevallen" };



Printmenu("Menu:", menu);






void DrukOpEnter()
{

}



int LeesGetal(int min, int max)
{

    return 0;
}


int BehandelBestand(int subkeuze, int maand)
{
    return 0;
}



void DrukResultaat(int subkeuze, int waarde)
{


}


void Printmenu(string soort, string[] menu)
{
    Console.WriteLine(soort);
    for (int i = 0; i < menu.Length; i++)
    {
        Console.WriteLine($"{i}: {menu[i]}");
    }
}