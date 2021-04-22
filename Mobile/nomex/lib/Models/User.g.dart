// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'User.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

User _$UserFromJson(Map<String, dynamic> json) {
  return User(
    json['id'] as int?,
    json['email'] as String,
  )..personalDetails = json['personalDetails'] == null
      ? null
      : PersonalDetails.fromJson(
          json['personalDetails'] as Map<String, dynamic>);
}

Map<String, dynamic> _$UserToJson(User instance) => <String, dynamic>{
      'id': instance.id,
      'email': instance.email,
      'personalDetails': instance.personalDetails,
    };
