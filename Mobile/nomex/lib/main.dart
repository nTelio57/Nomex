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
      home: FutureBuilder<bool>(
          future: checkLoginStatus(),
        builder: (context, snapshot) {
            if(snapshot.hasData)
              {
                if(snapshot.data!)
                  return HomeScreen();
                else
                  return WelcomeScreen();
              }
            return CircularProgressIndicator();
        },
      ),
    );
  }

  Future<bool> checkLoginStatus() async{
    SharedPreferences sharedPreferences = await SharedPreferences.getInstance();
    var token = sharedPreferences.getString("token");
    var id = sharedPreferences.getInt("id");

    if(sharedPreferences.getString("token") != null){
      User.currentLogin.id = id;
      return true;
    }else
      return false;
  }

}

class MyHttpOverrides extends HttpOverrides{
  @override
  HttpClient createHttpClient(SecurityContext? context){
    return super.createHttpClient(context)
      ..badCertificateCallback = (X509Certificate cert, String host, int port)=> true;
  }
}
