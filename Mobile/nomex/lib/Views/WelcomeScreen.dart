import 'package:flutter/material.dart';


import 'RegisterScreen.dart';
import 'LoginScreen.dart';
class WelcomeScreen extends StatefulWidget {

  @override
  _WelcomeScreenState createState() => _WelcomeScreenState();
}

class _WelcomeScreenState extends State<WelcomeScreen>{
  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Stack(
        children: <Widget>[
          Container(
            height: double.infinity,
            width: double.infinity,
            decoration: BoxDecoration(
                gradient: LinearGradient(
                    begin: Alignment.topCenter,
                    end: Alignment.bottomCenter,
                    colors: [
                      Colors.orangeAccent,
                      Colors.orange
                    ],
                    stops: [0.4, 0.7]
                )
            ),
          ),
          Container(
            height: double.infinity,
            child: SingleChildScrollView(
              physics: AlwaysScrollableScrollPhysics(),
              padding: EdgeInsets.symmetric(
                  horizontal: 40.0,
                  vertical: 120.0
              ),
              child: Column(
                mainAxisAlignment: MainAxisAlignment.center,
                children: <Widget>[
                  Text(
                    'NOMEX',
                    style: TextStyle(
                        color: Colors.white,
                        fontFamily: 'OpenSans',
                        fontSize: 50.0,
                        fontWeight: FontWeight.bold
                    )),
                  SizedBox(height: 100.0),
                  _loginButton(),
                  _registerButton()
                ],
              ),
            ),
          )
        ],
      ),
    );
  }

  Widget _loginButton()
  {
    return Container(
      padding: EdgeInsets.symmetric(vertical: 10.0),
      width: double.infinity,
      child: ElevatedButton(
        onPressed: (){
          Navigator.push(
              context,
              MaterialPageRoute(
                  builder: (context) => LoginScreen()
              )
          );
      },
        //padding: EdgeInsets.all(15.0),
        style: ElevatedButton.styleFrom(
          elevation: 5.0,
          padding: EdgeInsets.all(15.0),
          primary: Colors.white,
          shape: RoundedRectangleBorder(
              borderRadius: BorderRadius.circular(30.0)
          ),
        ),
        child: Text(
          'LOGIN',
          style: TextStyle(
              color: Colors.orange,
              letterSpacing: 1.5,
              fontSize: 18.0,
              fontWeight: FontWeight.bold,
              fontFamily: 'OpenSans'
          ),
        ),
      ),
    );
  }

  Widget _registerButton()
  {
    return Container(
      padding: EdgeInsets.symmetric(vertical: 10.0),
      width: double.infinity,
      child: OutlinedButton(
          onPressed: (){
            Navigator.push(
                context,
                MaterialPageRoute(
                    builder: (context) => RegisterScreen()
                )
            );
          },
        style: OutlinedButton.styleFrom(
          elevation: 5.0,
          backgroundColor: Colors.orange,
          padding: EdgeInsets.all(15.0),
          side: BorderSide(
            color: Colors.white,
            width: 3
          ),
          shape: RoundedRectangleBorder(
            borderRadius: BorderRadius.circular(30.0),
          ),
        ),
        child: Text(
          'REGISTER',
          style: TextStyle(
              color: Colors.white,
              letterSpacing: 1.5,
              fontSize: 18.0,
              fontWeight: FontWeight.bold,
              fontFamily: 'OpenSans'
          ),
        ),
      ),
    );
  }
  
}