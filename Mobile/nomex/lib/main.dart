// Copyright 2018 The Flutter team. All rights reserved.
// Use of this source code is governed by a BSD-style license that can be
// found in the LICENSE file.

import 'dart:io';

import 'package:flutter/material.dart';
import 'package:shared_preferences/shared_preferences.dart';

import 'Models/User.dart';
import 'Views/HomeScreen.dart';
import 'Views/WelcomeScreen.dart';

void main() {
  HttpOverrides.global = new MyHttpOverrides();
  runApp(MyApp());
}

class MyApp extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return MaterialApp(
      title: 'Startup Name Generator',
      theme: new ThemeData(canvasColor: Colors.orangeAccent),
      home: FutureBuilder<LoginType>(
          future: checkLoginStatus(),
        builder: (context, snapshot) {
            if(snapshot.hasData)
              {
                if(!(snapshot.data! == LoginType.Welcome))
                  return HomeScreen();
                else
                  return WelcomeScreen();
              }
            return CircularProgressIndicator();
        },
      ),
    );
  }

  Future<LoginType> checkLoginStatus() async{
    SharedPreferences sharedPreferences = await SharedPreferences.getInstance();
    var token = sharedPreferences.getString("token");
    var id = sharedPreferences.getInt("id");
    var name = sharedPreferences.getString("name");
    var surname = sharedPreferences.getString("surname");
    var personalCode = sharedPreferences.getString("personalCode");

    if(token != null){
      User.currentLogin.id = id;
      User.currentLogin.name = name;
      User.currentLogin.surname = surname;
      User.currentLogin.personalCode = personalCode;
      return LoginType.PersonalDetails;
    }else
      return LoginType.Welcome;
  }

}

enum LoginType{
  Welcome,
  PersonalDetails,
  FullLogin
}

class MyHttpOverrides extends HttpOverrides{
  @override
  HttpClient createHttpClient(SecurityContext? context){
    return super.createHttpClient(context)
      ..badCertificateCallback = (X509Certificate cert, String host, int port)=> true;
  }
}
