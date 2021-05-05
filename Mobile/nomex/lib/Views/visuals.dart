import 'package:flutter/material.dart';
import 'package:nomex/Models/User.dart';
import 'package:nomex/Views/PersonalDetailsScreen.dart';
import 'PersonalDetailsInfo.dart';
import 'LoginScreen.dart';
import 'HomeScreen.dart';
import 'package:shared_preferences/shared_preferences.dart';

class SideDrawer extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Drawer(
      child: Column(
        children: <Widget>[
          DrawerHeader(
            child: Container(
              decoration: BoxDecoration(
                image: DecorationImage(
                  image: AssetImage("assets/images/nomexLogo.png"),
                  fit: BoxFit.cover,
                ),
              ),
            ),
          ),
          ListTile(
            leading: Icon(Icons.home),
            title: Text('Home'),
            onTap: () => {
              Navigator.push(
                context,
                MaterialPageRoute(
                  builder: (context) => HomeScreen(),
                ),
              ),
            },
          ),
          ListTile(
            leading: Icon(Icons.person),
            title: Text('Personal information'),
            onTap: () => {
              Navigator.push(
                context,
                MaterialPageRoute(
                  builder: (context) => PersonalDetails(),
                ),
              ),
            },
          ),
          ListTile(
            leading: Icon(Icons.exit_to_app),
            title: Text('Logout'),
            onTap: () => {
              clearToken(),
              Navigator.push(
                context,
                MaterialPageRoute(
                  builder: (context) => LoginScreen(),
                ),
              ),
            },
          ),
        ],
      ),
    );
  }
  clearToken() async{
    SharedPreferences sharedPreferences = await SharedPreferences.getInstance();
    sharedPreferences.clear();
    User.currentLogin.id = -1;
  }
}

class Background extends StatelessWidget {
  @override
  Widget build(BuildContext context) {
    return Container(
      height: double.infinity,
      width: double.infinity,
      decoration: BoxDecoration(
          gradient: LinearGradient(
              begin: Alignment.topCenter,
              end: Alignment.bottomCenter,
              colors: [
                Colors.orangeAccent,
                Colors.orange,
              ],
              stops: [0.4, 0.7]
          )
      ),
    );
  }
}