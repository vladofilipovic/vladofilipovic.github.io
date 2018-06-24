


function switchLanguage() {
  var putanja = window.location.pathname;
  //console.log(putanja);
  var putanjaN = putanja.split("/");
  //console.log(putanjaN);
  var datoteka = putanjaN[putanjaN.length - 1];
  //console.log(datoteka);
  var ekstenzija = datoteka.split(".")[1] || "";
  //console.log(ekstenzija);
  var ime = datoteka.split(".")[0] || "";
  var delovi = ime.split("-");
  var osnova = delovi[0];
  for (var i = 1; i < delovi.length - 1; i++)
    osnova += "-" + delovi[i];
  //console.log(osnova);
  var jezik = "";
  if (delovi.length > 1)
    jezik = delovi[delovi.length - 1];
  //console.log(jezik);
  if (jezik == "en")
    jezik = "cy";
  else
    jezik = "en";
  return osnova + "-" + jezik + "." + ekstenzija;
}

function setLanguage(jezik) {
  //console.log(jezik);
  var putanja = window.location.pathname;
  //console.log(putanja);
  var putanjaN = putanja.split("/");
  //console.log(putanjaN);
  var datoteka = putanjaN[putanjaN.length - 1];
  //console.log(datoteka);
  var ekstenzija = datoteka.split(".")[1] || "";
  //console.log(ekstenzija);
  var ime = datoteka.split(".")[0] || "";
  var delovi = ime.split("-");
  var osnova = delovi[0];
  for (var i = 1; i < delovi.length - 1; i++)
    osnova += "-" + delovi[i];
  //console.log(osnova);  
  return osnova + "-" + jezik + "." + ekstenzija;
}