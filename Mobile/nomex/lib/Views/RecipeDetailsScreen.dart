import 'package:flutter/material.dart';
import 'package:nomex/Models/Usage.dart';
import 'package:nomex/Views/visuals.dart';
import 'package:nomex/Models/Recipe.dart';
import 'package:intl/intl.dart';

class RecipeDetails extends StatelessWidget {
  Recipe recipe;
  RecipeDetails(this.recipe);

  dosageToString(Dosage dosage)
  {
    if(dosage == Dosage.Daily)
      return "Kiekvieną dieną";
    else if(dosage == Dosage.Every2Days)
      return "Kas dvi dienas";
    else if(dosage == Dosage.Every3Days)
      return "Kas 3 dienas";
    else if(dosage == Dosage.Every4Days)
      return "Kas 4 dienas";
    else if(dosage == Dosage.Every5Days)
      return "Kas 5 dienas";
    else if(dosage == Dosage.OnceAWeek)
      return "Kas savaitę";
    else if(dosage == Dosage.Every2Weeks)
      return "Kas dvi savaites";
    else if(dosage == Dosage.OnceAMonth)
      return "Kas mėnesį";
    else
      return "Kiekvieną dieną";
  }

  formateDate(DateTime date)
  {
    return DateFormat('MM-dd-yyyy').format(date);
  }

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      appBar: AppBar(
        iconTheme: IconThemeData(color: Colors.black),
        elevation: 0.0,
        backgroundColor: Colors.transparent,
        toolbarHeight: 70,
        title: Text(
          'Nomex',
          style: TextStyle(
            fontFamily: 'OpenSans',
            fontSize: 25,
            fontWeight: FontWeight.bold,
            color: Colors.black,
          ),
        ),
      ),
      drawer: SideDrawer(),
      body: Container(
        height: double.infinity,
        width: double.infinity,
        margin: EdgeInsets.only(left: 10, right: 10, bottom: 10),
        decoration: BoxDecoration(
          borderRadius: BorderRadius.all(Radius.circular(10.0)),
          color: Colors.white24,
        ),
        child: Column(
          children: [
            Row(
              children: [
                Container(
                  height: 50,
                  width: 185,
                  padding: EdgeInsets.only(left: 10, top: 10),
                  alignment: Alignment.topLeft,
                  child: Text(
                    recipe.medicine!.name!,
                    style: TextStyle(
                      fontSize: 35,
                      fontWeight: FontWeight.bold,
                    ),
                  ),
                ),
              ],
            ),
            Container(
              height: 40,
              width: 350,
              alignment: Alignment.centerLeft,
              child: Text(
                //"Galioja iki: "+recipe.validUntil!.year.toString() + ' ' + recipe.validUntil!.month.toString() + ' ' + recipe.validUntil!.day.toString(),
                "Galioja iki: " + formateDate(recipe.validUntil!),
                style: TextStyle(
                  fontSize: 17,
                  fontWeight: FontWeight.normal,
                ),
              ),
            ),
            Container(
              height: 40,
              width: 350,
              margin: EdgeInsets.only(top: 45),
              alignment: Alignment.centerLeft,
              child: Text(
                "Kada vartoti: ",
                style: TextStyle(
                  fontSize: 20,
                  fontWeight: FontWeight.bold,
                ),
              ),
            ),
            Container(
              width: 350,
              height: 40,
              margin: EdgeInsets.only(top: 5),
              decoration: BoxDecoration(
                borderRadius: BorderRadius.all(Radius.circular(10.0)),
              ),
              alignment: Alignment.topLeft,
              child: Text(
                dosageToString(recipe.usage!.dosage!),
                style: TextStyle(
                  fontSize: 20,
                  fontWeight: FontWeight.normal,
                ),
              ),
            ),
            Container(
              height: 40,
              width: 350,
              margin: EdgeInsets.only(top: 10),
              alignment: Alignment.centerLeft,
              child: Text(
                "Kaip vartoti: ",
                style: TextStyle(
                  fontSize: 20,
                  fontWeight: FontWeight.bold,
                ),
              ),
            ),
            Container(
              width: 350,
              height: 100,
              margin: EdgeInsets.only(top: 5),
              decoration: BoxDecoration(
                borderRadius: BorderRadius.all(Radius.circular(10.0)),
              ),
              alignment: Alignment.topLeft,
              child: Text(
                recipe.usage!.description!,
                style: TextStyle(
                  fontSize: 20,
                  fontWeight: FontWeight.normal,
                ),
              ),
            ),
          ],
        ),
      ),
    );
  }
}
