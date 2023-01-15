namespace BOL;

public class fruits{

    public string Name {get; set;}
    public int Price {get; set;}

    public fruits(){

    }

    public fruits(string frname, int frprice){
        this.Name=frname;
        this.Price=frprice;
    }

}
