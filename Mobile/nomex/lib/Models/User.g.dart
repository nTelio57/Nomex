// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'User.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

User _$UserFromJson(Map<String, dynamic> json) {
  return User(
    json['id'] as int?,
  )
    ..email = json['email'] as String?
    ..personalDetails = json['personalDetails'] == null
        ? null
        : PersonalDetails.fromJson(
        json['personalDetails'] as Map<String, dynamic>)
    ..name = json['name'] as String?
    ..surname = json['surname'] as String?
    ..personalCode = json['personalCode'] as String?
    ..birthDate = json['birthDate'] == null
        ? null
        : DateTime.parse(json['birthDate'] as String);
}

Map<String, dynamic> _$UserToJson(User instance) => <String, dynamic>{
  'id': instance.id,
  'email': instance.email,
  'personalDetails': instance.personalDetails,
  'name': instance.name,
  'surname': instance.surname,
  'personalCode': instance.personalCode,
  'birthDate': instance.birthDate?.toIso8601String(),
};