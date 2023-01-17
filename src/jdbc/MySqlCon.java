package jdbc;
import java.sql.*;  
public class MySqlCon {
 
public static void main(String args[]){  
try{  
Class.forName("com.mysql.jdbc.Driver");  
//The forName() method of Class class is used to register the driver

Connection con=DriverManager.getConnection(  
"jdbc:mysql://localhost:3307/sonoo","root","root123");
//The getConnection() method of DriverManager class is used to establish connection with the database.
//here sonoo is database name, root is username and password  

Statement stmt=con.createStatement();  
//The createStatement() method of Connection interface is used to create statement. 
//The object of statement is responsible to execute queries with the database.

ResultSet rs=stmt.executeQuery("select * from emp"); 
//The executeQuery() method of Statement interface is used to execute queries to the database. 
//This method returns the object of ResultSet that can be used to get all the records of a table.

while(rs.next())  
System.out.println(rs.getInt(1)+"  "+rs.getString(2)+"  "+rs.getString(3));  

con.close();  

}

catch(Exception e){ System.out.println(e);}  

}  
}  