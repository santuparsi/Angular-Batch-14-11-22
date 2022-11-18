function f1()
{
    return 'Yes';
}
function f2()
{
    return 'No'
}
function callback(f1,f2) //here yes and no used as a function
{
    console.log(f1()+' '+f2());
}

callback(f1,f2)
callback(function(){return 'Ram'},function(){return 'Krishna'})
callback(()=>"Ram",()=>'Rahim')