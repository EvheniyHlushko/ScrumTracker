using System;
using BusinessLayer;
using DTO;


namespace StickersConsole
{
    public class UI
    {

        public void DoWork()
        {
            // var tsUsers = new ServiceDAL();
            var tsUsers = new Manager();

            // добавляем их в бд
            UserDto user1 = new UserDto { Id = Guid.NewGuid(),Login = "John21", Password = "33", Email = "qw" };
            //tsUsers.Add(user1);
            // tsUsers.RemoveUser(new UserDto { Id = 26, Login = "Tomas", Password = "33", Email = "qw" });

            //получаем объекты из бд и выводим на консоль
            var users = tsUsers.GetAllUsers();
            
            //tsUsers.Remove(userDel);
            Guid id = Guid.Empty;
            Console.WriteLine("Список объектов:");
            foreach (UserDto u in users)
            {
                if (u.Login == "John")
                    id = u.Id; 
                Console.WriteLine(@"{0}	{1}	{2}	{3}", u.Id, u.Login, u.Password, u.Email);
            }

            var userDel = users.Find(x => x.Id == id);
            //tsUsers.Remove(userDel);

            Console.Read();
        }
    }
}


// через SqlDataAdapter
// получаем строку подключения
//string connectionString = ConfigurationManager.ConnectionStrings["StickersConnectionString"].ConnectionString;
//using (SqlConnection connection = new SqlConnection(connectionString))
//{
//    connection.Open();
//    string sql = "SELECT * FROM users; Select * from roles";
//    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

//    DataSet ds = new DataSet();
//    adapter.Fill(ds);

//    // перебор всех таблиц
//    foreach (DataTable dt in ds.Tables)
//    {
//        Console.WriteLine(dt.TableName); // название таблицы
//                                         // перебор всех столбцов
//        foreach (DataColumn column in dt.Columns)
//            Console.Write("\t{0}", column.ColumnName);
//        Console.WriteLine();
//        // перебор всех строк таблицы
//        foreach (DataRow row in dt.Rows)
//        {
//            // получаем все ячейки строки
//            var cells = row.ItemArray;
//            foreach (object cell in cells)
//                Console.Write("\t{0}", cell);
//            Console.WriteLine();
//        }
//    }


//    // ВСТАВКА в таблицу 
//    var insertUser = new InsertUser();
//     insertUser.SqlCommandInsert(connection, 1234567, "admin2", "1234@email.ua", "Petrov");

//    // ЧТЕНИЕ из таблицы (после вставки)
//    var outputUser1 = new UsersDataReader();
//    outputUser1.SqlCommandSelect(connection);
//}

