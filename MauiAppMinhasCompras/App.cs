using SQLite;
using MauiAppMinhasCompras.Models;
using MauiAppMinhasCompras.Views;

namespace MauiAppMinhasCompras;

public class App : Application
{
    public static SQLiteAsyncConnection Db;

    public App()
    {
        string dbPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            "compras.db3");

        Db = new SQLiteAsyncConnection(dbPath);

        Db.CreateTableAsync<Produto>().Wait();

        MainPage = new NavigationPage(new ListaProduto());
    }
}