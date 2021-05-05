// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'Recipe.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Recipe _$RecipeFromJson(Map<String, dynamic> json) {
  return Recipe(
    json['id'] as int?,
  )
    ..validUntil = json['validUntil'] == null
        ? null
        : DateTime.parse(json['validUntil'] as String)
    ..usage = json['usage'] == null
        ? null
        : Usage.fromJson(json['usage'] as Map<String, dynamic>)
    ..medicine = json['medicine'] == null
        ? null
        : Medicine.fromJson(json['medicine'] as Map<String, dynamic>);
}

Map<String, dynamic> _$RecipeToJson(Recipe instance) => <String, dynamic>{
      'id': instance.id,
      'validUntil': instance.validUntil?.toIso8601String(),
      'usage': instance.usage,
      'medicine': instance.medicine,
    };
