import 'package:flutter/material.dart';
import 'package:nomex/Models/User.dart';
import 'package:shared_preferences/shared_preferences.dart';

class HomeScreen extends StatefulWidget {
  @override
  _HomeScreenState createState() => _HomeScreenState();
}

class _HomeScreenState extends State<HomeScreen>
{
  @override
  Widget build(BuildContext context) {
    //clearToken();
    return Scaffold(
      body: Text('Home screen '+ User.currentLogin.id.toString()),
    );
  }

  clearToken() async{
    SharedPreferences sharedPreferences = await SharedPreferences.getInstance();
    sharedPreferences.clear();
  }
}