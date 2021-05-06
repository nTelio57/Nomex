// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'Usage.dart';

// **************************************************************************
// JsonSerializableGenerator
// **************************************************************************

Usage _$UsageFromJson(Map<String, dynamic> json) {
  return Usage(
    json['id'] as int?,
  )
    ..description = json['description'] as String?
    ..dosage = _$enumDecodeNullable(_$DosageEnumMap, json['dosage']);
}

Map<String, dynamic> _$UsageToJson(Usage instance) => <String, dynamic>{
      'id': instance.id,
      'description': instance.description,
      'dosage': _$DosageEnumMap[instance.dosage],
    };

K _$enumDecode<K, V>(
  Map<K, V> enumValues,
  Object? source, {
  K? unknownValue,
}) {
  if (source == null) {
    throw ArgumentError(
      'A value must be provided. Supported values: '
      '${enumValues.values.join(', ')}',
    );
  }

  return enumValues.entries.singleWhere(
    (e) => e.value == source,
    orElse: () {
      if (unknownValue == null) {
        throw ArgumentError(
          '`$source` is not one of the supported values: '
          '${enumValues.values.join(', ')}',
        );
      }
      return MapEntry(unknownValue, enumValues.values.first);
    },
  ).key;
}

K? _$enumDecodeNullable<K, V>(
  Map<K, V> enumValues,
  dynamic source, {
  K? unknownValue,
}) {
  if (source == null) {
    return null;
  }
  return _$enumDecode<K, V>(enumValues, source, unknownValue: unknownValue);
}

const _$DosageEnumMap = {
  Dosage.Daily: 0,
  Dosage.Every2Days: 1,
  Dosage.Every3Days: 2,
  Dosage.Every4Days: 3,
  Dosage.Every5Days: 4,
  Dosage.OnceAWeek: 5,
  Dosage.Every2Weeks: 6,
  Dosage.OnceAMonth: 7,
};
