class BOOK
{
    int narx, betlari;
    string kitobnomi { get; set; }
    string kitobmuallifi { get; set; }
    public BOOK(string BookName, string Name)
    {
        kitobnomi = BookName;
        kitobmuallifi = Name;
    }
}