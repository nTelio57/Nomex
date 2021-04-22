
import 'package:flutter/material.dart';
import 'package:nomex/utilities/constants.dart';

class PersonalDetailsScreen extends StatefulWidget {
  @override
  _PersonalDetailsScreenState createState() => _PersonalDetailsScreenState();
}

class _PersonalDetailsScreenState extends State<PersonalDetailsScreen>
{
  final TextEditingController _emailText = TextEditingController();
  DateTime selectedDate = DateTime.now();

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
                    "Personal info",
                    style: TextStyle(
                        color: Colors.white,
                        fontFamily: 'OpenSans',
                        fontSize: 30.0,
                        fontWeight: FontWeight.bold
                    ),
                  ),
                  SizedBox(height: 30.0),
                  _nameField(),
                  SizedBox(height: 30.0),
                  _surnameField(),
                  SizedBox(height: 30.0),
                  _personalCodeField(),
                  SizedBox(height: 20.0),
                  //_birthDateField(),
                  _continueButton(),
                ],
              ),
            ),
          )
        ],
      ),
    );
  }

  Widget _nameField()
  {
    return Column(crossAxisAlignment: CrossAxisAlignment.start, children: [
      Text(
        "Name",
        style: kLabelStyle,
      ),
      SizedBox(height: 10.0),
      Container(
        alignment: Alignment.centerLeft,
        decoration: kBoxDecorationStyle,
        height: 60.0,
        child: TextField(
          keyboardType: TextInputType.emailAddress,
          controller: _emailText,
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
              hintText: "Enter your name",
              hintStyle: kHintTextStyle
          ),
        ),
      )
    ],
    );
  }

  Widget _surnameField()
  {
    return Column(crossAxisAlignment: CrossAxisAlignment.start, children: [
      Text(
        "Surname",
        style: kLabelStyle,
      ),
      SizedBox(height: 10.0),
      Container(
        alignment: Alignment.centerLeft,
        decoration: kBoxDecorationStyle,
        height: 60.0,
        child: TextField(
          keyboardType: TextInputType.emailAddress,
          controller: _emailText,
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
              hintText: "Enter your surname",
              hintStyle: kHintTextStyle
          ),
        ),
      )
    ],
    );
  }

  Widget _personalCodeField()
  {
    return Column(crossAxisAlignment: CrossAxisAlignment.start, children: [
      Text(
        "Personal code",
        style: kLabelStyle,
      ),
      SizedBox(height: 10.0),
      Container(
        alignment: Alignment.centerLeft,
        decoration: kBoxDecorationStyle,
        height: 60.0,
        child: TextField(
          keyboardType: TextInputType.emailAddress,
          controller: _emailText,
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
              hintText: "Enter your personal code",
              hintStyle: kHintTextStyle
          ),
        ),
      )
    ],
    );
  }

  Widget _birthDateField()
  {
    return Column(crossAxisAlignment: CrossAxisAlignment.start, children: [
      Text(
        "Name",
        style: kLabelStyle,
      ),
      SizedBox(height: 10.0),

    ],
    );
  }

  Future<void> _selectDate(BuildContext context) async {
    final DateTime? picked = (await showDatePicker(
        context: context,
        initialDate: selectedDate,
        firstDate: DateTime(2015, 8),
        lastDate: DateTime(2101)));
    if (picked != null && picked != selectedDate)
      setState(() {
        selectedDate = picked;
      });
  }

  Widget _continueButton()
  {
    return Container(
      padding: EdgeInsets.symmetric(vertical: 25.0),
      width: double.infinity,
      child: ElevatedButton(
        onPressed: () {
          print('Continue clicked');
          setState(() {

          });
        } ,
        style: ElevatedButton.styleFrom(
          elevation: 5.0,
          padding: EdgeInsets.all(15.0),
          primary: Colors.white,
          shape: RoundedRectangleBorder(
              borderRadius: BorderRadius.circular(30.0)
          ),
        ),
        child:
        Stack(
          children: [
            Align(child: Icon(Icons.arrow_forward_ios_rounded,
                  color: Colors.black,
                  size: 25),
              alignment: Alignment.centerRight
            ),
            Align(child: Text(
              'CONTINUE',
              style: TextStyle(
                  color: Colors.orange,
                  letterSpacing: 1.5,
                  fontSize: 20.0,
                  fontWeight: FontWeight.bold,
                  fontFamily: 'OpenSans'
              ),
              textAlign: TextAlign.center,
            ),
              alignment: Alignment.center,
            )
          ],
        )
      ),
    );
  }

}