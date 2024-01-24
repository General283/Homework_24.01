using Microsoft.Data.Sqlite;

File.Create(Constants.DatabaseFile).Close();

using (SqliteConnection databaseConnection = new SqliteConnection(Constants.DatabaseConnectionString))
{
    databaseConnection.Open();

    using (var command = databaseConnection.CreateCommand())
    {
        command.CommandType = System.Data.CommandType.Text;

        command.CommandText = "CREATE TABLE Invest( id INTEGER PRIMARY KEY AUTOINCREMENT, name TEXT, surname TEXT, address TEXT, email TEXT, phone TEXT, registration_date DATE);";
        command.ExecuteNonQuery();
        command.CommandText = "CREATE TABLE Money(money_id INTEGER PRIMARY KEY AUTOINCREMENT, Money_name TEXT, description TEXT, creation_date DATE, Money_size REAL,current_assets REAL);";
        command.ExecuteNonQuery();
        command.CommandText = "CREATE TABLE Transact(transact_id INTEGER PRIMARY KEY AUTOINCREMENT, investor_id INTEGER  Invest(investor_id), money_id INTEGER  Money(money_id), Transact_type TEXT, Transact_amount REAL, Transact_date DATE);";
        command.ExecuteNonQuery();       

        command.ExecuteNonQuery();
    }

    databaseConnection.Close();
}

