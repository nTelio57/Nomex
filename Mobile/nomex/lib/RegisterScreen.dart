import 'package:flutter/material.dart';
import 'package:nomex/utilities/constants.dart';

import './LoginScreen.dart';

class RegisterScreen extends StatefulWidget {
  @override
  _RegisterScreenState createState() => _RegisterScreenState();
}

class _RegisterScreenState extends State<RegisterScreen>
{
  @override
  Widget build(BuildContext context) {
    return Scaffold(
        body: Stack(children: <Widget>[
          Container(
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
                    "Register",
                    style: TextStyle(
                        color: Colors.white,
                        fontFamily: 'OpenSans',
                        fontSize: 30.0,
                        fontWeight: FontWeight.bold
                    ),
                  ),
                  SizedBox(height: 30.0),
                  _emailField(),
                  SizedBox(height: 30.0),
                  _passwordField(),
                  SizedBox(height: 30.0),
                  _passwordRepeatField(),
                  SizedBox(height: 20.0),
                  _registerButton(),
                  _loginButton(),
                ],
              ),
            ),
          )
        ],
        )
    );
  }

  Widget _emailField()
  {
    return Column(crossAxisAlignment: CrossAxisAlignment.start, children: [
      Text(
        "Email",
        style: kLabelStyle,
      ),
      SizedBox(height: 10.0),
      Container(
        alignment: Alignment.centerLeft,
        decoration: kBoxDecorationStyle,
        height: 60.0,
        child: TextField(
          keyboardType: TextInputType.emailAddress,
          style: TextStyle(
              color: Colors.white,
              fontFamily: 'OpenSans'
          ),
          decoration: InputDecoration(
              border: InputBorder.none,
              contentPadding: EdgeInsets.only(top: 14.0),
              prefixIcon: Icon(
                Icons.email,
                color: Colors.white,
              ),
              hintText: "Enter e-mail",
              hintStyle: kHintTextStyle
          ),
        ),
      )
    ],
    );
  }

  Widget _passwordField()
  {
    return Column(crossAxisAlignment: CrossAxisAlignment.start, children: [
      Text(
        "Password",
        style: kLabelStyle,
      ),
      SizedBox(height: 10.0),
      Container(
        alignment: Alignment.centerLeft,
        decoration: kBoxDecorationStyle,
        height: 60.0,
        child: TextField(
          obscureText: true,
          style: TextStyle(
              color: Colors.white,
              fontFamily: 'OpenSans'),
          decoration: InputDecoration(
              border: InputBorder.none,
              contentPadding: EdgeInsets.only(top: 14.0),
              prefixIcon: Icon(
                Icons.lock,
                color: Colors.white,
              ),
              hintText: "Enter password",
              hintStyle: kHintTextStyle
          ),
        ),
      )
    ],
    );
  }

  Widget _passwordRepeatField()
  {
    return Column(crossAxisAlignment: CrossAxisAlignment.start, children: [
      Text(
        "Repeat password",
        style: kLabelStyle,
      ),
      SizedBox(height: 10.0),
      Container(
        alignment: Alignment.centerLeft,
        decoration: kBoxDecorationStyle,
        height: 60.0,
        child: TextField(
          obscureText: true,
          style: TextStyle(
              color: Colors.white,
              fontFamily: 'OpenSans'),
          decoration: InputDecoration(
              border: InputBorder.none,
              contentPadding: EdgeInsets.only(top: 14.0),
              prefixIcon: Icon(
                Icons.lock,
                color: Colors.white,
              ),
              hintText: "Repeat password",
              hintStyle: kHintTextStyle
          ),
        ),
      )
    ],
    );
  }

  Widget _registerButton()
  {
    return Container(
      padding: EdgeInsets.symmetric(vertical: 25.0),
      width: double.infinity,
      child: ElevatedButton(
        onPressed: () => print('Register clicked'),
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
          'REGISTER',
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

  Widget _loginButton()
  {
    return GestureDetector(
      onTap: (){
        Navigator.push(
            context,
            MaterialPageRoute(builder: (context) => LoginScreen()
            )
        );
      },
      child: RichText(
        text: TextSpan(
            children: [
              TextSpan(
                  text: 'Already have an account? ',
                  style: TextStyle(
                      color: Colors.white,
                      fontSize: 18.0,
                      fontWeight: FontWeight.w400
                  )
              ),
              TextSpan(
                  text: 'Login',
                  style: TextStyle(
                      color: Colors.white,
                      fontSize: 18.0,
                      fontWeight: FontWeight.bold
                  )
              ),
            ]
        ),
      ),
    );
  }
}