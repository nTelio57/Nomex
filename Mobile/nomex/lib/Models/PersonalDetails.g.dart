// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'PersonalDetails.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

PersonalDetails _$PersonalDetailsFromJson(Map<String, dynamic> json) {
  return PersonalDetails(
    json['id'] as int,
    json['name'] as String,
    json['surname'] as String,
    json['personalCode'] as String,
    DateTime.parse(json['birthDate'] as String),
  );
}

Map<String, dynamic> _$PersonalDetailsToJson(PersonalDetails instance) =>
    <String, dynamic>{
      'id': instance.id,
      'name': instance.name,
      'surname': instance.surname,
      'personalCode': instance.personalCode,
      'birthDate': instance.birthDate.toIso8601String(),
    };