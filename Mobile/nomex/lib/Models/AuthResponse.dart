import 'package:json_annotation/json_annotation.dart';

import 'User.dart';
part 'AuthResponse.g.dart';

@JsonSerializable()
class AuthResponse{

  User? user;
  String? token;
  bool success;
  List<String>? errors;

  AuthResponse(this.user, this.token, this.success, this.errors);

  factory AuthResponse.fromJson(Map<String, dynamic> json) => _$AuthResponseFromJson(json);

  Map<String, dynamic> toJson() => _$AuthResponseToJson(this);

}