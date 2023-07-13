namespace GigHub.Migrations
{
    using System;
    using System.Data;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenresTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) VALUES ('Rock')");
            Sql("INSERT INTO Genres (Name) VALUES ('Popular music')");
            Sql("INSERT INTO Genres (Name) VALUES ('Electronic music')");
            Sql("INSERT INTO Genres (Name) VALUES ('Pop music')");
            Sql("INSERT INTO Genres (Name) VALUES ('Jazz')");
            Sql("INSERT INTO Genres (Name) VALUES ('Rhythm and blues')");
            Sql("INSERT INTO Genres (Name) VALUES ('Classical music')");
            Sql("INSERT INTO Genres (Name) VALUES ('Hip hop music')");
            Sql("INSERT INTO Genres (Name) VALUES ('Country music')");
            Sql("INSERT INTO Genres (Name) VALUES ('Blues')");

        }

        public override void Down()
        {
            Sql("DELETE FROM Genres WHERE id IN (40,41,42,43,44,45,46,47,48,49)");
        }
    }
}
