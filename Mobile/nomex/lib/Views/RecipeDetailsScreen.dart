import 'package:flutter/material.dart';
import 'package:nomex/Views/visuals.dart';
import 'package:nomex/Models/Recipe.dart';

class RecipeDetails extends StatelessWidget {
  Recipe recipe;
  RecipeDetails(this.recipe);
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
                  height: 40,
                  width: 185,
                  padding: EdgeInsets.only(left: 10, top: 10),
                  alignment: Alignment.topLeft,
                  child: Text(
                    recipe.medicine!.name!,
                    style: TextStyle(
                      fontSize: 30,
                      fontWeight: FontWeight.bold,
                    ),
                  ),
                ),
                Container(
                  height: 40,
                  width: 185,
                  padding: EdgeInsets.only(right: 10, top: 10),
                  alignment: Alignment.topRight,
                  child: Text(
                    recipe.validUntil!.year.toString() + ' ' + recipe.validUntil!.month.toString() + ' ' + recipe.validUntil!.day.toString(),
                    style: TextStyle(
                      fontSize: 30,
                      fontWeight: FontWeight.bold,
                    ),
                  ),
                ),
              ],
            ),
            Container(
              width: 350,
              height: 590,
              margin: EdgeInsets.only(top: 15),
              decoration: BoxDecoration(
                borderRadius: BorderRadius.all(Radius.circular(10.0)),
                color: Colors.grey,
              ),
              alignment: Alignment.center,
              child: Text(
                recipe.usage!.description!,
                style: TextStyle(
                  fontSize: 20,
                  fontWeight: FontWeight.bold,
                ),
              ),
            ),
          ],
        ),
      ),
    );
  }
}
