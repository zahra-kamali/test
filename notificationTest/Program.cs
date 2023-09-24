namespace notificationTest;
class Program
{
    static void Main(string[] args)
    {
        var db = new ZahraDBContext();
        /*var inadame = new Person()
        {
            PersonId = 98243029,
            FirstName= " ashghali",
            LastName="chom",
            Address="in my butt",
            City="hell"

        
        };*/
        var inadame = (from yechi in db.Persons
                       where yechi.PersonId == 98243029
                       select yechi).FirstOrDefault();

        if(inadame != null)
        {
            inadame.FirstName = "dan dan";
            inadame.LastName = "kamali";

        }
        db.Persons.Update(inadame);

        db.SaveChanges();


    }
}

