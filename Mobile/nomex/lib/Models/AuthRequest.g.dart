// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'AuthRequest.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

AuthRequest _$AuthRequestFromJson(Map<String, dynamic> json) {
  return AuthRequest(
    json['email'] as String,
    json['password'] as String,
  );
}

Map<String, dynamic> _$AuthRequestToJson(AuthRequest instance) =>
    <String, dynamic>{
      'email': instance.email,
      'password': instance.password,
    };
