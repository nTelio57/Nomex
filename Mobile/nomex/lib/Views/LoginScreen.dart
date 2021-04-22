import 'package:flutter/material.dart';
import 'package:nomex/Models/AuthRequest.dart';
import 'package:nomex/utilities/constants.dart';
import 'package:http/http.dart' as http;
import 'dart:convert';
import 'package:shared_preferences/shared_preferences.dart';

import 'RegisterScreen.dart';
import 'HomeScreen.dart';
import '../Models/User.dart';

class LoginScreen extends StatefulWidget {
  @override
  _LoginScreenState createState() => _LoginScreenState();
}

class _LoginScreenState extends State<LoginScreen>{

  final TextEditingController _emailText = TextEditingController();
  final TextEditingController _passwordText = TextEditingController();

  Widget _emailField() {
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
          controller: _emailText,
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
          controller: _passwordText,
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

  Widget _forgotPasswordField()
  {
    return Container(
      alignment: Alignment.centerRight,
      child: TextButton(
        onPressed: () => print('Forgot pass  clicked'),
        //padding: EdgeInsets.only(right: 0.0),
        child: Text(
          'Forgot password?',
          style: kLabelStyle,
        ),
      ),
    );
  }

  Widget _loginButton()
  {
    return Container(
      padding: EdgeInsets.symmetric(vertical: 25.0),
      width: double.infinity,
      child: ElevatedButton(
        onPressed: () {
          loginUser(_emailText.text, _passwordText.text);
          print('Login clicked');
          setState(() {

          });
        } ,
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
    return GestureDetector(
      onTap: (){
        Navigator.push(
            context,
            MaterialPageRoute(builder: (context) => RegisterScreen()
            )
        );
      },
      child: RichText(
        text: TextSpan(
          children: [
            TextSpan(
              text: 'Don\'t have an account? ',
              style: TextStyle(
                color: Colors.white,
                fontSize: 18.0,
                fontWeight: FontWeight.w400
              )
            ),
            TextSpan(
                text: 'Register',
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

  loginUser(String email, String password) async
  {
    var authRequest = new AuthRequest(email, password);
    SharedPreferences sharedPreferences = await SharedPreferences.getInstance();
    var response = await http.post(Uri.https('10.0.2.2:5001', '/api/Auth/login'),
        body: json.encode(authRequest),
        headers: <String, String>{
          'Content-Type': 'application/json; charset=UTF-8',
        }
      );
    var jsonData = null;
    if(response.statusCode == 200){
      print(response.body);
      jsonData = json.decode(response.body);
      setState(() {
        print(response.body);
        sharedPreferences.setString("token", jsonData['token']);
        Navigator.of(context).pushAndRemoveUntil(MaterialPageRoute(builder: (BuildContext context) => HomeScreen()), (Route<dynamic> route) => false);
      });
    }else
      {
        print(response.body);
      }
  }

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
                  "Login",
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
                _forgotPasswordField(),
                _loginButton(),
                SizedBox(height: 20.0),
                _registerButton(),
              ],
            ),
          ),
        )
      ],
      )
    );
  }
}