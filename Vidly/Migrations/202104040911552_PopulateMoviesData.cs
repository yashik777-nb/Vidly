namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMoviesData : DbMigration
    {
        public override void Up()
        {
            Sql("SET IDENTITY_INSERT Movies ON");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, Stock, GenreTypeId ) VALUES(1, 'Hangover', CAST('1992-01-01' AS DATETIME), CAST('1992-01-01' AS DATETIME), 4, 1)");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, Stock, GenreTypeId ) VALUES(2, 'Die Hard', CAST('1992-01-01' AS DATETIME), CAST('1992-01-01' AS DATETIME), 2, 2)");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, Stock, GenreTypeId ) VALUES(3, 'The Terminator', CAST('1992-01-01' AS DATETIME), CAST('1992-01-01' AS DATETIME), 5, 2)");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, Stock, GenreTypeId ) VALUES(4, 'Toy Story', CAST('1992-01-01' AS DATETIME), CAST('1992-01-01' AS DATETIME), 2, 3)");
            Sql("INSERT INTO Movies (Id, Name, ReleaseDate, DateAdded, Stock, GenreTypeId ) VALUES(5, 'Titanic', CAST('1992-01-01' AS DATETIME), CAST('1992-01-01' AS DATETIME), 8, 4)");
        }
        
        public override void Down()
        {
        }
    }
}
