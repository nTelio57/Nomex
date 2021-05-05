// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'Medicine.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Medicine _$MedicineFromJson(Map<String, dynamic> json) {
  return Medicine(
    json['id'] as int?,
  )..name = json['name'] as String?;
}

Map<String, dynamic> _$MedicineToJson(Medicine instance) => <String, dynamic>{
  'id': instance.id,
  'name': instance.name,
};