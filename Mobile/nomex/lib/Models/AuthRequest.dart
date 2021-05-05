import 'package:json_annotation/json_annotation.dart';

part 'AuthRequest.g.dart';

@JsonSerializable()
class AuthRequest{

  String? name;
  String? surname;
  String email;
  String password;

  AuthRequest(this.email, this.password);

  factory AuthRequest.fromJson(Map<String, dynamic> json) => _$AuthRequestFromJson(json);

  Map<String, dynamic> toJson() => _$AuthRequestToJson(this);

}