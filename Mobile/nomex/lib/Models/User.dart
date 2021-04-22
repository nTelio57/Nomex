import 'package:json_annotation/json_annotation.dart';
import 'package:nomex/Models/PersonalDetails.dart';

part 'User.g.dart';

@JsonSerializable()
class User{
  static User? currentLogin;

  int? id;
  String email;
  PersonalDetails? personalDetails;

  User(this.id, this.email);

  factory User.fromJson(Map<String, dynamic> json) => _$UserFromJson(json);

  Map<String, dynamic> toJson() => _$UserToJson(this);

}