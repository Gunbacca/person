using person;

Fordon f= new Fordon();
f.Tillverkare = "volvo";
f.setmodel("v70");
f.setadress("Moisture farm 1138");

Console.WriteLine(f.Tillverkare);
Console.WriteLine(f.getmodel());
Console.WriteLine(f.getsadress());

Fordon f2=new Fordon();
f2.settillverkare("BMW");
f2.setmodel("535d e60");
f2.setadress("skogängsvägen 1");

Console.WriteLine(f2.gettillverkare());
Console.WriteLine(f2.getmodel());
Console.WriteLine(f2.getsadress());

