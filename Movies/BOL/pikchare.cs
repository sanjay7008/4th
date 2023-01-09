namespace BOL; //pojo class
public class pikchare
{
    private int id;
    private string name;
    private int year;
    private string actor;
    public pikchare(){//default constructor
}

    public pikchare(int filmId, string filmName){
        this.id=filmId;
        this.name=filmName;
    }

    public pikchare(int year, string actorName){
        this.year=year;
        this.actor=actorName;
    }

    public pikchare(int filmId, string filmName,int year, string actorName){
        this.id=filmId;
        this.name=filmName;
        this.year=year;
        this.actor=actorName;
        }
        public int id{
            get{return id;}
            set{id = value;}
            }
            public string name{
                get{return name;}
                set{name=value;}
            }
            public int year{
                get{return year;}
                set{year=value;}
            }
            public string actor{
                get{return actor;}
                set{actor = value;}
            }
            
}
