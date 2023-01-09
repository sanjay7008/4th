namespace DAL;
using BOL;
using System.Text.Json;
using System.Threading.Tasks;

public class DataAccess
{
    public static List<pikchare> GetAllMovies(){
        List<pikchare> allMovies=new List<pikchare>();
        allMovies.Add(new pikchare{id=1,name="fury", year=2014,actor="brad pitt"});
        allMovies.Add(new pikchare{id=2, name="esotsm", year=2004, actor="kate winslet"});
        allMovies.Add(new pikchare{id=3, name="the lion", year=2016, actor="dev patel"});
        return allMovies;
    }

    public static List<pikchare> GetAllMoviesFromFile(string path){
        if(File.Exists(path)){//existance
            string jsonString = File.ReadAllText(path);//reading data
            List<pikchare> allMovies=JsonSerializer.Deserialize<List<pikchare>>(jsonString);
            //storing data in list
            return GetAllMovies;
        }
        else
        {
            return GetAllMovies();
        }
    }
    public static pikchare GetMovieById(int id){
        List<pikchare> movies = GetAllMovies();
        /*var product =await( from prod in products
                      where prod.ProductId == id
                      select prod);
         */

         pikchare movie =new pikchare { filmId=6, filmName="Gone Girl", year=2013, actorname="Ben Affleck" };

        
        return movie; 

    }
}
