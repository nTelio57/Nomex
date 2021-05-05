import 'dart:convert';

import 'package:flutter/material.dart';
import 'package:nomex/Models/Recipe.dart';
import 'package:nomex/Models/User.dart';
import 'package:nomex/Views/RecipeDetailsScreen.dart';
import 'package:nomex/Views/visuals.dart';
import 'package:shared_preferences/shared_preferences.dart';
import 'package:http/http.dart' as http;

class HomeScreen extends StatefulWidget {
  @override
  _HomeScreenState createState() => _HomeScreenState();
}

class _HomeScreenState extends State<HomeScreen> {

  @override
  Widget build(BuildContext context) {
    //List<Recipe> recipes = getRecipes();
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
      body: Stack(
          children:[
            Background(),
            Container(
              height: double.infinity,
              width: double.infinity,
              margin: EdgeInsets.only(left: 10, right: 10, bottom: 10),
              decoration: BoxDecoration(
                  borderRadius: BorderRadius.all(Radius.circular(10.0)),
                  color: Colors.white24,
              ),
              child: RecipeList(),
            ),
          ]
      ),
    );
  }

  RecipeList()
  {
    return FutureBuilder<List<Recipe>>(
        future: getRecipes(),
        builder: (context,snapshot) {
          if(snapshot.hasData)
          {
            List<Recipe> recipes = snapshot.data!;
            return Container(
                child: ListView.builder(
                    itemCount: recipes.length,
                    itemBuilder: (context, index){
                      return ListTile(
                        title: Column(
                          children: [
                            GestureDetector(
                              onTap: (){
                                Navigator.push(
                                  context,
                                  MaterialPageRoute(
                                    builder: (context) => RecipeDetails(recipes[index]),
                                  ),
                                );
                              },
                              child: Container(
                                margin: EdgeInsets.only(top: 10),
                                height: 60,
                                width: 340,
                                alignment: Alignment.centerLeft,
                                decoration: BoxDecoration(
                                  borderRadius: BorderRadius.all(Radius.circular(10.0)),
                                  color: Colors.deepOrange.withOpacity(0.5),
                                ),
                                child: Padding(
                                  padding: EdgeInsets.only(left: 10),
                                  child: Text(
                                      '${recipes[index].medicine!.name}',
                                      style: TextStyle(
                                        fontWeight: FontWeight.bold,
                                        fontSize: 20,
                                      ),
                                  ),
                                ),
                              ),
                            )
                          ],
                        ),
                      );
                    }
                )
            );
          }
          else if(snapshot.hasError)
          {
            return Text('Error '+snapshot.toString());
          }
          else{
            return CircularProgressIndicator();
          }
        }
    );
  }

  clearToken() async{
    SharedPreferences sharedPreferences = await SharedPreferences.getInstance();
    sharedPreferences.clear();
  }

  Future<List<Recipe>> getRecipes() async{
    SharedPreferences sharedPreferences = await SharedPreferences.getInstance();
    String? token = sharedPreferences.getString('token');

    var response = await http.get(Uri.https('10.0.2.2:5001', '/api/Recipe/by-user-id/'+User.currentLogin.id.toString()),
        headers: <String, String>{
          'Content-Type': 'application/json; charset=UTF-8',
          'Authorization': 'bearer '+(token ?? ''),
        }
    );
    List<dynamic> jsonData = json.decode(response.body);
    final parsed = jsonData.cast<Map<String, dynamic>>();

    return parsed.map<Recipe>((e) => Recipe.fromJson(e)).toList();
  }


}

