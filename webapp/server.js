var express=require("express")
var app=express()
app.get('/',function(req,res){
    res.send('zala re')

})
app.listen(8000)
console.log("server zala re connect")
 