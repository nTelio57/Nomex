import 'package:flutter/material.dart';
import 'package:nomex/Models/User.dart';
import 'package:nomex/Views/visuals.dart';

class PersonalDetails extends StatelessWidget {
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
      body: Stack(
        children: [
          Background(),
          Column(
            children: [
              InfoBox(User.currentLogin.name.toString(), 'Vardas', Icons.person),
              SizedBox(height: 10),
              InfoBox(User.currentLogin.surname.toString(), 'Pavardė', Icons.perm_identity),
              SizedBox(height: 10),
              InfoBox(User.currentLogin.personalCode.toString(), 'Kodas', Icons.person_search),
            ],
          ),
        ],
      ),
    );
  }
}

class InfoBox extends StatelessWidget {
  final text;
  final title;
  IconData icon;
  InfoBox(this.text, this.title, this.icon);
  @override
  Widget build(BuildContext context) {
    return Container(
      margin: EdgeInsets.only(left: 10, right: 10),
      height: 140,
      decoration: BoxDecoration(
        borderRadius: BorderRadius.all(Radius.circular(40.0)),
        color: Colors.white24,
      ),
      child: Row(
        children: [
          Container(
            //color: Colors.blue,
            padding: EdgeInsets.only(top: 10),
            height: 100,
            width: 120,
            child: Column(
              children: [
                Container(
                  alignment: Alignment.center,
                  child: Icon(
                    icon,
                    size: 60,
                  ),
                ),
                Container(
                  alignment: Alignment.center,
                  child: Text(
                    title,
                    style: TextStyle(
                      fontSize: 15,
                      fontWeight: FontWeight.bold,
                    ),
                  ),
                )
              ],
            ),
          ),
          Container(
            alignment: Alignment.center,
            child: Text(
              text,
              style: TextStyle(
                color: Colors.black,
                fontSize: 30,
                fontWeight: FontWeight.bold,
              ),
            ),
          )
        ],
      ),
    );
  }
}