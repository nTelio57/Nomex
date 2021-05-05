import 'package:json_annotation/json_annotation.dart';
import 'package:shared_preferences/shared_preferences.dart';

part 'User.g.dart';

@JsonSerializable()
class User{
  static User currentLogin = new User(-1);

  int? id;
  String? email;
  String? name;
  String? surname;
  String? personalCode;
  DateTime? birthDate;

  User(this.id);

  factory User.fromJson(Map<String, dynamic> json) => _$UserFromJson(json);

  Map<String, dynamic> toJson() => _$UserToJson(this);

}