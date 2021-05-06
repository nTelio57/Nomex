// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'AuthRequest.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

AuthRequest _$AuthRequestFromJson(Map<String, dynamic> json) {
  return AuthRequest(
    json['email'] as String,
    json['password'] as String,
  )
    ..name = json['name'] as String?
    ..surname = json['surname'] as String?;
}

Map<String, dynamic> _$AuthRequestToJson(AuthRequest instance) =>
    <String, dynamic>{
      'name': instance.name,
      'surname': instance.surname,
      'email': instance.email,
      'password': instance.password,
    };
